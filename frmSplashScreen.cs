using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaraAlvaroProjectA
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timLoading_Tick(object sender, EventArgs e)
        {
            pnlBar.Width += 100;
            if(pnlBar.Width >= 1000)
            {
                timLoading.Stop();
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }
    }
}
