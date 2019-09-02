using GProject.Core;
using GProject.Core.Features.User;
using GProject.Core.Features.User.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GProject.Api.Controllers
{
    [RoutePrefix("api/v1/users")]
    [NotFoundActionFilter]
    public class UsersController : ApiController
    {
        private readonly IMediator _dispatcher;

        public UsersController(IMediator dispatcher)
        {
            _dispatcher = dispatcher;
        }

        // GET api/v1/users
        [Route("")]
        public async Task<IEnumerable<UserModel>> GetAsync()
        {
            var result = await _dispatcher.Send(new ListUsers.Query());

            return result;
        }
        
        // GET api/v1/users/{id}/assignments
        [Route("{id}/assignments")]
        public async Task<IEnumerable<AssignmentModel>> GetAssignments([FromUri]int id)
        {
            var user = await _dispatcher.Send(new GetSingle.Query { UserId = id });

            if (user == null)
            {
                // will be catch by the action filter and transformed into a 404
                return null;
            }

            var result = await _dispatcher.Send(new ListAssignments.Query{ UserId = id});

            return result;
        }
    }
}
