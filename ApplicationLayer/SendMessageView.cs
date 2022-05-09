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
    public partial class SendMessageView : Form
    {
        readonly string mailText;
        public SendMessageView()
        {
            InitializeComponent();
        }
        public SendMessageView(string mailText)
        {
            InitializeComponent();
            this.mailText = mailText;
            
        }

        private void SendMessageView_Load(object sender, EventArgs e)
        {
            titleText.Text = $"Sending verification code to mail {mailText}. Please wait...";
        }
    }
}
