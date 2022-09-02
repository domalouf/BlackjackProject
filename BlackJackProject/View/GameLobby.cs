using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class GameLobby : Form
    {
        private Controller theController;
        private Table theTable;
        public int numHands;

        public GameLobby(Controller _theController)
        {
            InitializeComponent();
            theController = _theController;
            theTable = theController.GetTable();
            // methods that the controller can cause with an event
            theController.NewPlayerJoined += NewPlayerJoined;
            theController.UpdateChips += UpdateChips;
            theController.PlayerAction += PlayerAction;
            theController.NextHand += NextHand;
            theController.FinishedRound += FinishRound;
            theController.ShoeShuffled += ShoeShuffled;
            theController.UpdateHand += UpdateHand;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Adds player with chip count or,
        /// Gives existing player more chips
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(buyChipsTextBox.Text, out int numChips))
            {
                theController.BuyChips(numChips);
            }
            else
            {
                string message = "Please enter a valid amount of chips to start with.";
                string caption = "Invalid Chip Amount";
                MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks that bet size is valid,
        /// Calls method in controller to start hands,
        /// Updates text boxes to show dealt cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DealButton_Click(object sender, EventArgs e)
        {
            if (OneHandCheckBox.Checked) numHands = 1;
            if (TwoHandsCheckBox.Checked) numHands = 2;
            if (ThreeHandsCheckBox.Checked) numHands = 3;

            // error checking for text box
            if (int.TryParse(BetSizeTextBox.Text, out int betSize))
            {
                // makes sure player can afford all bets
                if ((betSize <= 0) ||
                    (betSize * numHands > theTable.player.GetChips()))
                {
                    string message = "Please enter a valid amount of chips to bet.";
                    string caption = "Invalid Bet Size";
                    MessageBox.Show(message, caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                // deals hands and updates view
                else
                {
                    theController.DealHands(numHands, betSize);
                    DealButton.Enabled = false;
                    Hand1TextBox.Text = "" +
                        theTable.player.GetHand(1).ToString();
                    Bet1TextBox.Text = "" + theTable.player.bets[1];
                    if (numHands >= 2)
                    {
                        Hand2TextBox.Text = "" +
                        theTable.player.GetHand(2).ToString();
                        Bet2TextBox.Text = "" + theTable.player.bets[2];
                    }
                    if (numHands >= 3)
                    {
                        Hand3TextBox.Text = "" +
                        theTable.player.GetHand(3).ToString();
                        Bet3TextBox.Text = "" + theTable.player.bets[3];
                    }
                    UpdateChips();
                }
            }
            // error checking for bet size
            else
            {
                string message = "Please enter a valid amount of chips to bet.";
                string caption = "Invalid Bet Size";
                MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// event handler for when a new player buys in,
        /// changes text box to show new chip amount
        /// </summary>
        public void NewPlayerJoined()
        {
            UpdateChips();
            DealButton.Enabled = true;
            BetSizeTextBox.Enabled = true;
        }

        /// <summary>
        /// Event handler for when a player adds chips,
        /// changes text box to show new amount
        /// </summary>
        public void UpdateChips()
        {
            chipCountTextBox.Text = "" + theTable.player.GetChips();
        }

        /// <summary>
        /// Event handler for when a player must act,
        /// enables hit and stand buttons,
        /// double and split are considered
        /// </summary>
        public void PlayerAction()
        {
            HitButton.Enabled = true;
            StandButton.Enabled = true;
            //double button
            if (theTable.player.chips >= theTable.player.bets[theController.currentHand])
                DoubleButton.Enabled = true;
            else DoubleButton.Enabled = false;
            //split button
            if (theTable.player.GetHand(theController.currentHand).pair && numHands < 5) SplitButton.Enabled = true;
            else SplitButton.Enabled = false;
            CurrentHandTextBox.Text = "" + theController.currentHand;
            DealerHandTextBox.Text = "" + theTable.dealer.GetFirstCard();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            theController.HitHand();
            if (theController.currentHand == 1)
                Hand1TextBox.Text = "" +
                    theTable.player.GetHand(theController.currentHand).ToString();
            if (theController.currentHand == 2)
                Hand2TextBox.Text = "" +
                    theTable.player.GetHand(theController.currentHand).ToString();
            if (theController.currentHand == 3)
                Hand3TextBox.Text = "" +
                    theTable.player.GetHand(theController.currentHand).ToString();
            if (theController.currentHand == 4)
                Hand4TextBox.Text = "" +
                    theTable.player.GetHand(theController.currentHand).ToString();
            if (theController.currentHand == 5)
                Hand5TextBox.Text = "" +
                    theTable.player.GetHand(theController.currentHand).ToString();
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            NextHand("stand");
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            theController.ResetHand();
            Hand1TextBox.Clear();
            Hand2TextBox.Clear();
            Hand3TextBox.Clear();
            Hand4TextBox.Clear();
            Hand5TextBox.Clear();
            Bet1TextBox.Clear();
            Bet2TextBox.Clear();
            Bet3TextBox.Clear();
            Bet4TextBox.Clear();
            Bet5TextBox.Clear();
            DealerHandTextBox.Clear();
            ResultTextBox.Clear();
            DealButton.Enabled = true;
            HitButton.Enabled = false;
            StandButton.Enabled = false;
            PlayAgainButton.Enabled = false;
        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {
            switch (theController.currentHand)
            {
                case 1:
                    Bet1TextBox.Text = "" + theTable.player.bets[1] * 2;
                    break;
                case 2:
                    Bet2TextBox.Text = "" + theTable.player.bets[2] * 2;
                    break;
                case 3:
                    Bet3TextBox.Text = "" + theTable.player.bets[3] * 2;
                    break;
                case 4:
                    Bet4TextBox.Text = "" + theTable.player.bets[4] * 2;
                    break;
                case 5:
                    Bet5TextBox.Text = "" + theTable.player.bets[5] * 2;
                    break;
            }
            theController.DoubleHand();
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            theController.SplitHand();
            numHands++;
            switch (theController.currentHand)
            {
                case 1:
                    Hand1TextBox.Text = "" + theTable.player.GetHand(1);
                    Hand2TextBox.Text = "" + theTable.player.GetHand(2);
                    Bet1TextBox.Text = "" + theTable.player.bets[1];
                    Bet2TextBox.Text = "" + theTable.player.bets[2];
                    if (numHands >= 3)
                    {
                        Hand3TextBox.Text = "" + theTable.player.GetHand(3);
                        Bet3TextBox.Text = "" + theTable.player.bets[3];
                    }
                    if (numHands >= 4)
                    {
                        Hand4TextBox.Text = "" + theTable.player.GetHand(4);
                        Bet4TextBox.Text = "" + theTable.player.bets[4];
                    }
                    if (numHands >= 5)
                    {
                        Hand5TextBox.Text = "" + theTable.player.GetHand(5);
                        Bet5TextBox.Text = "" + theTable.player.bets[5];
                    }
                    break;

                case 2:
                    Hand2TextBox.Text = "" + theTable.player.GetHand(2);
                    Hand3TextBox.Text = "" + theTable.player.GetHand(3);
                    Bet2TextBox.Text = "" + theTable.player.bets[2];
                    Bet3TextBox.Text = "" + theTable.player.bets[3];
                    if (numHands >= 4)
                    {
                        Hand4TextBox.Text = "" + theTable.player.GetHand(4);
                        Bet4TextBox.Text = "" + theTable.player.bets[4];
                    }
                    if (numHands >= 5)
                    {
                        Hand5TextBox.Text = "" + theTable.player.GetHand(5);
                        Bet5TextBox.Text = "" + theTable.player.bets[5];
                    }
                    break;

                case 3:
                    Hand3TextBox.Text = "" + theTable.player.GetHand(3);
                    Hand4TextBox.Text = "" + theTable.player.GetHand(4);
                    Bet3TextBox.Text = "" + theTable.player.bets[3];
                    Bet4TextBox.Text = "" + theTable.player.bets[4];
                    if (numHands >= 5)
                    {
                        Hand5TextBox.Text = "" + theTable.player.GetHand(5);
                        Bet5TextBox.Text = "" + theTable.player.bets[5];
                    }
                    break;
                case 4:
                    Hand4TextBox.Text = "" + theTable.player.GetHand(4);
                    Hand5TextBox.Text = "" + theTable.player.GetHand(5);
                    Bet4TextBox.Text = "" + theTable.player.bets[4];
                    Bet5TextBox.Text = "" + theTable.player.bets[5];
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Event Handler for when a hand ends,
        /// shows result of hand for a short time,
        /// moves on to next hand for player,
        /// if all hands are done shows net loss/gain,
        /// play again starts new loop
        /// </summary>
        public void NextHand(string result)
        {
            // if there are more hands to play
            if (theController.currentHand < numHands)
            {
                PlayerAction();
            }
            // if there are no more hands
            else
            {
                theController.HitDealer();
            }
        }

        /// <summary>
        /// called once hands are all played out,
        /// shows result to player,
        /// opens play again button
        /// </summary>
        public void FinishRound()
        {
            DealerHandTextBox.Text = "" + theTable.dealer.GetHand().ToString();
            if (theController.chipPayout >= 0)
                ResultTextBox.Text = "You Won" + theController.chipPayout + " Chips!";
            else
                ResultTextBox.Text = "You Lost " + Math.Abs(theController.chipPayout) + " Chips!";
            UpdateChips();
            PlayAgainButton.Enabled = true;
            HitButton.Enabled = false;
            StandButton.Enabled = false;
            DoubleButton.Enabled = false;
            SplitButton.Enabled = false;
        }

        public void UpdateHand(int currentHand)
        {
            switch(currentHand)
            {
                case 1:
                    Hand1TextBox.Text = "" + theTable.player.GetHand(1);
                    break;
                case 2:
                    Hand2TextBox.Text = "" + theTable.player.GetHand(2);
                    break;
                case 3:
                    Hand3TextBox.Text = "" + theTable.player.GetHand(3);
                    break;
                case 4:
                    Hand4TextBox.Text = "" + theTable.player.GetHand(4);
                    break;
                case 5:
                    Hand5TextBox.Text = "" + theTable.player.GetHand(5);
                    break;
            }
        }

        private void OnePlayerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TwoHandsCheckBox.Checked = false;
            ThreeHandsCheckBox.Checked = false;
        }

        private void TwoPlayerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OneHandCheckBox.Checked = false;
            ThreeHandsCheckBox.Checked = false;
        }

        private void ThreePlayersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OneHandCheckBox.Checked = false;
            TwoHandsCheckBox.Checked = false;
        }

        public void ShoeShuffled()
        {
            ResultTextBox.Text = "shoe shuffled";
        }
    }
}
