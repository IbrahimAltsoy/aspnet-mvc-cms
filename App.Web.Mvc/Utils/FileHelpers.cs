﻿namespace App.Web.Mvc.Utils
{
    
        public class FileHelpers
        {
            public static async Task<string> FileLoaderAsync(IFormFile formFile, string filePath = "/wwwroot/template/images/")
            {
                var fileName = "";
                if (formFile != null && formFile.Length > 0)
                {
                    fileName = formFile.FileName;
                    string directory = Directory.GetCurrentDirectory() + filePath + fileName;
                    using var stream = new FileStream(directory, FileMode.Create);
                    await formFile.CopyToAsync(stream);
                }
                return fileName;
            }


            public static bool FileRemover(string fileName, string filePath = "/wwwroot/template/images/")
            {
                string directory = Directory.GetCurrentDirectory() + filePath + fileName;
                if (File.Exists(directory))
                {
                    File.Delete(directory);
                    return true;
                }
                return false;
            }
        }
    }

