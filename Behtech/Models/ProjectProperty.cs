using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class ProjectProperty : BaseEntity
    {
        public Nullable<long> IdProject { get; set; }
        public Nullable<long> IdProperty { get; set; }
        public string Value { get; set; }
        public virtual Projects Projects { get; set; }
        public virtual Property Property { get; set; }
    }
}
