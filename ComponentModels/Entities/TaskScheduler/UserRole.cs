using System;
using System.Collections.Generic;
using System.Text;

namespace ArcsimPlatform.ComponentModels.Entities.TaskScheduler
{
    public class UserRole
    {
      public int Id { get; set; }
      public int UserId { get; set; }
      public virtual User User { get; set; }
      public int RoleId { get; set; }
      public virtual Role Role { get; set; }
    }
}
