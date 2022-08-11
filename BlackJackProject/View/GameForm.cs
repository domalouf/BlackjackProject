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

            DealerHandTextBox.Text = "" + theTable.dealer.getCards().Peek();
            PlayerHandTextBox.Text = "" + theTable.players[0].GetHand().ToString();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
