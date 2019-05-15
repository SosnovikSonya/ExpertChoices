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
            AnalyticAddProblemPage addProblemPage = new AnalyticAddProblemPage();
            addProblemPage.Show();
            this.Hide();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            AuthorizePage auth = new AuthorizePage();
            auth.Show();
            this.Hide();
        }
    }
}
