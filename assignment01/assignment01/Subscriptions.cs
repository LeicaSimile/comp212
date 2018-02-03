using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment01
{
    class Subscriptions
    {
        public static Dictionary<string, SendViaEmail> subEmail = new Dictionary<string, SendViaEmail>();
        public static Dictionary<string, SendViaMobile> subMobile = new Dictionary<string, SendViaMobile>();
        public static Publisher pub = new Publisher();
    }
}
