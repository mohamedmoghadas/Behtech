using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class SampleWorks : BaseEntity
    {
       
        public string Subject { get; set; }
        public string Name { get; set; }
        public Nullable<long> IdProjectType { get; set; }
       
        public string Image { get; set; }

        public virtual ProjectType ProjectType { get; set; }
    }
}
