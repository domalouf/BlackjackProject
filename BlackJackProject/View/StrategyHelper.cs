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
    public partial class StrategyHelper : Form
    {
        private Controller theController;
        private Strategy strategy;

        public StrategyHelper(Controller ctl)
        {
            InitializeComponent();
            theController = ctl;
            strategy = new Strategy();
        }

        private void GetMoveButton_Click(object sender, EventArgs e)
        {
            if (FirstCardTextBox.TextLength > 0 && SecondCardTextBox.TextLength > 0 && DealerCardTextBox.TextLength > 0)
            {
                Double.TryParse(FirstCardTextBox.Text, out double FirstCardval);
                Double.TryParse(SecondCardTextBox.Text, out double SecondCardval);
                Double.TryParse(DealerCardTextBox.Text, out double dCardVal);

                try
                {
                    GetMoveTextBox.Text = "" + strategy.GetMove((int)FirstCardval, (int)SecondCardval, (int)dCardVal);
                    if (GetMoveTextBox.Text == "?")
                    {
                        GetMoveTextBox.Clear();
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

        private void StrategyHelper_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
