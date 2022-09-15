using AyuboDrive.Interfaces;
using AyuboDrive.Utility;
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
    public partial class LoginFormV2 : AyuboDriveTemplateForm
    {
        public string firstName;
        public string lastName;
        private bool _maskPassword = false;

        public LoginFormV2() : base(Properties.Settings.Default.TRANSPARENT)
        {
            InitializeComponent();
            HandleTitleBar();
            imagePanel.BringToFront();
        }
        //
        // Text box enter and leave event handlers
        //
        protected void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        protected void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
        //
        // Utility 
        //
        private bool ValidateInput(string userName, string password)
        {
            bool validUserName = false;
            bool validPassword = false;

            if(ValidationHandler.ValidateInputLength(userName))
            {
                validUserName = true;
                userNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                userNameErrorLbl.Text = "";

                if (!ValidationHandler.CheckUserNamePresence(userName))
                {
                    userNamePnl.BackColor = Properties.Settings.Default.RED;
                    userNameErrorLbl.Text = "User name does not exist";
                }  
            }
            else
            {
                userNamePnl.BackColor = Properties.Settings.Default.RED;
                userNameErrorLbl.Text = "Invalid user name";
            }

            if (ValidationHandler.ValidatePassword(password))
            {
                validPassword = true;
                passwordPnl.BackColor = Properties.Settings.Default.PURPLE;
                passwordErrorLbl.Text = "";
            }
            else
            {
                passwordPnl.BackColor = Properties.Settings.Default.RED;
                passwordErrorLbl.Text = "Invalid password";
            }

            return validUserName && validPassword;
        }
        //
        // Click event handlers
        //
        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            new AccountRegistrationFormV2(this).Show();
            Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            if (ValidateInput(userName, password))
            {
                User user = User.Login(userName, password);

                if (user != null)
                {
                    new DashboardForm(user.FirstName, user.LastName, userName).Show();
                    Hide();
                    user = null;
                }
                else
                {
                    MessageBox.Show("Sorry... We failed to log you into your account.\n" +
                        "Please try re-entering your credentials or seek assitance from your superior",
                        "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PasswordMask_Click(object sender, EventArgs e)
        {
            if (_maskPassword)
            {
                _maskPassword = false;
                PasswordTxtBox.PasswordChar = '*';
                PasswordMask.BackgroundImage = Properties.Resources.PasswordVisibleBlack16;
            }
            else
            {
                _maskPassword = true;
                PasswordTxtBox.PasswordChar = (char)0;
                PasswordMask.BackgroundImage = Properties.Resources.PasswordInvisibleBlack16;
            }
        }
    }
}
