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

        /// <summary>
        /// Opens window to basic strategy helper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelperButton_Click(object sender, EventArgs e)
        {
            StrategyHelper sh = new StrategyHelper(theController);
            this.Hide();
            sh.ShowDialog();
        }

        /// <summary>
        /// Opens new window to play blackjack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(theController);
            this.Hide();
            game.ShowDialog();
        }

        /// <summary>
        /// Opens new window for testing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestFormButton_Click(object sender, EventArgs e)
        {
            TestForm tf = new TestForm(theController);
            this.Hide();
            tf.ShowDialog();
        }
    }
}
