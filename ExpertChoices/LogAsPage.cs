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
    public partial class LogAsPage : Form
    {
        public LogAsPage()
        {
            InitializeComponent();

            if (AppContext.CurrentUser.Role.HasFlag(UserRole.Admin))
            {
                this.buttonLoginAsAdmin.Visible = true;
            }

            if (AppContext.CurrentUser.Role.HasFlag(UserRole.Analytic))
            {
                this.buttonLoginAsAnalytic.Visible = true;
            }

            if (AppContext.CurrentUser.Role.HasFlag(UserRole.Expert))
            {
                this.buttonLoginAsExpert.Visible = true;
            }            
        }

        private void buttonLoginAsAdmin_Click(object sender, EventArgs e)
        {
            var adminPage = new AdminPage();
            adminPage.Show();
            this.Close();
        }

        private void buttonLoginAsAnalytic_Click(object sender, EventArgs e)
        {
            var analyticPage = new AnalyticPage();
            analyticPage.Show();
            this.Close();
        }

        private void buttonLoginAsExpert_Click(object sender, EventArgs e)
        {
            var expertPage = new ExpertPage();
            expertPage.Show();
            this.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var authorizePage = new AuthorizePage();
            authorizePage.Show();
            this.Close();
        }
    }
}
