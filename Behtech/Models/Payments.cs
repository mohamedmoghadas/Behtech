using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Payments : BaseEntity
    {
        public Nullable<long> RefrenceNumber { get; set; }
        public long SaleRefrenceId { get; set; }
        public string StatusPayment { get; set; }
        public Nullable<bool> PaymentFinished { get; set; }
        public Nullable<long> Amount { get; set; }
        public string BankName { get; set; }
        public long CusromerId { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
