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

        public void ChangeForms(Control tag)
        {
            var form = tag;
            form.Show();
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            ChangeForms((SignInForm)Tag);
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

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(cPasswordTextBox.Text.Trim())
                )
            {
                ValidationMessage.AlertMsg("Text feild cannot be empty");

                output = false;
            }
            else if (!Regex.IsMatch(emailTextBox.Text.Trim(), Patterns.MailPattern))
            {

                ValidationMessage.AlertMsg("Email is invalid");

                output = false;
            }
            else if (passwordTextBox.Text.Trim().Length > 8)
            {
                ValidationMessage.AlertMsg("Password can be maximum 8 characters long");

                output = false;
            }
            else if (passwordTextBox.Text.Trim() != cPasswordTextBox.Text.Trim())
            {
                ValidationMessage.AlertMsg("Entered password doesn't match. Make sure you have entered the same password");

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

                bool multipleAcc = false;
                SQLiteConnector db = new SQLiteConnector();

                multipleAcc = db.VerifySignUp(masterAcc);
                if (!multipleAcc)
                {

                    db.SignUp(masterAcc);

                    DialogResult r = ValidationMessage.SucessMsgResult("Signed Up sucessfully");
                    if (r == DialogResult.OK)
                    {
                        ResetFeilds();
                        ChangeForms((SignInForm)Tag);
                    }
                }
                else
                {
                    ValidationMessage.AlertMsg("An account with same firstname/lastname/email/password already exist.Try again");

                    ResetFeilds();
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
