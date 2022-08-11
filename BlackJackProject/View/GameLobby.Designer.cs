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
            this.cashierLabel.Location = new System.Drawing.Point(111, 68);
            this.cashierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(53, 16);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Cashier";
            // 
            // buyChipsLabel
            // 
            this.buyChipsLabel.AutoSize = true;
            this.buyChipsLabel.Location = new System.Drawing.Point(13, 114);
            this.buyChipsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyChipsLabel.Name = "buyChipsLabel";
            this.buyChipsLabel.Size = new System.Drawing.Size(238, 16);
            this.buyChipsLabel.TabIndex = 2;
            this.buyChipsLabel.Text = "How many chips would you like to buy?";
            // 
            // buyChipsTextBox
            // 
            this.buyChipsTextBox.Location = new System.Drawing.Point(19, 159);
            this.buyChipsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyChipsTextBox.Name = "buyChipsTextBox";
            this.buyChipsTextBox.Size = new System.Drawing.Size(145, 22);
            this.buyChipsTextBox.TabIndex = 3;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(200, 159);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.playerInfoLabel.Location = new System.Drawing.Point(843, 118);
            this.playerInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(70, 16);
            this.playerInfoLabel.TabIndex = 5;
            this.playerInfoLabel.Text = "Player Info";
            // 
            // chipCountLabel
            // 
            this.chipCountLabel.AutoSize = true;
            this.chipCountLabel.Location = new System.Drawing.Point(812, 159);
            this.chipCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chipCountLabel.Name = "chipCountLabel";
            this.chipCountLabel.Size = new System.Drawing.Size(74, 16);
            this.chipCountLabel.TabIndex = 6;
            this.chipCountLabel.Text = "Chip Count:";
            // 
            // chipCountTextBox
            // 
            this.chipCountTextBox.Enabled = false;
            this.chipCountTextBox.Location = new System.Drawing.Point(903, 155);
            this.chipCountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chipCountTextBox.Name = "chipCountTextBox";
            this.chipCountTextBox.Size = new System.Drawing.Size(132, 22);
            this.chipCountTextBox.TabIndex = 7;
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(589, 361);
            this.DealButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.BetLabel.Location = new System.Drawing.Point(432, 341);
            this.BetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(56, 16);
            this.BetLabel.TabIndex = 13;
            this.BetLabel.Text = "Bet Size";
            // 
            // BetSizeTextBox
            // 
            this.BetSizeTextBox.Location = new System.Drawing.Point(405, 361);
            this.BetSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BetSizeTextBox.Name = "BetSizeTextBox";
            this.BetSizeTextBox.Size = new System.Drawing.Size(132, 22);
            this.BetSizeTextBox.TabIndex = 14;
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BetSizeTextBox);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.chipCountTextBox);
            this.Controls.Add(this.chipCountLabel);
            this.Controls.Add(this.playerInfoLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.buyChipsTextBox);
            this.Controls.Add(this.buyChipsLabel);
            this.Controls.Add(this.cashierLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameLobby";
            this.Text = "BlackJack Lobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameLobby_Load);
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
    }
}