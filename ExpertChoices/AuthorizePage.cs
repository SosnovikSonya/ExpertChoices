using ExpertChoicesModels;
using ExpertChoices.ServerInteraction;
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
    public partial class AuthorizePage : Form
    {
        public AuthorizePage()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        public void next_Click(object sender, EventArgs e)
        {
            AppContext.CurrentUser = new User()
            {
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text
            };
            var authResult = AppContext.Client.Authorize(AppContext.CurrentUser.Email, AppContext.CurrentUser.Password);

            if (!authResult.IsAuthorized)
            {
                MessageBox.Show("Пользователь с таким email и паролем не существует или не одобрен администратором", "Ошибка Авторизации", MessageBoxButtons.OK);
                return;
            }

            AppContext.CurrentUser.Role = authResult.Role;
            AppContext.CurrentUser.FirstName = authResult.FirstName;
            AppContext.CurrentUser.LastName = authResult.LastName;

            var logAsPage = new LogAsPage();
            logAsPage.Show();
            this.Close();
        }       
    }
}
