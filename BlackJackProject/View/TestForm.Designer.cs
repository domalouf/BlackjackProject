
namespace BlackJack
{
    partial class TestForm
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
            this.HitCardTextBox = new System.Windows.Forms.TextBox();
            this.HitCardButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.ShoeCountLabel = new System.Windows.Forms.Label();
            this.ShoeCountTextBox = new System.Windows.Forms.TextBox();
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
            // HitCardTextBox
            // 
            this.HitCardTextBox.Location = new System.Drawing.Point(260, 99);
            this.HitCardTextBox.Name = "HitCardTextBox";
            this.HitCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.HitCardTextBox.TabIndex = 9;
            // 
            // HitCardButton
            // 
            this.HitCardButton.Location = new System.Drawing.Point(260, 58);
            this.HitCardButton.Name = "HitCardButton";
            this.HitCardButton.Size = new System.Drawing.Size(75, 23);
            this.HitCardButton.TabIndex = 10;
            this.HitCardButton.Text = "Hit da boof";
            this.HitCardButton.UseVisualStyleBackColor = true;
            this.HitCardButton.Click += new System.EventHandler(this.HitCardButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(260, 135);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(90, 23);
            this.ShuffleButton.TabIndex = 11;
            this.ShuffleButton.Text = "shuffle da boof";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // ShoeCountLabel
            // 
            this.ShoeCountLabel.AutoSize = true;
            this.ShoeCountLabel.Location = new System.Drawing.Point(454, 68);
            this.ShoeCountLabel.Name = "ShoeCountLabel";
            this.ShoeCountLabel.Size = new System.Drawing.Size(95, 13);
            this.ShoeCountLabel.TabIndex = 12;
            this.ShoeCountLabel.Text = "Cards Left In Shoe";
            // 
            // ShoeCountTextBox
            // 
            this.ShoeCountTextBox.Location = new System.Drawing.Point(461, 101);
            this.ShoeCountTextBox.Name = "ShoeCountTextBox";
            this.ShoeCountTextBox.Size = new System.Drawing.Size(96, 20);
            this.ShoeCountTextBox.TabIndex = 13;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 465);
            this.Controls.Add(this.ShoeCountTextBox);
            this.Controls.Add(this.ShoeCountLabel);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.HitCardButton);
            this.Controls.Add(this.HitCardTextBox);
            this.Controls.Add(this.MoveTextBox);
            this.Controls.Add(this.Card2TextBox);
            this.Controls.Add(this.Card2Label);
            this.Controls.Add(this.DealerCardLabel);
            this.Controls.Add(this.Card1Label);
            this.Controls.Add(this.DealerCardTextBox);
            this.Controls.Add(this.Card1TextBox);
            this.Controls.Add(this.GetMoveButton);
            this.Name = "TestForm";
            this.Text = "Test Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
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
        private System.Windows.Forms.TextBox HitCardTextBox;
        private System.Windows.Forms.Button HitCardButton;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Label ShoeCountLabel;
        private System.Windows.Forms.TextBox ShoeCountTextBox;
    }
}

