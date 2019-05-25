namespace ExpertChoices
{
    partial class AuthorizePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizePage));
            this.goBack = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.EnterEmailLabel = new System.Windows.Forms.Label();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(12, 293);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(145, 86);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(287, 30);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(145, 196);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(287, 30);
            this.textBoxPassword.TabIndex = 2;
            // 
            // EnterEmailLabel
            // 
            this.EnterEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EnterEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterEmailLabel.Location = new System.Drawing.Point(206, 31);
            this.EnterEmailLabel.Name = "EnterEmailLabel";
            this.EnterEmailLabel.Size = new System.Drawing.Size(165, 30);
            this.EnterEmailLabel.TabIndex = 3;
            this.EnterEmailLabel.Text = "Введите Email:";
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterPasswordLabel.Location = new System.Drawing.Point(197, 145);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(203, 30);
            this.EnterPasswordLabel.TabIndex = 4;
            this.EnterPasswordLabel.Text = "Введите пароль:";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Maroon;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.ForeColor = System.Drawing.SystemColors.Control;
            this.next.Location = new System.Drawing.Point(445, 293);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 41);
            this.next.TabIndex = 5;
            this.next.Text = "ДАЛЕЕ";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += next_Click;
            // 
            // AuthorizePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 359);
            this.Controls.Add(this.next);
            this.Controls.Add(this.EnterPasswordLabel);
            this.Controls.Add(this.EnterEmailLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.goBack);
            this.Name = "AuthorizePage";
            this.Text = "ОАО МяскоРай/ авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label EnterEmailLabel;
        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.Button next;
    }
}