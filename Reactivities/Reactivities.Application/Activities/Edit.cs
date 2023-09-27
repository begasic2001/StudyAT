using AutoMapper;
using MediatR;
using Reactivities.Domain;
using Reactivities.Persistence;


namespace Reactivities.Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly ReactivitiesContext _context;
            private readonly IMapper _mapper;
            public Handler(ReactivitiesContext context,IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
               var activity = await _context.Activities.FindAsync(request.Activity.Id);
                _mapper.Map(request.Activity, activity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
