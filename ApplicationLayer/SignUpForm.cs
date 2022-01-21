using BussinessLogicLayer;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var form = (SignInForm)Tag;
            form.Show();
            Close();
        }
        private void ResetFeilds()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            cPasswordTextBox.Text = "";
        }
        private bool ValidateForm()
        {
            bool output = true;
            string mailPattern = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text.Trim())||
                string.IsNullOrWhiteSpace(passwordTextBox.Text.Trim())||
                string.IsNullOrWhiteSpace(cPasswordTextBox.Text.Trim())
                )
            {
                MessageBox.Show("Text feild cannot be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if (!Regex.IsMatch(emailTextBox.Text.Trim(),mailPattern)){

                MessageBox.Show("Email is invalid", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if(passwordTextBox.Text.Trim().Length > 8)
            {
                MessageBox.Show("Password can be maximum 8 characters long", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }
            else if(passwordTextBox.Text.Trim() != cPasswordTextBox.Text.Trim())
            {
                MessageBox.Show("Entered password doesn't match. Make sure you have entered the same password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
            }

            return output;

        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MasterAccModel masterAcc = new MasterAccModel();
                masterAcc.firstname = firstNameTextBox.Text.Trim();
                masterAcc.lastname = lastNameTextBox.Text.Trim();
                masterAcc.email = emailTextBox.Text.Trim();
                masterAcc.master_password = HashPasswordLogic.HashPass(passwordTextBox.Text.Trim());

                foreach (var db in GlobalConfig.dBConnections)
                {
                    db.SignUp(masterAcc);
                }
                DialogResult r = MessageBox.Show("Signed Up sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(r == DialogResult.OK)
                {
                    ResetFeilds();
                    // sends the user back to the signinform
                    // TODO:    consider creating a single method since this
                    //          logic is being repeated in this file
                    var form = (SignInForm)Tag;
                    form.Show();
                    Close();
                }
            }
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (SignInForm)Tag;
            form.Show();
        }
    }
}
