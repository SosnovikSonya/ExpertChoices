using ExpertChoicesModels;
using ProblemSolver;
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
    public partial class AssignedEstimationsPage : Form
    {
        private Expert _currentExpert;
        private Problem _currentProblem;
        private List<Expert> _assignedestimationsOnExpert;
        private List<Alternative> _assignedestimationsOnALternative;
        public AssignedEstimationsPage(Problem currentProblem)
        {
            _currentProblem = currentProblem;
            _assignedestimationsOnExpert = AppContext.Client.CheckForAssignedEstimationsOnExperts(_currentProblem.Id);
            _assignedestimationsOnALternative = AppContext.Client.CheckForAssignedEstimationsOnAlternatives(_currentProblem.Id);
            _currentExpert = AppContext.Client.GetCurrentExpert();

            InitializeComponent();

            labelCurrentProblem.Text += $" {_currentProblem.Name}";

            foreach (var expert in _assignedestimationsOnExpert)
            {
                dataGridViewEstimationsOnExperts.Rows.Add();
                var lastRowIndex = dataGridViewEstimationsOnExperts.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewEstimationsOnExperts.Rows[lastRowIndex].SetValues(new object[] { expert.Id, expert.Name });
            }

            foreach (var alternative in _assignedestimationsOnALternative)
            {
                dataGridViewEstimationsOnAternatives.Rows.Add();
                var lastRowIndex = dataGridViewEstimationsOnAternatives.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewEstimationsOnAternatives.Rows[lastRowIndex].SetValues(new object[] { alternative.Id, alternative.Name, alternative.Description });
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var problemsPage = new AssignedProblemsPage();
            problemsPage.Show();
            this.Close();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            //Validate values of alternatives
            foreach (DataGridViewRow row in dataGridViewEstimationsOnAternatives.Rows)
            {
                int.TryParse((string)row.Cells["AlternativeValue"].Value, out var value);
                if (value > 10 || value < 1)
                {
                    MessageBox.Show("Значения оценок должны быть целыми и в диапазоне 1-10", "Ошибка ввода", MessageBoxButtons.OK);
                    return;
                }
            }

            //Validate values of experts
            foreach (DataGridViewRow row in dataGridViewEstimationsOnExperts.Rows)
            {
                int.TryParse((string)row.Cells["ExpertValue"].Value, out var value);
                if (value > 10 || value < 1)
                {
                    MessageBox.Show("Значения оценок должны быть целыми и в диапазоне 1-10", "Ошибка ввода", MessageBoxButtons.OK);
                    return;
                }
            }

            var estimationOnAlts = new Estimation<Expert, Alternative>()
            {
                Estimator = _currentExpert,
                Estimated = new Dictionary<Alternative, int?>()
            };
            foreach (DataGridViewRow row in dataGridViewEstimationsOnAternatives.Rows)
            {
                int.TryParse((string)row.Cells["AlternativeValue"].Value, out var value);
                estimationOnAlts.Estimated.Add(new Alternative
                {
                    Id = (int)row.Cells["IdAlt"].Value,
                    Name = (string)row.Cells["AlternativeName"].Value,
                    Description = (string)row.Cells["AlternativeDescription"].Value
                }, value
                );
            }

            var estimationOnExperts = new Estimation<Expert, Expert>()
            {
                Estimator = _currentExpert,
                Estimated = new Dictionary<Expert, int?>()
            };
            foreach (DataGridViewRow row in dataGridViewEstimationsOnExperts.Rows)
            {
                int.TryParse((string)row.Cells["ExpertValue"].Value, out var value);
                estimationOnExperts.Estimated.Add(new Expert
                {
                    Id = (int)row.Cells["IdExpert"].Value,
                    Name = (string)row.Cells["ExpertName"].Value
                },
                value
                );
            }


            AppContext.Client.SendEstimationsOnAlternatives(_currentProblem.Id, estimationOnAlts);
            AppContext.Client.SendEstimationsOnExperts(_currentProblem.Id, estimationOnExperts);
        }        
    }
}
