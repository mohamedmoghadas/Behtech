using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class RelativeProjects : BaseEntity
    {
     
        public Nullable<long> IdProjectMain { get; set; }
        public Nullable<long> IdProjectSubMain { get; set; }

        public virtual Projects Projects { get; set; }
    }
}
