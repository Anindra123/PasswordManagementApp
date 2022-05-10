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
    public partial class ViewUserAccountForm : Form
    {
        readonly MasterAccModel _masterAccModel;
        public ViewUserAccountForm()
        {
            InitializeComponent();
        }
        public ViewUserAccountForm(MasterAccModel masterAccModel)
        {
            InitializeComponent();
            this._masterAccModel = masterAccModel;
        }

        private void ViewUserAccountForm_Load(object sender, EventArgs e)
        {
            fullNameLabel.Text = $" {_masterAccModel.firstname} {_masterAccModel.lastname}";
            mailLabel.Text = $"{_masterAccModel.email}";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
