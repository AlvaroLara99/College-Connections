using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeConnectionDLL;

namespace LaraAlvaroProjectA
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            try
            {
                DLL.LoadMessages(dgvChat);
                hlpChat.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Unexpected Error Occured (Chat).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DLL.LogMessage(txtMessage.Text);
            dgvChat.DataBindings.Clear();
            DLL.LoadMessages(dgvChat);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
        }

        private void mnuItmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpChat.HelpNamespace);
        }
    }
}
