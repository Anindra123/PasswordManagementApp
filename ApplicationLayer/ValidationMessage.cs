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
    public partial class ValidationMessage : Form
    {

        public static DialogResult QuestionMsg(string msg)
        {
            DialogResult r = MessageBox.Show(msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return r;
        }

        public static DialogResult SucessMsgResult(string msg)
        {
            DialogResult r = MessageBox.Show(msg, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return r;
        }

        public static void AlertMsg(string msg)
        {
            MessageBox.Show(msg,"Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        public static DialogResult SucessMsg(string msg)
        {
            DialogResult r = MessageBox.Show(msg, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return r;
        }

    }
}
