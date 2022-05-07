using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public sealed class ValidationMessage:Form
    {
        public static void AlertMsg(string msg)
        {
            MessageBox.Show(msg, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void SucessMsg(string msg)
        {
            MessageBox.Show(msg, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult SucessMsgResult(string msg)
        {
            DialogResult r = MessageBox.Show(msg, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return r;
        }

        public static DialogResult QuestionMsg(string msg)
        {
           DialogResult r =  MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return r;
        }
    }
}
