﻿using System;
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
    public partial class AccountRegistrationForm : Form
    {

        private QueryHandler queryHandler = new QueryHandler();
        private string OTP;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;

        public AccountRegistrationForm()
        {
            InitializeComponent();
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (User.RegisterAccount(firstName, lastName, userName, password))
            {
                new LoginForm().Show();
                this.Hide();
            } else
            {
                MessageBox.Show($"Sorry {firstName}, we failed to register your account", "Registration failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getOTPBtn_Click(object sender, EventArgs e)
        {
            firstName = firstNameTxtBox.Text;
            lastName = lastNameTxtBox.Text;
            userName = userNameTxtBox.Text;
            password = passwordTxtBox.Text;

            bool validUserName = false;
            bool validFirstName = false;
            bool validLastName = false;
            bool validPassword = false;

            // Check if the user name is taken
            string query = "SELECT * FROM User WHERE userName = '" + userName + "'";
            if (queryHandler.SelectQueryHandler(query).Rows.Count > 0)
            //if (false)
            {
                this.userNamePanel.BackColor = Color.Red;
                this.userNameErrorLbl.Text = "User name is unavailable";
            }
            else
            {
                // Reset the color if the re-entered username is valid
                this.userNamePanel.BackColor = Color.DarkSlateBlue;
                validUserName = true;
                this.userNameErrorLbl.Text = "";
            }

            // Check the first name
            if (firstName.Length == 0)
            {
                validFirstName = false;
                this.firstNamePanel.BackColor = Color.Red;
                this.firstNameErrorLbl.Text = "Invalid first name";
            }
            else
            {
                validFirstName = true;
                this.firstNamePanel.BackColor = Color.DarkSlateBlue;
                this.firstNameErrorLbl.Text = "";
            }

            // Check the last name
            if (lastName.Length == 0)
            {
                validLastName = false;
                this.lastNamePanel.BackColor = Color.Red;
                this.lastNameErrorLbl.Text = "Invalid last name";
            }
            else
            {
                validLastName = true;
                this.lastNamePanel.BackColor = Color.DarkSlateBlue;
                this.lastNameErrorLbl.Text = "";
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

            if (validFirstName && validLastName && validUserName && validPassword)
            {
                EmailSender emailSender = new EmailSender("shalinkulawardana@gmail.com", "shalinkulawardana@gmail.com", "Ayuobo Drive", "wuxrfgttqosyplba");
                OTP = KeyGenerator.GenerateKey();
                if(emailSender.SendEmail($"Here is your OTP", $"To finish creating your account, please use the following OTP: {OTP}"))
                {
                    MessageBox.Show("OTP was successfully generated. You should receive a mail shortly", "OTP sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Sorry. An error prevented the OTP from being sent.\nTry checking your network connection or notify your admin", "Failed to send OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OTPTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (OTPTxtBox.TextLength == OTP.Length)
            {
                OTPTxtBox.Enabled = false;

                if (OTPTxtBox.Text == OTP)
                {
                    MessageBox.Show("OTP is valid. You can proceed to sign up", "Valid OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getOTPBtn.Visible = false;
                }
                else
                {
                    MessageBox.Show("The OTP you entered was invalid", "Invalid OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OTPTxtBox.Enabled = true;
                    OTPTxtBox.Text = "";
                }
            }
        }
    }
}
