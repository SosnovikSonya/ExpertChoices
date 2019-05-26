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
    public partial class AnalyticPage : Form
    {
        public AnalyticPage()
        {
            InitializeComponent();
        }

        private void AddProblemButton_Click(object sender, EventArgs e)
        {
            var addProblemPage = new AnalyticAddProblemPage();
            addProblemPage.Show();
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var logAsPage = new LogAsPage();
            logAsPage.Show();
            this.Close();
        }

        private void ViewProblemHistoryButton_Click(object sender, EventArgs e)
        {
            var page = new AnalyticViewProblemsPage();
            page.Show();
            this.Close();
        }
    }
}
