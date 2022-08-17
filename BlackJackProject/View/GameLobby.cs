using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // methods that the controller can cause with event
            theController.NewPlayerJoined += NewPlayerJoined;
            theController.UpdateChips += UpdateChips;
            theController.PlayerAction += PlayerAction;
            theController.FinishedRound += FinishedRound;
            theController.NextHand += NextHand;
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
                    (betSize * numHands > theTable.players[1].GetChips()))
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
                    DealButton.Enabled = false;
                    theController.DealHands(numHands, betSize);
                    PlayerHandTextBox.Text = "" +
                        theTable.players[theController.currentPlayer].GetHand(1).ToString();
                    HandCountTextBox.Text = "1";
                    DealerHandTextBox.Text = "" + theTable.dealer.GetFirstCard();
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
            PlayerTextBox.Text += "1";
        }

        /// <summary>
        /// Event handler for when a player adds chips,
        /// changes text box to show new amount
        /// </summary>
        public void UpdateChips()
        {
            chipCountTextBox.Text = "" + theTable.players[1].GetChips();
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
            if (theTable.players[1].chips >= theTable.players[1].bet) DoubleButton.Enabled = true;
            else DoubleButton.Enabled = false;
            if (theTable.players[1].GetHand(theController.currentHand).pair) SplitButton.Enabled = true;
            else SplitButton.Enabled = false;
        }

        public void FinishedRound()
        {

        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            theController.HitHand();
            PlayerHandTextBox.Text = "" +
                theTable.players[1].GetHand(theController.currentHand).ToString();
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            theController.StandHand();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            theController.ResetHand();
            PlayerHandTextBox.Clear();
            DealerHandTextBox.Clear();
            ResultTextBox.Clear();
            DealButton.Enabled = true;
            HitButton.Enabled = false;
            StandButton.Enabled = false;
            PlayAgainButton.Enabled = false;
            
        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {
            theController.DoubleHand();
            PlayerHandTextBox.Text = "" +
                theTable.players[1].GetHand(theController.currentHand).ToString();
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            theController.SplitHand();
        }

        /// <summary>
        /// Event Handler that moves current hand to the next
        /// </summary>
        public void NextHand(string result)
        {
            
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
    }
}
