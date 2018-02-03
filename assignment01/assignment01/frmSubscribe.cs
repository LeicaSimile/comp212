using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace assignment01
{
    public partial class frmSubscribe : Form
    {
        public frmSubscribe()
        {
            InitializeComponent();
        }

        private bool IsEmail(string email)
        {
            try
            {
                // Must have @ followed by . at some point
                return email.Split('@')[1].Contains(".");
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        private bool IsPhone(string phone)
        {
            // Remove non-numeric characters from string
            phone = Regex.Replace(phone, @"\D", "");

            // Min length 5, max length 15
            return (5 <= phone.Length && phone.Length <= 15);
        }

        private bool IsDuplicate(string item, List<string> list)
        {
            return false;
        }

        private bool IsValid()
        {
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;

            if (!IsEmail(email))
            {
                lblError.Text += "Email is not valid. ";
            }

            if (!IsPhone(mobile))
            {
                lblError.Text += "Mobile number is not valid.";
            }

            // TODO: Check duplicates

            return true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                chkEmail.CheckState = CheckState.Checked;
            }
            else
            {
                chkEmail.CheckState = CheckState.Unchecked;
            }
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtMobile.Text))
            {
                chkMobile.CheckState = CheckState.Checked;
            }
            else
            {
                chkMobile.CheckState = CheckState.Unchecked;
            }
        }
    }

}
