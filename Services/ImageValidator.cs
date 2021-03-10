using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Services
{
    public static class ImageValidator
    {
        public static (string, byte[]) ValidateImg(IFormFile titleImageFile)
        {
            if (titleImageFile != null)
            {
                string ext = Path.GetExtension(titleImageFile.FileName).ToLowerInvariant();

                if (titleImageFile.Length <= Config.FileSizeLimit && !string.IsNullOrEmpty(ext) && Config.PermittedExtensions.Contains(ext))
                {
                    ext = ext.Replace(".", "");
                    byte[] imageData = null;

                    using (var binaryReader = new BinaryReader(titleImageFile.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)titleImageFile.Length);
                    }

                    return (ext, imageData);
                }
            }
            return default;
        }
    }
}
