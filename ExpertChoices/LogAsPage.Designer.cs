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
            this.buttonLoginAsAdmin = new System.Windows.Forms.Button();
            this.buttonLoginAsAnalytic = new System.Windows.Forms.Button();
            this.buttonLoginAsExpert = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInAsLabel
            // 
            this.LogInAsLabel.AutoSize = true;
            this.LogInAsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LogInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInAsLabel.ForeColor = System.Drawing.Color.Black;
            this.LogInAsLabel.Location = new System.Drawing.Point(238, 25);
            this.LogInAsLabel.Name = "LogInAsLabel";
            this.LogInAsLabel.Size = new System.Drawing.Size(139, 31);
            this.LogInAsLabel.TabIndex = 0;
            this.LogInAsLabel.Text = "Войти как";
            // 
            // buttonLoginAsAdmin
            // 
            this.buttonLoginAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginAsAdmin.Location = new System.Drawing.Point(178, 114);
            this.buttonLoginAsAdmin.Name = "buttonLoginAsAdmin";
            this.buttonLoginAsAdmin.Size = new System.Drawing.Size(259, 44);
            this.buttonLoginAsAdmin.TabIndex = 1;
            this.buttonLoginAsAdmin.Text = "Администратор";
            this.buttonLoginAsAdmin.UseVisualStyleBackColor = true;
            this.buttonLoginAsAdmin.Visible = false;
            this.buttonLoginAsAdmin.Click += new System.EventHandler(this.buttonLoginAsAdmin_Click);
            // 
            // buttonLoginAsAnalytic
            // 
            this.buttonLoginAsAnalytic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginAsAnalytic.Location = new System.Drawing.Point(178, 187);
            this.buttonLoginAsAnalytic.Name = "buttonLoginAsAnalytic";
            this.buttonLoginAsAnalytic.Size = new System.Drawing.Size(259, 44);
            this.buttonLoginAsAnalytic.TabIndex = 2;
            this.buttonLoginAsAnalytic.Text = "Аналитик";
            this.buttonLoginAsAnalytic.UseVisualStyleBackColor = true;
            this.buttonLoginAsAnalytic.Visible = false;
            this.buttonLoginAsAnalytic.Click += new System.EventHandler(this.buttonLoginAsAnalytic_Click);
            // 
            // buttonLoginAsExpert
            // 
            this.buttonLoginAsExpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginAsExpert.Location = new System.Drawing.Point(178, 263);
            this.buttonLoginAsExpert.Name = "buttonLoginAsExpert";
            this.buttonLoginAsExpert.Size = new System.Drawing.Size(259, 44);
            this.buttonLoginAsExpert.TabIndex = 3;
            this.buttonLoginAsExpert.Text = "Эксперт";
            this.buttonLoginAsExpert.UseVisualStyleBackColor = true;
            this.buttonLoginAsExpert.Visible = false;
            this.buttonLoginAsExpert.Click += new System.EventHandler(this.buttonLoginAsExpert_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(22, 350);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 5;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // LogAsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 412);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.buttonLoginAsExpert);
            this.Controls.Add(this.buttonLoginAsAnalytic);
            this.Controls.Add(this.buttonLoginAsAdmin);
            this.Controls.Add(this.LogInAsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogAsPage";
            this.Text = "ОАО МяскоРай";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInAsLabel;
        private System.Windows.Forms.Button buttonLoginAsAdmin;
        private System.Windows.Forms.Button buttonLoginAsAnalytic;
        private System.Windows.Forms.Button buttonLoginAsExpert;
        private System.Windows.Forms.Button goBack;
    }
}