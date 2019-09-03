using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GProject.Core.Storage;
using AutoMapper;
using GProject.Core.Domain;
using GProject.Core.Features.User.Models;

namespace GProject.Core.Features.User
{
    public class ListAssignments
    {
        public class Query : IRequest<IList<AssignmentModel>>
        {
            public int UserId { get; set; }
        }
        
        public class QueryHandler : IRequestHandler<Query, IList<AssignmentModel>>
        {
            private readonly IUserRepository _repository;

            public QueryHandler(IUserRepository repository)
            {
                _repository = repository;
            }
            

            async Task<IList<AssignmentModel>> IRequestHandler<Query, IList<AssignmentModel>>.Handle(Query request, CancellationToken cancellationToken)
            {
                var theList = await _repository.GetAssignments(request.UserId);

                return Mapper.Map<IList<AssignmentModel>>(theList, opts => opts.Items[nameof(AssignmentModel.UserId)] = request.UserId);
            }
        }
    }

}
