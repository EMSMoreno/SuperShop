using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SuperShop.Helpers
{
    public interface IBlobHelper
    {
        Task <Guid> UploadBlobAsync (IFormFile file, string containerName); //web

        Task<Guid> UploadBlobAsync(byte[] file, string containerName); //mobile

        Task<Guid> UploadBlobAsync(string image, string containerName); //se precisarmos
    }
}
