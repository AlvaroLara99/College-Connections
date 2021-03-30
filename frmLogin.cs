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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                DLL.OpenDatabase();

                hlpLogin.HelpNamespace = Application.StartupPath + "\\HelpFile.chm";

                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Black;

                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Unexpected Error Occured (Login).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string choice = cbxType.Text;

            switch (choice)
            {
                case "Admin":
                    if(DLL.AdminLogin(txtUsername.Text, txtPassword.Text) == true)
                    {
                        frmAdmin admin = new frmAdmin();
                        admin.ShowDialog();
                    }
                    break;
                case "User":
                    if (DLL.UserLogin(txtUsername.Text, txtPassword.Text) == true)
                    {
                        frmStudent student = new frmStudent();
                        student.ShowDialog();
                    }
                    break;
            }
        }

        private void mnuItmAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void mnuItmHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpLogin.HelpNamespace);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
