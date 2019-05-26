namespace ExpertChoices
{
    partial class AnalyticViewProblemsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticViewProblemsPage));
            this.goBack = new System.Windows.Forms.Button();
            this.ProblemsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelToolTip = new System.Windows.Forms.Label();
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
            // ProblemsLabel
            // 
            this.ProblemsLabel.AutoSize = true;
            this.ProblemsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProblemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemsLabel.ForeColor = System.Drawing.Color.Black;
            this.ProblemsLabel.Location = new System.Drawing.Point(258, 9);
            this.ProblemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProblemsLabel.Name = "ProblemsLabel";
            this.ProblemsLabel.Size = new System.Drawing.Size(182, 26);
            this.ProblemsLabel.TabIndex = 5;
            this.ProblemsLabel.Text = "Список проблем";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.problemName,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(34, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 192);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            this.description.Width = 300;
            // 
            // labelToolTip
            // 
            this.labelToolTip.AutoSize = true;
            this.labelToolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelToolTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToolTip.ForeColor = System.Drawing.Color.Black;
            this.labelToolTip.Location = new System.Drawing.Point(31, 48);
            this.labelToolTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToolTip.Name = "labelToolTip";
            this.labelToolTip.Size = new System.Drawing.Size(345, 17);
            this.labelToolTip.TabIndex = 7;
            this.labelToolTip.Text = "Нажмите дважды на строку, чтобы увидеть детали";
            // 
            // AnalyticViewProblemsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 350);
            this.Controls.Add(this.labelToolTip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProblemsLabel);
            this.Controls.Add(this.goBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyticViewProblemsPage";
            this.Text = "ОАО МяскоРай";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label ProblemsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label labelToolTip;
    }
}