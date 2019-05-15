namespace ExpertChoices
{
    partial class HowToLogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToLogInPage));
            this.LogInAsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInAsLabel
            // 
            this.LogInAsLabel.AutoSize = true;
            this.LogInAsLabel.BackColor = System.Drawing.Color.Maroon;
            this.LogInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInAsLabel.ForeColor = System.Drawing.Color.White;
            this.LogInAsLabel.Location = new System.Drawing.Point(36, 9);
            this.LogInAsLabel.Name = "LogInAsLabel";
            this.LogInAsLabel.Size = new System.Drawing.Size(502, 29);
            this.LogInAsLabel.TabIndex = 0;
            this.LogInAsLabel.Text = "ПРОДОЛЖИТЬ РАБОТУ В КАЧЕСТВЕ ...";
            // 
            // HowToLogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 412);
            this.Controls.Add(this.LogInAsLabel);
            this.Name = "HowToLogInPage";
            this.Text = "HowToLogInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInAsLabel;
    }
}