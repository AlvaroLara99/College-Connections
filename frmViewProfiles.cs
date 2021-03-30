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
    public partial class frmViewProfiles : Form
    {
        public frmViewProfiles()
        {
            InitializeComponent();
        }

        CurrencyManager accountManager;


        private void frmViewProfiles_Load(object sender, EventArgs e)
        {
            try
            {
                DLL.LoadAll(lblIDText, lblFirstNameText, lblLastNameText, lblAgeText, lblStateText, lblCityText, lblAddressText, lblZipText, lblGradText, lblWorkText, lblSalaryText, lblEducationText, lblStoryText, pbxPhoto);
                hlpProfile.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";
                accountManager = (CurrencyManager)this.BindingContext[DLL.Account];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Unexpected Error Occured (View Account).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SetText()
        {
            //Sets a counter at the top of the form 
            this.Text = "College Connections - Profile " + (accountManager.Position + 1).ToString() + " of " + accountManager.Count.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Brings the user to the first entry
            if (accountManager.Position == 0)
            {
                //If the user has reached the first entry it will play a noise letting the user know they have reached the end
                Console.Beep();
            }
            accountManager.Position = 0;
            SetText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Brings the user to the next entry
            if (accountManager.Position == accountManager.Count - 1)
            {
                //If the user has reached the last entry it will play a noise letting the user know they have reached the end
                Console.Beep();
            }
            accountManager.Position++;
            SetText();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (accountManager.Position == accountManager.Count - 1)
            {
                //If the user has reached the last entry it will play a noise letting the user know they have reached the end
                Console.Beep();
            }
            accountManager.Position = accountManager.Count - 1;
            SetText();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Brings the user to the previous entry
            if (accountManager.Position == 0)
            {
                //If the user has reached the first entry it will play a noise letting the user know they have reached the end
                Console.Beep();
            }
            accountManager.Position--;
            SetText();
        }

        private void mnuItmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpProfile.HelpNamespace);
        }
    }
}
