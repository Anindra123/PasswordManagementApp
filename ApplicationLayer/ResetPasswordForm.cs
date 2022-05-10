using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class ResetPasswordForm : Form
    {
        private readonly int u_id;
        public ResetPasswordForm()
        {
            InitializeComponent();
        }
        public ResetPasswordForm(int u_id)
        {
            InitializeComponent();
            this.u_id = u_id;
        }

        public void GoToSignIn()
        {
            Close();
            
        }
        public void GoToSignInOnClose()
        {
            var verficationCodeForm = (VerificationCodeForm)Tag;
            var forgetPassForm = (ForgotPassForm)verficationCodeForm.Tag;
            var signInForm = (SignInForm)forgetPassForm.Tag;
            forgetPassForm.Close();
            signInForm.Show();
        }
        private bool ValidateForm()
        {
            bool valid = true;
            string nMasterPass = nMasterPassword.Text.Trim();
            string cMasterPass = cMasterPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(nMasterPass) ||
                string.IsNullOrWhiteSpace(cMasterPass))
            {
                ValidationMessage.AlertMsg("Password feilds cannot be empty");
                valid = false;
            }
            else if (nMasterPass.Length > 8)
            {
                ValidationMessage.AlertMsg("Password can be maximum 8 characters long");
                valid = false;
            }
            else if (nMasterPass != cMasterPass)
            {
                ValidationMessage.AlertMsg("Password doesn't match");
                valid = false;
            }

            return valid;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string mPass = HashPasswordLogic.HashPass(nMasterPassword.Text.Trim());
                SQLiteConnector db = new SQLiteConnector();
                db.ResetMasterPass(u_id, mPass);
                DialogResult r = ValidationMessage.SucessMsgResult("Password Reseted Sucessfully");
                if (r == DialogResult.OK)
                {
                    GoToSignIn();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            GoToSignIn();
        }

        private void ResetPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GoToSignInOnClose();
        }
    }
}
