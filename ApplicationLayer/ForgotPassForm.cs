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
using BussinessLogicLayer;
using DataAcessLayer;

namespace ApplicationLayer
{
    public partial class ForgotPassForm : Form
    {
        private MasterAccModel masterAcc;
        public ForgotPassForm()
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

        bool ValidateForm()
        {
            bool output = true;
            string emailText = sendPassTextBox.Text.Trim();
            SQLiteConnector db = new SQLiteConnector();
           

            if (emailText == String.Empty)
            {
                output = false;
                ValidationMessage.AlertMsg("Email feild cannot be empty");

            }
            else if (!Regex.IsMatch(emailText, Patterns.MailPattern))
            {
                output = false;
                ValidationMessage.AlertMsg("Not a proper mail");
            }
            else if(output == true)
            {
                masterAcc = db.ValidateMail(emailText);
                if (masterAcc == null)
                {
                    output = false;
                    ValidationMessage.AlertMsg("Account not found with this mail or invalid mail");

                }
            }
            
            return output;
        }

        private async void sendPassBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string mailText = sendPassTextBox.Text.Trim();
                try
                {
                    bool val = await MailService.SendMail(masterAcc);
                    MessageBox.Show($"{val}");
                }
                catch(Exception)
                {
                    ValidationMessage.AlertMsg("Error in sending verification code. Please try again later");
                }
                
            }   
        }

        private void ForgotPassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (SignInForm)Tag;
            form.Show();
        }
    }
}
