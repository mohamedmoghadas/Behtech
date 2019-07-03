using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Discount : BaseEntity
    {
        public string Code { get; set; }
        public Nullable<int> DPercent { get; set; }
        public Nullable<int> NumberOfUseg { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<long> CustomerId { get; set; }
        public Nullable<long> ProjectId { get; set; }
        public string Discription { get; set; }
        public string Title { get; set; }
    }
}
