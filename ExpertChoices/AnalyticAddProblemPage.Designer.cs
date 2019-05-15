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
            this.SuspendLayout();
            // 
            // AddProblemLabel
            // 
            this.AddProblemLabel.AutoSize = true;
            this.AddProblemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProblemLabel.Location = new System.Drawing.Point(66, 62);
            this.AddProblemLabel.Name = "AddProblemLabel";
            this.AddProblemLabel.Size = new System.Drawing.Size(274, 24);
            this.AddProblemLabel.TabIndex = 0;
            this.AddProblemLabel.Text = "Введите сущность проблемы\r\n";
            // 
            // ProbleNameTextBox
            // 
            this.ProbleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProbleNameTextBox.Location = new System.Drawing.Point(381, 62);
            this.ProbleNameTextBox.Name = "ProbleNameTextBox";
            this.ProbleNameTextBox.Size = new System.Drawing.Size(398, 27);
            this.ProbleNameTextBox.TabIndex = 1;
            // 
            // AddAlternativesLabel
            // 
            this.AddAlternativesLabel.AutoSize = true;
            this.AddAlternativesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAlternativesLabel.Location = new System.Drawing.Point(64, 152);
            this.AddAlternativesLabel.Name = "AddAlternativesLabel";
            this.AddAlternativesLabel.Size = new System.Drawing.Size(276, 24);
            this.AddAlternativesLabel.TabIndex = 2;
            this.AddAlternativesLabel.Text = "Введите список альтернатив\r\n";
            // 
            // AddExpertsLabel
            // 
            this.AddExpertsLabel.AutoSize = true;
            this.AddExpertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExpertsLabel.Location = new System.Drawing.Point(12, 268);
            this.AddExpertsLabel.Name = "AddExpertsLabel";
            this.AddExpertsLabel.Size = new System.Drawing.Size(328, 24);
            this.AddExpertsLabel.TabIndex = 3;
            this.AddExpertsLabel.Text = "Выберите необходимых экспертов";
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.White;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.Color.Maroon;
            this.goBack.Location = new System.Drawing.Point(36, 378);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.White;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.ForeColor = System.Drawing.Color.Maroon;
            this.next.Location = new System.Drawing.Point(662, 378);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 41);
            this.next.TabIndex = 6;
            this.next.Text = "ДАЛЕЕ";
            this.next.UseVisualStyleBackColor = false;
            // 
            // AnalyticPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.AddExpertsLabel);
            this.Controls.Add(this.AddAlternativesLabel);
            this.Controls.Add(this.ProbleNameTextBox);
            this.Controls.Add(this.AddProblemLabel);
            this.Name = "AnalyticPage";
            this.Text = "ОАО МяскоРай";
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
    }
}