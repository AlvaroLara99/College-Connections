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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                DLL.AccountInfo(lblIDText, lblFirstNameText, lblLastNameText, lblAgeText, lblStateText, lblCityText, lblAddressText, lblZipText, lblGradText, lblWorkText, lblSalaryText, lblEducationText, lblStoryText, pbxPhoto);
                hlpStudent.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Unexpected Error Occured (Student).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mnuStudent_Click(object sender, EventArgs e)
        {
            DLL.CloseDisposeDatabase();
            this.Close();
        }

        private void mnuItmChat_Click(object sender, EventArgs e)
        {
            frmChat chat = new frmChat();
            chat.ShowDialog();
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpStudent.HelpNamespace);
        }
    }
}
