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
    public partial class frmChangeLog : Form
    {
        public frmChangeLog()
        {
            InitializeComponent();
        }

        private void frmChangeLog_Load(object sender, EventArgs e)
        {
            ChangeLogReport change = new ChangeLogReport();
            change.SetDatabaseLogon("alarafa201392", "1638146");
            change.Refresh();
            crvChangeLog.ReportSource = change;
        }
    }
}
