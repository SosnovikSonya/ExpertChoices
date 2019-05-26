namespace ExpertChoices
{
    partial class AssignedProblemsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignedProblemsPage));
            this.goBack = new System.Windows.Forms.Button();
            this.ListAssignedProblemsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solveTheProblem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(43, 290);
            this.goBack.Margin = new System.Windows.Forms.Padding(2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 33);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "Назад";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // ListAssignedProblemsLabel
            // 
            this.ListAssignedProblemsLabel.AutoSize = true;
            this.ListAssignedProblemsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListAssignedProblemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListAssignedProblemsLabel.ForeColor = System.Drawing.Color.Black;
            this.ListAssignedProblemsLabel.Location = new System.Drawing.Point(243, 31);
            this.ListAssignedProblemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListAssignedProblemsLabel.Name = "ListAssignedProblemsLabel";
            this.ListAssignedProblemsLabel.Size = new System.Drawing.Size(304, 26);
            this.ListAssignedProblemsLabel.TabIndex = 5;
            this.ListAssignedProblemsLabel.Text = "Список проблем для оценки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.problemName,
            this.description,
            this.solveTheProblem});
            this.dataGridView1.Location = new System.Drawing.Point(43, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 192);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.Maroon;
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSolve.Location = new System.Drawing.Point(664, 290);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 33);
            this.buttonSolve.TabIndex = 7;
            this.buttonSolve.Text = "Оценить";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // problemName
            // 
            this.problemName.HeaderText = "Название";
            this.problemName.Name = "problemName";
            this.problemName.ReadOnly = true;
            this.problemName.Width = 200;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // solveTheProblem
            // 
            this.solveTheProblem.HeaderText = "Оценить";
            this.solveTheProblem.Name = "solveTheProblem";
            // 
            // AssignedProblemsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 350);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListAssignedProblemsLabel);
            this.Controls.Add(this.goBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AssignedProblemsPage";
            this.Text = "ОАО МяскоРай";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label ListAssignedProblemsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solveTheProblem;
    }
}