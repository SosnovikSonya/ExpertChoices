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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            var regPage = new RegistrationPage();
            regPage.Show();
            this.Hide();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            var authPage = new AuthorizePage();
            authPage.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
