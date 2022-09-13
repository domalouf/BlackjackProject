
namespace BlackJack
{
    partial class MainMenu
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
            this.HelperLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.HelperButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.TestFormLabel = new System.Windows.Forms.Label();
            this.TestFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelperLabel
            // 
            this.HelperLabel.AutoSize = true;
            this.HelperLabel.Location = new System.Drawing.Point(73, 229);
            this.HelperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelperLabel.Name = "HelperLabel";
            this.HelperLabel.Size = new System.Drawing.Size(197, 16);
            this.HelperLabel.TabIndex = 1;
            this.HelperLabel.Text = "Click Here for BlackJack Helper";
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.Location = new System.Drawing.Point(749, 229);
            this.PlayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(179, 16);
            this.PlayLabel.TabIndex = 2;
            this.PlayLabel.Text = "Click Here to Play BlackJack";
            // 
            // HelperButton
            // 
            this.HelperButton.Location = new System.Drawing.Point(97, 276);
            this.HelperButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelperButton.Name = "HelperButton";
            this.HelperButton.Size = new System.Drawing.Size(159, 28);
            this.HelperButton.TabIndex = 3;
            this.HelperButton.Text = "BlackJack Helper";
            this.HelperButton.UseVisualStyleBackColor = true;
            this.HelperButton.Click += new System.EventHandler(this.HelperButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(779, 276);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(133, 28);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // TestFormLabel
            // 
            this.TestFormLabel.AutoSize = true;
            this.TestFormLabel.Location = new System.Drawing.Point(936, 482);
            this.TestFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestFormLabel.Name = "TestFormLabel";
            this.TestFormLabel.Size = new System.Drawing.Size(97, 16);
            this.TestFormLabel.TabIndex = 5;
            this.TestFormLabel.Text = "secret test form";
            // 
            // TestFormButton
            // 
            this.TestFormButton.Location = new System.Drawing.Point(954, 502);
            this.TestFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.TestFormButton.Name = "TestFormButton";
            this.TestFormButton.Size = new System.Drawing.Size(100, 28);
            this.TestFormButton.TabIndex = 6;
            this.TestFormButton.Text = "test form";
            this.TestFormButton.UseVisualStyleBackColor = true;
            this.TestFormButton.Click += new System.EventHandler(this.TestFormButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TestFormButton);
            this.Controls.Add(this.TestFormLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.HelperButton);
            this.Controls.Add(this.PlayLabel);
            this.Controls.Add(this.HelperLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HelperLabel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Button HelperButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TestFormLabel;
        private System.Windows.Forms.Button TestFormButton;
    }
}