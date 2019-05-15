namespace ExpertChoices
{
    partial class LogAsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAsPage));
            this.LogInAsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInAsLabel
            // 
            this.LogInAsLabel.AutoSize = true;
            this.LogInAsLabel.BackColor = System.Drawing.Color.Maroon;
            this.LogInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInAsLabel.ForeColor = System.Drawing.Color.White;
            this.LogInAsLabel.Location = new System.Drawing.Point(160, 23);
            this.LogInAsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogInAsLabel.Name = "LogInAsLabel";
            this.LogInAsLabel.Size = new System.Drawing.Size(107, 24);
            this.LogInAsLabel.TabIndex = 0;
            this.LogInAsLabel.Text = "Войти как";
            // 
            // LogAsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 335);
            this.Controls.Add(this.LogInAsLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogAsPage";
            this.Text = "HowToLogInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInAsLabel;
    }
}