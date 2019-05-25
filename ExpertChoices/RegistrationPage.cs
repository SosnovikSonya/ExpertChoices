using ExpertChoices.ServerInteraction;
using ExpertChoicesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            var frm1 = new HomePage();
            frm1.Show();
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (!ValidateInputData())
            {
                return;
            }

            var role = UserRole.Null;
            if (checkedListBoxRoles.SelectedItems.Contains("Эксперт"))
            {
                role |= UserRole.Expert;
            }

            if (checkedListBoxRoles.SelectedItems.Contains("Администратор"))
            {
                role |= UserRole.Admin;
            }

            if (checkedListBoxRoles.SelectedItems.Contains("Аналитик"))
            {
                role |= UserRole.Analytic;
            }

            var user = new User()
            {
                Email = textBoxEmail.Text,
                FirstName = textBoxFirstName.Text,
                Password = textBoxPassword.Text,
                Role = role,
                LastName = textBoxLastName.Text
            };

            AppContext.Client.Register(user);

            MessageBox.Show("Ваша заявка отправлена на расссмотрение администратором", "Регистрация успешна", MessageBoxButtons.OK);

            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private bool ValidateInputData()
        {
            var caption = "Неправильные данные";
            var regexName = new Regex("([A-Za-z\\s<>?!@#$%^&*:;.,'\"\\d])");
            var regexEmail = new Regex(@"([\w])+@([\w])+.([\w])+");
            if (!regexEmail.IsMatch(textBoxEmail.Text))
            {
                MessageBox.Show("Email должен быть правильным", caption, MessageBoxButtons.OK);
                return false;
            }
            if (textBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Длина пароля должна быть более 5 символов", caption, MessageBoxButtons.OK);
                return false;
            }
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Пароли должны совпадать", caption, MessageBoxButtons.OK);
                return false;
            }
            if (textBoxFirstName.Text.Length < 2)
            {
                MessageBox.Show("Длина имени должна быть более 1 символа", caption, MessageBoxButtons.OK);
                return false;
            }
            if (textBoxLastName.Text.Length < 2)
            {
                MessageBox.Show("Длина фамилии должна быть более 1 символа", caption, MessageBoxButtons.OK);
                return false;
            }
            if (regexName.IsMatch(textBoxFirstName.Text))
            {
                MessageBox.Show("Имя не должно содержать запрещенные символы", caption, MessageBoxButtons.OK);
                return false;
            }
            if (regexName.IsMatch(textBoxLastName.Text))
            {
                MessageBox.Show("Фамилия не должна содержать запрещенные символы", caption, MessageBoxButtons.OK);
                return false;
            }
            if (checkedListBoxRoles.SelectedItems.Count < 1)
            {
                MessageBox.Show("Как минмиум одна роль должна быть выбрана", caption, MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

    }
}

  
