namespace ExpertChoices
{
    partial class ApproveUsersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveUsersPage));
            this.goBack = new System.Windows.Forms.Button();
            this.ListPendingUsersLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // ListPendingUsersLabel
            // 
            this.ListPendingUsersLabel.AutoSize = true;
            this.ListPendingUsersLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListPendingUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListPendingUsersLabel.ForeColor = System.Drawing.Color.Black;
            this.ListPendingUsersLabel.Location = new System.Drawing.Point(60, 35);
            this.ListPendingUsersLabel.Name = "ListPendingUsersLabel";
            this.ListPendingUsersLabel.Size = new System.Drawing.Size(480, 31);
            this.ListPendingUsersLabel.TabIndex = 5;
            this.ListPendingUsersLabel.Text = "Список пользователей к одобрению:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Email,
            this.FirstName,
            this.LastName,
            this.Role,
            this.IsApproved});
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 236);
            this.dataGridView1.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 200;
            // 
            // Role
            // 
            this.Role.HeaderText = "Роль";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 200;
            // 
            // IsApproved
            // 
            this.IsApproved.HeaderText = "Одобрен";
            this.IsApproved.Name = "IsApproved";
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.Maroon;
            this.buttonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApprove.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonApprove.Location = new System.Drawing.Point(886, 357);
            this.buttonApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(100, 41);
            this.buttonApprove.TabIndex = 7;
            this.buttonApprove.Text = "Одобрить";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // ApproveUsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1023, 431);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListPendingUsersLabel);
            this.Controls.Add(this.goBack);
            this.Name = "ApproveUsersPage";
            this.Text = "ОАО МяскоРай";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label ListPendingUsersLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsApproved;
    }
}