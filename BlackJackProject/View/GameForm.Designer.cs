namespace BlackJack
{
    partial class GameForm
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
            this.Hit17Label = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.PlayerHandTextBox = new System.Windows.Forms.TextBox();
            this.DealerHandTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hit17Label
            // 
            this.Hit17Label.AutoSize = true;
            this.Hit17Label.Location = new System.Drawing.Point(347, 9);
            this.Hit17Label.Name = "Hit17Label";
            this.Hit17Label.Size = new System.Drawing.Size(96, 13);
            this.Hit17Label.TabIndex = 0;
            this.Hit17Label.Text = "Dealer Hits Soft 17";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(358, 267);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(72, 13);
            this.PlayerLabel.TabIndex = 8;
            this.PlayerLabel.Text = "Player\'s Hand";
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Location = new System.Drawing.Point(358, 46);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(74, 13);
            this.DealerLabel.TabIndex = 9;
            this.DealerLabel.Text = "Dealer\'s Hand";
            // 
            // HitButton
            // 
            this.HitButton.Location = new System.Drawing.Point(271, 402);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(75, 23);
            this.HitButton.TabIndex = 10;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            // 
            // StandButton
            // 
            this.StandButton.Location = new System.Drawing.Point(432, 402);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 23);
            this.StandButton.TabIndex = 11;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            // 
            // PlayerHandTextBox
            // 
            this.PlayerHandTextBox.Enabled = false;
            this.PlayerHandTextBox.Location = new System.Drawing.Point(350, 316);
            this.PlayerHandTextBox.Name = "PlayerHandTextBox";
            this.PlayerHandTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerHandTextBox.TabIndex = 12;
            // 
            // DealerHandTextBox
            // 
            this.DealerHandTextBox.Enabled = false;
            this.DealerHandTextBox.Location = new System.Drawing.Point(350, 102);
            this.DealerHandTextBox.Name = "DealerHandTextBox";
            this.DealerHandTextBox.Size = new System.Drawing.Size(100, 20);
            this.DealerHandTextBox.TabIndex = 13;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DealerHandTextBox);
            this.Controls.Add(this.PlayerHandTextBox);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.Hit17Label);
            this.Controls.Add(this.DealerLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Name = "GameForm";
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hit17Label;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.TextBox PlayerHandTextBox;
        private System.Windows.Forms.TextBox DealerHandTextBox;
    }
}