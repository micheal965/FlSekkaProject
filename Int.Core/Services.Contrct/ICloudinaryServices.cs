using Microsoft.AspNetCore.Http;
namespace Int.Core.Services.Contrct
{
    public interface ICloudinaryServices
    {
        Task<List<(string imageUrl, string publicId)>> UploadImagesAsync(List<IFormFile> files);
    }
}
