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

        public LoginFormV2() : base(Properties.Settings.Default.TRANSPARENT)
        {
            InitializeComponent();
            HandleTitleBar();
            imagePanel.BringToFront();
        }

        // -- USER NAME TEXT BOX FUNCTIONALITY --

        private void UserNameTxtBox_Enter(object sender, EventArgs e)
        {
            userNameTxtBox.ForeColor = Program.ENABLED_WHITE;
        }

        private void UserNameTxtBox_Leave(object sender, EventArgs e)
        {
            userNameTxtBox.ForeColor = Program.DISABLED_WHITE;
        }

        // -- END OF USER NAME TEXT BOX FUNCTIONALITY --

        // -- PASSWORD TEXT BOX FUNCTIONALITY --

        private void PasswordTxtBox_Enter(object sender, EventArgs e)
        {
            passwordTxtBox.ForeColor = Program.ENABLED_WHITE;
        }

        private void PasswordTxtBox_Leave(object sender, EventArgs e)
        {
            passwordTxtBox.ForeColor = Program.DISABLED_WHITE;
        }

        // -- END OF PASSWORD TEXT BOX FUNCTIONALITY --

        // -- SIGN UP LABEL FUNCTIONALITY --

        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            new AccountRegistrationForm().Show();
            Hide();
        }

        // -- END OF SIGN UP LABEL FUNCTIONALITY --
        
        // -- LOGIN LABEL FUNCTIONALITY --

        private void LoginLbl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, LoginLbl.DisplayRectangle, Program.PURPLE, ButtonBorderStyle.Solid);
        }

        private void LoginLbl_MouseLeave(object sender, EventArgs e)
        {
            LoginLbl.BackColor = Program.TRANSPARENT;
            LoginLbl.ForeColor = Program.PURPLE;
        }

        private void LoginLbl_MouseEnter(object sender, EventArgs e)
        {
            LoginLbl.BackColor = Program.PURPLE;
            LoginLbl.ForeColor = Program.ENABLED_WHITE;
        }

        private void LoginLbl_MouseDown(object sender, MouseEventArgs e)
        {
            LoginLbl.BackColor = Program.LIGHT_PURPLE;
        }

        private void LoginLbl_MouseUp(object sender, MouseEventArgs e)
        {
            LoginLbl.BackColor = Program.TRANSPARENT;
        }

        private void LoginLbl_Click(object sender, EventArgs e)
        {
            string userName = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;
            bool validUserName = false;
            bool validPassword = false;

            if (userName.Length == 0)
            {
                validUserName = false;
                this.userNamePnl.BackColor = Properties.Settings.Default.RED;
                this.userNameErrorLbl.Text = "Invalid user name";
            }
            else
            {
                validUserName = true;
                this.userNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                this.userNameErrorLbl.Text = "";
            }

            if (password.Length == 0)
            {
                validPassword = false;
                this.passwordPnl.BackColor = Properties.Settings.Default.RED;
                this.passwordErrorLbl.Text = "Invalid password";
            }
            else
            {
                validPassword = true;
                this.passwordPnl.BackColor = Properties.Settings.Default.PURPLE;
                this.passwordErrorLbl.Text = "";
            }

            if (validUserName && validPassword)
            {
                User user = User.Login(userName, password);

                if (user != null)
                {
                    new DashboardForm(user.FirstName, user.LastName).Show();
                    this.Hide();
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
        
        // -- END OF LOGIN LABEL FUNCTIONALITY --
    }
}
