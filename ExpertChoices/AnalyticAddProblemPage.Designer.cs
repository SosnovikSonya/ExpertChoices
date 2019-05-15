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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddProblemLabel
            // 
            this.AddProblemLabel.AutoSize = true;
            this.AddProblemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProblemLabel.Location = new System.Drawing.Point(50, 50);
            this.AddProblemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProblemLabel.Name = "AddProblemLabel";
            this.AddProblemLabel.Size = new System.Drawing.Size(213, 18);
            this.AddProblemLabel.TabIndex = 0;
            this.AddProblemLabel.Text = "Введите сущность проблемы\r\n";
            // 
            // ProbleNameTextBox
            // 
            this.ProbleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProbleNameTextBox.Location = new System.Drawing.Point(286, 50);
            this.ProbleNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProbleNameTextBox.Name = "ProbleNameTextBox";
            this.ProbleNameTextBox.Size = new System.Drawing.Size(300, 23);
            this.ProbleNameTextBox.TabIndex = 1;
            // 
            // AddAlternativesLabel
            // 
            this.AddAlternativesLabel.AutoSize = true;
            this.AddAlternativesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAlternativesLabel.Location = new System.Drawing.Point(48, 124);
            this.AddAlternativesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddAlternativesLabel.Name = "AddAlternativesLabel";
            this.AddAlternativesLabel.Size = new System.Drawing.Size(210, 18);
            this.AddAlternativesLabel.TabIndex = 2;
            this.AddAlternativesLabel.Text = "Введите список альтернатив\r\n";
            // 
            // AddExpertsLabel
            // 
            this.AddExpertsLabel.AutoSize = true;
            this.AddExpertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExpertsLabel.Location = new System.Drawing.Point(9, 218);
            this.AddExpertsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddExpertsLabel.Name = "AddExpertsLabel";
            this.AddExpertsLabel.Size = new System.Drawing.Size(253, 18);
            this.AddExpertsLabel.TabIndex = 3;
            this.AddExpertsLabel.Text = "Выберите необходимых экспертов";
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.White;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.Color.Maroon;
            this.goBack.Location = new System.Drawing.Point(27, 307);
            this.goBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 33);
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
            this.next.Location = new System.Drawing.Point(496, 307);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 33);
            this.next.TabIndex = 6;
            this.next.Text = "ДАЛЕЕ";
            this.next.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(286, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 81);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // AnalyticAddProblemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.AddExpertsLabel);
            this.Controls.Add(this.AddAlternativesLabel);
            this.Controls.Add(this.ProbleNameTextBox);
            this.Controls.Add(this.AddProblemLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnalyticAddProblemPage";
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
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}