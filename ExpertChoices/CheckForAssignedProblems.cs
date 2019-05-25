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
    public partial class CheckForAssignedProblems : Form
    {
        private List<User> _pendingUsers;
        public CheckForAssignedProblems()
        {
            _pendingUsers = AppContext.Client.GetPendingUsers();
            InitializeComponent();
            foreach (var pendingUser in _pendingUsers)
            {
                dataGridView1.Rows.Add();
                var lastRowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dataGridView1.Rows[lastRowIndex].SetValues(new object[] { pendingUser.Id, pendingUser.Email, pendingUser.FirstName, pendingUser.LastName, role, false });
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            var adminPage = new AdminPage();
            adminPage.Show();
            this.Close();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            var ids = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[0].Value != null)
                .Where(row => (bool)(row.Cells["IsApproved"] as DataGridViewCheckBoxCell).Value)
                .Select(row => (int)(row.Cells["Id"].Value))
                .ToList();

            foreach (var id in ids)
            {
                AppContext.Client.ApproveUsers(id);
            }
            var approveUserPage = new ApproveUsersPage();
            approveUserPage.Show();
            this.Close();
        }
    }
}
