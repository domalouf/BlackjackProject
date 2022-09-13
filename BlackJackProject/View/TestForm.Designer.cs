
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
            this.GetMoveButton.Location = new System.Drawing.Point(501, 428);
            this.GetMoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetMoveButton.Name = "GetMoveButton";
            this.GetMoveButton.Size = new System.Drawing.Size(328, 107);
            this.GetMoveButton.TabIndex = 0;
            this.GetMoveButton.Text = "Get Move";
            this.GetMoveButton.UseVisualStyleBackColor = true;
            this.GetMoveButton.Click += new System.EventHandler(this.GetMoveButton_Click);
            // 
            // Card1TextBox
            // 
            this.Card1TextBox.Location = new System.Drawing.Point(20, 448);
            this.Card1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card1TextBox.Name = "Card1TextBox";
            this.Card1TextBox.Size = new System.Drawing.Size(132, 22);
            this.Card1TextBox.TabIndex = 1;
            // 
            // DealerCardTextBox
            // 
            this.DealerCardTextBox.Location = new System.Drawing.Point(179, 448);
            this.DealerCardTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DealerCardTextBox.Name = "DealerCardTextBox";
            this.DealerCardTextBox.Size = new System.Drawing.Size(132, 22);
            this.DealerCardTextBox.TabIndex = 2;
            // 
            // Card1Label
            // 
            this.Card1Label.AutoSize = true;
            this.Card1Label.Location = new System.Drawing.Point(16, 428);
            this.Card1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Card1Label.Name = "Card1Label";
            this.Card1Label.Size = new System.Drawing.Size(64, 16);
            this.Card1Label.TabIndex = 3;
            this.Card1Label.Text = "First Card";
            // 
            // DealerCardLabel
            // 
            this.DealerCardLabel.AutoSize = true;
            this.DealerCardLabel.Location = new System.Drawing.Point(179, 428);
            this.DealerCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DealerCardLabel.Name = "DealerCardLabel";
            this.DealerCardLabel.Size = new System.Drawing.Size(80, 16);
            this.DealerCardLabel.TabIndex = 4;
            this.DealerCardLabel.Text = "Dealer Card";
            // 
            // Card2Label
            // 
            this.Card2Label.AutoSize = true;
            this.Card2Label.Location = new System.Drawing.Point(16, 490);
            this.Card2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Card2Label.Name = "Card2Label";
            this.Card2Label.Size = new System.Drawing.Size(86, 16);
            this.Card2Label.TabIndex = 5;
            this.Card2Label.Text = "Second Card";
            // 
            // Card2TextBox
            // 
            this.Card2TextBox.Location = new System.Drawing.Point(20, 510);
            this.Card2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Card2TextBox.Name = "Card2TextBox";
            this.Card2TextBox.Size = new System.Drawing.Size(132, 22);
            this.Card2TextBox.TabIndex = 6;
            // 
            // MoveTextBox
            // 
            this.MoveTextBox.Location = new System.Drawing.Point(837, 470);
            this.MoveTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoveTextBox.Name = "MoveTextBox";
            this.MoveTextBox.Size = new System.Drawing.Size(188, 22);
            this.MoveTextBox.TabIndex = 7;
            // 
            // HitCardTextBox
            // 
            this.HitCardTextBox.Location = new System.Drawing.Point(347, 122);
            this.HitCardTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HitCardTextBox.Name = "HitCardTextBox";
            this.HitCardTextBox.Size = new System.Drawing.Size(132, 22);
            this.HitCardTextBox.TabIndex = 9;
            // 
            // HitCardButton
            // 
            this.HitCardButton.Location = new System.Drawing.Point(347, 71);
            this.HitCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HitCardButton.Name = "HitCardButton";
            this.HitCardButton.Size = new System.Drawing.Size(100, 28);
            this.HitCardButton.TabIndex = 10;
            this.HitCardButton.Text = "draw card";
            this.HitCardButton.UseVisualStyleBackColor = true;
            this.HitCardButton.Click += new System.EventHandler(this.HitCardButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(347, 166);
            this.ShuffleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(120, 28);
            this.ShuffleButton.TabIndex = 11;
            this.ShuffleButton.Text = "shuffle";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // ShoeCountLabel
            // 
            this.ShoeCountLabel.AutoSize = true;
            this.ShoeCountLabel.Location = new System.Drawing.Point(612, 83);
            this.ShoeCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShoeCountLabel.Name = "ShoeCountLabel";
            this.ShoeCountLabel.Size = new System.Drawing.Size(115, 16);
            this.ShoeCountLabel.TabIndex = 12;
            this.ShoeCountLabel.Text = "Cards Left In Shoe";
            // 
            // ShoeCountTextBox
            // 
            this.ShoeCountTextBox.Location = new System.Drawing.Point(615, 124);
            this.ShoeCountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShoeCountTextBox.Name = "ShoeCountTextBox";
            this.ShoeCountTextBox.Size = new System.Drawing.Size(127, 22);
            this.ShoeCountTextBox.TabIndex = 13;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 572);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

