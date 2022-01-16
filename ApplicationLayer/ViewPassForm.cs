using BussinessLogicLayer;
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
    public partial class ViewPassForm : Form
    {
        PassAccModel passAcc;
        public ViewPassForm()
        {
            InitializeComponent();
        }

        public ViewPassForm(PassAccModel passAcc)
        {
            InitializeComponent();
            this.passAcc = passAcc;
        }
        public void ResetView()
        {
            titleLabel.Text = "none";
            websiteLinkLabel.Text = "none";
            passwordLabel.Text = "none";
        }
        private void ViewPassForm_Load(object sender, EventArgs e)
        {
            if(passAcc != null)
            {
                titleLabel.Text = passAcc.title;
                websiteLinkLabel.Text = passAcc.link;
                passwordLabel.Text = passAcc.password;

                
            }
        }

        private void copyClipboardBtn_Click(object sender, EventArgs e)
        {
            if(passAcc != null)
            {
                Clipboard.SetText(passAcc.password);
                MessageBox.Show("Password copied to clipboard sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
