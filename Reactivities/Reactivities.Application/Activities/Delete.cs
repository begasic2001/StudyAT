using MediatR;
using Reactivities.Application.Core;
using Reactivities.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class Delete
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesContext _context;
            public Handler(ReactivitiesContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);
                if (activity == null) return null;

                _context.Remove(activity);
                var res = await _context.SaveChangesAsync() > 0;
                if (!res) return Result<Unit>.Failure("Failed to delete activity");
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}
