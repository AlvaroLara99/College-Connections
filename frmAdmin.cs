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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                DLL.AccountInfo(lblIDText, lblFirstNameText, lblLastNameText, lblAgeText, lblStateText, lblCityText, lblAddressText, lblZipText, lblGradText, lblWorkText, lblSalaryText, lblEducationText, lblStoryText, pbxPhoto);
                hlpAdmin.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Unexpected Error Occured (Admin).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mnuItmEditStudent_Click(object sender, EventArgs e)
        {
            frmEditAccount edit = new frmEditAccount();
            edit.ShowDialog();
        }

        private void mnuAdminClose_Click(object sender, EventArgs e)
        {
            DLL.CloseDisposeDatabase();
            this.Close();
        }

        private void mnuItmChat_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.ShowDialog();
        }

        private void mnuItmChatLog_Click(object sender, EventArgs e)
        {
            frmChatLog chatLog = new frmChatLog();
            chatLog.ShowDialog();
        }

        private void mnuItmChangeLog_Click(object sender, EventArgs e)
        {
            frmChangeLog change = new frmChangeLog();
            change.ShowDialog();
        }

        private void mnuItmAdd_Click(object sender, EventArgs e)
        {
            frmAddAccount add = new frmAddAccount();
            add.ShowDialog();
        }

        private void mnuItmView_Click(object sender, EventArgs e)
        {
            frmViewProfiles view = new frmViewProfiles();
            view.ShowDialog();
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpAdmin.HelpNamespace);
        }
    }
}
