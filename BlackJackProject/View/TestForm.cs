using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class TestForm : Form
    {
        private Controller theController;
        private Table theTable;

        public TestForm(Controller ctl)
        {
            InitializeComponent();
            Card1TextBox.Enabled = false;
            Card2TextBox.Enabled = false;
            DealerCardTextBox.Enabled = false;
            GetMoveButton.Enabled = false;
            MoveTextBox.Enabled = false;
            theController = ctl;
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
                    MoveTextBox.Text = "" + theController.strategy.GetMove((int)card1val, (int)card2val, (int)dCardVal);
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            theController.StartSession();
            Card1TextBox.Enabled = true;
            Card2TextBox.Enabled = true;
            DealerCardTextBox.Enabled = true;
            GetMoveButton.Enabled = true;
            MoveTextBox.Enabled = true;
        }

        private void HitCardButton_Click(object sender, EventArgs e)
        {
            HitCardTextBox.Text = "" + theTable.shoe.DrawCard();

            if (HitCardTextBox.Text == "0")
            {
                HitCardTextBox.Text = "boof shmoked";
            }
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            theTable.shoe.ShuffleShoe();
        }

        private void GetHandButton_Click(object sender, EventArgs e)
        {
            theTable.players[0].hand.cards.Clear(); //shouldn't be in view
            PlayerHandTextBox.Clear();

            theTable.players[0].hand.cards.Push(theTable.shoe.DrawCard());
            theTable.players[0].hand.cards.Push(theTable.shoe.DrawCard());
            foreach (int i in theTable.players[0].hand.cards)
            {
                PlayerHandTextBox.Text += i + ", ";
            }
        }
    }
}
