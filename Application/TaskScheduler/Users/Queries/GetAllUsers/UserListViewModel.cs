using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TaskScheduler.Users.Queries.GetAllUsers
{
    public class UserListViewModel
    {
        public IEnumerable<UserDto> Users { get; set; }
    }
}
