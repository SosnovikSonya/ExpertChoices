namespace ExpertChoices
{
    partial class AssignedEstimationsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignedEstimationsPage));
            this.goBack = new System.Windows.Forms.Button();
            this.AssignedEstimationAltLabel = new System.Windows.Forms.Label();
            this.dataGridViewEstimationsOnAternatives = new System.Windows.Forms.DataGridView();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelCurrentProblem = new System.Windows.Forms.Label();
            this.dataGridViewEstimationsOnExperts = new System.Windows.Forms.DataGridView();
            this.labelEstimationOnExperts = new System.Windows.Forms.Label();
            this.IdAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativeValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdExpert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimationsOnAternatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimationsOnExperts)).BeginInit();
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
            // AssignedEstimationAltLabel
            // 
            this.AssignedEstimationAltLabel.AutoSize = true;
            this.AssignedEstimationAltLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AssignedEstimationAltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssignedEstimationAltLabel.ForeColor = System.Drawing.Color.Black;
            this.AssignedEstimationAltLabel.Location = new System.Drawing.Point(184, 72);
            this.AssignedEstimationAltLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignedEstimationAltLabel.Name = "AssignedEstimationAltLabel";
            this.AssignedEstimationAltLabel.Size = new System.Drawing.Size(392, 26);
            this.AssignedEstimationAltLabel.TabIndex = 5;
            this.AssignedEstimationAltLabel.Text = "Список альтернатив для оценивания";
            // 
            // dataGridViewEstimationsOnAternatives
            // 
            this.dataGridViewEstimationsOnAternatives.AllowUserToAddRows = false;
            this.dataGridViewEstimationsOnAternatives.AllowUserToDeleteRows = false;
            this.dataGridViewEstimationsOnAternatives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstimationsOnAternatives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlt,
            this.AlternativeName,
            this.AlternativeDescription,
            this.AlternativeValue});
            this.dataGridViewEstimationsOnAternatives.Location = new System.Drawing.Point(51, 119);
            this.dataGridViewEstimationsOnAternatives.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEstimationsOnAternatives.Name = "dataGridViewEstimationsOnAternatives";
            this.dataGridViewEstimationsOnAternatives.RowTemplate.Height = 24;
            this.dataGridViewEstimationsOnAternatives.Size = new System.Drawing.Size(584, 170);
            this.dataGridViewEstimationsOnAternatives.TabIndex = 6;
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.Maroon;
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolve.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSolve.Location = new System.Drawing.Point(662, 577);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 33);
            this.buttonSolve.TabIndex = 7;
            this.buttonSolve.Text = "Оценить";
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
            // dataGridViewEstimationsOnExperts
            // 
            this.dataGridViewEstimationsOnExperts.AllowUserToAddRows = false;
            this.dataGridViewEstimationsOnExperts.AllowUserToDeleteRows = false;
            this.dataGridViewEstimationsOnExperts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstimationsOnExperts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdExpert,
            this.ExpertName,
            this.ExpertValue});
            this.dataGridViewEstimationsOnExperts.Location = new System.Drawing.Point(51, 374);
            this.dataGridViewEstimationsOnExperts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEstimationsOnExperts.Name = "dataGridViewEstimationsOnExperts";
            this.dataGridViewEstimationsOnExperts.RowTemplate.Height = 24;
            this.dataGridViewEstimationsOnExperts.Size = new System.Drawing.Size(584, 170);
            this.dataGridViewEstimationsOnExperts.TabIndex = 10;
            // 
            // labelEstimationOnExperts
            // 
            this.labelEstimationOnExperts.AutoSize = true;
            this.labelEstimationOnExperts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelEstimationOnExperts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEstimationOnExperts.ForeColor = System.Drawing.Color.Black;
            this.labelEstimationOnExperts.Location = new System.Drawing.Point(184, 329);
            this.labelEstimationOnExperts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstimationOnExperts.Name = "labelEstimationOnExperts";
            this.labelEstimationOnExperts.Size = new System.Drawing.Size(366, 26);
            this.labelEstimationOnExperts.TabIndex = 9;
            this.labelEstimationOnExperts.Text = "Список экспертов для оценивания";
            // 
            // IdAlt
            // 
            this.IdAlt.HeaderText = "Id";
            this.IdAlt.Name = "IdAlt";
            this.IdAlt.Visible = false;
            // 
            // AlternativeName
            // 
            this.AlternativeName.HeaderText = "Название";
            this.AlternativeName.Name = "AlternativeName";
            this.AlternativeName.ReadOnly = true;
            this.AlternativeName.Width = 200;
            // 
            // AlternativeDescription
            // 
            this.AlternativeDescription.HeaderText = "Описание";
            this.AlternativeDescription.Name = "AlternativeDescription";
            this.AlternativeDescription.ReadOnly = true;
            // 
            // AlternativeValue
            // 
            this.AlternativeValue.HeaderText = "Оценка";
            this.AlternativeValue.Name = "AlternativeValue";
            this.AlternativeValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlternativeValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IdExpert
            // 
            this.IdExpert.HeaderText = "Id";
            this.IdExpert.Name = "IdExpert";
            this.IdExpert.Visible = false;
            // 
            // ExpertName
            // 
            this.ExpertName.HeaderText = "Имя";
            this.ExpertName.Name = "ExpertName";
            this.ExpertName.ReadOnly = true;
            this.ExpertName.Width = 200;
            // 
            // ExpertValue
            // 
            this.ExpertValue.HeaderText = "Оценка";
            this.ExpertValue.Name = "ExpertValue";
            this.ExpertValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpertValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssignedEstimationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 621);
            this.Controls.Add(this.dataGridViewEstimationsOnExperts);
            this.Controls.Add(this.labelEstimationOnExperts);
            this.Controls.Add(this.labelCurrentProblem);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.dataGridViewEstimationsOnAternatives);
            this.Controls.Add(this.AssignedEstimationAltLabel);
            this.Controls.Add(this.goBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AssignedEstimationsPage";
            this.Text = "ОАО МяскоРай";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimationsOnAternatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimationsOnExperts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label AssignedEstimationAltLabel;
        private System.Windows.Forms.DataGridView dataGridViewEstimationsOnAternatives;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelCurrentProblem;
        private System.Windows.Forms.DataGridView dataGridViewEstimationsOnExperts;
        private System.Windows.Forms.Label labelEstimationOnExperts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlternativeValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertValue;
    }
}