using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GProject.Core.Storage;
using AutoMapper;
using GProject.Core.Features.User.Models;

namespace GProject.Core.Features.User
{
    public class ListUsers
    {
        public class Query : IRequest<IList<UserModel>>
        {
        }
        
        public class QueryHandler : IRequestHandler<Query, IList<UserModel>>
        {
            private readonly IUserRepository _repository;

            public QueryHandler(IUserRepository repository)
            {
                _repository = repository;
            }
            

            Task<IList<UserModel>> IRequestHandler<Query, IList<UserModel>>.Handle(Query request, CancellationToken cancellationToken)
            {
                var theList = _repository.GetAll();
                return Task.FromResult(Mapper.Map<IList<UserModel>>(theList));
            }
        }
    }

}
