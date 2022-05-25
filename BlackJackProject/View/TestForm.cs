using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class TestForm : Form
    {
        private Controller theController;
        private Table theTable;
        private Strategy strategy;

        public TestForm(Controller ctl)
        {
            InitializeComponent();
            theController = ctl;
            strategy = new Strategy();
            theTable = theController.GetTable();
        }


        private void GetMoveButton_Click(object sender, EventArgs e)
        {
            if (Card1TextBox.TextLength > 0 && Card2TextBox.TextLength > 0 && DealerCardTextBox.TextLength > 0)
            {
                Double.TryParse(Card1TextBox.Text, out double card1val);
                Double.TryParse(Card2TextBox.Text, out double card2val);
                Double.TryParse(DealerCardTextBox.Text, out double dCardVal);

                try
                {
                    MoveTextBox.Text = "" + strategy.GetMove((int)card1val, (int)card2val, (int)dCardVal);
                    if (MoveTextBox.Text == "?")
                    {
                        MoveTextBox.Clear();
                        MessageBox.Show("The card(s) given are invalid. Only use values 2-11\n(11 being an ace).", "Invalid Cards",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The card(s) given are invalid. Only use values 2-11\n(11 being an ace).", "Invalid Cards",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
            {
                string message = "Both player cards and the dealer card must be filled in to get a move.";
                string caption = "Missing Information";
                MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void HitCardButton_Click(object sender, EventArgs e)
        {
            HitCardTextBox.Text = "" + theTable.shoe.DrawCard();

            if (HitCardTextBox.Text == "0")
            {
                HitCardTextBox.Text = "boof shmoked";
            }

            ShoeCountTextBox.Text = "" + theTable.shoe.ShoeCount();
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            theTable.shoe.ShuffleShoe();
            ShoeCountTextBox.Text = "" + theTable.shoe.ShoeCount();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
