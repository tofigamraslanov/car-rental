using System;
using Microsoft.AspNetCore.Http;
using System.IO;
using Core.Utilities.Results;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string ImagePath { get; set; }

        public static string SaveImageFile(IFormFile imageFile)
        {
            string newImageName = Guid.NewGuid() + Path.GetExtension(imageFile.FileName);
            var fullPath = Path.Combine(ImagePath, newImageName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }
            return newImageName;
        }

        public static bool DeleteImageFile(string fileName)
        {
            string fullPath = Path.Combine(ImagePath, fileName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
                return true;
            }
            return false;
        }

        #region MyRegion
        //public static string Add(IFormFile file)
        //{
        //    var sourcePath = Path.GetTempFileName();
        //    if (file.Length>0)
        //    {
        //        using (var fileStream=new FileStream(sourcePath,FileMode.Create))
        //        {
        //            file.CopyTo(fileStream);
        //        }
        //    }

        //    var result = NewPath(file);
        //    File.Move(sourcePath,result);
        //    return result;
        //}

        //public static IResult Delete(string path)
        //{
        //    try
        //    {
        //        File.Delete(path);
        //    }
        //    catch (Exception exception)
        //    {
        //        return new ErrorResult(exception.Message);
        //    }

        //    return new SuccessResult();
        //}

        //public static string Update(string sourcePath, IFormFile file)
        //{
        //    var result = NewPath(file);
        //    FileInfo fileInfo = new FileInfo(file.FileName);
        //    if (sourcePath.Length>0)
        //    {
        //        using (var fileStream=new FileStream(result,FileMode.Create))
        //        {
        //            file.CopyTo(fileStream);
        //        }
        //    }
        //    File.Delete(sourcePath);
        //    return result;
        //}

        //private static string NewPath(IFormFile file)
        //{
        //    var fileInfo = new FileInfo(file.FileName);
        //    string fileExtension = fileInfo.Extension;

        //    string path = Environment.CurrentDirectory + @"\wwwroot\Upload\Images";
        //    var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

        //    string result = $@"{path}\{newPath}";
        //    return result;
        //}
        #endregion
    }
}