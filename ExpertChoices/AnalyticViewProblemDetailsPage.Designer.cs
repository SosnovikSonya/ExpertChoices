namespace ExpertChoices
{
    partial class AnalyticViewProblemDetailsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticViewProblemDetailsPage));
            this.goBack = new System.Windows.Forms.Button();
            this.AlternativesMetricsLabel = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelCurrentProblem = new System.Windows.Forms.Label();
            this.dataGridViewExpertsMetrics = new System.Windows.Forms.DataGridView();
            this.IdExpert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertCompetency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertDispersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertsMetricsLabel = new System.Windows.Forms.Label();
            this.dataGridViewAlternativesMetrics = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativePreferency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeDispersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpertsMetrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlternativesMetrics)).BeginInit();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(22, 577);
            this.goBack.Margin = new System.Windows.Forms.Padding(2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 33);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "Назад";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // AlternativesMetricsLabel
            // 
            this.AlternativesMetricsLabel.AutoSize = true;
            this.AlternativesMetricsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AlternativesMetricsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlternativesMetricsLabel.ForeColor = System.Drawing.Color.Black;
            this.AlternativesMetricsLabel.Location = new System.Drawing.Point(188, 321);
            this.AlternativesMetricsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlternativesMetricsLabel.Name = "AlternativesMetricsLabel";
            this.AlternativesMetricsLabel.Size = new System.Drawing.Size(293, 26);
            this.AlternativesMetricsLabel.TabIndex = 5;
            this.AlternativesMetricsLabel.Text = "Расчеты по альтернативам";
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.Maroon;
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSolve.Location = new System.Drawing.Point(607, 577);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(130, 33);
            this.buttonSolve.TabIndex = 7;
            this.buttonSolve.Text = "Пересчитать";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelCurrentProblem
            // 
            this.labelCurrentProblem.AutoSize = true;
            this.labelCurrentProblem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCurrentProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentProblem.ForeColor = System.Drawing.Color.Black;
            this.labelCurrentProblem.Location = new System.Drawing.Point(46, 9);
            this.labelCurrentProblem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentProblem.Name = "labelCurrentProblem";
            this.labelCurrentProblem.Size = new System.Drawing.Size(156, 20);
            this.labelCurrentProblem.TabIndex = 8;
            this.labelCurrentProblem.Text = "Текущая проблема:";
            // 
            // dataGridViewExpertsMetrics
            // 
            this.dataGridViewExpertsMetrics.AllowUserToAddRows = false;
            this.dataGridViewExpertsMetrics.AllowUserToDeleteRows = false;
            this.dataGridViewExpertsMetrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpertsMetrics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdExpert,
            this.ExpertName,
            this.ExpertCompetency,
            this.ExpertDispersion});
            this.dataGridViewExpertsMetrics.Location = new System.Drawing.Point(64, 120);
            this.dataGridViewExpertsMetrics.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewExpertsMetrics.Name = "dataGridViewExpertsMetrics";
            this.dataGridViewExpertsMetrics.ReadOnly = true;
            this.dataGridViewExpertsMetrics.RowTemplate.Height = 24;
            this.dataGridViewExpertsMetrics.Size = new System.Drawing.Size(584, 170);
            this.dataGridViewExpertsMetrics.TabIndex = 10;
            // 
            // IdExpert
            // 
            this.IdExpert.HeaderText = "Id";
            this.IdExpert.Name = "IdExpert";
            this.IdExpert.ReadOnly = true;
            this.IdExpert.Visible = false;
            // 
            // ExpertName
            // 
            this.ExpertName.HeaderText = "Имя эксперта";
            this.ExpertName.Name = "ExpertName";
            this.ExpertName.ReadOnly = true;
            this.ExpertName.Width = 200;
            // 
            // ExpertCompetency
            // 
            this.ExpertCompetency.HeaderText = "Компетентность";
            this.ExpertCompetency.Name = "ExpertCompetency";
            this.ExpertCompetency.ReadOnly = true;
            this.ExpertCompetency.Width = 200;
            // 
            // ExpertDispersion
            // 
            this.ExpertDispersion.HeaderText = "Дисперсия";
            this.ExpertDispersion.Name = "ExpertDispersion";
            this.ExpertDispersion.ReadOnly = true;
            this.ExpertDispersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ExpertsMetricsLabel
            // 
            this.ExpertsMetricsLabel.AutoSize = true;
            this.ExpertsMetricsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExpertsMetricsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpertsMetricsLabel.ForeColor = System.Drawing.Color.Black;
            this.ExpertsMetricsLabel.Location = new System.Drawing.Point(215, 65);
            this.ExpertsMetricsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExpertsMetricsLabel.Name = "ExpertsMetricsLabel";
            this.ExpertsMetricsLabel.Size = new System.Drawing.Size(243, 26);
            this.ExpertsMetricsLabel.TabIndex = 9;
            this.ExpertsMetricsLabel.Text = "Расчеты по экспертам";
            // 
            // dataGridViewAlternativesMetrics
            // 
            this.dataGridViewAlternativesMetrics.AllowUserToAddRows = false;
            this.dataGridViewAlternativesMetrics.AllowUserToDeleteRows = false;
            this.dataGridViewAlternativesMetrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlternativesMetrics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.AlternativeName,
            this.AlternativePreferency,
            this.AlternativeDispersion});
            this.dataGridViewAlternativesMetrics.Location = new System.Drawing.Point(64, 382);
            this.dataGridViewAlternativesMetrics.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAlternativesMetrics.Name = "dataGridViewAlternativesMetrics";
            this.dataGridViewAlternativesMetrics.ReadOnly = true;
            this.dataGridViewAlternativesMetrics.RowTemplate.Height = 24;
            this.dataGridViewAlternativesMetrics.Size = new System.Drawing.Size(584, 170);
            this.dataGridViewAlternativesMetrics.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // AlternativeName
            // 
            this.AlternativeName.HeaderText = "Имя альтернативы";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.ReadOnly = true;
            this.AlternativeName.Width = 200;
            // 
            // AlternativePreferency
            // 
            this.AlternativePreferency.HeaderText = "Предпочтительность";
            this.AlternativePreferency.Name = "AlternativePreferency";
            this.AlternativePreferency.ReadOnly = true;
            this.AlternativePreferency.Width = 200;
            // 
            // AlternativeDispersion
            // 
            this.AlternativeDispersion.HeaderText = "Дисперсия";
            this.AlternativeDispersion.Name = "AlternativeDispersion";
            this.AlternativeDispersion.ReadOnly = true;
            this.AlternativeDispersion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AnalyticViewProblemDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 621);
            this.Controls.Add(this.dataGridViewAlternativesMetrics);
            this.Controls.Add(this.dataGridViewExpertsMetrics);
            this.Controls.Add(this.ExpertsMetricsLabel);
            this.Controls.Add(this.labelCurrentProblem);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.AlternativesMetricsLabel);
            this.Controls.Add(this.goBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyticViewProblemDetailsPage";
            this.Text = "ОАО МяскоРай";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpertsMetrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlternativesMetrics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label AlternativesMetricsLabel;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelCurrentProblem;
        private System.Windows.Forms.DataGridView dataGridViewExpertsMetrics;
        private System.Windows.Forms.Label ExpertsMetricsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertCompetency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertDispersion;
        private System.Windows.Forms.DataGridView dataGridViewAlternativesMetrics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativePreferency;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeDispersion;
    }
}