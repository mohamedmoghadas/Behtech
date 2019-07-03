using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class FactorOrder : BaseEntity
    {
        public string FactorCode { get; set; }
        public Nullable<long> PrCount { get; set; }
        public Nullable<long> CustomerId { get; set; }
        public string DiscountCode { get; set; }
        public Nullable<int> DiscountPercent { get; set; }
        public Nullable<bool> StateDelete { get; set; }
        public Nullable<long> TotalPrice { get; set; }
    }
}
