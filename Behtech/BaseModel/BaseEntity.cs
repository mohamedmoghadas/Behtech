using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public bool StateDelete { get; set; }
        public DateTime? DateInsert { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateDelete { get; set; }

        public long IdUserInsert { get; set; }
        public long IdUserUpdate { get; set; }
        public long IdUserDelete { get; set; }


    }
}
