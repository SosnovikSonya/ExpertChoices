namespace ExpertChoices
{
    partial class CheckForAssignedProblems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForAssignedProblems));
            this.goBack = new System.Windows.Forms.Button();
            this.ListAssignedProblemsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solveTheProblem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonSolve = new System.Windows.Forms.Button();
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
            this.ListAssignedProblemsLabel.Location = new System.Drawing.Point(324, 38);
            this.ListAssignedProblemsLabel.Name = "ListAssignedProblemsLabel";
            this.ListAssignedProblemsLabel.Size = new System.Drawing.Size(403, 31);
            this.ListAssignedProblemsLabel.TabIndex = 5;
            this.ListAssignedProblemsLabel.Text = "Список проблем для решения:";
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
            this.dataGridView1.Location = new System.Drawing.Point(262, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 236);
            this.dataGridView1.TabIndex = 6;
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
            this.solveTheProblem.HeaderText = "Решить";
            this.solveTheProblem.Name = "solveTheProblem";
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.Maroon;
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSolve.Location = new System.Drawing.Point(886, 357);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(100, 41);
            this.buttonSolve.TabIndex = 7;
            this.buttonSolve.Text = "Решить";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // CheckForAssignedProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1023, 431);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListAssignedProblemsLabel);
            this.Controls.Add(this.goBack);
            this.Name = "CheckForAssignedProblems";
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