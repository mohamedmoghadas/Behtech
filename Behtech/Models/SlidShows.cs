using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class SlidShows : BaseEntity
    {
     
        public string text { get; set; }
        public string image { get; set; }
        public Nullable<long> IdLanguage { get; set; }

        public virtual Languages Languages { get; set; }
    }
}
