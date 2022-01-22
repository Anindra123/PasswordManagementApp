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
        MasterAccModel masterAcc;
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
            string urlPattern = @"[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)";
            string mailPattern = @"^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (string.IsNullOrWhiteSpace(titleTextBox.Text.Trim())
                || string.IsNullOrWhiteSpace(passwordTextBox.Text.Trim()))
            {
                output = false;
            }
            if (!string.IsNullOrWhiteSpace(linkTextBox.Text.Trim())
                && (!Regex.IsMatch(linkTextBox.Text.Trim(), urlPattern) &&
                    !Regex.IsMatch(linkTextBox.Text.Trim(), mailPattern))
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

                var duplicateAcc = false;
                foreach (var db in GlobalConfig.dBConnections)
                {
                    duplicateAcc = db.VerifyStorePass(passAccModel);
                }
                if (!duplicateAcc)
                {
                    foreach (var db in GlobalConfig.dBConnections)
                    {
                        db.StorePass(passAccModel);
                    }
                    DialogResult r = MessageBox.Show("Password stored sucessfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("A password for this account is already saved.Please save password for a different account.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Form data given is invalid. Please check and try again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
