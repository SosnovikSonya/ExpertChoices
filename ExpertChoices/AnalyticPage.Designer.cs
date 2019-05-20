namespace ExpertChoices
{
    partial class AnalyticPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticPage));
            this.AddProblemButton = new System.Windows.Forms.Button();
            this.ViewProblemHistoryButton = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProblemButton
            // 
            this.AddProblemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddProblemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProblemButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddProblemButton.Location = new System.Drawing.Point(149, 59);
            this.AddProblemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProblemButton.Name = "AddProblemButton";
            this.AddProblemButton.Size = new System.Drawing.Size(269, 69);
            this.AddProblemButton.TabIndex = 1;
            this.AddProblemButton.Text = "ДОБАВИТЬ ПРОБЛЕМУ";
            this.AddProblemButton.UseVisualStyleBackColor = false;
            this.AddProblemButton.Click += new System.EventHandler(this.AddProblemButton_Click);
            // 
            // ViewProblemHistoryButton
            // 
            this.ViewProblemHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ViewProblemHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewProblemHistoryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewProblemHistoryButton.Location = new System.Drawing.Point(149, 164);
            this.ViewProblemHistoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewProblemHistoryButton.Name = "ViewProblemHistoryButton";
            this.ViewProblemHistoryButton.Size = new System.Drawing.Size(269, 69);
            this.ViewProblemHistoryButton.TabIndex = 2;
            this.ViewProblemHistoryButton.Text = "СПИСОК ПРОБЛЕМ";
            this.ViewProblemHistoryButton.UseVisualStyleBackColor = false;
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(29, 334);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 3;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // AnalyticPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 398);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.ViewProblemHistoryButton);
            this.Controls.Add(this.AddProblemButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnalyticPage";
            this.Text = "ОАО МяскоРай";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProblemButton;
        private System.Windows.Forms.Button ViewProblemHistoryButton;
        private System.Windows.Forms.Button goBack;
    }
}