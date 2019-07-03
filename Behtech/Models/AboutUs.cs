using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class AboutUs : BaseEntity
    {
        public string BehtechHistory { get; set; }
        public string BehtechDescription { get; set; }
        public string BehtechDepartment { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        public virtual Languages Languages { get; set; }
    }
}
