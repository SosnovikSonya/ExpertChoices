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
            this.LogInAsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LogInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInAsLabel.ForeColor = System.Drawing.Color.Black;
            this.LogInAsLabel.Location = new System.Drawing.Point(238, 25);
            this.LogInAsLabel.Name = "LogInAsLabel";
            this.LogInAsLabel.Size = new System.Drawing.Size(128, 29);
            this.LogInAsLabel.TabIndex = 0;
            this.LogInAsLabel.Text = "Войти как";
            // 
            // LogAsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 412);
            this.Controls.Add(this.LogInAsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogAsPage";
            this.Text = "ОАО МяскоРай";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInAsLabel;
    }
}