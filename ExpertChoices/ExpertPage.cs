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
    public partial class ExpertPage : Form
    {
        public ExpertPage()
        {
            InitializeComponent();
        }

        private void buttonCheckForAssignedProblems_Click(object sender, EventArgs e)
        {
            var checkForAssignedProblems = new AssignedProblemsPage();
            checkForAssignedProblems.Show();
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var logAsPage = new LogAsPage();
            logAsPage.Show();
            this.Close();
        }
    }
}
