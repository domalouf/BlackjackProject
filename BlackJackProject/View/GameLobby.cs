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

        public GameLobby(Controller _theController)
        {
            InitializeComponent();
            theController = _theController;
            theTable = theController.GetTable();
            // methods that the controller can cause with event
            theController.NewPlayerJoined += NewPlayerJoined;
            theController.AddChips += AddChips;
            theController.PlayerWin += PlayerWin;
            theController.PlayerBust += PlayerBust;
            theController.PlayerBlackJack += PlayerBlackJack;
            theController.PushBet += PushBet;
            theController.PlayerAction += PlayerAction;
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// checks if there is a valid amount of chips entered and adds a player with that chip count
        /// only works once for first player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(buyChipsTextBox.Text, out int numChips))
            {
                theController.GiveChips(numChips);
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
        /// Calls method in controller to start hand,
        /// Updates text boxes to show dealt cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DealButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(BetSizeTextBox.Text, out int betSize))
            {
                if ((betSize <= 0) || (betSize > theTable.players[0].GetChips()))
                {
                    string message = "Please enter a valid amount of chips to bet.";
                    string caption = "Invalid Bet Size";
                    MessageBox.Show(message, caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    DealButton.Enabled = false;
                    theController.DealHand(betSize);
                    PlayerHandTextBox.Text = "" + theTable.players[0].GetHand().ToString();
                    DealerHandTextBox.Text = "" + theTable.dealer.GetHand().ToString();
                }
            }
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
            chipCountTextBox.Text = "" + theTable.players[0].GetChips();
        }

        /// <summary>
        /// Event handler for when a player adds chips,
        /// changes text box to show new amount
        /// </summary>
        public void AddChips()
        {
            chipCountTextBox.Text = "" + theTable.players[0].GetChips();
        }

        /// <summary>
        /// Event handler for when a player wins
        /// </summary>
        public void PlayerWin()
        {
            DealerHandTextBox.Text = "" + theTable.dealer.GetHand().ToString();
            ResultTextBox.Text = "You Win!!!";
            PlayAgainButton.Enabled = true;
        }

        /// <summary>
        /// Event Handler for when a player loses
        /// </summary>
        public void PlayerBust()
        {
            DealerHandTextBox.Text = "" + theTable.dealer.GetHand().ToString();
            ResultTextBox.Text = "You Lose!!!";
            PlayAgainButton.Enabled = true;
        }

        /// <summary>
        /// Event handler for when a player gets a blackjack
        /// </summary>
        public void PlayerBlackJack()
        {
            ResultTextBox.Text = "BlackJack!!!";
            PlayAgainButton.Enabled = true;
        }

        /// <summary>
        /// Event handler for when a player ties with dealer
        /// </summary>
        public void PushBet()
        {
            ResultTextBox.Text = "You Tie.";
            PlayAgainButton.Enabled = true;
        }

        /// <summary>
        /// Event handler for when a player must act
        /// </summary>
        public void PlayerAction()
        {
            HitButton.Enabled = true;
            StandButton.Enabled = true;
        }

        /// <summary>
        /// double tapping the screen calls this (while coding)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLobby_Load(object sender, EventArgs e)
        {

        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            theController.HitPlayer();
            PlayerHandTextBox.Text = "" + theTable.players[0].GetHand().ToString();
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            theController.StandPlayer();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            theController.ResetHand();
            PlayerHandTextBox.Clear();
            DealerHandTextBox.Clear();
            DealButton.Enabled = true;
        }
    }
}
