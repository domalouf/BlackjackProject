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
    public partial class MainMenu : Form
    {
        private Controller theController;

        public MainMenu(Controller ctl)
        {
            InitializeComponent();
            theController = ctl;
        }

        private void HelperButton_Click(object sender, EventArgs e)
        {
            StrategyHelper sh = new StrategyHelper(theController);
            this.Hide();
            sh.ShowDialog();
        }
    }
}
