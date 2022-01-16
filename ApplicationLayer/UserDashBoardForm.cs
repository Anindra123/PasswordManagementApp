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
        MasterAccModel masterAcc;
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
            foreach (var db in GlobalConfig.dBConnections)
            {
                passAccModels = db.GetPassAcc();
            }
            if (passAccModels != null)
            {
                passDataGridView.DataSource = passAccModels;
                passDataGridView.ClearSelection();

            }
            passDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(passDataGridView_CellFormatting);
        }

        private void passDataGridView_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('●', e.Value.ToString().Length);
            }
        }

        private void storeNewPassBtn_Click(object sender, EventArgs e)
        {
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
            DialogResult r = MessageBox.Show("Are you sure ?. This is going to delete all information of this stored password.", "Confimr", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                if (passDataGridView.SelectedRows.Count >= 1)
                {
                    PassAccModel passAcc = passDataGridView.SelectedRows[0].DataBoundItem as PassAccModel;
                    if (passAcc != null)
                    {
                        foreach (var db in GlobalConfig.dBConnections)
                        {
                            db.RemovePass(passAcc);
                        }
                        r = MessageBox.Show("Password deleted sucessfully.");
                        if(r == DialogResult.OK)
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
            SignInForm loginForm = new SignInForm(true);
            
            DialogResult r = loginForm.ShowDialog();
            if(r == DialogResult.Cancel)
            {
                var output = loginForm.MasterAcc;
                if(output is MasterAccModel)
                {
                   if(passDataGridView.SelectedRows.Count >= 1)
                    {
                        PassAccModel passAcc = null;
                        var temp_data = passDataGridView.SelectedRows[0].DataBoundItem as PassAccModel;
                        foreach( var db in GlobalConfig.dBConnections)
                        {
                            passAcc = db.GetAccInfo(temp_data);
                        }
                        if (passAcc != null)
                        {
                            string e_pass = passAcc.password;
                            passAcc.password = EncryptPass.Decrypt(e_pass, output.master_password);
                            ViewPassForm viewPassForm = new ViewPassForm(passAcc);
                            DialogResult res = viewPassForm.ShowDialog();
                            if(res == DialogResult.Cancel)
                            {
                                ResetView();
                                DisableButton(false);
                            }
                        }
                    }
                }
            }
        }
    }
}
