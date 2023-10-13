using Microsoft.AspNetCore.Http;
using Reactivities.Application.Photos;

namespace Reactivities.Application.Interfaces
{
    public interface IPhotoAccessor
    {
        Task<PhotoUploadResult> AddPhoto(IFormFile file);
        Task<string> DeletePhoto(string publicId);
    }
}
