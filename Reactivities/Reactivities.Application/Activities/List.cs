using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Activities
{
    public class List
    {
        public class Query : IRequest<Result<List<Activity>>> { }
        public class Handler : IRequestHandler<Query, Result<List<Activity>>>
        {
            private readonly ReactivitiesContext _context;

            public Handler(ReactivitiesContext context) {
                _context = context;
            }
            public async Task<Result<List<Activity>>> Handle(Query request,CancellationToken cancellationToken)
            {
                var res = await _context.Activities.ToListAsync();
                return Result<List<Activity>>.Success(res);
            }
        }
    }
}
