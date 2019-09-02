using AutoMapper;
using GProject.Core.Features.User.Models;
using GProject.Core.Storage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GProject.Core.Features.User
{
    public class GetSingle
    {
        public class Query : IRequest<UserModel>
        {
            public int UserId { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, UserModel>
        {
            private readonly IUserRepository _repository;

            public QueryHandler(IUserRepository repository)
            {
                _repository = repository;
            }

            public async Task<UserModel> Handle(Query request, CancellationToken cancellationToken)
            {
                var theList = await _repository.GetSingle(request.UserId);

                return Mapper.Map<UserModel>(theList);
            }
        }
    }
}
