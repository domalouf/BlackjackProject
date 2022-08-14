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
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.HandLabel = new System.Windows.Forms.Label();
            this.HandTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTextBox = new System.Windows.Forms.TextBox();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.StandButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.DealerHandTextBox = new System.Windows.Forms.TextBox();
            this.PlayerHandTextBox = new System.Windows.Forms.TextBox();
            this.DealerHandLabel = new System.Windows.Forms.Label();
            this.PlayerHandLabel = new System.Windows.Forms.Label();
            this.PlayerNumberLabel = new System.Windows.Forms.Label();
            this.OnePlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.TwoPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.ThreePlayersCheckBox = new System.Windows.Forms.CheckBox();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(429, 11);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(192, 16);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Casino Homes";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Location = new System.Drawing.Point(99, 9);
            this.cashierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(53, 16);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Cashier";
            // 
            // buyChipsLabel
            // 
            this.buyChipsLabel.AutoSize = true;
            this.buyChipsLabel.Location = new System.Drawing.Point(15, 57);
            this.buyChipsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyChipsLabel.Name = "buyChipsLabel";
            this.buyChipsLabel.Size = new System.Drawing.Size(238, 16);
            this.buyChipsLabel.TabIndex = 2;
            this.buyChipsLabel.Text = "How many chips would you like to buy?";
            // 
            // buyChipsTextBox
            // 
            this.buyChipsTextBox.Location = new System.Drawing.Point(21, 102);
            this.buyChipsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.buyChipsTextBox.Name = "buyChipsTextBox";
            this.buyChipsTextBox.Size = new System.Drawing.Size(145, 22);
            this.buyChipsTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(203, 102);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(69, 23);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Location = new System.Drawing.Point(843, 30);
            this.playerInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(70, 16);
            this.playerInfoLabel.TabIndex = 5;
            this.playerInfoLabel.Text = "Player Info";
            // 
            // chipCountLabel
            // 
            this.chipCountLabel.AutoSize = true;
            this.chipCountLabel.Location = new System.Drawing.Point(814, 75);
            this.chipCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chipCountLabel.Name = "chipCountLabel";
            this.chipCountLabel.Size = new System.Drawing.Size(74, 16);
            this.chipCountLabel.TabIndex = 6;
            this.chipCountLabel.Text = "Chip Count:";
            // 
            // chipCountTextBox
            // 
            this.chipCountTextBox.Enabled = false;
            this.chipCountTextBox.Location = new System.Drawing.Point(904, 71);
            this.chipCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chipCountTextBox.Name = "chipCountTextBox";
            this.chipCountTextBox.Size = new System.Drawing.Size(132, 22);
            this.chipCountTextBox.TabIndex = 7;
            // 
            // DealButton
            // 
            this.DealButton.Enabled = false;
            this.DealButton.Location = new System.Drawing.Point(230, 315);
            this.DealButton.Margin = new System.Windows.Forms.Padding(4);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(100, 28);
            this.DealButton.TabIndex = 12;
            this.DealButton.Text = "Deal Cards";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(101, 298);
            this.BetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(56, 16);
            this.BetLabel.TabIndex = 13;
            this.BetLabel.Text = "Bet Size";
            // 
            // BetSizeTextBox
            // 
            this.BetSizeTextBox.Enabled = false;
            this.BetSizeTextBox.Location = new System.Drawing.Point(75, 318);
            this.BetSizeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BetSizeTextBox.Name = "BetSizeTextBox";
            this.BetSizeTextBox.Size = new System.Drawing.Size(132, 22);
            this.BetSizeTextBox.TabIndex = 14;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.DoubleButton);
            this.GamePanel.Controls.Add(this.PlayerLabel);
            this.GamePanel.Controls.Add(this.HandLabel);
            this.GamePanel.Controls.Add(this.HandTextBox);
            this.GamePanel.Controls.Add(this.PlayerTextBox);
            this.GamePanel.Controls.Add(this.PlayAgainButton);
            this.GamePanel.Controls.Add(this.ResultTextBox);
            this.GamePanel.Controls.Add(this.StandButton);
            this.GamePanel.Controls.Add(this.HitButton);
            this.GamePanel.Controls.Add(this.DealerHandTextBox);
            this.GamePanel.Controls.Add(this.PlayerHandTextBox);
            this.GamePanel.Controls.Add(this.DealerHandLabel);
            this.GamePanel.Controls.Add(this.PlayerHandLabel);
            this.GamePanel.Controls.Add(this.BetSizeTextBox);
            this.GamePanel.Controls.Add(this.DealButton);
            this.GamePanel.Controls.Add(this.BetLabel);
            this.GamePanel.Location = new System.Drawing.Point(341, 102);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(457, 382);
            this.GamePanel.TabIndex = 15;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(85, 10);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(46, 16);
            this.PlayerLabel.TabIndex = 26;
            this.PlayerLabel.Text = "Player";
            // 
            // HandLabel
            // 
            this.HandLabel.AutoSize = true;
            this.HandLabel.Location = new System.Drawing.Point(301, 10);
            this.HandLabel.Name = "HandLabel";
            this.HandLabel.Size = new System.Drawing.Size(40, 16);
            this.HandLabel.TabIndex = 25;
            this.HandLabel.Text = "Hand";
            // 
            // HandTextBox
            // 
            this.HandTextBox.Enabled = false;
            this.HandTextBox.Location = new System.Drawing.Point(296, 28);
            this.HandTextBox.Name = "HandTextBox";
            this.HandTextBox.Size = new System.Drawing.Size(100, 22);
            this.HandTextBox.TabIndex = 24;
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Enabled = false;
            this.PlayerTextBox.Location = new System.Drawing.Point(84, 32);
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.Size = new System.Drawing.Size(100, 22);
            this.PlayerTextBox.TabIndex = 23;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Enabled = false;
            this.PlayAgainButton.Location = new System.Drawing.Point(362, 308);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(75, 42);
            this.PlayAgainButton.TabIndex = 22;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(191, 160);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 22);
            this.ResultTextBox.TabIndex = 21;
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Location = new System.Drawing.Point(149, 207);
            this.StandButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 23);
            this.StandButton.TabIndex = 20;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(56, 207);
            this.HitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(75, 23);
            this.HitButton.TabIndex = 19;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // DealerHandTextBox
            // 
            this.DealerHandTextBox.Enabled = false;
            this.DealerHandTextBox.Location = new System.Drawing.Point(296, 95);
            this.DealerHandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.Size = new System.Drawing.Size(100, 22);
            this.DealerHandTextBox.TabIndex = 18;
            // 
            // PlayerHandTextBox
            // 
            this.PlayerHandTextBox.Enabled = false;
            this.PlayerHandTextBox.Location = new System.Drawing.Point(84, 95);
            this.PlayerHandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerHandTextBox.Name = "PlayerHandTextBox";
            this.PlayerHandTextBox.Size = new System.Drawing.Size(100, 22);
            this.PlayerHandTextBox.TabIndex = 17;
            // 
            // DealerHandLabel
            // 
            this.DealerHandLabel.AutoSize = true;
            this.DealerHandLabel.Location = new System.Drawing.Point(301, 77);
            this.DealerHandLabel.Name = "DealerHandLabel";
            this.DealerHandLabel.Size = new System.Drawing.Size(94, 16);
            this.DealerHandLabel.TabIndex = 16;
            this.DealerHandLabel.Text = "Dealer\'s Hand";
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Location = new System.Drawing.Point(81, 77);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(92, 16);
            this.PlayerHandLabel.TabIndex = 15;
            this.PlayerHandLabel.Text = "Player\'s Hand";
            // 
            // PlayerNumberLabel
            // 
            this.PlayerNumberLabel.AutoSize = true;
            this.PlayerNumberLabel.Location = new System.Drawing.Point(30, 333);
            this.PlayerNumberLabel.Name = "PlayerNumberLabel";
            this.PlayerNumberLabel.Size = new System.Drawing.Size(242, 16);
            this.PlayerNumberLabel.TabIndex = 16;
            this.PlayerNumberLabel.Text = "How Many Players? (single player only)";
            // 
            // OnePlayerCheckBox
            // 
            this.OnePlayerCheckBox.AutoSize = true;
            this.OnePlayerCheckBox.Enabled = false;
            this.OnePlayerCheckBox.Location = new System.Drawing.Point(78, 364);
            this.OnePlayerCheckBox.Name = "OnePlayerCheckBox";
            this.OnePlayerCheckBox.Size = new System.Drawing.Size(36, 20);
            this.OnePlayerCheckBox.TabIndex = 17;
            this.OnePlayerCheckBox.Text = "1";
            this.OnePlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // TwoPlayerCheckBox
            // 
            this.TwoPlayerCheckBox.AutoSize = true;
            this.TwoPlayerCheckBox.Enabled = false;
            this.TwoPlayerCheckBox.Location = new System.Drawing.Point(78, 390);
            this.TwoPlayerCheckBox.Name = "TwoPlayerCheckBox";
            this.TwoPlayerCheckBox.Size = new System.Drawing.Size(36, 20);
            this.TwoPlayerCheckBox.TabIndex = 18;
            this.TwoPlayerCheckBox.Text = "2";
            this.TwoPlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThreePlayersCheckBox
            // 
            this.ThreePlayersCheckBox.AutoSize = true;
            this.ThreePlayersCheckBox.Enabled = false;
            this.ThreePlayersCheckBox.Location = new System.Drawing.Point(78, 416);
            this.ThreePlayersCheckBox.Name = "ThreePlayersCheckBox";
            this.ThreePlayersCheckBox.Size = new System.Drawing.Size(36, 20);
            this.ThreePlayersCheckBox.TabIndex = 19;
            this.ThreePlayersCheckBox.Text = "3";
            this.ThreePlayersCheckBox.UseVisualStyleBackColor = true;
            // 
            // DoubleButton
            // 
            this.DoubleButton.Enabled = false;
            this.DoubleButton.Location = new System.Drawing.Point(245, 198);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(75, 40);
            this.DoubleButton.TabIndex = 27;
            this.DoubleButton.Text = "Double Down";
            this.DoubleButton.UseVisualStyleBackColor = true;
            this.DoubleButton.Click += new System.EventHandler(this.DoubleButton_Click);
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ThreePlayersCheckBox);
            this.Controls.Add(this.TwoPlayerCheckBox);
            this.Controls.Add(this.OnePlayerCheckBox);
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
            this.Load += new System.EventHandler(this.GameLobby_Load);
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
        private System.Windows.Forms.TextBox PlayerHandTextBox;
        private System.Windows.Forms.Label DealerHandLabel;
        private System.Windows.Forms.Label PlayerHandLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label HandLabel;
        private System.Windows.Forms.TextBox HandTextBox;
        private System.Windows.Forms.TextBox PlayerTextBox;
        private System.Windows.Forms.Label PlayerNumberLabel;
        private System.Windows.Forms.CheckBox OnePlayerCheckBox;
        private System.Windows.Forms.CheckBox TwoPlayerCheckBox;
        private System.Windows.Forms.CheckBox ThreePlayersCheckBox;
        private System.Windows.Forms.Button DoubleButton;
    }
}