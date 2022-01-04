
namespace BlackJack
{
    partial class Form1
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
            this.GetMoveButton = new System.Windows.Forms.Button();
            this.Card1TextBox = new System.Windows.Forms.TextBox();
            this.DealerCardTextBox = new System.Windows.Forms.TextBox();
            this.Card1Label = new System.Windows.Forms.Label();
            this.DealerCardLabel = new System.Windows.Forms.Label();
            this.Card2Label = new System.Windows.Forms.Label();
            this.Card2TextBox = new System.Windows.Forms.TextBox();
            this.MoveTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.HitCardTextBox = new System.Windows.Forms.TextBox();
            this.HitCardButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.PlayerHandLabel = new System.Windows.Forms.Label();
            this.PlayerHandTextBox = new System.Windows.Forms.TextBox();
            this.GetHandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetMoveButton
            // 
            this.GetMoveButton.Location = new System.Drawing.Point(376, 348);
            this.GetMoveButton.Name = "GetMoveButton";
            this.GetMoveButton.Size = new System.Drawing.Size(246, 87);
            this.GetMoveButton.TabIndex = 0;
            this.GetMoveButton.Text = "Get Move";
            this.GetMoveButton.UseVisualStyleBackColor = true;
            this.GetMoveButton.Click += new System.EventHandler(this.GetMoveButton_Click);
            // 
            // Card1TextBox
            // 
            this.Card1TextBox.Location = new System.Drawing.Point(15, 364);
            this.Card1TextBox.Name = "Card1TextBox";
            this.Card1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Card1TextBox.TabIndex = 1;
            // 
            // DealerCardTextBox
            // 
            this.DealerCardTextBox.Location = new System.Drawing.Point(134, 364);
            this.DealerCardTextBox.Name = "DealerCardTextBox";
            this.DealerCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.DealerCardTextBox.TabIndex = 2;
            // 
            // Card1Label
            // 
            this.Card1Label.AutoSize = true;
            this.Card1Label.Location = new System.Drawing.Point(12, 348);
            this.Card1Label.Name = "Card1Label";
            this.Card1Label.Size = new System.Drawing.Size(51, 13);
            this.Card1Label.TabIndex = 3;
            this.Card1Label.Text = "First Card";
            // 
            // DealerCardLabel
            // 
            this.DealerCardLabel.AutoSize = true;
            this.DealerCardLabel.Location = new System.Drawing.Point(134, 348);
            this.DealerCardLabel.Name = "DealerCardLabel";
            this.DealerCardLabel.Size = new System.Drawing.Size(63, 13);
            this.DealerCardLabel.TabIndex = 4;
            this.DealerCardLabel.Text = "Dealer Card";
            // 
            // Card2Label
            // 
            this.Card2Label.AutoSize = true;
            this.Card2Label.Location = new System.Drawing.Point(12, 398);
            this.Card2Label.Name = "Card2Label";
            this.Card2Label.Size = new System.Drawing.Size(69, 13);
            this.Card2Label.TabIndex = 5;
            this.Card2Label.Text = "Second Card";
            // 
            // Card2TextBox
            // 
            this.Card2TextBox.Location = new System.Drawing.Point(15, 414);
            this.Card2TextBox.Name = "Card2TextBox";
            this.Card2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Card2TextBox.TabIndex = 6;
            // 
            // MoveTextBox
            // 
            this.MoveTextBox.Location = new System.Drawing.Point(628, 382);
            this.MoveTextBox.Name = "MoveTextBox";
            this.MoveTextBox.Size = new System.Drawing.Size(142, 20);
            this.MoveTextBox.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(41, 26);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(88, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start Session";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HitCardTextBox
            // 
            this.HitCardTextBox.Location = new System.Drawing.Point(643, 98);
            this.HitCardTextBox.Name = "HitCardTextBox";
            this.HitCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.HitCardTextBox.TabIndex = 9;
            // 
            // HitCardButton
            // 
            this.HitCardButton.Location = new System.Drawing.Point(643, 69);
            this.HitCardButton.Name = "HitCardButton";
            this.HitCardButton.Size = new System.Drawing.Size(75, 23);
            this.HitCardButton.TabIndex = 10;
            this.HitCardButton.Text = "Hit da boof";
            this.HitCardButton.UseVisualStyleBackColor = true;
            this.HitCardButton.Click += new System.EventHandler(this.HitCardButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(643, 150);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(90, 23);
            this.ShuffleButton.TabIndex = 11;
            this.ShuffleButton.Text = "shuffle da boof";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // PlayerHandLabel
            // 
            this.PlayerHandLabel.AutoSize = true;
            this.PlayerHandLabel.Location = new System.Drawing.Point(12, 79);
            this.PlayerHandLabel.Name = "PlayerHandLabel";
            this.PlayerHandLabel.Size = new System.Drawing.Size(33, 13);
            this.PlayerHandLabel.TabIndex = 12;
            this.PlayerHandLabel.Text = "Hand";
            // 
            // PlayerHandTextBox
            // 
            this.PlayerHandTextBox.Location = new System.Drawing.Point(15, 96);
            this.PlayerHandTextBox.Name = "PlayerHandTextBox";
            this.PlayerHandTextBox.Size = new System.Drawing.Size(227, 20);
            this.PlayerHandTextBox.TabIndex = 13;
            // 
            // GetHandButton
            // 
            this.GetHandButton.Location = new System.Drawing.Point(15, 150);
            this.GetHandButton.Name = "GetHandButton";
            this.GetHandButton.Size = new System.Drawing.Size(140, 23);
            this.GetHandButton.TabIndex = 14;
            this.GetHandButton.Text = "Get New Hand";
            this.GetHandButton.UseVisualStyleBackColor = true;
            this.GetHandButton.Click += new System.EventHandler(this.GetHandButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetHandButton);
            this.Controls.Add(this.PlayerHandTextBox);
            this.Controls.Add(this.PlayerHandLabel);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.HitCardButton);
            this.Controls.Add(this.HitCardTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MoveTextBox);
            this.Controls.Add(this.Card2TextBox);
            this.Controls.Add(this.Card2Label);
            this.Controls.Add(this.DealerCardLabel);
            this.Controls.Add(this.Card1Label);
            this.Controls.Add(this.DealerCardTextBox);
            this.Controls.Add(this.Card1TextBox);
            this.Controls.Add(this.GetMoveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetMoveButton;
        private System.Windows.Forms.TextBox Card1TextBox;
        private System.Windows.Forms.TextBox DealerCardTextBox;
        private System.Windows.Forms.Label Card1Label;
        private System.Windows.Forms.Label DealerCardLabel;
        private System.Windows.Forms.Label Card2Label;
        private System.Windows.Forms.TextBox Card2TextBox;
        private System.Windows.Forms.TextBox MoveTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox HitCardTextBox;
        private System.Windows.Forms.Button HitCardButton;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Label PlayerHandLabel;
        private System.Windows.Forms.TextBox PlayerHandTextBox;
        private System.Windows.Forms.Button GetHandButton;
    }
}

