using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class LearningCustomerClass : BaseEntity
    {
        public long CustomerId { get; set; }
        public Nullable<long> IdLearning { get; set; }
        public Nullable<System.DateTime> DateRequest { get; set; }
        public Nullable<System.DateTime> DateAnswer { get; set; }
        public Nullable<long> IdStateLearning { get; set; }
        public string ReasonOfCanceletion { get; set; }
        public Nullable<System.DateTime> DateCancelation { get; set; }
        public Nullable<System.DateTime> dateFinish { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Learnings Learnings { get; set; }
        public virtual LearningState LearningState { get; set; }
    }
}
