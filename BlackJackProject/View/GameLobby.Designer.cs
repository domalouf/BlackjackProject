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
            this.BuyButton = new System.Windows.Forms.Button();
            this.playerInfoLabel = new System.Windows.Forms.Label();
            this.chipCountLabel = new System.Windows.Forms.Label();
            this.chipCountTextBox = new System.Windows.Forms.TextBox();
            this.DealButton = new System.Windows.Forms.Button();
            this.BetLabel = new System.Windows.Forms.Label();
            this.BetSizeTextBox = new System.Windows.Forms.TextBox();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.Bet5TextBox = new System.Windows.Forms.TextBox();
            this.Bet4TextBox = new System.Windows.Forms.TextBox();
            this.Bet3TextBox = new System.Windows.Forms.TextBox();
            this.Bet2TextBox = new System.Windows.Forms.TextBox();
            this.Bet1TextBox = new System.Windows.Forms.TextBox();
            this.PlayerBetsLabel = new System.Windows.Forms.Label();
            this.Hand5TextBox = new System.Windows.Forms.TextBox();
            this.Hand4TextBox = new System.Windows.Forms.TextBox();
            this.Hand3TextBox = new System.Windows.Forms.TextBox();
            this.Hand2TextBox = new System.Windows.Forms.TextBox();
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
            this.OneHandRadioButton = new System.Windows.Forms.RadioButton();
            this.TwoHandsRadioButton = new System.Windows.Forms.RadioButton();
            this.ThreeHandsRadioButton = new System.Windows.Forms.RadioButton();
            this.HandsNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runningCountLabel = new System.Windows.Forms.Label();
            this.RunningCountTextBox = new System.Windows.Forms.TextBox();
            this.GamePanel.SuspendLayout();
            this.HandsNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(358, 20);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(153, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Casino Homes";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Location = new System.Drawing.Point(110, 18);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(42, 13);
            this.cashierLabel.TabIndex = 1;
            this.cashierLabel.Text = "Cashier";
            // 
            // buyChipsLabel
            // 
            this.buyChipsLabel.AutoSize = true;
            this.buyChipsLabel.Location = new System.Drawing.Point(47, 57);
            this.buyChipsLabel.Name = "buyChipsLabel";
            this.buyChipsLabel.Size = new System.Drawing.Size(193, 13);
            this.buyChipsLabel.TabIndex = 2;
            this.buyChipsLabel.Text = "How many chips would you like to buy?";
            // 
            // buyChipsTextBox
            // 
            this.buyChipsTextBox.Location = new System.Drawing.Point(50, 84);
            this.buyChipsTextBox.Name = "buyChipsTextBox";
            this.buyChipsTextBox.Size = new System.Drawing.Size(110, 20);
            this.buyChipsTextBox.TabIndex = 3;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(186, 84);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(52, 23);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Location = new System.Drawing.Point(668, 35);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(57, 13);
            this.playerInfoLabel.TabIndex = 5;
            this.playerInfoLabel.Text = "Player Info";
            // 
            // chipCountLabel
            // 
            this.chipCountLabel.AutoSize = true;
            this.chipCountLabel.Location = new System.Drawing.Point(646, 72);
            this.chipCountLabel.Name = "chipCountLabel";
            this.chipCountLabel.Size = new System.Drawing.Size(62, 13);
            this.chipCountLabel.TabIndex = 6;
            this.chipCountLabel.Text = "Chip Count:";
            // 
            // chipCountTextBox
            // 
            this.chipCountTextBox.Enabled = false;
            this.chipCountTextBox.Location = new System.Drawing.Point(714, 69);
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
            this.BetLabel.Size = new System.Drawing.Size(46, 13);
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
            this.GamePanel.Location = new System.Drawing.Point(186, 132);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(440, 329);
            this.GamePanel.TabIndex = 15;
            // 
            // Bet5TextBox
            // 
            this.Bet5TextBox.Enabled = false;
            this.Bet5TextBox.Location = new System.Drawing.Point(333, 133);
            this.Bet5TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Bet5TextBox.Name = "Bet5TextBox";
            this.Bet5TextBox.Size = new System.Drawing.Size(76, 20);
            this.Bet5TextBox.TabIndex = 38;
            // 
            // Bet4TextBox
            // 
            this.Bet4TextBox.Enabled = false;
            this.Bet4TextBox.Location = new System.Drawing.Point(254, 133);
            this.Bet4TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Bet4TextBox.Name = "Bet4TextBox";
            this.Bet4TextBox.Size = new System.Drawing.Size(76, 20);
            this.Bet4TextBox.TabIndex = 37;
            // 
            // Bet3TextBox
            // 
            this.Bet3TextBox.Enabled = false;
            this.Bet3TextBox.Location = new System.Drawing.Point(174, 133);
            this.Bet3TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Bet3TextBox.Name = "Bet3TextBox";
            this.Bet3TextBox.Size = new System.Drawing.Size(76, 20);
            this.Bet3TextBox.TabIndex = 36;
            // 
            // Bet2TextBox
            // 
            this.Bet2TextBox.Enabled = false;
            this.Bet2TextBox.Location = new System.Drawing.Point(94, 133);
            this.Bet2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Bet2TextBox.Name = "Bet2TextBox";
            this.Bet2TextBox.Size = new System.Drawing.Size(76, 20);
            this.Bet2TextBox.TabIndex = 35;
            // 
            // Bet1TextBox
            // 
            this.Bet1TextBox.Enabled = false;
            this.Bet1TextBox.Location = new System.Drawing.Point(12, 133);
            this.Bet1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Bet1TextBox.Name = "Bet1TextBox";
            this.Bet1TextBox.Size = new System.Drawing.Size(76, 20);
            this.Bet1TextBox.TabIndex = 34;
            // 
            // PlayerBetsLabel
            // 
            this.PlayerBetsLabel.AutoSize = true;
            this.PlayerBetsLabel.Location = new System.Drawing.Point(16, 118);
            this.PlayerBetsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerBetsLabel.Name = "PlayerBetsLabel";
            this.PlayerBetsLabel.Size = new System.Drawing.Size(67, 13);
            this.PlayerBetsLabel.TabIndex = 33;
            this.PlayerBetsLabel.Text = "Player\'s Bets";
            // 
            // Hand5TextBox
            // 
            this.Hand5TextBox.Enabled = false;
            this.Hand5TextBox.Location = new System.Drawing.Point(333, 81);
            this.Hand5TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Hand5TextBox.Name = "Hand5TextBox";
            this.Hand5TextBox.Size = new System.Drawing.Size(76, 20);
            this.Hand5TextBox.TabIndex = 32;
            // 
            // Hand4TextBox
            // 
            this.Hand4TextBox.Enabled = false;
            this.Hand4TextBox.Location = new System.Drawing.Point(254, 81);
            this.Hand4TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Hand4TextBox.Name = "Hand4TextBox";
            this.Hand4TextBox.Size = new System.Drawing.Size(76, 20);
            this.Hand4TextBox.TabIndex = 31;
            // 
            // Hand3TextBox
            // 
            this.Hand3TextBox.Enabled = false;
            this.Hand3TextBox.Location = new System.Drawing.Point(174, 81);
            this.Hand3TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Hand3TextBox.Name = "Hand3TextBox";
            this.Hand3TextBox.Size = new System.Drawing.Size(76, 20);
            this.Hand3TextBox.TabIndex = 30;
            // 
            // Hand2TextBox
            // 
            this.Hand2TextBox.Enabled = false;
            this.Hand2TextBox.Location = new System.Drawing.Point(94, 81);
            this.Hand2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Hand2TextBox.Name = "Hand2TextBox";
            this.Hand2TextBox.Size = new System.Drawing.Size(76, 20);
            this.Hand2TextBox.TabIndex = 29;
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
            // HandLabel
            // 
            this.HandLabel.AutoSize = true;
            this.HandLabel.Location = new System.Drawing.Point(16, 7);
            this.HandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HandLabel.Name = "HandLabel";
            this.HandLabel.Size = new System.Drawing.Size(70, 13);
            this.HandLabel.TabIndex = 25;
            this.HandLabel.Text = "Current Hand";
            // 
            // CurrentHandTextBox
            // 
            this.CurrentHandTextBox.Enabled = false;
            this.CurrentHandTextBox.Location = new System.Drawing.Point(12, 22);
            this.CurrentHandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentHandTextBox.Name = "CurrentHandTextBox";
            this.CurrentHandTextBox.Size = new System.Drawing.Size(76, 20);
            this.CurrentHandTextBox.TabIndex = 24;
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
            this.ResultTextBox.Location = new System.Drawing.Point(185, 173);
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
            this.DealerHandTextBox.Location = new System.Drawing.Point(188, 21);
            this.DealerHandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.Size = new System.Drawing.Size(76, 20);
            this.DealerHandTextBox.TabIndex = 18;
            // 
            // Hand1TextBox
            // 
            this.Hand1TextBox.Enabled = false;
            this.Hand1TextBox.Location = new System.Drawing.Point(12, 81);
            this.Hand1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Hand1TextBox.Name = "Hand1TextBox";
            this.Hand1TextBox.Size = new System.Drawing.Size(76, 20);
            this.Hand1TextBox.TabIndex = 17;
            // 
            // DealerHandLabel
            // 
            this.DealerHandLabel.AutoSize = true;
            this.DealerHandLabel.Location = new System.Drawing.Point(190, 7);
            this.DealerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DealerHandLabel.Name = "DealerHandLabel";
            this.DealerHandLabel.Size = new System.Drawing.Size(74, 13);
            this.DealerHandLabel.TabIndex = 16;
            this.DealerHandLabel.Text = "Dealer\'s Hand";
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Location = new System.Drawing.Point(13, 67);
            this.PlayerHandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(77, 13);
            this.PlayerHandLabel.TabIndex = 15;
            this.PlayerHandLabel.Text = "Player\'s Hands";
            // 
            // OneHandRadioButton
            // 
            this.OneHandRadioButton.AutoSize = true;
            this.OneHandRadioButton.Checked = true;
            this.OneHandRadioButton.Location = new System.Drawing.Point(25, 33);
            this.OneHandRadioButton.Name = "OneHandRadioButton";
            this.OneHandRadioButton.Size = new System.Drawing.Size(31, 17);
            this.OneHandRadioButton.TabIndex = 20;
            this.OneHandRadioButton.TabStop = true;
            this.OneHandRadioButton.Text = "1";
            this.OneHandRadioButton.UseVisualStyleBackColor = true;
            // 
            // TwoHandsRadioButton
            // 
            this.TwoHandsRadioButton.AutoSize = true;
            this.TwoHandsRadioButton.Location = new System.Drawing.Point(25, 56);
            this.TwoHandsRadioButton.Name = "TwoHandsRadioButton";
            this.TwoHandsRadioButton.Size = new System.Drawing.Size(31, 17);
            this.TwoHandsRadioButton.TabIndex = 21;
            this.TwoHandsRadioButton.Text = "2";
            this.TwoHandsRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThreeHandsRadioButton
            // 
            this.ThreeHandsRadioButton.AutoSize = true;
            this.ThreeHandsRadioButton.Location = new System.Drawing.Point(25, 79);
            this.ThreeHandsRadioButton.Name = "ThreeHandsRadioButton";
            this.ThreeHandsRadioButton.Size = new System.Drawing.Size(31, 17);
            this.ThreeHandsRadioButton.TabIndex = 22;
            this.ThreeHandsRadioButton.Text = "3";
            this.ThreeHandsRadioButton.UseVisualStyleBackColor = true;
            // 
            // HandsNumberGroupBox
            // 
            this.HandsNumberGroupBox.Controls.Add(this.OneHandRadioButton);
            this.HandsNumberGroupBox.Controls.Add(this.ThreeHandsRadioButton);
            this.HandsNumberGroupBox.Controls.Add(this.TwoHandsRadioButton);
            this.HandsNumberGroupBox.Location = new System.Drawing.Point(66, 291);
            this.HandsNumberGroupBox.Name = "HandsNumberGroupBox";
            this.HandsNumberGroupBox.Size = new System.Drawing.Size(112, 100);
            this.HandsNumberGroupBox.TabIndex = 23;
            this.HandsNumberGroupBox.TabStop = false;
            this.HandsNumberGroupBox.Text = "How Many Hands?";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // runningCountLabel
            // 
            this.runningCountLabel.AutoSize = true;
            this.runningCountLabel.Location = new System.Drawing.Point(646, 132);
            this.runningCountLabel.Name = "runningCountLabel";
            this.runningCountLabel.Size = new System.Drawing.Size(81, 13);
            this.runningCountLabel.TabIndex = 24;
            this.runningCountLabel.Text = "Running Count:";
            // 
            // RunningCountTextBox
            // 
            this.RunningCountTextBox.Enabled = false;
            this.RunningCountTextBox.Location = new System.Drawing.Point(733, 129);
            this.RunningCountTextBox.Name = "RunningCountTextBox";
            this.RunningCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.RunningCountTextBox.TabIndex = 25;
            // 
            // GameLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 505);
            this.Controls.Add(this.RunningCountTextBox);
            this.Controls.Add(this.runningCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandsNumberGroupBox);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.chipCountTextBox);
            this.Controls.Add(this.chipCountLabel);
            this.Controls.Add(this.playerInfoLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.buyChipsTextBox);
            this.Controls.Add(this.buyChipsLabel);
            this.Controls.Add(this.cashierLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "GameLobby";
            this.Text = "BlackJack Lobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.HandsNumberGroupBox.ResumeLayout(false);
            this.HandsNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.Label buyChipsLabel;
        private System.Windows.Forms.TextBox buyChipsTextBox;
        private System.Windows.Forms.Button BuyButton;
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
        private System.Windows.Forms.RadioButton OneHandRadioButton;
        private System.Windows.Forms.RadioButton TwoHandsRadioButton;
        private System.Windows.Forms.RadioButton ThreeHandsRadioButton;
        private System.Windows.Forms.GroupBox HandsNumberGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label runningCountLabel;
        private System.Windows.Forms.TextBox RunningCountTextBox;
    }
}