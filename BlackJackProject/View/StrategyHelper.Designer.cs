
namespace BlackJack
{
    partial class StrategyHelper
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
            this.FirstCardTextBox = new System.Windows.Forms.TextBox();
            this.SecondCardTextBox = new System.Windows.Forms.TextBox();
            this.DealerCardTextBox = new System.Windows.Forms.TextBox();
            this.FirstCardLabel = new System.Windows.Forms.Label();
            this.SecondCardLabel = new System.Windows.Forms.Label();
            this.DealerCardLabel = new System.Windows.Forms.Label();
            this.GetMoveButton = new System.Windows.Forms.Button();
            this.GetMoveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstCardTextBox
            // 
            this.FirstCardTextBox.Location = new System.Drawing.Point(72, 65);
            this.FirstCardTextBox.Name = "FirstCardTextBox";
            this.FirstCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstCardTextBox.TabIndex = 0;
            // 
            // SecondCardTextBox
            // 
            this.SecondCardTextBox.Location = new System.Drawing.Point(72, 167);
            this.SecondCardTextBox.Name = "SecondCardTextBox";
            this.SecondCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondCardTextBox.TabIndex = 1;
            // 
            // DealerCardTextBox
            // 
            this.DealerCardTextBox.Location = new System.Drawing.Point(265, 65);
            this.DealerCardTextBox.Name = "DealerCardTextBox";
            this.DealerCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.DealerCardTextBox.TabIndex = 2;
            // 
            // FirstCardLabel
            // 
            this.FirstCardLabel.AutoSize = true;
            this.FirstCardLabel.Location = new System.Drawing.Point(69, 49);
            this.FirstCardLabel.Name = "FirstCardLabel";
            this.FirstCardLabel.Size = new System.Drawing.Size(51, 13);
            this.FirstCardLabel.TabIndex = 3;
            this.FirstCardLabel.Text = "First Card";
            // 
            // SecondCardLabel
            // 
            this.SecondCardLabel.AutoSize = true;
            this.SecondCardLabel.Location = new System.Drawing.Point(72, 151);
            this.SecondCardLabel.Name = "SecondCardLabel";
            this.SecondCardLabel.Size = new System.Drawing.Size(69, 13);
            this.SecondCardLabel.TabIndex = 4;
            this.SecondCardLabel.Text = "Second Card";
            // 
            // DealerCardLabel
            // 
            this.DealerCardLabel.AutoSize = true;
            this.DealerCardLabel.Location = new System.Drawing.Point(267, 44);
            this.DealerCardLabel.Name = "DealerCardLabel";
            this.DealerCardLabel.Size = new System.Drawing.Size(63, 13);
            this.DealerCardLabel.TabIndex = 5;
            this.DealerCardLabel.Text = "Dealer Card";
            // 
            // GetMoveButton
            // 
            this.GetMoveButton.Location = new System.Drawing.Point(91, 263);
            this.GetMoveButton.Name = "GetMoveButton";
            this.GetMoveButton.Size = new System.Drawing.Size(160, 66);
            this.GetMoveButton.TabIndex = 6;
            this.GetMoveButton.Text = "Get Move";
            this.GetMoveButton.UseVisualStyleBackColor = true;
            this.GetMoveButton.Click += new System.EventHandler(this.GetMoveButton_Click);
            // 
            // GetMoveTextBox
            // 
            this.GetMoveTextBox.Location = new System.Drawing.Point(100, 364);
            this.GetMoveTextBox.Name = "GetMoveTextBox";
            this.GetMoveTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetMoveTextBox.TabIndex = 7;
            // 
            // StrategyHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetMoveTextBox);
            this.Controls.Add(this.GetMoveButton);
            this.Controls.Add(this.DealerCardLabel);
            this.Controls.Add(this.SecondCardLabel);
            this.Controls.Add(this.FirstCardLabel);
            this.Controls.Add(this.DealerCardTextBox);
            this.Controls.Add(this.SecondCardTextBox);
            this.Controls.Add(this.FirstCardTextBox);
            this.Name = "StrategyHelper";
            this.Text = "Strategy Helper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StrategyHelper_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstCardTextBox;
        private System.Windows.Forms.TextBox SecondCardTextBox;
        private System.Windows.Forms.TextBox DealerCardTextBox;
        private System.Windows.Forms.Label FirstCardLabel;
        private System.Windows.Forms.Label SecondCardLabel;
        private System.Windows.Forms.Label DealerCardLabel;
        private System.Windows.Forms.Button GetMoveButton;
        private System.Windows.Forms.TextBox GetMoveTextBox;
    }
}