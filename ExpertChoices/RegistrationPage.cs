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
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void goBack_Click(object sender, EventArgs e)
        {
            HomePage frm1 = new HomePage();
            frm1.Show();
            this.Hide();
        }

    }
}

  
