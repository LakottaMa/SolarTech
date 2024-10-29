using Microsoft.AspNetCore.Components.Forms;

namespace SolarTech.Helpers
    {
    public class OrderFileUploadHelper
        {
        public async Task<string> UploadOrderImage(IBrowserFile selectedImage)
            {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(selectedImage.Name)}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/orders", fileName);

            await using var fileStream = new FileStream(filePath, FileMode.Create);
            await selectedImage.OpenReadStream(maxAllowedSize: 10 * 1024 * 1024).CopyToAsync(fileStream);

            return "uploads/orders/" + fileName;
            }
        }
    }
