using MediatR;
using Reactivities.Domain;
using Reactivities.Persistence;
using System.Diagnostics.Metrics;

namespace Reactivities.Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ReactivitiesContext _context;
            public Handler(ReactivitiesContext context)
            {
                _context = context;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.AddAsync(request.Activity);
                await _context.SaveChangesAsync(); 

            }
        }
    }
}
