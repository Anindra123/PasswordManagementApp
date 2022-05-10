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
    public partial class UserDashBoardForm : Form
    {
        readonly MasterAccModel masterAcc;
        public UserDashBoardForm()
        {
            InitializeComponent();
        }
        public UserDashBoardForm(MasterAccModel masterAcc)
        {
            InitializeComponent();
            this.masterAcc = masterAcc;
        }
        private void DisableButton(bool val)
        {
            deletePassBtn.Enabled = val;
            updatePassBtn.Enabled = val;
            viewSelectedPassBtn.Enabled = val;
        }
        private void ResetView()
        {
            List<PassAccModel> passAccModels = null;
            passDataGridView.DataSource = null;
            int count = 1;
            SQLiteConnector db = new SQLiteConnector();
            passAccModels = db.GetPassAcc(masterAcc.id);

            if (passAccModels != null)
            {
                passDataGridView.DataSource = passAccModels.Select(o => new { Sl = count++, Title = o.title, Link = o.link, Password = o.password, ID = o.id }).ToList();
                passDataGridView.AutoGenerateColumns = false;
                passDataGridView.Columns["ID"].Visible = false;
                passDataGridView.ClearSelection();

            }
            passDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(passDataGridView_CellFormatting);
        }

        private void passDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('●', e.Value.ToString().Length);
            }
        }

        private void storeNewPassBtn_Click(object sender, EventArgs e)
        {
            DisableButton(false);
            StoreNewPassForm storeNewPass = new StoreNewPassForm(this.masterAcc);
            DialogResult r = storeNewPass.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                ResetView();
            }
        }

        private void UserDashBoardForm_Load(object sender, EventArgs e)
        {
            ResetView();
            DisableButton(false);


        }

        private void deletePassBtn_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure ?. This is going to delete all information of this stored password.";
            DialogResult r = ValidationMessage.QuestionMsg(msg);
            if (r == DialogResult.Yes)
            {
                if (passDataGridView.SelectedRows.Count >= 1)
                {
                    int pass_id = (int)passDataGridView.SelectedRows[0].Cells[4].Value;
                    SQLiteConnector db = new SQLiteConnector();
                    PassAccModel passAcc = db.GetAccInfo(pass_id, masterAcc.id);

                    if (passAcc != null)
                    {
                        db.RemovePass(passAcc);
                        r = ValidationMessage.SucessMsgResult("Password deleted sucessfully");
                        if (r == DialogResult.OK)
                        {
                            ResetView();
                            DisableButton(false);
                        }
                    }
                }
            }


        }

        private void passDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableButton(true);
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserDashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (SignInForm)Tag;
            var mainform = (StartForm)form.Tag;
            mainform.Show();


        }

        private void viewSelectedPassBtn_Click(object sender, EventArgs e)
        {
            SignInForm loginForm = new SignInForm(true, masterAcc.id);

            DialogResult r = loginForm.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                var output = loginForm.MasterAcc;
                if (output is MasterAccModel && output.id == masterAcc.id)
                {
                    if (passDataGridView.SelectedRows.Count >= 1)
                    {
                        int pass_id = (int)passDataGridView.SelectedRows[0].Cells[4].Value;
                        SQLiteConnector db = new SQLiteConnector();
                        PassAccModel passAcc = db.GetAccInfo(pass_id, output.id);

                        if (passAcc != null)
                        {
                            string e_pass = passAcc.password;
                            passAcc.password = EncryptPass.Decrypt(e_pass, output.master_password);
                            ViewPassForm viewPassForm = new ViewPassForm(passAcc);
                            DialogResult res = viewPassForm.ShowDialog();
                            if (res == DialogResult.Cancel)
                            {
                                ResetView();
                                DisableButton(false);
                            }
                        }
                    }
                }

            }
        }

        private void updatePassBtn_Click(object sender, EventArgs e)
        {
            SignInForm loginForm = new SignInForm(true, masterAcc.id);

            DialogResult r = loginForm.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                var output = loginForm.MasterAcc;
                if (output is MasterAccModel && output.id == masterAcc.id)
                {
                    if (passDataGridView.SelectedRows.Count >= 1)
                    {
                        int pass_id = (int)passDataGridView.SelectedRows[0].Cells[4].Value;
                        SQLiteConnector db = new SQLiteConnector();
                        PassAccModel passAcc = db.GetAccInfo(pass_id, output.id);
                        if (passAcc != null)
                        {
                            string e_pass = passAcc.password;
                            passAcc.password = EncryptPass.Decrypt(e_pass, output.master_password);
                            UpdatePassForm updatePassForm = new UpdatePassForm(passAcc, output);
                            DialogResult res = updatePassForm.ShowDialog();
                            if (res == DialogResult.Cancel)
                            {
                                ResetView();
                                DisableButton(false);
                            }
                        }
                    }
                }
            }
        }

        private void updateAccountBtn_Click(object sender, EventArgs e)
        {
            UpdateMasterAccForm updateMasterAccForm = new UpdateMasterAccForm(masterAcc);
            DialogResult r = updateMasterAccForm.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                ResetView();
                DisableButton(false);
            }
        }

        private void viewAccountBtn_Click(object sender, EventArgs e)
        {
            ViewUserAccountForm viewUserAccount = new ViewUserAccountForm(masterAcc);
            DialogResult r = viewUserAccount.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                ResetView();
                DisableButton(false);

            }
        }
    }
}
