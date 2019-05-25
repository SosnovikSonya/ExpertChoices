namespace ExpertChoices
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.buttonListUnapprovedUsers = new System.Windows.Forms.Button();
            this.buttonDeleteUsers = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListUnapprovedUsers
            // 
            this.buttonListUnapprovedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonListUnapprovedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListUnapprovedUsers.Location = new System.Drawing.Point(74, 67);
            this.buttonListUnapprovedUsers.Name = "buttonListUnapprovedUsers";
            this.buttonListUnapprovedUsers.Size = new System.Drawing.Size(574, 55);
            this.buttonListUnapprovedUsers.TabIndex = 0;
            this.buttonListUnapprovedUsers.Text = "СПИСОК ПОЛЬЗОВАТЕЛЕЙ ДЛЯ ОДОБРЕНИЯ";
            this.buttonListUnapprovedUsers.UseVisualStyleBackColor = false;
            this.buttonListUnapprovedUsers.Click += new System.EventHandler(this.buttonListUnapprovedUsers_Click);
            // 
            // buttonDeleteUsers
            // 
            this.buttonDeleteUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDeleteUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUsers.Location = new System.Drawing.Point(74, 199);
            this.buttonDeleteUsers.Name = "buttonDeleteUsers";
            this.buttonDeleteUsers.Size = new System.Drawing.Size(574, 52);
            this.buttonDeleteUsers.TabIndex = 1;
            this.buttonDeleteUsers.Text = "УДАЛИТЬ ПОЛЬЗОВАТЕЛЕЙ";
            this.buttonDeleteUsers.UseVisualStyleBackColor = false;
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(57, 357);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(691, 431);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.buttonDeleteUsers);
            this.Controls.Add(this.buttonListUnapprovedUsers);
            this.Name = "AdminPage";
            this.Text = "ОАО МяскоРай";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListUnapprovedUsers;
        private System.Windows.Forms.Button buttonDeleteUsers;
        private System.Windows.Forms.Button goBack;
    }
}