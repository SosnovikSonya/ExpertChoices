using ExpertChoicesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertChoices
{
    public partial class AnalyticAddProblemPage : Form
    {
        List<Expert> _experts = new List<Expert>();
        public AnalyticAddProblemPage()
        {
            InitializeComponent();
            _experts = AppContext.Client.GetAllExperts();

            foreach (var expert in _experts)
            {
                dataGridView2.Rows.Add();

                var lastRowIndex = dataGridView2.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridView2.Rows[lastRowIndex].SetValues(new object[] { expert.Id, expert.Name, false });
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            AnalyticPage analyticPage = new AnalyticPage();
            analyticPage.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                //messagebox
                return;
            }

            var experts = new List<int>();
            foreach (var row in dataGridView2.Rows.Cast<DataGridViewRow>())
            {
                if ((bool)row.Cells["Selected"].Value)
                {
                    experts.Add((int)row.Cells["Id"].Value);
                }
            }

            if (experts.Count < 2)
            {
                //messagebox with error
            }

            var alternatives = new List<Alternative>();
            foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                if (row.Cells[0].Value != null)
                {
                    alternatives.Add(new Alternative
                    {
                        Name = (string)row.Cells[0].Value,
                        Description = (string)row.Cells[1].Value,
                    });
                }
            }

            if (alternatives.Count < 2)
            {
                //messagebox with error
            }

            var problem = new Problem
            {
                Name = ProbleNameTextBox.Text,
                Description = textBoxProblemDescription.Text
            };

            var problemId = AppContext.Client.CreateProblem(problem);

            AppContext.Client.AssignExperts(problemId, experts);

            AppContext.Client.AssignAlternative(problemId, alternatives);

            //messagebox фсе ок!
            var page = new AnalyticPage();
            page.Show();
            this.Close();
        }

        public bool Validate()
        {
            return true;
        }
    }
}
