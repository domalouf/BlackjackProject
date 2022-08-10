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
    public partial class GameForm : Form
    {
        private Controller theController;
        private Table theTable;

        public GameForm(Controller _theController)
        {
            InitializeComponent();
            theController = _theController;
            theTable = theController.GetTable();
            theController.NewPlayerJoined += NewPlayerJoined;
            theController.AddChips += UpdatePlayerChips;
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
                    theController.DealHand(betSize);
                    PlayerHandTextBox.Text = "" + theTable.players[0].GetHand().cards;
                    DealerHandTextBox.Text = "" + theTable.dealer.getCards();
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
        /// event handler for when a player adds chips,
        /// changes text box to show new amount
        /// </summary>
        public void UpdatePlayerChips()
        {
            chipCountTextBox.Text = "" + theTable.players[0].GetChips();
        }
    }
}
