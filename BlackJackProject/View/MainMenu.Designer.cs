
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.HelperLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.HelperButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.TestFormLabel = new System.Windows.Forms.Label();
            this.TestFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(242, 46);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(287, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Motherfuckin Blackjack Program Fuckface";
            // 
            // HelperLabel
            // 
            this.HelperLabel.AutoSize = true;
            this.HelperLabel.Location = new System.Drawing.Point(55, 186);
            this.HelperLabel.Name = "HelperLabel";
            this.HelperLabel.Size = new System.Drawing.Size(158, 13);
            this.HelperLabel.TabIndex = 1;
            this.HelperLabel.Text = "Click Here for BlackJack Helper";
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.Location = new System.Drawing.Point(562, 186);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(144, 13);
            this.PlayLabel.TabIndex = 2;
            this.PlayLabel.Text = "Click Here to Play BlackJack";
            // 
            // HelperButton
            // 
            this.HelperButton.Location = new System.Drawing.Point(73, 224);
            this.HelperButton.Name = "HelperButton";
            this.HelperButton.Size = new System.Drawing.Size(119, 23);
            this.HelperButton.TabIndex = 3;
            this.HelperButton.Text = "BlackJack Helper";
            this.HelperButton.UseVisualStyleBackColor = true;
            this.HelperButton.Click += new System.EventHandler(this.HelperButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(584, 224);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 23);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play BlackJack";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // TestFormLabel
            // 
            this.TestFormLabel.AutoSize = true;
            this.TestFormLabel.Location = new System.Drawing.Point(702, 392);
            this.TestFormLabel.Name = "TestFormLabel";
            this.TestFormLabel.Size = new System.Drawing.Size(69, 13);
            this.TestFormLabel.TabIndex = 5;
            this.TestFormLabel.Text = "Woah Kenny";
            // 
            // TestFormButton
            // 
            this.TestFormButton.Location = new System.Drawing.Point(696, 415);
            this.TestFormButton.Name = "TestFormButton";
            this.TestFormButton.Size = new System.Drawing.Size(75, 23);
            this.TestFormButton.TabIndex = 6;
            this.TestFormButton.Text = "Penis Butt";
            this.TestFormButton.UseVisualStyleBackColor = true;
            this.TestFormButton.Click += new System.EventHandler(this.TestFormButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestFormButton);
            this.Controls.Add(this.TestFormLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.HelperButton);
            this.Controls.Add(this.PlayLabel);
            this.Controls.Add(this.HelperLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label HelperLabel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Button HelperButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label TestFormLabel;
        private System.Windows.Forms.Button TestFormButton;
    }
}