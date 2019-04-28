using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Emails
    {
        public string from_address { get; set; }
        public string to_address { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public Nullable<DateTime> received_date { get; set; }
    }
}
