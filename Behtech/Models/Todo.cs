using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class Todo : BaseEntity
    {
       
        public string Text { get; set; }
        public string DateRemind { get; set; }
        public string DateEnd { get; set; }
        public string TimeInsert { get; set; }
        public string TimeRemind { get; set; }
        public string TimeEnde { get; set; }
        public string UserId { get; set; }
    }
}
