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
    public partial class frmPublish : Form
    {
        public frmPublish()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            Subscriptions.pub.PublishMessage(txtNotification.Text);
        }
    }
}
