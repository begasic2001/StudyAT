using FluentValidation;
using MediatR;
using Reactivities.Application.Core;
using Reactivities.Domain;
using Reactivities.Persistence;
using System.Diagnostics.Metrics;

namespace Reactivities.Application.Activities
{
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Activity Activity { get; set; }
        }
        public class CommandValidtor : AbstractValidator<Command>
        {
            public CommandValidtor()
            {
                RuleFor(x => x.Activity).SetValidator(new ActivityValidator());
            }
        }
        public class Handler : IRequestHandler<Command,Result<Unit>>
        {
            private readonly ReactivitiesContext _context;
            public Handler(ReactivitiesContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.AddAsync(request.Activity);
                var res = await _context.SaveChangesAsync() > 0;
                if (!res) return Result<Unit>.Failure("Failed to create activity");
                return Result<Unit>.Success(Unit.Value);

            }
        }
    }
}
