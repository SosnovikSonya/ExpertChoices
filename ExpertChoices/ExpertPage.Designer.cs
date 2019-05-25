namespace ExpertChoices
{
    partial class ExpertPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpertPage));
            this.goBack = new System.Windows.Forms.Button();
            this.buttonCheckForAssignedProblems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Maroon;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.SystemColors.Control;
            this.goBack.Location = new System.Drawing.Point(37, 352);
            this.goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(100, 41);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "НАЗАД";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // buttonCheckForAssignedProblems
            // 
            this.buttonCheckForAssignedProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCheckForAssignedProblems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckForAssignedProblems.Location = new System.Drawing.Point(55, 138);
            this.buttonCheckForAssignedProblems.Name = "buttonCheckForAssignedProblems";
            this.buttonCheckForAssignedProblems.Size = new System.Drawing.Size(483, 55);
            this.buttonCheckForAssignedProblems.TabIndex = 5;
            this.buttonCheckForAssignedProblems.Text = "Просмотреть список проблем";
            this.buttonCheckForAssignedProblems.UseVisualStyleBackColor = false;
            this.buttonCheckForAssignedProblems.Click += new System.EventHandler(this.buttonCheckForAssignedProblems_Click);
            // 
            // ExpertPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 420);
            this.Controls.Add(this.buttonCheckForAssignedProblems);
            this.Controls.Add(this.goBack);
            this.Name = "ExpertPage";
            this.Text = "ОАО МяскоРай";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button buttonCheckForAssignedProblems;
    }
}