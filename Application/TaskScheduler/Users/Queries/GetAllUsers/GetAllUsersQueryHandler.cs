using ArcsimPlatform.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.TaskScheduler.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, UserListViewModel>
    {
        private readonly TaskSchedulerDbContext _context;

        public GetAllUsersQueryHandler(TaskSchedulerDbContext context)
        {
            _context = context;
        }

        public async Task<UserListViewModel> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var model = new UserListViewModel
            {
                Users = await _context.User
                    .Select(UserDto.Projection)
                    .OrderBy(p => p.Name)
                    .ToListAsync(cancellationToken)
            };

            return model;
        }
    }
}
