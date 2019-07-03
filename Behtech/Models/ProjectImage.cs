using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class ProjectImage : BaseEntity
    {
        public Nullable<long> IdProject { get; set; }
        public string Url { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
