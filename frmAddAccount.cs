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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        byte[] image = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string admin;
            string share;
            string graduated;
            bool valid = true;
            if(cbxAdmin.Text == "Yes")
            {
                admin = "1";
            }
            else
            {
                admin = "0";
            }
            if (cbxAdmin.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (cbxStory.Text == "Yes")
            {
                share = "1";
            }
            else
            {
                share = "0";
            }
            if (cbxStory.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (cbxGraduated.Text == "Yes")
            {
                graduated = "1";
            }
            else
            {
                graduated = "0";
            }
            if (cbxGraduated.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
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
            if(pbxPhoto.Image == null)
            {
                MessageBox.Show("Please make sure there is no empty information.");
                valid = false;
            }
            if(valid == true)
            {
                try
                {
                    DLL.AddAccount(txtID.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text, txtState.Text, txtCity.Text, txtAddress.Text, txtZip.Text, graduated, admin, txtWork.Text, txtSalary.Text, txtEducation.Text, txtStory.Text, image, share);
                    DLL.LogChanges(txtID.Text, txtFirstName.Text, txtLastName.Text, txtAge.Text, txtState.Text, txtCity.Text, txtAddress.Text, txtZip.Text, graduated, admin, txtWork.Text, txtSalary.Text, txtEducation.Text, txtStory.Text, share);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An unexpected error occured while adding the account.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Account added successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtState.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            txtZip.Clear();
            cbxGraduated.SelectedIndex = -1;
            cbxAdmin.SelectedIndex = -1;
            cbxStory.SelectedIndex =-1;
            txtWork.Clear();
            txtSalary.Clear();
            txtEducation.Clear();
            txtStory.Clear();
            pbxPhoto.Image = null;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog open = new OpenFileDialog())
            {
                if(open.ShowDialog() == DialogResult.OK)
                {
                    filePath = open.FileName;
                    image = File.ReadAllBytes(filePath);
                    pbxPhoto.ImageLocation = filePath.ToString();
                }
            }
        }

        private void mnuItmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpAdd.HelpNamespace);
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            hlpAdd.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";
        }
    }
}
