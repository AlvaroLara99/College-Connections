using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeConnectionDLL;

namespace LaraAlvaroProjectA
{
    public partial class frmEditAccount : Form
    {
        public frmEditAccount()
        {
            InitializeComponent();
        }

        CurrencyManager accountManager;

        bool edit;
        byte[] image = null;
        bool valid = true;
        bool validPhoto = true;

        public void Enable()
        {
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtState.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtZip.ReadOnly = false;
            txtGradutated.ReadOnly = false;
            txtWork.ReadOnly = false;
            txtSalary.ReadOnly = false;
            txtEducation.ReadOnly = false;
            txtStory.ReadOnly = false;

            mnuItmClose.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        public void Disable()
        {
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtState.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtZip.ReadOnly = true;
            txtGradutated.ReadOnly = true;
            txtWork.ReadOnly = true;
            txtSalary.ReadOnly = true;
            txtEducation.ReadOnly = true;
            txtStory.ReadOnly = true;

            mnuItmClose.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnSavePhoto.Enabled = false;
        }

        public void ClearData()
        {
            txtID.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            txtState.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtZip.DataBindings.Clear();
            txtGradutated.DataBindings.Clear();
            txtAdmin.DataBindings.Clear();
            txtWork.DataBindings.Clear();
            txtSalary.DataBindings.Clear();
            txtEducation.DataBindings.Clear();
            txtStory.DataBindings.Clear();
            txtShare.DataBindings.Clear();
            pbxPhoto.DataBindings.Clear();

            DLL.LoadAccounts(txtID, txtPassword, txtFirstName, txtLastName, txtAge, txtState, txtCity, txtAddress, txtZip, txtGradutated, txtAdmin, txtWork, txtSalary, txtEducation, txtStory, txtShare, pbxPhoto);
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            try
            {
                DLL.LoadAccounts(txtID, txtPassword, txtFirstName, txtLastName, txtAge, txtState, txtCity, txtAddress, txtZip, txtGradutated, txtAdmin, txtWork, txtSalary, txtEducation, txtStory, txtShare, pbxPhoto);
                hlpEdit.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";
                accountManager = (CurrencyManager)this.BindingContext[DLL.Account];
                txtID.Enabled = false;
                txtFirstName.Focus();
                Disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Unexpected Error Occured (Edit Account).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SetText()
        {
            //Sets a counter at the top of the form 
            this.Text = "College Connection - Account " + (accountManager.Position + 1).ToString() + " of " + accountManager.Count.ToString();
        }

        private void mnuEditClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable();
            DLL.LogChanges(txtID.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text, txtState.Text, txtCity.Text, txtAddress.Text, txtZip.Text, txtGradutated.Text, txtAdmin.Text, txtWork.Text, txtSalary.Text, txtEducation.Text, txtStory.Text, txtShare.Text);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtState.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtZip.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtSalary.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtWork.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtEducation.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtStory.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (valid == true)
            {
                edit = true;
            }

            if (edit == true)
            {
                try
                {
                    DLL.EditInfo(txtID.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text, txtState.Text, txtCity.Text, txtAddress.Text, txtZip.Text, txtWork.Text, txtSalary.Text, txtEducation.Text, txtStory.Text);
                    DLL.LogChanges(txtID.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text, txtState.Text, txtCity.Text, txtAddress.Text, txtZip.Text, txtGradutated.Text, txtAdmin.Text, txtWork.Text, txtSalary.Text, txtEducation.Text, txtStory.Text, txtShare.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An unexpected error occured while saving changes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please make sure there is no empty information.");
            }
            MessageBox.Show("Save successful!");
            Disable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete current student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DLL.DeleteAccount(txtID.Text);
                    MessageBox.Show("Successfully Deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An unexpected error occured while deleting.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ClearData();
                Disable();
                accountManager.Position = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                mnuItmClose.Enabled = true;
                txtID.Undo();
                txtFirstName.Undo();
                txtLastName.Undo();
                txtAge.Undo();
                txtState.Undo();
                txtCity.Undo();
                txtAddress.Undo();
                txtZip.Undo();
                txtGradutated.Undo();
                txtWork.Undo();
                txtSalary.Undo();
                txtEducation.Undo();
                txtStory.Undo();

                Disable();
                ClearData();
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog open = new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filePath = open.FileName;
                    image = File.ReadAllBytes(filePath);
                    pbxPhoto.ImageLocation = filePath.ToString();
                    pbxPhoto.Refresh();
                }
            }

            if (pbxPhoto.Image == null)
            {
                MessageBox.Show("Please select a picture");
            }
            else
            {
                btnSavePhoto.Enabled = true;
            }
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpEdit.HelpNamespace);
        }

        private void btnSavePhoto_Click(object sender, EventArgs e)
        {
            if (validPhoto == true)
            {
                try
                {
                    DLL.EditPhoto(txtID.Text, image);
                    DLL.LogChanges(txtID.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text, txtState.Text, txtCity.Text, txtAddress.Text, txtZip.Text, txtGradutated.Text, txtAdmin.Text, txtWork.Text, txtSalary.Text, txtEducation.Text, txtStory.Text, txtShare.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An unexpected error occured while saving changes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Disable();
            }
        }
    }
}
