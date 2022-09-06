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
    public partial class AccountRegistrationForm: Form
    {
        private string _firstName;
        private string _lastName;
        private string _key;

        public AccountRegistrationForm()
        {
            InitializeComponent();
            HandleTitleBar();
            DisableSecretKeyObjects();
        }

        // -- TITLE BAR BUTTON FUNCTIONALITY --

        private void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            new LoginFormV2().Show();
            Hide();
        }

        private void MinimizeBtn_MouseClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // -- END OF TITLE BAR BUTTON FUNCTIONALITY --

        private void HandleTitleBar()
        {
            CustomTitleBar customTitleBar = new CustomTitleBar(this, 30, Properties.Settings.Default.TRANSPARENT);
            customTitleBar.CreateExitButton(Properties.Settings.Default.TRANSPARENT,
                Properties.Settings.Default.ENABLED_WHITE);
            customTitleBar.CreateMinimizeButton(Properties.Settings.Default.TRANSPARENT,
                Properties.Settings.Default.DISABLED_WHITE);
            Panel titleBar = customTitleBar.GetTitleBar();
            Button exitButton = customTitleBar.GetExitButton();
            Button minimizeButton = customTitleBar.GetMinimizeButton();
            Controls.Add(titleBar);
            //titleBar.BringToFront();
            exitButton.MouseClick += new MouseEventHandler(ExitBtn_MouseClick);
            minimizeButton.MouseClick += new MouseEventHandler(MinimizeBtn_MouseClick);
        }

        private void HandleKeyDelivery()
        {
            _key = Viper.GenerateKey();
            SimpleEmailSender simpleEmailSender = new SimpleEmailSender("AyuboDrive");
            bool result = simpleEmailSender.SendEmail(
                "Secret key",
                $"Hello {_firstName} {_lastName},\nPlease use this secret key to finish creating your account.\n" +
                $"Secret key: {_key}"
            );

            if (result)
            {
                EnableSecretKeyObjects();

                MessagePrinter.PrintToMessageBox("We sent the secret key to the following email address\n" +
                    $"{ConfigurationHandler.GetReceiverEmail()}.", "Secret key sent successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessagePrinter.PrintToMessageBox($"Sorry {_firstName}, it seems like we ran into a " +
                    $"problem when sending your secret key.\nPlease seek assistance from your superior " +
                    $"and try again later", "Failed to send secret key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            FirstNameTxtBox.Text = "";
            FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            FirstNameErrorLbl.Text = "";

            LastNameTxtBox.Text = "";
            LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            LastNameErrorLbl.Text = "";

            UserNameTxtBox.Text = "";
            UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            UserNameErrorLbl.Text = "";

            PasswordTxtBox.Text = "";
            PasswordPnl.BackColor = Properties.Settings.Default.PURPLE;
            PasswordErrorLbl.Text = "";

            KeyTxtBox.Text = "";
            KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
            KeyErrorLbl.Text = "";

        }

        private void EnableSecretKeyObjects()
        {
            KeyTxtBox.Enabled = true;
            KeyPnl.Enabled = true;
            KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
            KeyErrorLbl.Enabled = true;
        }

        private void DisableSecretKeyObjects()
        {
            KeyTxtBox.Enabled = false;
            KeyPnl.Enabled = false;
            KeyPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            KeyErrorLbl.Enabled = false;
        }

        // -- FIRST NAME TEXT BOX FUNCTIONALITY --

        private void FirstNameTxtBox_Leave(object sender, EventArgs e)
        {
            FirstNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void FirstNameTxtBox_Enter(object sender, EventArgs e)
        {
            FirstNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        // -- END OF FIRST NAME TEXT BOX FUNCTIONALITY --

        // -- LAST NAME TEXT BOX FUNCTIONALITY --

        private void LastNameTxtBox_Leave(object sender, EventArgs e)
        {
            LastNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void LastNameTxtBox_Enter(object sender, EventArgs e)
        {
            LastNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        // -- END OF LAST NAME TEXT BOX FUNCTIONALITY --

        // -- USER NAME TEXT BOX FUNCTIONALITY --

        private void UserNameTxtBox_Leave(object sender, EventArgs e)
        {
            UserNameTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void UserNameTxtBox_Enter(object sender, EventArgs e)
        {
            UserNameTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        // -- END OF USER NAME TEXT BOX FUNCTIONALITY --

        // -- PASSWORD TEXT BOX FUNCTIONALITY --

        private void PasswordTxtBox_Leave(object sender, EventArgs e)
        {
            PasswordTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void PasswordTxtBox_Enter(object sender, EventArgs e)
        {
            PasswordTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        // -- END OF PASSWORD TEXT BOX FUNCTIONALITY --

        // -- KEY TEXT BOX FUNCTIONALITY --

        private void KeyTxtBox_Leave(object sender, EventArgs e)
        {
            KeyTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void KeyTxtBox_Enter(object sender, EventArgs e)
        {
            KeyTxtBox.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void KeyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTxtBox.Text.Length == _key.Length)
            {
                KeyTxtBox.Enabled = false;

                if (KeyTxtBox.Text != _key)
                {
                    KeyPnl.BackColor = Properties.Settings.Default.RED;
                    KeyErrorLbl.Text = "Invalid key";

                    DialogResult confirmation = MessagePrinter.PrintToMessageBoxV2("You entered an invalid key. Do you want to resend the key?",
                        "Resend confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        KeyTxtBox.Text = "";
                        KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
                        KeyErrorLbl.Text = "";
                        HandleKeyDelivery();
                    }
                    else
                    {
                        Reset();
                    }
                }
                else
                {
                    KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
                    KeyErrorLbl.Text = "";

                    GenerateKeyLbl.Visible = false;
                    SignUpLbl.Focus();
                }
            }
        }

        // -- END OF KEY TEXT BOX FUNCTIONALITY --


        // -- GENERATE KEY LABEL FUNCTIONALITY --

        private void GenerateKeyLbl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, GenerateKeyLbl.DisplayRectangle, Program.PURPLE, ButtonBorderStyle.Solid);
        }

        private void GenerateKeyLbl_Click(object sender, EventArgs e)
        {
            // Generate key button logic goes here...

            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string userName = UserNameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            bool validFirstName = false;
            bool validLastName = false;
            bool validUserName = false;
            bool validPassword = false;


            if(firstName.Length == 0)
            {
                validFirstName = false;
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
                FirstNameErrorLbl.Text = "Invalid first name";
            }
            else
            {
                validFirstName = true;
                _firstName = firstName;
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                FirstNameErrorLbl.Text = "";
            }

            if(lastName.Length == 0)
            {
                validLastName = false;
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
                LastNameErrorLbl.Text = "Invalid last name";
            }
            else
            {
                validLastName = true;
                _lastName = lastName;
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                LastNameErrorLbl.Text = "";
            }

            if (userName.Length == 0)
            {
                validUserName = false;
                UserNamePnl.BackColor = Properties.Settings.Default.RED;
                UserNameErrorLbl.Text = "Invalid user name";
            }
            else
            {
                validUserName = true;
                UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                UserNameErrorLbl.Text = "";
            }

            if (password.Length == 0)
            {
                validPassword = false;
                PasswordPnl.BackColor = Properties.Settings.Default.RED;
                PasswordErrorLbl.Text = "Invalid password";
            }
            else
            {
                validPassword = true;
                PasswordPnl.BackColor = Properties.Settings.Default.PURPLE;
                PasswordErrorLbl.Text = "";
            }

            if(validFirstName && validLastName && validUserName && validPassword)
            {
                HandleKeyDelivery();
            }
        }

        private void GenerateKeyLbl_MouseUp(object sender, MouseEventArgs e)
        {
            GenerateKeyLbl.BackColor = Properties.Settings.Default.TRANSPARENT;
        }

        private void GenerateKeyLbl_MouseDown(object sender, MouseEventArgs e)
        {
            GenerateKeyLbl.BackColor = Program.LIGHT_PURPLE;
        }

        private void GenerateKeyLbl_MouseLeave(object sender, EventArgs e)
        {
            GenerateKeyLbl.BackColor = Properties.Settings.Default.TRANSPARENT;
            GenerateKeyLbl.ForeColor = Properties.Settings.Default.PURPLE;
        }

        private void GenerateKeyLbl_MouseEnter(object sender, EventArgs e)
        {
            GenerateKeyLbl.BackColor = Properties.Settings.Default.PURPLE;
            GenerateKeyLbl.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        // -- END OF GENERATE KEY LABEL FUNCTIONALITY --

        
        // -- SIGN UP BUTTON FUNCTIONALITY --

        private void SignUpLbl_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text;
            string password = PasswordTxtBox.Text;
            User user = new User(userName, password, _firstName, _lastName);
            bool result = user.Insert();

            if(result)
            {
                MessagePrinter.PrintToMessageBox("Your account was successfully created.\n" +
                    "You can now log into your new account", "Operation successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                new LoginFormV2().Show();
                Hide();
            }
            else
            {
                MessagePrinter.PrintToMessageBox($"Sorry {_firstName}... an expected problem kept your account from being created\n" +
                    "Seek assitance from your superior and try again later", "Operation failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpLbl_MouseEnter(object sender, EventArgs e)
        {
            SignUpLbl.BackColor = Properties.Settings.Default.PURPLE;
            SignUpLbl.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void SignUpLbl_MouseLeave(object sender, EventArgs e)
        {
            SignUpLbl.BackColor = Properties.Settings.Default.TRANSPARENT;
            SignUpLbl.ForeColor = Properties.Settings.Default.PURPLE;
        }

        private void SignUpLbl_MouseUp(object sender, MouseEventArgs e)
        {
            SignUpLbl.BackColor = Properties.Settings.Default.TRANSPARENT;
        }

        private void SignUpLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SignUpLbl.BackColor = Program.LIGHT_PURPLE;
        }

        private void SignUpLbl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SignUpLbl.DisplayRectangle, Program.PURPLE, ButtonBorderStyle.Solid);
        }

        // -- END OF SIGN UP BUTTON FUNCTIONALITY --
    }
}
