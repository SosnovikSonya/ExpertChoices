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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var logAsPage = new LogAsPage();
            logAsPage.Show();
            this.Close();
        }

        private void buttonListUnapprovedUsers_Click(object sender, EventArgs e)
        {
            var approveUsersPage = new ApproveUsersPage();
            approveUsersPage.Show();
            this.Close();
        }
    }
}
