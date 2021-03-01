using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string AddAsync(IFormFile file)
        {
            var result = newPath(file);
            try
            {
                var sourcepath = Path.GetTempFileName();
                if (file.Length > 0)
                    using (var stream = new FileStream(sourcepath, FileMode.Create))
                        file.CopyTo(stream);

                File.Move(sourcepath, result.newPath);
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

            return result.Path2;
        }

        public static string UpdateAsync(string sourcePath, IFormFile file)
        {
            var result = newPath(file);

            try
            {
                //File.Copy(sourcePath,result);

                if (sourcePath.Length > 0)
                {
                    using (var stream = new FileStream(result.newPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                File.Delete(sourcePath);
            }
            catch (Exception excepiton)
            {
                return excepiton.Message;
            }

            return result.Path2;
        }

        public static IResult DeleteAsync(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            var creatingUniqueFilename = Guid.NewGuid().ToString("N")
               + "_" + DateTime.Now.Month + "_"
               + DateTime.Now.Day + "_"
               + DateTime.Now.Year + fileExtension;


            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            string result = $@"{path}\{creatingUniqueFilename}";

            return (result, $"\\Images\\{creatingUniqueFilename}");
        }
    }
}
