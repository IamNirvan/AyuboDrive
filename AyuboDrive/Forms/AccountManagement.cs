using AyuboDrive.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Forms
{
    public partial class AccountManagement : AyuboDriveTemplateForm
    {
        private string _userID;
        private string _userName;
        private string _firstName;
        private string _lastName;
        private string _imagePath;
        private string _initialEmailAddress;
        private string _newEmailAddress = "";
        private bool _updatePassword = false;
        private string _key;
        private bool _includeImage = false;

        public AccountManagement(DashboardForm dashboardForm, string userName) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            _userName = userName;
            AddData();
            LoadProfileImage();
            DisableInputs();
            DisableSecretKeyObjects();
            DisableImagePathObjects();

            // Set the event handler programmatically in order to prevent
            // triggering the text changed event after AddData() executes
            EmailTxtBox.TextChanged += new EventHandler(EmailTxtBox_TextChanged);
        }
        //
        // Mouse enter and leave event handlers
        //
        private void DeleteBtn_MouseEnter(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Properties.Settings.Default.RED;
            DeleteBtn.ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void DeleteBtn_MouseLeave(object sender, EventArgs e)
        {
            DeleteBtn.BackColor = Properties.Settings.Default.TRANSPARENT;
            DeleteBtn.ForeColor = Properties.Settings.Default.RED;
        }
        //
        // Click event handlers
        //
        private void ImagePathBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = "c://",
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path
                    _imagePath = openFileDialog.FileName;
                    ImagePathTxtBox.Text = _imagePath;
                    LoadProfileImage();
                }
            }
        }

        private void PasswordMask_Click(object sender, EventArgs e)
        {
            if (_updatePassword)
            {
                _updatePassword = false;
                PasswordTxtBox.PasswordChar = '*';
                PasswordMask.BackgroundImage = Properties.Resources.PasswordVisibleBlack16;
            }
            else
            {
                _updatePassword = true;
                PasswordTxtBox.PasswordChar = (char)0;
                PasswordMask.BackgroundImage = Properties.Resources.PasswordInvisibleBlack16;
            }
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            _newEmailAddress = EmailTxtBox.Text;

            if (ValidateInput(_newEmailAddress))
            {
                if (DeliverKey())
                {
                    EnableSecretKeyObjects();
                    KeyTxtBox.Focus();
                }
                else
                {
                    EmailTxtBox.Text = _initialEmailAddress;
                }
                ResetSecretKeyObjects();
            }
        }
        //
        // Utility
        //
        private void AddData()
        {
            DataRow record = QueryHandler.SelectQueryHandler($"SELECT * FROM userAccount WHERE " +
                $"userName = '{_userName}'").Rows[0];
            _userID = record[0].ToString();
            UserNameTxtBox.Text = record[1].ToString();
            PasswordTxtBox.Text = record[2].ToString();
            FirstNameTxtBox.Text = record[3].ToString();
            _firstName = record[3].ToString();
            LastNameTxtBox.Text = record[4].ToString();
            _lastName = record[4].ToString();
            ImagePathTxtBox.Text = record[5].ToString();
            _imagePath = record[5].ToString();
            EmailTxtBox.Text = record[6].ToString();
            _initialEmailAddress = record[6].ToString();
        }

        private void LoadProfileImage()
        {
            ProfileImagePicBox.BackgroundImageLayout = ImageLayout.Zoom;

            if (File.Exists(_imagePath))
            {
                ProfileImagePicBox.BackgroundImage = Image.FromFile(_imagePath);
            }
            else
            {
                ProfileImagePicBox.BackgroundImage = Properties.Resources.DefaultUserBlack128Px;
            }
        }

        private void DisableInputs()
        {
            UserNameTxtBox.Enabled = false;
            UserNameErrorLbl.Text = "";
            UserNamePnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;

            FirstNameTxtBox.Enabled = false;
            FirstNameErrorLbl.Text = "";
            FirstNamePnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;

            LastNameTxtBox.Enabled = false;
            LastNameErrorLbl.Text = "";
            LastNamePnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;

            PasswordTxtBox.Enabled = false;
            PasswordErrorLbl.Text = "";
            PasswordPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;

            PasswordMask.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            PasswordMask.FlatAppearance.BorderColor = Properties.Settings.Default.DISABLED_WHITE;
            PasswordMask.Enabled = false;
            
            UploadImageCheckBox.Enabled = false;

            VerifyBtn.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            VerifyBtn.FlatAppearance.BorderColor = Properties.Settings.Default.DISABLED_WHITE;
            VerifyBtn.Enabled = false;

            EmailTxtBox.Enabled = false;
            EmailErrLbl.Text = "";
            EmailPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private void EnableInputs()
        {
            UserNameTxtBox.Enabled = true;
            UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;

            FirstNameTxtBox.Enabled = true;
            FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;

            LastNameTxtBox.Enabled = true;
            LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;

            PasswordTxtBox.Enabled = true;
            PasswordPnl.BackColor = Properties.Settings.Default.PURPLE;

            PasswordMask.BackColor = Properties.Settings.Default.PURPLE;
            PasswordMask.FlatAppearance.BorderColor = Properties.Settings.Default.PURPLE;
            PasswordMask.Enabled = true;
            
            UploadImageCheckBox.Enabled = true;

            EmailTxtBox.Enabled = true;
            EmailErrLbl.Text = "";
            EmailPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void DisableVerifyBtn()
        {
            VerifyBtn.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            VerifyBtn.FlatAppearance.BorderColor = Properties.Settings.Default.DISABLED_WHITE;
            VerifyBtn.Enabled = false;
        }

        private void EnableVerifyBtn()
        {
            VerifyBtn.BackColor = Properties.Settings.Default.PURPLE;
            VerifyBtn.FlatAppearance.BorderColor = Properties.Settings.Default.PURPLE;
            VerifyBtn.Enabled = true;
        }

        private void DisableImagePathObjects()
        {
            ImagePathBtn.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathBtn.FlatAppearance.BorderColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathBtn.Enabled = false;

            ImagePathErrorLbl.Text = "";
            ImagePathPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathTxtBox.Enabled = false;
            ImagePathTxtBox.Text = "";
        }

        private void EnableImagePathObjects()
        {
            ImagePathBtn.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathBtn.FlatAppearance.BorderColor = Properties.Settings.Default.PURPLE;
            ImagePathBtn.Enabled = true;

            ImagePathErrorLbl.Text = "";
            ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathTxtBox.Enabled = true;
            ImagePathTxtBox.Text = "";
        }

        private void EnableSecretKeyObjects()
        {
            KeyTxtBox.Enabled = true;
            KeyPnl.Enabled = true;
            KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
            KeyErrLbl.Enabled = true;
        }

        private void DisableSecretKeyObjects()
        {
            KeyTxtBox.Enabled = false;
            KeyTxtBox.ForeColor = Properties.Settings.Default.DISABLED_WHITE;
            KeyPnl.Enabled = false;
            KeyPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            KeyErrLbl.Enabled = false;
        }

        private bool ValidateInput(string userName, string firstName, string lastName, string password, string imagePath, string emailAddress)
        {
            bool validUserName = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validPassword = false;
            bool validImagePath = false;
            bool validEmail = false;

            if(userName.Equals(_userName))
            {
                validUserName = true;
                UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                UserNameErrorLbl.Text = "";
            }
            else if (ValidationHandler.ValidateInputLength(userName))
            {
                validUserName = true;
                UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                UserNameErrorLbl.Text = "";

                if (ValidationHandler.CheckUserNamePresence(userName))
                {
                    validUserName = false;
                    UserNamePnl.BackColor = Properties.Settings.Default.RED;
                    UserNameErrorLbl.Text = "Username is already taken";
                }
            }
            else
            {
                UserNamePnl.BackColor = Properties.Settings.Default.RED;
                UserNameErrorLbl.Text = "Invalid username.";
            }

            if(ValidationHandler.ValidateInputLength(firstName))
            {
                validFirstName = true;
                FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                FirstNameErrorLbl.Text = "";
            }
            else
            {
                FirstNamePnl.BackColor = Properties.Settings.Default.RED;
                FirstNameErrorLbl.Text = "Invalid first name";
            }

            if(ValidationHandler.ValidateInputLength(userName))
            {
                validLastName = true;
                LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
                LastNameErrorLbl.Text = "";
            }
            else
            {
                LastNamePnl.BackColor = Properties.Settings.Default.RED;
                LastNameErrorLbl.Text = "Invalid last name";
            }

            if(ValidationHandler.ValidatePassword(password))
            {
                validPassword = true;
                PasswordPnl.BackColor = Properties.Settings.Default.PURPLE;
                PasswordErrorLbl.Text = "";
            }
            else
            {
                PasswordPnl.BackColor = Properties.Settings.Default.RED;
                PasswordErrorLbl.Text = "Password is weak";
            }

            if(!_includeImage)
            {
                validImagePath = true;
            }
            else if (ValidationHandler.ValidateFilePath(imagePath))
            {
                validImagePath = true;
                ImagePathPnl.BackColor = Properties.Settings.Default.PURPLE;
                ImagePathErrorLbl.Text = "";
            }
            else
            {
                ImagePathPnl.BackColor = Properties.Settings.Default.RED;
                ImagePathErrorLbl.Text = "Invalid image path";
            }

            if (_initialEmailAddress.Equals(emailAddress))
            {
                validEmail = true;
                EmailPnl.BackColor = Properties.Settings.Default.PURPLE;
                EmailErrLbl.Text = "";
            }
            else
            {
                if (!ValidationHandler.ValidateEmailAddress(emailAddress))
                {
                    EmailPnl.BackColor = Properties.Settings.Default.RED;
                    EmailErrLbl.Text = "Invalid NIC";
                }
                else
                {
                    validEmail = true;
                }
            }

            //if (ValidationHandler.ValidateInputLength(emailAddress))
            //{
            //    if (ValidationHandler.ValidateEmailAddress(emailAddress))
            //    {
            //        validEmail = true;
            //        EmailPnl.BackColor = Properties.Settings.Default.PURPLE;
            //        EmailErrLbl.Text = "";
            //    }
            //    else
            //    {
            //        EmailPnl.BackColor = Properties.Settings.Default.RED;
            //        EmailErrLbl.Text = "Email address already exists";
            //    }
            //}
            //else
            //{
            //    EmailPnl.BackColor = Properties.Settings.Default.RED;
            //    EmailErrLbl.Text = "Invalid email";
            //}
            return validUserName && validFirstName && validLastName && validPassword 
                && validImagePath && validEmail;
        }

        private bool ValidateInput(string emailAddress)
        {
            bool validEmail = false;

            if (ValidationHandler.ValidateInputLength(emailAddress))
            {
                if (ValidationHandler.ValidateEmailAddress(emailAddress))
                {
                    validEmail = true;
                    EmailPnl.BackColor = Properties.Settings.Default.PURPLE;
                    EmailErrLbl.Text = "";
                }
                else
                {
                    EmailPnl.BackColor = Properties.Settings.Default.RED;
                    EmailErrLbl.Text = "Email address already exists";
                }
            }
            else
            {
                EmailPnl.BackColor = Properties.Settings.Default.RED;
                EmailErrLbl.Text = "Invalid email";
            }
            return validEmail;
        }

        private void ResetErrors()
        {
            UserNameErrorLbl.Text = "";
            UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            FirstNameErrorLbl.Text = "";
            FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            LastNameErrorLbl.Text = "";
            LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            PasswordErrorLbl.Text = "";
            PasswordPnl.BackColor = Properties.Settings.Default.PURPLE;
        }

        private void Reset()
        {
            UserNameTxtBox.Text = "";
            UserNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            UserNameErrorLbl.Text = "";

            FirstNameTxtBox.Text = "";
            FirstNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            FirstNameErrorLbl.Text = "";

            LastNameTxtBox.Text = "";
            LastNamePnl.BackColor = Properties.Settings.Default.PURPLE;
            LastNameErrorLbl.Text = "";

            PasswordTxtBox.Enabled = false;
            PasswordPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            PasswordTxtBox.Text = "";
        }

        private void ResetSecretKeyObjects()
        {
            KeyTxtBox.Text = "";
            KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
            KeyErrLbl.Text = "";
        }

        private bool DeliverKey()
        {
            _key = Viper.GenerateKey();
            bool emailSent = new PostMan().DeliverKey(_firstName, _lastName, _newEmailAddress, _key);

            if (emailSent)
            {
                EnableSecretKeyObjects();
                MessagePrinter.PrintToMessageBox("The secret key was sent to the following email address\n" +
                    $"{_newEmailAddress}.", "Secret key sent successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessagePrinter.PrintToMessageBox("A problem occurred when sending your secret key." +
                    "\nPlease seek assistance from your superior and try again later",
                    "Failed to send secret key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return emailSent;
        }
        //
        // Data manipulation event handlers
        //
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxtBox.Text;
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string imagePath = ImagePathTxtBox.Text;
            string emailAddress = EmailTxtBox.Text;

            if (ValidateInput(userName, firstName, lastName, password, imagePath, emailAddress))
            {
                User user = new User(userName, password, firstName, lastName, _imagePath, emailAddress);

                if (user.Update(_userID))
                {
                    MessagePrinter.PrintToMessageBox("Account were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    base.DashboardForm = new DashboardForm(user);
                    // Do this to update the old user name in the class and therefore be able to add data correctly
                    _userName = userName; 
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to update account details", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AddData();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ResetErrors();
            DialogResult result = MessagePrinter.PrintToMessageBoxV2("Are you sure you want to delete this account?", 
                "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (User.Delete(_userID))
                {
                    MessagePrinter.PrintToMessageBox("Account was successfully deleted", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    new LoginFormV2().Show();
                    Hide();
                }
                else
                {
                    MessagePrinter.PrintToMessageBox("Failed to delete your account", "Operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        // Checkbox check changed event handler
        //
        private void EnableUpdateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(EnableUpdateCheckbox.Checked)
            {
                UpdateBtn.Enabled = true;
                EnableInputs();
            }
            else
            {
                UpdateBtn.Enabled = false;
                DisableInputs();
            }
        }
        //
        // text box enter and leave event handlers
        //
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.ENABLED_WHITE;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Properties.Settings.Default.DISABLED_WHITE;
        }
        // 
        // Text box key press event handler
        //
        private void CharacterOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }
        //
        // Textbox text changed event handler
        //
        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTxtBox.Text == _initialEmailAddress)
            {
                UpdateBtn.Enabled = true;
                DisableVerifyBtn();
            }
            else
            {
                UpdateBtn.Enabled = false;
                // Enable the verify button when the email address changes
                EnableVerifyBtn();
            }
        }

        private void KeyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTxtBox.Text.Length == _key.Length)
            {
                KeyTxtBox.Enabled = false;

                if (KeyTxtBox.Text != _key)
                {
                    KeyPnl.BackColor = Properties.Settings.Default.RED;
                    KeyErrLbl.Text = "Invalid key";

                    DialogResult confirmation = MessagePrinter.PrintToMessageBoxV2("You entered an invalid key." +
                        "Do you want to resend the key?", "Resend confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        ResetSecretKeyObjects();
                        DeliverKey();
                    }
                    else
                    {
                        ResetSecretKeyObjects();
                        DisableSecretKeyObjects();
                        EmailTxtBox.Text = _initialEmailAddress;
                    }
                }
                else
                {
                    KeyPnl.BackColor = Properties.Settings.Default.PURPLE;
                    KeyErrLbl.Text = "";
                    DisableSecretKeyObjects();
                    UpdateBtn.Enabled = true;
                    _initialEmailAddress = _newEmailAddress;
                }
            }
        }

        private void UploadImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(UploadImageCheckBox.Checked)
            {
                _includeImage = true;
                EnableImagePathObjects();
            } 
            else
            {
                _includeImage = false;
                DisableImagePathObjects();
            }
        }
    }
}
