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
    public partial class AnalyticViewProblemsPage : Form
    {
        private List<Problem> _allProblems;
        public AnalyticViewProblemsPage()
        {
            _allProblems = AppContext.Client.GetAllProblems();
            InitializeComponent();
            foreach (var assignedProblem in _allProblems)
            {
                dataGridView1.Rows.Add();
                var lastRowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridView1.Rows[lastRowIndex].SetValues(new object[] { assignedProblem.Id, assignedProblem.Name, assignedProblem.Description });
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var page = new AnalyticPage();
            page.Show();
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

            var page = new AssignedEstimationsPage(_allProblems.Single(pr => pr.Id == ids.Single()));
            page.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            var page = new AnalyticViewProblemDetailsPage(_allProblems.Single(problem => problem.Id == id));
            page.Show();
            this.Close();

        }
    }
}
