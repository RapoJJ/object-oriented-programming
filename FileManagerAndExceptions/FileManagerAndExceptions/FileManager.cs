using System;
using System.IO;
using System.Text;

namespace FileManagerAndExceptions
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = String.Empty;
        }

        public string ReadWords()
        {
            string content = String.Empty;

            content = ReadFile();

            return content;
        }

        private string ReadFile()
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}