using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PictureManager.BLL
{
    public class Picture
    {
        public Picture(string sourceFilePath)
        {
            var fileInfo = new FileInfo(sourceFilePath);
            Name = fileInfo.Name;
            FileSize = fileInfo.Length;
            FileType = GetFileTypeByExtension(fileInfo.Extension);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public FileType FileType { get; set; }

        private FileType GetFileTypeByExtension(string extension)
        {
            var ext = extension.ToLower();

            if (ext == "jpg")
            {
                return FileType.JPG;
            }
            else if (ext == "jpeg")
            {
                return FileType.JPEG;
            }
            else if (ext == "png")
            {
                return FileType.PNG;
            }
            else if (ext == "gif")
            {
                return FileType.GIF;
            }
            else if (ext == "bmp")
            {
                return FileType.BMP;
            }
            else if (ext == "svg")
            {
                return FileType.SVG;
            }
            else
            {
                return FileType.UNDEFINED;
            }
        }
    }

    public class Test
    {
        public void CreatePicture()
        {
            var picture = new Picture("c:\\image.jpg");
        }
    }
}
