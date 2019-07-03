using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class ContactUs : BaseEntity
    {
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MapLocation { get; set; }
        public string Customername { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerSubject { get; set; }
        public string CustomerMessage { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        public virtual Languages Languages { get; set; }
    }
}
