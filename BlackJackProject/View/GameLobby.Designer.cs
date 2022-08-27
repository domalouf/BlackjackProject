namespace BlackJack
{
    partial class GameLobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.cashierLabel = new System.Windows.Forms.Label();
            this.buyChipsLabel = new System.Windows.Forms.Label();
            this.buyChipsTextBox = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.playerInfoLabel = new System.Windows.Forms.Label();
            this.chipCountLabel = new System.Windows.Forms.Label();
            this.chipCountTextBox = new System.Windows.Forms.TextBox();
            this.DealButton = new System.Windows.Forms.Button();
            this.BetLabel = new System.Windows.Forms.Label();
            this.BetSizeTextBox = new System.Windows.Forms.TextBox();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SplitButton = new System.Windows.Forms.Button();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.HandLabel = new System.Windows.Forms.Label();
            this.CurrentHandTextBox = new System.Windows.Forms.TextBox();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.StandButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.DealerHandTextBox = new System.Windows.Forms.TextBox();
            this.Hand1TextBox = new System.Windows.Forms.TextBox();
            this.DealerHandLabel = new System.Windows.Forms.Label();
            this.PlayerHandLabel = new System.Windows.Forms.Label();
            this.PlayerNumberLabel = new System.Windows.Forms.Label();
            this.OneHandCheckBox = new System.Windows.Forms.CheckBox();
            this.TwoHandsCheckBox = new System.Windows.Forms.CheckBox();
            this.ThreeHandsCheckBox = new System.Windows.Forms.CheckBox();
            this.Hand2TextBox = new System.Windows.Forms.TextBox();
            this.Hand3TextBox = new System.Windows.Forms.TextBox();
            this.Hand4TextBox = new System.Windows.Forms.TextBox();
            this.Hand5TextBox = new System.Windows.Forms.TextBox();
            this.PlayerBetsLabel = new System.Windows.Forms.Label();
            this.Bet1TextBox = new System.Windows.Forms.TextBox();
            this.Bet2TextBox = new System.Windows.Forms.TextBox();
            this.Bet3TextBox = new System.Windows.Forms.TextBox();
            this.Bet4TextBox = new System.Windows.Forms.TextBox();
            this.Bet5TextBox = new System.Windows.Forms.TextBox();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(477, 25);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(192, 16);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Casino Homes";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Location = new System.Drawing.Point(147, 22);
            this.cashierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(53, 16);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Cashier";
            // 
            // buyChipsLabel
            // 
            this.buyChipsLabel.AutoSize = true;
            this.buyChipsLabel.Location = new System.Drawing.Point(63, 70);
            this.buyChipsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyChipsLabel.Name = "buyChipsLabel";
            this.buyChipsLabel.Size = new System.Drawing.Size(238, 16);
            this.buyChipsLabel.TabIndex = 2;
            this.buyChipsLabel.Text = "How many chips would you like to buy?";
            // 
            // buyChipsTextBox
            // 
            this.buyChipsTextBox.Location = new System.Drawing.Point(66, 104);
            this.buyChipsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.buyChipsTextBox.Name = "buyChipsTextBox";
            this.buyChipsTextBox.Size = new System.Drawing.Size(145, 22);
            this.buyChipsTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(248, 104);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(69, 28);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Location = new System.Drawing.Point(891, 43);
            this.playerInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(70, 16);
            this.playerInfoLabel.TabIndex = 5;
            this.playerInfoLabel.Text = "Player Info";
            // 
            // chipCountLabel
            // 
            this.chipCountLabel.AutoSize = true;
            this.chipCountLabel.Location = new System.Drawing.Point(861, 89);
            this.chipCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chipCountLabel.Name = "chipCountLabel";
            this.chipCountLabel.Size = new System.Drawing.Size(74, 16);
            this.chipCountLabel.TabIndex = 6;
            this.chipCountLabel.Text = "Chip Count:";
            // 
            // chipCountTextBox
            // 
            this.chipCountTextBox.Enabled = false;
            this.chipCountTextBox.Location = new System.Drawing.Point(952, 85);
            this.chipCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chipCountTextBox.Name = "chipCountTextBox";
            this.chipCountTextBox.Size = new System.Drawing.Size(132, 22);
            this.chipCountTextBox.TabIndex = 7;
            // 
            // DealButton
            // 
            this.DealButton.Enabled = false;
            this.DealButton.Location = new System.Drawing.Point(281, 330);
            this.DealButton.Margin = new System.Windows.Forms.Padding(4);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(100, 63);
            this.DealButton.TabIndex = 12;
            this.DealButton.Text = "Deal Cards";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(160, 330);
            this.BetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(56, 16);
            this.BetLabel.TabIndex = 13;
            this.BetLabel.Text = "Bet Size";
            // 
            // BetSizeTextBox
            // 
            this.BetSizeTextBox.Enabled = false;
            this.BetSizeTextBox.Location = new System.Drawing.Point(133, 350);
            this.BetSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BetSizeTextBox.Name = "BetSizeTextBox";
            this.BetSizeTextBox.Size = new System.Drawing.Size(132, 22);
            this.BetSizeTextBox.TabIndex = 14;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.Bet5TextBox);
            this.GamePanel.Controls.Add(this.Bet4TextBox);
            this.GamePanel.Controls.Add(this.Bet3TextBox);
            this.GamePanel.Controls.Add(this.Bet2TextBox);
            this.GamePanel.Controls.Add(this.Bet1TextBox);
            this.GamePanel.Controls.Add(this.PlayerBetsLabel);
            this.GamePanel.Controls.Add(this.Hand5TextBox);
            this.GamePanel.Controls.Add(this.Hand4TextBox);
            this.GamePanel.Controls.Add(this.Hand3TextBox);
            this.GamePanel.Controls.Add(this.Hand2TextBox);
            this.GamePanel.Controls.Add(this.SplitButton);
            this.GamePanel.Controls.Add(this.DoubleButton);
            this.GamePanel.Controls.Add(this.HandLabel);
            this.GamePanel.Controls.Add(this.CurrentHandTextBox);
            this.GamePanel.Controls.Add(this.PlayAgainButton);
            this.GamePanel.Controls.Add(this.ResultTextBox);
            this.GamePanel.Controls.Add(this.StandButton);
            this.GamePanel.Controls.Add(this.HitButton);
            this.GamePanel.Controls.Add(this.DealerHandTextBox);
            this.GamePanel.Controls.Add(this.Hand1TextBox);
            this.GamePanel.Controls.Add(this.DealerHandLabel);
            this.GamePanel.Controls.Add(this.PlayerHandLabel);
            this.GamePanel.Controls.Add(this.BetSizeTextBox);
            this.GamePanel.Controls.Add(this.DealButton);
            this.GamePanel.Controls.Add(this.BetLabel);
            this.GamePanel.Location = new System.Drawing.Point(337, 135);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(587, 405);
            this.GamePanel.TabIndex = 15;
            // 
            // SplitButton
            // 
            this.SplitButton.Enabled = false;
            this.SplitButton.Location = new System.Drawing.Point(408, 239);
            this.SplitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(75, 43);
            this.SplitButton.TabIndex = 28;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // DoubleButton
            // 
            this.DoubleButton.Enabled = false;
            this.DoubleButton.Location = new System.Drawing.Point(307, 239);
            this.DoubleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(75, 49);
            this.DoubleButton.TabIndex = 27;
            this.DoubleButton.Text = "Double Down";
            this.DoubleButton.UseVisualStyleBackColor = true;
            this.DoubleButton.Click += new System.EventHandler(this.DoubleButton_Click);
            // 
            // HandLabel
            // 
            this.HandLabel.AutoSize = true;
            this.HandLabel.Location = new System.Drawing.Point(21, 9);
            this.HandLabel.Name = "HandLabel";
            this.HandLabel.Size = new System.Drawing.Size(85, 16);
            this.HandLabel.TabIndex = 25;
            this.HandLabel.Text = "Current Hand";
            // 
            // CurrentHandTextBox
            // 
            this.CurrentHandTextBox.Enabled = false;
            this.CurrentHandTextBox.Location = new System.Drawing.Point(16, 27);
            this.CurrentHandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentHandTextBox.Name = "CurrentHandTextBox";
            this.CurrentHandTextBox.Size = new System.Drawing.Size(100, 22);
            this.CurrentHandTextBox.TabIndex = 24;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Enabled = false;
            this.PlayAgainButton.Location = new System.Drawing.Point(421, 340);
            this.PlayAgainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(75, 49);
            this.PlayAgainButton.TabIndex = 22;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(247, 213);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 22);
            this.ResultTextBox.TabIndex = 21;
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Location = new System.Drawing.Point(208, 239);
            this.StandButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 43);
            this.StandButton.TabIndex = 20;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(115, 239);
            this.HitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(75, 41);
            this.HitButton.TabIndex = 19;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // DealerHandTextBox
            // 
            this.DealerHandTextBox.Enabled = false;
            this.DealerHandTextBox.Location = new System.Drawing.Point(250, 26);
            this.DealerHandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.Size = new System.Drawing.Size(100, 22);
            this.DealerHandTextBox.TabIndex = 18;
            // 
            // Hand1TextBox
            // 
            this.Hand1TextBox.Enabled = false;
            this.Hand1TextBox.Location = new System.Drawing.Point(16, 100);
            this.Hand1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hand1TextBox.Name = "Hand1TextBox";
            this.Hand1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Hand1TextBox.TabIndex = 17;
            // 
            // DealerHandLabel
            // 
            this.DealerHandLabel.AutoSize = true;
            this.DealerHandLabel.Location = new System.Drawing.Point(253, 9);
            this.DealerHandLabel.Name = "DealerHandLabel";
            this.DealerHandLabel.Size = new System.Drawing.Size(94, 16);
            this.DealerHandLabel.TabIndex = 16;
            this.DealerHandLabel.Text = "Dealer\'s Hand";
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Location = new System.Drawing.Point(17, 82);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(99, 16);
            this.PlayerHandLabel.TabIndex = 15;
            this.PlayerHandLabel.Text = "Player\'s Hands";
            // 
            // PlayerNumberLabel
            // 
            this.PlayerNumberLabel.AutoSize = true;
            this.PlayerNumberLabel.Location = new System.Drawing.Point(77, 375);
            this.PlayerNumberLabel.Name = "PlayerNumberLabel";
            this.PlayerNumberLabel.Size = new System.Drawing.Size(113, 16);
            this.PlayerNumberLabel.TabIndex = 16;
            this.PlayerNumberLabel.Text = "How Many Hands";
            // 
            // OneHandCheckBox
            // 
            this.OneHandCheckBox.AutoSize = true;
            this.OneHandCheckBox.Checked = true;
            this.OneHandCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OneHandCheckBox.Location = new System.Drawing.Point(125, 406);
            this.OneHandCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OneHandCheckBox.Name = "OneHandCheckBox";
            this.OneHandCheckBox.Size = new System.Drawing.Size(36, 20);
            this.OneHandCheckBox.TabIndex = 17;
            this.OneHandCheckBox.Text = "1";
            this.OneHandCheckBox.UseVisualStyleBackColor = true;
            this.OneHandCheckBox.CheckedChanged += new System.EventHandler(this.OnePlayerCheckBox_CheckedChanged);
            // 
            // TwoHandsCheckBox
            // 
            this.TwoHandsCheckBox.AutoSize = true;
            this.TwoHandsCheckBox.Location = new System.Drawing.Point(125, 432);
            this.TwoHandsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TwoHandsCheckBox.Name = "TwoHandsCheckBox";
            this.TwoHandsCheckBox.Size = new System.Drawing.Size(36, 20);
            this.TwoHandsCheckBox.TabIndex = 18;
            this.TwoHandsCheckBox.Text = "2";
            this.TwoHandsCheckBox.UseVisualStyleBackColor = true;
            this.TwoHandsCheckBox.CheckedChanged += new System.EventHandler(this.TwoPlayerCheckBox_CheckedChanged);
            // 
            // ThreeHandsCheckBox
            // 
            this.ThreeHandsCheckBox.AutoSize = true;
            this.ThreeHandsCheckBox.Location = new System.Drawing.Point(125, 458);
            this.ThreeHandsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThreeHandsCheckBox.Name = "ThreeHandsCheckBox";
            this.ThreeHandsCheckBox.Size = new System.Drawing.Size(36, 20);
            this.ThreeHandsCheckBox.TabIndex = 19;
            this.ThreeHandsCheckBox.Text = "3";
            this.ThreeHandsCheckBox.UseVisualStyleBackColor = true;
            this.ThreeHandsCheckBox.CheckedChanged += new System.EventHandler(this.ThreePlayersCheckBox_CheckedChanged);
            // 
            // Hand2TextBox
            // 
            this.Hand2TextBox.Enabled = false;
            this.Hand2TextBox.Location = new System.Drawing.Point(126, 100);
            this.Hand2TextBox.Name = "Hand2TextBox";
            this.Hand2TextBox.Size = new System.Drawing.Size(100, 22);
            this.Hand2TextBox.TabIndex = 29;
            // 
            // Hand3TextBox
            // 
            this.Hand3TextBox.Enabled = false;
            this.Hand3TextBox.Location = new System.Drawing.Point(232, 100);
            this.Hand3TextBox.Name = "Hand3TextBox";
            this.Hand3TextBox.Size = new System.Drawing.Size(100, 22);
            this.Hand3TextBox.TabIndex = 30;
            // 
            // Hand4TextBox
            // 
            this.Hand4TextBox.Enabled = false;
            this.Hand4TextBox.Location = new System.Drawing.Point(338, 100);
            this.Hand4TextBox.Name = "Hand4TextBox";
            this.Hand4TextBox.Size = new System.Drawing.Size(100, 22);
            this.Hand4TextBox.TabIndex = 31;
            // 
            // Hand5TextBox
            // 
            this.Hand5TextBox.Enabled = false;
            this.Hand5TextBox.Location = new System.Drawing.Point(444, 100);
            this.Hand5TextBox.Name = "Hand5TextBox";
            this.Hand5TextBox.Size = new System.Drawing.Size(100, 22);
            this.Hand5TextBox.TabIndex = 32;
            // 
            // PlayerBetsLabel
            // 
            this.PlayerBetsLabel.AutoSize = true;
            this.PlayerBetsLabel.Location = new System.Drawing.Point(22, 145);
            this.PlayerBetsLabel.Name = "PlayerBetsLabel";
            this.PlayerBetsLabel.Size = new System.Drawing.Size(86, 16);
            this.PlayerBetsLabel.TabIndex = 33;
            this.PlayerBetsLabel.Text = "Player\'s Bets";
            // 
            // Bet1TextBox
            // 
            this.Bet1TextBox.Enabled = false;
            this.Bet1TextBox.Location = new System.Drawing.Point(16, 164);
            this.Bet1TextBox.Name = "Bet1TextBox";
            this.Bet1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Bet1TextBox.TabIndex = 34;
            // 
            // Bet2TextBox
            // 
            this.Bet2TextBox.Enabled = false;
            this.Bet2TextBox.Location = new System.Drawing.Point(126, 164);
            this.Bet2TextBox.Name = "Bet2TextBox";
            this.Bet2TextBox.Size = new System.Drawing.Size(100, 22);
            this.Bet2TextBox.TabIndex = 35;
            // 
            // Bet3TextBox
            // 
            this.Bet3TextBox.Enabled = false;
            this.Bet3TextBox.Location = new System.Drawing.Point(232, 164);
            this.Bet3TextBox.Name = "Bet3TextBox";
            this.Bet3TextBox.Size = new System.Drawing.Size(100, 22);
            this.Bet3TextBox.TabIndex = 36;
            // 
            // Bet4TextBox
            // 
            this.Bet4TextBox.Enabled = false;
            this.Bet4TextBox.Location = new System.Drawing.Point(338, 164);
            this.Bet4TextBox.Name = "Bet4TextBox";
            this.Bet4TextBox.Size = new System.Drawing.Size(100, 22);
            this.Bet4TextBox.TabIndex = 37;
            // 
            // Bet5TextBox
            // 
            this.Bet5TextBox.Enabled = false;
            this.Bet5TextBox.Location = new System.Drawing.Point(444, 164);
            this.Bet5TextBox.Name = "Bet5TextBox";
            this.Bet5TextBox.Size = new System.Drawing.Size(100, 22);
            this.Bet5TextBox.TabIndex = 38;
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 622);
            this.Controls.Add(this.ThreeHandsCheckBox);
            this.Controls.Add(this.TwoHandsCheckBox);
            this.Controls.Add(this.OneHandCheckBox);
            this.Controls.Add(this.PlayerNumberLabel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.chipCountTextBox);
            this.Controls.Add(this.chipCountLabel);
            this.Controls.Add(this.playerInfoLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.buyChipsTextBox);
            this.Controls.Add(this.buyChipsLabel);
            this.Controls.Add(this.cashierLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameLobby";
            this.Text = "BlackJack Lobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.Label buyChipsLabel;
        private System.Windows.Forms.TextBox buyChipsTextBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label playerInfoLabel;
        private System.Windows.Forms.Label chipCountLabel;
        private System.Windows.Forms.TextBox chipCountTextBox;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.TextBox BetSizeTextBox;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.TextBox DealerHandTextBox;
        private System.Windows.Forms.TextBox Hand1TextBox;
        private System.Windows.Forms.Label DealerHandLabel;
        private System.Windows.Forms.Label PlayerHandLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label HandLabel;
        private System.Windows.Forms.TextBox CurrentHandTextBox;
        private System.Windows.Forms.Label PlayerNumberLabel;
        private System.Windows.Forms.CheckBox OneHandCheckBox;
        private System.Windows.Forms.CheckBox TwoHandsCheckBox;
        private System.Windows.Forms.CheckBox ThreeHandsCheckBox;
        private System.Windows.Forms.Button DoubleButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.TextBox Hand2TextBox;
        private System.Windows.Forms.TextBox Hand5TextBox;
        private System.Windows.Forms.TextBox Hand4TextBox;
        private System.Windows.Forms.TextBox Hand3TextBox;
        private System.Windows.Forms.TextBox Bet5TextBox;
        private System.Windows.Forms.TextBox Bet4TextBox;
        private System.Windows.Forms.TextBox Bet3TextBox;
        private System.Windows.Forms.TextBox Bet2TextBox;
        private System.Windows.Forms.TextBox Bet1TextBox;
        private System.Windows.Forms.Label PlayerBetsLabel;
    }
}