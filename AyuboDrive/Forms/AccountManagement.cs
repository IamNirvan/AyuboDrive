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
        private User _updatedUser;
        private string _imagePath;
        private bool _updatePassword = false;
        private DashboardForm _dashboardForm;

        public AccountManagement(DashboardForm dashboardForm, string userName) : base(dashboardForm)
        {
            InitializeComponent();
            HandleTitleBar();
            DisableInputs();
            _userName = userName;
            AddData();
            LoadProfileImage();
        }
        //
        // Title bar exit functionality
        //
        protected override void ExitBtn_MouseClick(object sender, EventArgs e)
        {
            if(_dashboardForm == null)
            {
                Application.Exit();
            }

            else if(_updatedUser != null)
            {
                _dashboardForm = new DashboardForm(_updatedUser.FirstName, _updatedUser.LastName, _updatedUser.UserName);
            }
            _dashboardForm.Show();
            Hide();
        }

        //
        // Mouse event handlers
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
        //
        // Utility
        //
        private void AddData()
        {
            DataRow record = queryHandler.SelectQueryHandler("SELECT * FROM userAccount WHERE userName = '"
                + _userName + "'").Rows[0];
            _userID = record[0].ToString();
            UserNameTxtBox.Text = record[1].ToString();
            PasswordTxtBox.Text = record[2].ToString();
            FirstNameTxtBox.Text = record[3].ToString();
            LastNameTxtBox.Text = record[4].ToString();
            ImagePathTxtBox.Text = record[5].ToString();
            _imagePath = record[5].ToString();
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

            ImagePathBtn.BackColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathBtn.FlatAppearance.BorderColor = Properties.Settings.Default.DISABLED_WHITE;
            ImagePathBtn.Enabled = false;

            ImagePathTxtBox.Enabled = false;
            ImagePathErrorLbl.Text = "";
            ImagePathPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
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

            ImagePathBtn.BackColor = Properties.Settings.Default.PURPLE;
            ImagePathBtn.FlatAppearance.BorderColor = Properties.Settings.Default.PURPLE;
            ImagePathBtn.Enabled = true;
            
            ImagePathErrorLbl.Text = "";
            ImagePathPnl.BackColor = Properties.Settings.Default.DISABLED_WHITE;
        }

        private bool ValidateInput(string userName, string firstName, string lastName, string password, string imagePath)
        {
            bool validUserName = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validPassword = false;
            bool validImagePath = false;

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
                PasswordErrorLbl.Text = "Insufficient password length";
            }

            if (ValidationHandler.ValidateFilePath(imagePath))
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
            return validUserName && validFirstName && validLastName && validPassword && validImagePath;
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

            if (ValidateInput(userName, firstName, lastName, password, imagePath))
            {
                if (new User(userName, password, firstName, lastName, _imagePath).Update(_userID))
                {
                    MessagePrinter.PrintToMessageBox("Account were successfully updated", "Operation successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Discard the character by setting handled to true
                e.Handled = true;
            }
        }
    }
}
