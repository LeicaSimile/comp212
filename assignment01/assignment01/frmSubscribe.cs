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
            bool isValid = false;
            return isValid;
        }

        private bool IsPhone(string phone)
        {
            phone = Regex.Replace(phone, @"\D", "");
            return (5 <= phone.Length && phone.Length <= 15);
        }

        private bool IsDuplicate(string item, List<string> list)
        {
            return false;
        }
    }

}
