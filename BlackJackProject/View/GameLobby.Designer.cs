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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.StandButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.DealerHandTextBox = new System.Windows.Forms.TextBox();
            this.PlayerHandTextBox = new System.Windows.Forms.TextBox();
            this.DealerHandLabel = new System.Windows.Forms.Label();
            this.PlayerHandLabel = new System.Windows.Forms.Label();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(322, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(153, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Casino Homes";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Location = new System.Drawing.Point(74, 7);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(42, 13);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Cashier";
            // 
            // buyChipsLabel
            // 
            this.buyChipsLabel.AutoSize = true;
            this.buyChipsLabel.Location = new System.Drawing.Point(11, 46);
            this.buyChipsLabel.Name = "buyChipsLabel";
            this.buyChipsLabel.Size = new System.Drawing.Size(193, 13);
            this.buyChipsLabel.TabIndex = 2;
            this.buyChipsLabel.Text = "How many chips would you like to buy?";
            // 
            // buyChipsTextBox
            // 
            this.buyChipsTextBox.Location = new System.Drawing.Point(16, 83);
            this.buyChipsTextBox.Name = "buyChipsTextBox";
            this.buyChipsTextBox.Size = new System.Drawing.Size(110, 20);
            this.buyChipsTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(152, 83);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(52, 19);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Location = new System.Drawing.Point(632, 24);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(57, 13);
            this.playerInfoLabel.TabIndex = 5;
            this.playerInfoLabel.Text = "Player Info";
            // 
            // chipCountLabel
            // 
            this.chipCountLabel.AutoSize = true;
            this.chipCountLabel.Location = new System.Drawing.Point(608, 57);
            this.chipCountLabel.Name = "chipCountLabel";
            this.chipCountLabel.Size = new System.Drawing.Size(62, 13);
            this.chipCountLabel.TabIndex = 6;
            this.chipCountLabel.Text = "Chip Count:";
            // 
            // chipCountTextBox
            // 
            this.chipCountTextBox.Enabled = false;
            this.chipCountTextBox.Location = new System.Drawing.Point(676, 54);
            this.chipCountTextBox.Name = "chipCountTextBox";
            this.chipCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.chipCountTextBox.TabIndex = 7;
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(194, 258);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 23);
            this.DealButton.TabIndex = 12;
            this.DealButton.Text = "Deal Cards";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(76, 242);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(46, 13);
            this.BetLabel.TabIndex = 13;
            this.BetLabel.Text = "Bet Size";
            // 
            // BetSizeTextBox
            // 
            this.BetSizeTextBox.Location = new System.Drawing.Point(56, 258);
            this.BetSizeTextBox.Name = "BetSizeTextBox";
            this.BetSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.BetSizeTextBox.TabIndex = 14;
            // 
            // GamePanel
            // 
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
            this.GamePanel.Location = new System.Drawing.Point(256, 83);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(343, 310);
            this.GamePanel.TabIndex = 15;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(143, 130);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(76, 20);
            this.ResultTextBox.TabIndex = 21;
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Location = new System.Drawing.Point(112, 168);
            this.StandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(56, 19);
            this.StandButton.TabIndex = 20;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(42, 168);
            this.HitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(56, 19);
            this.HitButton.TabIndex = 19;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // DealerHandTextBox
            // 
            this.DealerHandTextBox.Enabled = false;
            this.DealerHandTextBox.Location = new System.Drawing.Point(222, 77);
            this.DealerHandTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.Size = new System.Drawing.Size(76, 20);
            this.DealerHandTextBox.TabIndex = 18;
            // 
            // PlayerHandTextBox
            // 
            this.PlayerHandTextBox.Enabled = false;
            this.PlayerHandTextBox.Location = new System.Drawing.Point(63, 77);
            this.PlayerHandTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayerHandTextBox.Name = "PlayerHandTextBox";
            this.PlayerHandTextBox.Size = new System.Drawing.Size(76, 20);
            this.PlayerHandTextBox.TabIndex = 17;
            // 
            // DealerHandLabel
            // 
            this.DealerHandLabel.AutoSize = true;
            this.DealerHandLabel.Location = new System.Drawing.Point(226, 32);
            this.DealerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DealerHandLabel.Name = "DealerHandLabel";
            this.DealerHandLabel.Size = new System.Drawing.Size(74, 13);
            this.DealerHandLabel.TabIndex = 16;
            this.DealerHandLabel.Text = "Dealer\'s Hand";
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Location = new System.Drawing.Point(61, 32);
            this.PlayerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(72, 13);
            this.PlayerHandLabel.TabIndex = 15;
            this.PlayerHandLabel.Text = "Player\'s Hand";
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}