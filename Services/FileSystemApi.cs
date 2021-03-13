using System;
using System.IO;

namespace GnomShop.Services
{
    public static class FileSystemApi
    {
        private static readonly string path;
        static FileSystemApi()
        {
            path = Path.Combine(Environment.CurrentDirectory, $"wwwroot\\temp\\");
        }
        public static string GetImagesDirectoryById(Guid directory)
        {
            return Path.Combine(Environment.CurrentDirectory, $"wwwroot\\images\\ProductItems\\{directory}\\");
        }
        public static string CreateTempDirectory()
        {            
            Directory.CreateDirectory(path);
            return path;
        }
        public static void CopyTempDirectoryById(Guid directory)
        {
            string destination = GetImagesDirectoryById(directory);
            Directory.CreateDirectory(destination);

            if (new DirectoryInfo(path).Exists)
            {
                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationDirectory = Path.Combine(destination, fileName);
                    File.Copy(file, destinationDirectory, true);
                }

                Directory.Delete(path, true);                
            }
        }

        public static void DeleteImagesDirectoryById(Guid directory)
        {
            string pathImagesDir = GetImagesDirectoryById(directory);
            if (new DirectoryInfo(pathImagesDir).Exists)
            {
                Directory.Delete(pathImagesDir, true);
            }
        }

    }
}
