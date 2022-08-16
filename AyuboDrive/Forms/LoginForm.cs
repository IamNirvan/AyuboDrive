using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Forms
{
    public partial class LoginForm : Form
    {
        private User AccountUser { get; set; }
        private QueryHandler queryHandler = new QueryHandler();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            new AccountRegistrationForm().Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;

            bool validUserName = false;
            bool validPassword = false;

            // Check the user name
            if (userName.Length == 0)
            {
                validUserName = false;
                this.userNamePanel.BackColor = Color.Red;
                this.userNameErrorLbl.Text = "Invalid user name";
            }
            else
            {
                validUserName = true;
                // Reset the color if the re-entered username is valid
                this.userNamePanel.BackColor = Color.DarkSlateBlue;                
                this.userNameErrorLbl.Text = "";
            }

            // Check the password
            if (password.Length == 0)
            {
                validPassword = false;
                this.passwordPanel.BackColor = Color.Red;
                this.passwordErrorLbl.Text = "Invalid password";
            }
            else
            {
                validPassword = true;
                this.passwordPanel.BackColor = Color.DarkSlateBlue;
                this.passwordErrorLbl.Text = "";
            }

            if (validUserName && validPassword)
            {
                AccountUser = User.Login(userName, password);

                if(AccountUser != null)
                {
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.SetAccountUser(AccountUser);
                    dashboard.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Login failed", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
