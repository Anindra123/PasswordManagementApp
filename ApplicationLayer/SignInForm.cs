using BussinessLogicLayer;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class SignInForm : Form
    {

        readonly bool login = false;
        readonly int curr_masterAccID;
        public MasterAccModel MasterAcc { get; private set; } = null;
        public SignInForm()
        {
            InitializeComponent();
        }
        public SignInForm(bool login)
        {

            InitializeComponent();
            this.login = login;
            this.Text = "Login";
            forgotPassLinkLabel.Visible = false;
            signUpLinkLabel.Visible = false;
            signInBtn.Text = "Log In";
        }
        public SignInForm(bool login, int curr_masterAccID)
        {

            InitializeComponent();
            this.login = login;
            this.Text = "Login";
            forgotPassLinkLabel.Visible = false;
            signUpLinkLabel.Visible = false;
            signInBtn.Text = "Log In";
            this.curr_masterAccID = curr_masterAccID;
        }
        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Tag = this;
            signUpForm.Show(this);
            Hide();
        }
        private void ResetFeilds()
        {
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrWhiteSpace(emailTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text.Trim()))
            {
                ValidationMessage.AlertMsg("Text feild cannot be empty");

                output = false;
            }
            else if (Regex.IsMatch(emailTextBox.Text.Trim(), Patterns.MailPattern) == false)
            {
                ValidationMessage.AlertMsg("Email is invalid");

                output = false;
            }
            else if (passwordTextBox.Text.Trim().Length > 8)
            {
                ValidationMessage.AlertMsg("Password can be maximum 8 characters long");

                output = false;
            }
            return output;
        }
        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login == false)
            {
                var form = (StartForm)Tag;
                form.Show();
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                SQLiteConnector db = new SQLiteConnector();
                MasterAcc = db.SignIn(emailTextBox.Text.Trim(), passwordTextBox.Text.Trim());

                if (MasterAcc != null && login == true && curr_masterAccID == MasterAcc.id)
                {
                    DialogResult r = MessageBox.Show("User validated sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        Close();
                    }
                }
                else if (MasterAcc != null && login == false)
                {
                    MessageBox.Show("Logged in sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserDashBoardForm userDashBoard = new UserDashBoardForm(MasterAcc);
                    userDashBoard.Tag = this;
                    userDashBoard.Show(this);
                    Hide();

                }
                else
                {
                    MessageBox.Show("Email or password is invalid or account doesn't exist.Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetFeilds();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (login == false)
            {
                var form = (StartForm)Tag;
                form.Show();
                Close();
            }
            Close();
        }

        private void forgotPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm forgotPassForm = new ForgotPassForm();
            forgotPassForm.Tag = this;
            forgotPassForm.Show(this);
            Hide();
        }
    }
}
