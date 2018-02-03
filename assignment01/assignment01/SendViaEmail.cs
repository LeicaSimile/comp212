using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment01
{
    public class SendViaEmail
    {
        private String Email { get; set; }

        public SendViaEmail() { }

        public SendViaEmail(String email)
        {
            Email = email;
        }

        public void sendEmail(string msg)
        {
            MessageBox.Show(String.Format("Sent to {0}: '{1}'", Email, msg));
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }
    }
}
