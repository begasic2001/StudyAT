using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Photos
{
    public class Add 
    {
        public class Command : IRequest<Result<Photo>>
        {
            public IFormFile File { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Photo>>
        {
            private readonly ReactivitiesContext _dbContext;
            private readonly IUserAccessor _userAccessor;
            private readonly IPhotoAccessor _photoAccessor;

            public Handler(ReactivitiesContext dbContext,IUserAccessor userAccessor,IPhotoAccessor photoAccessor)
            {
                _dbContext = dbContext;
                _userAccessor = userAccessor;
                _photoAccessor = photoAccessor;

            }
            public async Task<Result<Photo>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _dbContext.Users.Include(p => p.Photos)
                    .FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetUserName());

                if (user == null) return null;
                var photoUploadResult = await _photoAccessor.AddPhoto(request.File);
                var photo = new Photo
                {
 
                    Id = photoUploadResult.PublicId,
                    ImageUrl = photoUploadResult.ImageUrl
                };
                if (!user.Photos.Any(x => x.IsMain)) photo.IsMain = true;
                user.Photos.Add(photo);
                var res = await _dbContext.SaveChangesAsync() > 0;
                if(res) return Result<Photo>.Success(photo);
                return Result<Photo>.Failure("Problem adding photo");
            }
        }
    }
}
