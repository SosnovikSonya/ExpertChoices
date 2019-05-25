namespace ExpertChoices
{
    partial class AnalyticAddProblemPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticAddProblemPage));
            this.AddProblemLabel = new System.Windows.Forms.Label();
            this.ProbleNameTextBox = new System.Windows.Forms.TextBox();
            this.AddAlternativesLabel = new System.Windows.Forms.Label();
            this.AddExpertsLabel = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProblemDescription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProblemLabel
            // 
            this.AddProblemLabel.AutoSize = true;
            this.AddProblemLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddProblemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProblemLabel.Location = new System.Drawing.Point(256, 20);
            this.AddProblemLabel.Name = "AddProblemLabel";
            this.AddProblemLabel.Size = new System.Drawing.Size(223, 24);
            this.AddProblemLabel.TabIndex = 0;
            this.AddProblemLabel.Text = "Введите имя проблемы\r\n";
            // 
            // ProbleNameTextBox
            // 
            this.ProbleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProbleNameTextBox.Location = new System.Drawing.Point(100, 67);
            this.ProbleNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProbleNameTextBox.Name = "ProbleNameTextBox";
            this.ProbleNameTextBox.Size = new System.Drawing.Size(597, 27);
            this.ProbleNameTextBox.TabIndex = 1;
            // 
            // AddAlternativesLabel
            // 
            this.AddAlternativesLabel.AutoSize = true;
            this.AddAlternativesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddAlternativesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAlternativesLabel.Location = new System.Drawing.Point(266, 251);
            this.AddAlternativesLabel.Name = "AddAlternativesLabel";
            this.AddAlternativesLabel.Size = new System.Drawing.Size(276, 24);
            this.AddAlternativesLabel.TabIndex = 2;
            this.AddAlternativesLabel.Text = "Введите список альтернатив\r\n";
            // 
            // AddExpertsLabel
            // 
            this.AddExpertsLabel.AutoSize = true;
            this.AddExpertsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddExpertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExpertsLabel.Location = new System.Drawing.Point(245, 468);
            this.AddExpertsLabel.Name = "AddExpertsLabel";
            this.AddExpertsLabel.Size = new System.Drawing.Size(328, 24);
            this.AddExpertsLabel.TabIndex = 3;
            this.AddExpertsLabel.Text = "Выберите необходимых экспертов";
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(12, 749);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Maroon;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.ForeColor = System.Drawing.SystemColors.Control;
            this.next.Location = new System.Drawing.Point(688, 740);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 41);
            this.next.TabIndex = 6;
            this.next.Text = "ДАЛЕЕ";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите описание проблемы\r\n";
            // 
            // textBoxProblemDescription
            // 
            this.textBoxProblemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProblemDescription.Location = new System.Drawing.Point(100, 164);
            this.textBoxProblemDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProblemDescription.Multiline = true;
            this.textBoxProblemDescription.Name = "textBoxProblemDescription";
            this.textBoxProblemDescription.Size = new System.Drawing.Size(597, 60);
            this.textBoxProblemDescription.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlternativeName,
            this.AlternativeDescription});
            this.dataGridView1.Location = new System.Drawing.Point(100, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // AlternativeName
            // 
            this.AlternativeName.HeaderText = "Имя альтернативы";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.Width = 200;
            // 
            // AlternativeDescription
            // 
            this.AlternativeDescription.HeaderText = "Описание альтернативы";
            this.AlternativeDescription.Name = "AlternativeDescription";
            this.AlternativeDescription.Width = 300;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ExpertName,
            this.Selected});
            this.dataGridView2.Location = new System.Drawing.Point(100, 518);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(597, 217);
            this.dataGridView2.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ExpertName
            // 
            this.ExpertName.HeaderText = "Имя эксперта";
            this.ExpertName.Name = "ExpertName";
            this.ExpertName.ReadOnly = true;
            this.ExpertName.Width = 200;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Назначить эксперта";
            this.Selected.Name = "Selected";
            // 
            // AnalyticAddProblemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 801);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxProblemDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.AddExpertsLabel);
            this.Controls.Add(this.AddAlternativesLabel);
            this.Controls.Add(this.ProbleNameTextBox);
            this.Controls.Add(this.AddProblemLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnalyticAddProblemPage";
            this.Text = "ОАО МяскоРай";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProblemLabel;
        private System.Windows.Forms.TextBox ProbleNameTextBox;
        private System.Windows.Forms.Label AddAlternativesLabel;
        private System.Windows.Forms.Label AddExpertsLabel;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProblemDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeDescription;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
    }
}