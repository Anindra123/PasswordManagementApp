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
        public UserDashBoardForm()
        {
            InitializeComponent();
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
            }
        }

        private void storeNewPassBtn_Click(object sender, EventArgs e)
        {
            StoreNewPassForm storeNewPass = new StoreNewPassForm();
            DialogResult r = storeNewPass.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                ResetView();
            }
        }

        private void UserDashBoardForm_Load(object sender, EventArgs e)
        {
            ResetView();
        }

        private void passDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('●', e.Value.ToString().Length);
            }
        }
    }
}
