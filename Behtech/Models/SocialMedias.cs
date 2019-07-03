using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class SocialMedias : BaseEntity
    {
        
        public Nullable<long> IdSocialNetwork { get; set; }
        public Nullable<long> IdAboutUs { get; set; }
        public Nullable<long> IdContactUs { get; set; }
        public Nullable<long> IdUser { get; set; }
        public Nullable<long> IdTeacher { get; set; }
    }
}
