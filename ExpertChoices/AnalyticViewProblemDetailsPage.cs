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
    public partial class AnalyticViewProblemDetailsPage : Form
    {
        private Problem _currentProblem;
        private Dictionary<Expert, ExpertMetricsModel> _expertsMetrics = new Dictionary<Expert, ExpertMetricsModel>();
        private Dictionary<Alternative, AlternativeMetricsModel> _alternativesMetrics = new Dictionary<Alternative, AlternativeMetricsModel>();

        public AnalyticViewProblemDetailsPage(Problem currentProblem)
        {
            _currentProblem = currentProblem;
            AppContext.Client.SolveTheProblem(_currentProblem.Id);

            var details = AppContext.Client.GetProblemDetails(_currentProblem.Id);

            foreach (var expert in details.Experts)
            {
                _expertsMetrics.Add(expert, AppContext.Client.GetExpertMetrics(_currentProblem.Id, expert.Id));
            }

            foreach (var alternative in details.Alternatives)
            {
                _alternativesMetrics.Add(alternative, AppContext.Client.GetAlternativeMetrics(_currentProblem.Id, alternative.Id));
            }

            InitializeComponent();

            labelCurrentProblem.Text += $" {_currentProblem.Name}";

            bool EstimationsIncompelete = true;
            EstimationsIncompelete = _expertsMetrics.Any(pair => pair.Value.Competency == null || pair.Value.Dispersion == null);
            EstimationsIncompelete = _alternativesMetrics.Any(pair => pair.Value.Preferency == null || pair.Value.Dispersion == null);
            if (EstimationsIncompelete)
            {
                MessageBox.Show("Не все оценки были выставлены экспертами. Ожидайте.", "Решение не готово", MessageBoxButtons.OK);
            }

            foreach (var pair in _expertsMetrics)
            {
                dataGridViewExpertsMetrics.Rows.Add();
                var lastRowIndex = dataGridViewExpertsMetrics.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewExpertsMetrics.Rows[lastRowIndex].SetValues(new object[] { pair.Key.Id, pair.Key.Name, pair.Value.Competency, pair.Value.Dispersion });
            }

            foreach (var pair in _alternativesMetrics)
            {
                dataGridViewAlternativesMetrics.Rows.Add();
                var lastRowIndex = dataGridViewAlternativesMetrics.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridViewAlternativesMetrics.Rows[lastRowIndex].SetValues(new object[] { pair.Key.Id, pair.Key.Name, pair.Value.Preferency, pair.Value.Dispersion });
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var page = new AnalyticViewProblemsPage();
            page.Show();
            this.Close();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var page = new AnalyticViewProblemDetailsPage(_currentProblem);
            page.Show();
            this.Close();
        }
    }
}
