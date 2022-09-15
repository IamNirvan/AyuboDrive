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
    public partial class AccountRegistrationFormV2 : AyuboDriveTemplateForm
    {
        private string _firstName;
        private string _lastName;
        private string _imagePath = "";
        private string _key;
        private bool _maskPassword = false;

        public AccountRegistrationFormV2(Form loginForm) : base(loginForm)
        {
            InitializeComponent();
            HandleTitleBar();
            DisableImagePathObjects();
            DisableSecretKeyObjects();
        }
        //
        // Click event handlers
        //
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

        private void ImagePathBtn_Click(object sender, EventArgs e)
        {
            _imagePath = FileRetriever.GetFilePath();
            ImagePathTxtBox.Text = _imagePath;
        }

        private void SecretKeyBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string userName = UserNameTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string imagePath = ImagePathTxtBox.Text;

            if (ValidateInput(userName, firstName, lastName, password, imagePath))
            {
                DeliverKey();
                SecretKeyBtn.Text = "Resend secret key";
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            if (new User(userName, password, _firstName, _lastName, _imagePath).Insert())
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
                MessagePrinter.PrintToMessageBox($"An expected problem kept your account from being created\n" +
                    "Seek assitance from your superior and try again later", "Operation failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        // Textbox text changed event handlers
        //
        private void KeyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTxtBox.Text.Length == _key.Length)
            {
                KeyTxtBox.Enabled = false;

                if (KeyTxtBox.Text != _key)
                {
                    KeyPnl.BackColor = Properties.Settings.Default.RED;
                    KeyErrorLbl.Text = "Invalid key";

                    DialogResult confirmation = MessagePrinter.PrintToMessageBoxV2("You entered an invalid key." +
                        "Do you want to resend the key?", "Resend confirmation", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        KeyTxtBox.Text = "";
                        KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
                        KeyErrorLbl.Text = "";
                        DeliverKey();
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
                    SecretKeyBtn.Visible = false;
                    SignUpBtn.Focus();
                }
            }
        }
        //
        // Utility
        //
        private void DeliverKey()
        {
            _key = Viper.GenerateKey();
            SimpleEmailSender simpleEmailSender = new SimpleEmailSender();
            bool emailSent = simpleEmailSender.SendEmail(
                "Secret key",
                $"Hello,\n\n" +
                "You received this mail because a request was made to create an account for AyuobDrive.\n\n" +
                "Please use this secret key to finish creating the account.\n" +
                $"Secret key: {_key}"
            );

            if (emailSent)
            {
                EnableSecretKeyObjects();

                MessagePrinter.PrintToMessageBox("The secret key was sent to the following email address\n" +
                    $"{Properties.Settings.Default.RECEIVER_EMAIL}.", "Secret key sent successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessagePrinter.PrintToMessageBox("A problem occurred when sending your secret key." +
                    "\nPlease seek assistance from your superior and try again later", 
                    "Failed to send secret key", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Mask the password
            PasswordMask.PerformClick();

            ImagePathTxtBox.Text = "";
            ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathErrorLbl.Text = "";

            KeyTxtBox.Text = "";
            KeyErrorLbl.Text = "";
            DisableSecretKeyObjects();

            SecretKeyBtn.Text = "Send secret key";
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
        
        private void DisableImagePathObjects()
        {
            ImagePathPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathBtn.Enabled = false;
            ImagePathBtn.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathBtn.FlatAppearance.BorderColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathErrorLbl.Text = "";
        }

        private void EnableImagePathObjects()
        {
            ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathBtn.Enabled = true;
            ImagePathBtn.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathBtn.FlatAppearance.BorderColor = Properties.Settings.Default.PURPLE;
            ImagePathErrorLbl.Text = "";
        }
        
        private bool ValidateInput(string userName, string firstName, string lastName, string password, string imagePath)
        {
            bool validFirstName = false;
            bool validLastName = false;
            bool validUserName = false;
            bool validPassword = false;
            bool validFilePath = false;

            if (ValidationHandler.ValidateInputLength(firstName))
            {
                validFirstName = true;
                _firstName = firstName;
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                FirstNameErrorLbl.Text = "";
            }
            else
            {
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
                FirstNameErrorLbl.Text = "Invalid first name";
            }

            if (ValidationHandler.ValidateInputLength(lastName))
            {
                validLastName = true;
                _lastName = lastName;
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                LastNameErrorLbl.Text = "";
            }
            else
            {
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
                LastNameErrorLbl.Text = "Invalid last name";
            }

            if (ValidationHandler.ValidateInputLength(userName))
            {
                if(!ValidationHandler.CheckUserNamePresence(userName))
                {
                    validUserName = true;
                    UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                    UserNameErrorLbl.Text = "";
                }
                else
                {
                    UserNamePnl.BackColor = Properties.Settings.Default.RED;
                    UserNameErrorLbl.Text = "User name is already taken";
                }
            }
            else
            {
                UserNamePnl.BackColor = Properties.Settings.Default.RED;
                UserNameErrorLbl.Text = "Invalid user name";
            }

            if (ValidationHandler.ValidatePassword(password))
            {
                validPassword = true;
                PasswordPnl.BackColor = Properties.Settings.Default.PURPLE;
                PasswordErrorLbl.Text = "";
            }
            else
            {
                PasswordPnl.BackColor = Properties.Settings.Default.RED;
                PasswordErrorLbl.Text = "Insufficient password length";
            }

            if(UploadImageCheckBox.Checked)
            {
                if (ValidationHandler.ValidateFilePath(imagePath))
                {
                    validFilePath = true;
                    ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
                    ImagePathErrorLbl.Text = "";
                }
                else
                {
                    ImagePathPnl.BackColor = Properties.Settings.Default.RED;
                    ImagePathErrorLbl.Text = "Invalid file path";
                }
            }
            else
            {
                validFilePath = true;
            }
            return validUserName && validFirstName && validLastName && validPassword && validFilePath;
        }
        //
        // Checkbox check changed event handler
        //
        private void UploadImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(UploadImageCheckBox.Checked)
            {
                EnableImagePathObjects();
            }
            else
            {
                DisableImagePathObjects();
            }
        }
        // 
        // Text box key press event handler
        //
        private void CharacterOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }
    }
}
