using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TaskScheduler.Users.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<UserListViewModel>
    {
    }
}
