using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class CustomerProjectTicket : BaseEntity
    {
        public long CustomerId { get; set; }
        public long ProjectId { get; set; }
        public string TicketSubject { get; set; }
        public string TicketDescription { get; set; }
        public long UniteId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Projects Projects { get; set; }
        public virtual Unite Unite { get; set; }
    }
}
