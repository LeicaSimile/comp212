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

        private bool IsValid(bool subscribe)
        {
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;
            bool isValid = true;
            lblError.Text = "";

            if (subscribe)
            {
                if (chkEmail.Checked)
                {
                    if (!IsEmail(email))
                    {
                        lblError.Text += "Email is not valid. ";
                        isValid = false;
                    }
                    else if (Subscriptions.subEmail.Keys.Contains(email))
                    {
                        lblError.Text += "Email is already subscribed.";
                        isValid = false;
                    }
                }
                
                if (chkMobile.Checked && !IsPhone(mobile))
                {
                    lblError.Text += "Mobile number is not valid.";
                    isValid = false;
                }
            }
            else // Unsubscribe
            {
                if (chkEmail.Checked && !Subscriptions.subEmail.Keys.Contains(email))
                {
                    lblError.Text += "Email not found.";
                    isValid = false;
                }
                if (chkMobile.Checked && !Subscriptions.subMobile.Keys.Contains(mobile))
                {
                    lblError.Text += "Mobile number not found.";
                    isValid = false;
                }
            }

            return isValid;
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

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (IsValid(true))
            {
                Subscribe();
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            if (IsValid(false))
            {
                Unsubscribe();
            }
        }

        private void Subscribe()
        {
            if (chkEmail.Checked)
            {
                string email = txtEmail.Text;
                SendViaEmail delEmail = new SendViaEmail(email);

                delEmail.Subscribe(Subscriptions.pub);
                MessageBox.Show(String.Format("{0} subscribed.", email));
            }

            if (chkMobile.Checked)
            {
                string mobile = txtMobile.Text;
                SendViaMobile delMobile = new SendViaMobile(mobile);
                
                delMobile.Subscribe(Subscriptions.pub);
                MessageBox.Show(String.Format("{0} subscribed.", mobile));
            }
        }

        private void Unsubscribe()
        {
            if (chkEmail.Checked)
            {
                string email = txtEmail.Text;
                Subscriptions.subEmail[email].Unsubscribe(Subscriptions.pub);
                MessageBox.Show(String.Format("{0} unsubscribed.", email));
            }

            if (chkMobile.Checked)
            {
                string mobile = txtMobile.Text;
                Subscriptions.subMobile[mobile].Unsubscribe(Subscriptions.pub);
                MessageBox.Show(String.Format("{0} unsubscribed.", mobile));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
