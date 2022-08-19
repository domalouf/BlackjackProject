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
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.HandLabel = new System.Windows.Forms.Label();
            this.HandCountTextBox = new System.Windows.Forms.TextBox();
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
            this.OneHandCheckBox = new System.Windows.Forms.CheckBox();
            this.TwoHandsCheckBox = new System.Windows.Forms.CheckBox();
            this.ThreeHandsCheckBox = new System.Windows.Forms.CheckBox();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(358, 43);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(176, 15);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Casino Homes";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Location = new System.Drawing.Point(110, 41);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(49, 15);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Cashier";
            // 
            // buyChipsLabel
            // 
            this.buyChipsLabel.AutoSize = true;
            this.buyChipsLabel.Location = new System.Drawing.Point(47, 80);
            this.buyChipsLabel.Name = "buyChipsLabel";
            this.buyChipsLabel.Size = new System.Drawing.Size(219, 15);
            this.buyChipsLabel.TabIndex = 2;
            this.buyChipsLabel.Text = "How many chips would you like to buy?";
            // 
            // buyChipsTextBox
            // 
            this.buyChipsTextBox.Location = new System.Drawing.Point(52, 117);
            this.buyChipsTextBox.Name = "buyChipsTextBox";
            this.buyChipsTextBox.Size = new System.Drawing.Size(110, 20);
            this.buyChipsTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(188, 117);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(52, 23);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Location = new System.Drawing.Point(668, 58);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(64, 15);
            this.playerInfoLabel.TabIndex = 5;
            this.playerInfoLabel.Text = "Player Info";
            // 
            // chipCountLabel
            // 
            this.chipCountLabel.AutoSize = true;
            this.chipCountLabel.Location = new System.Drawing.Point(646, 95);
            this.chipCountLabel.Name = "chipCountLabel";
            this.chipCountLabel.Size = new System.Drawing.Size(70, 15);
            this.chipCountLabel.TabIndex = 6;
            this.chipCountLabel.Text = "Chip Count:";
            // 
            // chipCountTextBox
            // 
            this.chipCountTextBox.Enabled = false;
            this.chipCountTextBox.Location = new System.Drawing.Point(714, 92);
            this.chipCountTextBox.Name = "chipCountTextBox";
            this.chipCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.chipCountTextBox.TabIndex = 7;
            // 
            // DealButton
            // 
            this.DealButton.Enabled = false;
            this.DealButton.Location = new System.Drawing.Point(211, 268);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 51);
            this.DealButton.TabIndex = 12;
            this.DealButton.Text = "Deal Cards";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(120, 268);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(52, 15);
            this.BetLabel.TabIndex = 13;
            this.BetLabel.Text = "Bet Size";
            // 
            // BetSizeTextBox
            // 
            this.BetSizeTextBox.Enabled = false;
            this.BetSizeTextBox.Location = new System.Drawing.Point(100, 284);
            this.BetSizeTextBox.Name = "BetSizeTextBox";
            this.BetSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.BetSizeTextBox.TabIndex = 14;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.SplitButton);
            this.GamePanel.Controls.Add(this.DoubleButton);
            this.GamePanel.Controls.Add(this.PlayerLabel);
            this.GamePanel.Controls.Add(this.HandLabel);
            this.GamePanel.Controls.Add(this.HandCountTextBox);
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
            this.GamePanel.Location = new System.Drawing.Point(292, 117);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(440, 361);
            this.GamePanel.TabIndex = 15;
            // 
            // SplitButton
            // 
            this.SplitButton.Enabled = false;
            this.SplitButton.Location = new System.Drawing.Point(306, 194);
            this.SplitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(56, 35);
            this.SplitButton.TabIndex = 28;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // DoubleButton
            // 
            this.DoubleButton.Enabled = false;
            this.DoubleButton.Location = new System.Drawing.Point(230, 194);
            this.DoubleButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(56, 40);
            this.DoubleButton.TabIndex = 27;
            this.DoubleButton.Text = "Double Down";
            this.DoubleButton.UseVisualStyleBackColor = true;
            this.DoubleButton.Click += new System.EventHandler(this.DoubleButton_Click);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(108, 34);
            this.PlayerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(41, 15);
            this.PlayerLabel.TabIndex = 26;
            this.PlayerLabel.Text = "Player";
            // 
            // HandLabel
            // 
            this.HandLabel.AutoSize = true;
            this.HandLabel.Location = new System.Drawing.Point(270, 34);
            this.HandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HandLabel.Name = "HandLabel";
            this.HandLabel.Size = new System.Drawing.Size(37, 15);
            this.HandLabel.TabIndex = 25;
            this.HandLabel.Text = "Hand";
            // 
            // HandCountTextBox
            // 
            this.HandCountTextBox.Enabled = false;
            this.HandCountTextBox.Location = new System.Drawing.Point(266, 49);
            this.HandCountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HandCountTextBox.Name = "HandCountTextBox";
            this.HandCountTextBox.Size = new System.Drawing.Size(76, 20);
            this.HandCountTextBox.TabIndex = 24;
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Enabled = false;
            this.PlayerTextBox.Location = new System.Drawing.Point(107, 52);
            this.PlayerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.Size = new System.Drawing.Size(76, 20);
            this.PlayerTextBox.TabIndex = 23;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Enabled = false;
            this.PlayAgainButton.Location = new System.Drawing.Point(316, 276);
            this.PlayAgainButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(56, 40);
            this.PlayAgainButton.TabIndex = 22;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(187, 156);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(76, 20);
            this.ResultTextBox.TabIndex = 21;
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Location = new System.Drawing.Point(156, 194);
            this.StandButton.Margin = new System.Windows.Forms.Padding(2);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(56, 35);
            this.StandButton.TabIndex = 20;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(86, 194);
            this.HitButton.Margin = new System.Windows.Forms.Padding(2);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(56, 33);
            this.HitButton.TabIndex = 19;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // DealerHandTextBox
            // 
            this.DealerHandTextBox.Enabled = false;
            this.DealerHandTextBox.Location = new System.Drawing.Point(266, 103);
            this.DealerHandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.Size = new System.Drawing.Size(76, 20);
            this.DealerHandTextBox.TabIndex = 18;
            // 
            // PlayerHandTextBox
            // 
            this.PlayerHandTextBox.Enabled = false;
            this.PlayerHandTextBox.Location = new System.Drawing.Point(107, 103);
            this.PlayerHandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerHandTextBox.Name = "PlayerHandTextBox";
            this.PlayerHandTextBox.Size = new System.Drawing.Size(76, 20);
            this.PlayerHandTextBox.TabIndex = 17;
            // 
            // DealerHandLabel
            // 
            this.DealerHandLabel.AutoSize = true;
            this.DealerHandLabel.Location = new System.Drawing.Point(270, 89);
            this.DealerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DealerHandLabel.Name = "DealerHandLabel";
            this.DealerHandLabel.Size = new System.Drawing.Size(86, 15);
            this.DealerHandLabel.TabIndex = 16;
            this.DealerHandLabel.Text = "Dealer\'s Hand";
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Location = new System.Drawing.Point(105, 89);
            this.PlayerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(83, 15);
            this.PlayerHandLabel.TabIndex = 15;
            this.PlayerHandLabel.Text = "Player\'s Hand";
            // 
            // PlayerNumberLabel
            // 
            this.PlayerNumberLabel.AutoSize = true;
            this.PlayerNumberLabel.Location = new System.Drawing.Point(58, 305);
            this.PlayerNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerNumberLabel.Name = "PlayerNumberLabel";
            this.PlayerNumberLabel.Size = new System.Drawing.Size(104, 15);
            this.PlayerNumberLabel.TabIndex = 16;
            this.PlayerNumberLabel.Text = "How Many Hands";
            // 
            // OneHandCheckBox
            // 
            this.OneHandCheckBox.AutoSize = true;
            this.OneHandCheckBox.Checked = true;
            this.OneHandCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OneHandCheckBox.Location = new System.Drawing.Point(94, 330);
            this.OneHandCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.OneHandCheckBox.Name = "OneHandCheckBox";
            this.OneHandCheckBox.Size = new System.Drawing.Size(36, 19);
            this.OneHandCheckBox.TabIndex = 17;
            this.OneHandCheckBox.Text = "1";
            this.OneHandCheckBox.UseVisualStyleBackColor = true;
            this.OneHandCheckBox.CheckedChanged += new System.EventHandler(this.OnePlayerCheckBox_CheckedChanged);
            // 
            // TwoHandsCheckBox
            // 
            this.TwoHandsCheckBox.AutoSize = true;
            this.TwoHandsCheckBox.Enabled = false;
            this.TwoHandsCheckBox.Location = new System.Drawing.Point(94, 351);
            this.TwoHandsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.TwoHandsCheckBox.Name = "TwoHandsCheckBox";
            this.TwoHandsCheckBox.Size = new System.Drawing.Size(36, 19);
            this.TwoHandsCheckBox.TabIndex = 18;
            this.TwoHandsCheckBox.Text = "2";
            this.TwoHandsCheckBox.UseVisualStyleBackColor = true;
            this.TwoHandsCheckBox.CheckedChanged += new System.EventHandler(this.TwoPlayerCheckBox_CheckedChanged);
            // 
            // ThreeHandsCheckBox
            // 
            this.ThreeHandsCheckBox.AutoSize = true;
            this.ThreeHandsCheckBox.Enabled = false;
            this.ThreeHandsCheckBox.Location = new System.Drawing.Point(94, 372);
            this.ThreeHandsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ThreeHandsCheckBox.Name = "ThreeHandsCheckBox";
            this.ThreeHandsCheckBox.Size = new System.Drawing.Size(36, 19);
            this.ThreeHandsCheckBox.TabIndex = 19;
            this.ThreeHandsCheckBox.Text = "3";
            this.ThreeHandsCheckBox.UseVisualStyleBackColor = true;
            this.ThreeHandsCheckBox.CheckedChanged += new System.EventHandler(this.ThreePlayersCheckBox_CheckedChanged);
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 505);
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
        private System.Windows.Forms.TextBox PlayerHandTextBox;
        private System.Windows.Forms.Label DealerHandLabel;
        private System.Windows.Forms.Label PlayerHandLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label HandLabel;
        private System.Windows.Forms.TextBox HandCountTextBox;
        private System.Windows.Forms.TextBox PlayerTextBox;
        private System.Windows.Forms.Label PlayerNumberLabel;
        private System.Windows.Forms.CheckBox OneHandCheckBox;
        private System.Windows.Forms.CheckBox TwoHandsCheckBox;
        private System.Windows.Forms.CheckBox ThreeHandsCheckBox;
        private System.Windows.Forms.Button DoubleButton;
        private System.Windows.Forms.Button SplitButton;
    }
}