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
    public partial class VerificationCodeForm : Form
    {
        private readonly int _vcode;
        private readonly int _uid;
        public VerificationCodeForm()
        {
            InitializeComponent();
        }
        public VerificationCodeForm(int vcode, int uid)
        {
            InitializeComponent();
            this._vcode = vcode;
            this._uid = uid;
        }

        private bool ValidateForm()
        {
            bool valid = true;
            int val;
            string u_input = vcodeTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(u_input))
            {
                ValidationMessage.AlertMsg("Text feild cannot be empty");
                //MessageBox.Show("Text feild cannot be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }
            else if (int.TryParse(u_input, out val) == false)
            {

                ValidationMessage.AlertMsg("Invalid verification code");
                valid = false;
            }
            else if(this._vcode != val)
            {
                ValidationMessage.AlertMsg("Invalid verification code");
                valid = false;
            }
            return valid;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var form = new ResetPasswordForm(_uid);
                form.Tag = this;
                form.Show(this);
                Hide();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void VerificationCodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var forgotPassForm = (ForgotPassForm)Tag;
            var signInFrom = (SignInForm)forgotPassForm.Tag;
            signInFrom.Show();
        }
    }
}
