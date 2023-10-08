using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Activities
{
    public class List
    {
        public class Query : IRequest<Result<List<ActivityDto>>> { }
        public class Handler : IRequestHandler<Query, Result<List<ActivityDto>>>
        {
            private readonly ReactivitiesContext _context;
            private readonly IMapper _mapper;

            public Handler(ReactivitiesContext context ,IMapper mapper) {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Result<List<ActivityDto>>> Handle(Query request,CancellationToken cancellationToken)
            {
                var res = await _context.Activities
                    .ProjectTo<ActivityDto>(_mapper.ConfigurationProvider)
                    .ToListAsync();

                var activitiesToReturn = _mapper.Map<List<ActivityDto>>(res);
                return Result<List<ActivityDto>>.Success(activitiesToReturn);
            }
        }
    }
}
