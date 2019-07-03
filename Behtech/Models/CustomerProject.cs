using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class CustomerProject : BaseEntity
    {
        public long CustomerId { get; set; }
        public long ProjectId { get; set; }
        public Nullable<System.DateTime> DateRequest { get; set; }
        public Nullable<System.DateTime> DateAnswer { get; set; }
        public Nullable<long> IdState { get; set; }
        public string DescriptionCustomerProject { get; set; }
        public string ReasonOfCanceletion { get; set; }
        public Nullable<System.DateTime> DateCancelation { get; set; }
        public Nullable<System.DateTime> DateFinish { get; set; }
        public string CustomerProjectFile { get; set; }
        public Nullable<long> FactorOrderCode { get; set; }
        public Nullable<long> FactorPaymentCode { get; set; }
        public Nullable<long> Count { get; set; }
        public Nullable<long> TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Projects Projects { get; set; }
        public virtual ProjectState ProjectState { get; set; }
    }
}
