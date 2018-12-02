using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.TaskScheduler.Users.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArcsimPlatform.HedgingGUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<UserListViewModel> Get(CancellationToken cancellationtoken)
        {
            return _mediator.Send(new GetAllUsersQuery());
        }
    }
}
