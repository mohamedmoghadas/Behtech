using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class DailyUserWorks : BaseEntity
    {
        public string DescriptiondailyUserWork { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
