using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class WorkingDay : BaseEntity
    {
      
        public Nullable<System.DateTime> DayWork { get; set; }
        public Nullable<long> Iduser { get; set; }
    }
}
