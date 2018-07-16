using System.IO;

namespace DotNetWrappers.IO
{
    public interface IIOOperation
    {
        bool DirectoryExist(string directoryPath);
        bool FileExist(string filePath);
        void FileDelete(string filePath);

        Stream CreateFile(string filePath);
        Stream FileOpenRead(string filePath);
    }
}
