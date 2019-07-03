using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Suggestion : BaseEntity
    {
        public string CustomerFullName { get; set; }
        public string CustomerEmail { get; set; }
        public string sug { get; set; }
        public string AnswerSuggestion { get; set; }
        public Nullable<System.DateTime> DateSuggestion { get; set; }
        public Nullable<System.DateTime> dateRespond { get; set; }
        public long UniteId { get; set; }

        public virtual Unite Unite { get; set; }
    }
}
