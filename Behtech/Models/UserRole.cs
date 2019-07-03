using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behtech.Models
{
    public class UserRole : BaseEntity
    {
      
        public long UserId { get; set; }
        public long RoleId { get; set; }
    }
}
