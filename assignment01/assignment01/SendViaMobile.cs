using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment01
{
    public class SendViaMobile
    {
        private String CellPhone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            CellPhone = phone;
        }

        private void sendMessage(string msg)
        {
            MessageBox.Show(String.Format("Texted {0}: '{1}'", CellPhone, msg));
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }
    }
}
