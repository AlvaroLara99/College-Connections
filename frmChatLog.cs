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
    public partial class frmChatLog : Form
    {
        public frmChatLog()
        {
            InitializeComponent();
        }

        private void frmChatLog_Load(object sender, EventArgs e)
        {
            ChatLogReport chat = new ChatLogReport();
            chat.SetDatabaseLogon("alarafa201392", "1638146");
            chat.Refresh();
            crvChat.ReportSource = chat;
        }
    }
}
