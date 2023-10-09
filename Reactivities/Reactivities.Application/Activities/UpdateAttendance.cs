using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Domain;
using Reactivities.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class UpdateAttendance
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesContext _context;
            private readonly IUserAccessor _userAccessor;

            public Handler(ReactivitiesContext context, IUserAccessor userAccessor)
            {
                _context = context;
                _userAccessor = userAccessor;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                // Fetch the activity with the given ID from the database
                var activity = await _context.Activities
                    .Include(a => a.Attendees)
                    .ThenInclude(u => u.AppUser)
                    .SingleOrDefaultAsync(x => x.Id == request.Id);
                // Check if the activity with the specified ID exists
                if (activity == null) return null;// If not, return a null result or handle it appropriately (not shown)

                // Fetch the user based on their username
                var user = await _context.Users
                    .FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetUserName());

                // Check if the user exists
                if (user == null) return null;// If not, return a null result or handle it appropriately (not shown)

                // Fetch the host's username for the activity (if there is one)
                var hostUserName = activity.Attendees.FirstOrDefault(x => x.IsHost)?.AppUser?.UserName;

                // Fetch the attendance record for the user in the activity
                var attendance = activity.Attendees.FirstOrDefault(x => x.AppUser.UserName == user.UserName);

                // Update the attendance based on various conditions
                if (attendance != null && hostUserName == user.UserName)
                {
                    // If the user is the host, toggle the activity's cancellation status
                    activity.IsCancelled = !activity.IsCancelled;
                }

                if (attendance != null && hostUserName != user.UserName)
                {
                    // If the user is not the host, remove their attendance from the activity
                    activity.Attendees.Remove(attendance);
                }

                if (attendance == null)
                {
                    // If the user has no previous attendance, add a new attendance record
                    attendance = new ActivityAttendee
                    {
                        AppUser = user,
                        Activity = activity,
                        IsHost = false
                    };
                    activity.Attendees.Add(attendance);
                }
                var res = await _context.SaveChangesAsync() > 0;
                return res ? Result<Unit>.Success(Unit.Value) : Result<Unit>.Failure("Problem updating attendance");
            }
        }
    }
}
