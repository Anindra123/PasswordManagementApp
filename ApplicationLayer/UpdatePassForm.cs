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
    public partial class UpdatePassForm : Form
    {
        readonly PassAccModel _passAccModel;
        readonly MasterAccModel _masterAccModel;
        public UpdatePassForm()
        {
            InitializeComponent();
        }
        public UpdatePassForm(PassAccModel passAccModel,MasterAccModel masterAccModel)
        {
            InitializeComponent();
            this._passAccModel = passAccModel;
            this._masterAccModel = masterAccModel;
        }
       

        private void UpdatePassForm_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = _passAccModel.title;
            passwordTextBox.Text = _passAccModel.password;
            linkTextBox.Text = _passAccModel.link;
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

        private void updatePassBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PassAccModel passAccModel = new PassAccModel();
                passAccModel.id = _passAccModel.id;
                passAccModel.title = titleTextBox.Text.Trim();
                passAccModel.password = EncryptPass.Encrypt(passwordTextBox.Text.Trim(),
                    _masterAccModel.master_password);
                passAccModel.link = linkTextBox.Text.Trim();
                passAccModel.m_id = _masterAccModel.id;

                bool duplicateAcc = false;

                SQLiteConnector db = new SQLiteConnector();
                duplicateAcc = db.VerifyStorePass(passAccModel);
                if (!duplicateAcc)
                {

                    db.UpdatePass(passAccModel);

                    DialogResult r = ValidationMessage.SucessMsgResult("Password updated sucessfully!");
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
        
    }



}
