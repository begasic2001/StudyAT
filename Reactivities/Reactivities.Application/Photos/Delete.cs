using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Persistence;

namespace Reactivities.Application.Photos
{
    public class Delete
    {
        public class Command : IRequest<Result<Unit>>
        {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesContext _dbContext;
            private readonly IPhotoAccessor _photoAccessor;
            private readonly IUserAccessor _userAccessor;

            public Handler(ReactivitiesContext dbContext,IPhotoAccessor photoAccessor,IUserAccessor userAccessor)
            {
                _dbContext = dbContext;
                _photoAccessor = photoAccessor;
                _userAccessor = userAccessor;
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _dbContext.Users.Include(p => p.Photos)
                     .FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetUserName());

                if (user == null) return null;
                var photo = user.Photos.FirstOrDefault(x => x.Id == request.Id);
                if (photo == null) return null;
                if (photo.IsMain) return Result<Unit>.Failure("You can not delete your main photo");

                var res = await _photoAccessor.DeletePhoto(photo.Id);
                if (res == null) return Result<Unit>.Failure("Problem deleting photo from cloudinary");
                user.Photos.Remove(photo);
                var success = await _dbContext.SaveChangesAsync() > 0;
                return Result<Unit>.Failure("Problem deleting photo");
            
            }
        }
    }
}
