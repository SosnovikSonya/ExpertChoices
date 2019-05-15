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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EnterEmailLabel = new System.Windows.Forms.Label();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.White;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.Color.Maroon;
            this.goBack.Location = new System.Drawing.Point(12, 293);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(258, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(258, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 30);
            this.textBox2.TabIndex = 2;
            // 
            // EnterEmailLabel
            // 
            this.EnterEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterEmailLabel.Location = new System.Drawing.Point(22, 107);
            this.EnterEmailLabel.Name = "EnterEmailLabel";
            this.EnterEmailLabel.Size = new System.Drawing.Size(192, 30);
            this.EnterEmailLabel.TabIndex = 3;
            this.EnterEmailLabel.Text = "Введите Email:";
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterPasswordLabel.Location = new System.Drawing.Point(22, 163);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(192, 30);
            this.EnterPasswordLabel.TabIndex = 4;
            this.EnterPasswordLabel.Text = "Введите пароль:";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.White;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.ForeColor = System.Drawing.Color.Maroon;
            this.next.Location = new System.Drawing.Point(445, 293);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 41);
            this.next.TabIndex = 5;
            this.next.Text = "ДАЛЕЕ";
            this.next.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.goBack);
            this.Name = "AuthorizePage";
            this.Text = "ОАО МяскоРай/ авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label EnterEmailLabel;
        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.Button next;
    }
}