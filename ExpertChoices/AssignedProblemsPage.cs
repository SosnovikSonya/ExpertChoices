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
    public partial class AssignedProblemsPage : Form
    {
        private List<Problem> _assignedProblems;
        public AssignedProblemsPage()
        {
            _assignedProblems = AppContext.Client.CheckForAssignedProblems();
            InitializeComponent();
            foreach (var assignedProblem in _assignedProblems)
            {
                dataGridView1.Rows.Add();
                var lastRowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridView1.Rows[lastRowIndex].SetValues(new object[] { assignedProblem.Id, assignedProblem.Name, assignedProblem.Description, false });
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var expertPage = new ExpertPage();
            expertPage.Show();
            this.Close();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var ids = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => (bool)row.Cells["solveTheProblem"].Value)
                .Select(row => (int)row.Cells["id"].Value)
                .ToList();
            if (ids.Count != 1)
            {
                MessageBox.Show("Выберите ровно одну проблему для оценивания", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var page = new AssignedEstimationsPage(_assignedProblems.Single(pr => pr.Id == ids.Single()));
            page.Show();
            this.Close();
        }

    }
}
