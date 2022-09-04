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
        private User userAccount { get; set; }
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
                userAccount = User.Login(userName, password);

                if(userAccount != null)
                {
                    new DashboardForm(userAccount).Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Login failed", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // -----------------------------------------------------------
        // Mouse enter and leave section
        // -----------------------------------------------------------

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Program.PURPLE;
            loginBtn.ForeColor = Program.ENABLED_WHITE;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Program.TRANSPARENT;
            loginBtn.ForeColor = Program.PURPLE;
        }

        // -----------------------------------------------------------
        // Change focus color section
        // -----------------------------------------------------------

        private void userNameTxtBox_Leave(object sender, EventArgs e)
        {
            userNameTxtBox.ForeColor = Program.DISABLED_WHITE;
        }

        private void userNameTxtBox_Enter(object sender, EventArgs e)
        {
            userNameTxtBox.ForeColor = Program.ENABLED_WHITE;
        }
        
        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            passwordTxtBox.ForeColor = Program.DISABLED_WHITE;
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            passwordTxtBox.ForeColor = Program.ENABLED_WHITE;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
