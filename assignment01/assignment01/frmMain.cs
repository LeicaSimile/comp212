using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageSub_Click(object sender, EventArgs e)
        {
            frmSubscribe fs = new frmSubscribe();
            fs.Owner = this;
            fs.ShowDialog();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            frmPublish fp = new frmPublish();
            fp.ShowDialog();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            // Check if subscriptions are empty before enabling btnManageSub
            if (!Subscriptions.subEmail.Any() && !Subscriptions.subMobile.Any())
            {
                btnPublishNotification.Enabled = false;
            }
            else
            {
                btnPublishNotification.Enabled = true;
            }
        }
    }
}
