using BussinessLogicLayer;
using DataAcessLayer;
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
    public partial class UpdateMasterAccForm : Form
    {
        readonly MasterAccModel _masterAccModel;
        public UpdateMasterAccForm()
        {
            InitializeComponent();
        }
        public UpdateMasterAccForm(MasterAccModel masterAccModel)
        {
            InitializeComponent();
            this._masterAccModel = masterAccModel;
        }

        private void UpdateMasterAccForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = _masterAccModel.firstname;
            lastNameTextBox.Text = _masterAccModel.lastname;
            emailTextBox.Text = _masterAccModel.email;
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text.Trim())
                )
            {
                ValidationMessage.AlertMsg("Text feild cannot be empty");
                output = false;
            }
           
            return output;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MasterAccModel masterAccModel = _masterAccModel;
                masterAccModel.firstname = firstNameTextBox.Text.Trim();
                masterAccModel.lastname = lastNameTextBox.Text.Trim();

                SQLiteConnector db = new SQLiteConnector();

                db.UpdateMasterAcc(masterAccModel);
                DialogResult r = ValidationMessage.SucessMsgResult("Account information update sucessfully ");
                if(r == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
