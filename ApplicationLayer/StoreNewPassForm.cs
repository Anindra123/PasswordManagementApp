using BussinessLogicLayer;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class StoreNewPassForm : Form
    {
        readonly MasterAccModel masterAcc;
        public StoreNewPassForm()
        {
            InitializeComponent();
        }
        public StoreNewPassForm(MasterAccModel masterAcc)
        {
            InitializeComponent();
            this.masterAcc = masterAcc;
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (string.IsNullOrWhiteSpace(titleTextBox.Text.Trim())
                || string.IsNullOrWhiteSpace(passwordTextBox.Text.Trim()))
            {
                output = false;
            }
            if (!string.IsNullOrWhiteSpace(linkTextBox.Text.Trim())
                && (!Regex.IsMatch(linkTextBox.Text.Trim(), Patterns.MailPattern) &&
                    !Regex.IsMatch(linkTextBox.Text.Trim(), Patterns.UrlPattern))
                )
            {
                output = false;
            }
            return output;
        }

        private void savePassBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PassAccModel passAccModel = new PassAccModel();
                passAccModel.title = titleTextBox.Text.Trim();
                passAccModel.password = EncryptPass.Encrypt(passwordTextBox.Text.Trim(), masterAcc.master_password);
                passAccModel.link = linkTextBox.Text.Trim();
                passAccModel.m_id = masterAcc.id;

                bool duplicateAcc = false;

                SQLiteConnector db = new SQLiteConnector();
                duplicateAcc = db.VerifyStorePass(passAccModel);
                if (!duplicateAcc)
                {

                    db.StorePass(passAccModel);

                    DialogResult r = ValidationMessage.SucessMsgResult("Password stored sucessfully!");
                    if (r == DialogResult.OK)
                    {
                        Close();
                    }
                }
                else
                {

                    ValidationMessage.AlertMsg("A password for this account is already saved.Please save password for a different account.");
                }
            }
            else
            {

                ValidationMessage.AlertMsg("Form data given is invalid. Please check and try again.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
