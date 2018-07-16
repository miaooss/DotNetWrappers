
using System.IO;

namespace DotNetWrappers.IO
{
    public class IOOperation : IIOOperation
    {
        public Stream CreateFile(string filePath)
        {
            return File.Create(filePath);
        }

        public bool DirectoryExist(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }

        public void FileDelete(string filePath)
        {
            File.Delete(filePath);
        }

        public bool FileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public Stream FileOpenRead(string filePath)
        {
            return File.OpenRead(filePath);
        }
    }
}
