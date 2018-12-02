using System;
using System.Linq.Expressions;
using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;

namespace Application.TaskScheduler.Users.Queries.GetAllUsers
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Team { get; set; }

        public static Expression<Func<User, UserDto>> Projection
        {
            get
            {
                return p => new UserDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    LastName = p.LastName,
                    FirstName = p.FirstName,
                    Team = p.Team
                };
            }
        }

        public static UserDto Create(User user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
