using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment01
{
    public class Publisher
    {
        public delegate void PublishMessageDel(string msg);
        public PublishMessageDel publishmsg = null;

        public void PublishMessage(string message)
        {
            publishmsg.Invoke(message);
        }
    }
}
