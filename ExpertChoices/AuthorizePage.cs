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
            HomePage frm1 = new HomePage();
            frm1.Show();
            this.Hide();
        }

        public void NextButtonClick()
        {
            var expertchoicesclient = new ExpertChoicesClient();

            var email = "";
            var password = "";
            var authorized = expertchoicesclient.Authorize(email, password, out UserRole role);
            if (!authorized)
            {
                MessageBox.Show("Ошибка", "Не удалось авторизировать", MessageBoxButtons.OK);
                return;
            }


            //switch (role)
            //{
            //    case UserRole.Admin:
            //        //show button work as admin
            //        break;
            //    case UserRole.Expert:
            //        //show button work as expert
            //        break;
            //    case UserRole.Analytic:
            //        //show button work as analytic
            //        break;               
            //}
        }
    }
}
