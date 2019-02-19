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
        private readonly string _filePath;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        public string ReadWords()
        {
            try
            {
                var content = ReadFile();
                return content;
            }
            catch (Exception e)
            {
                return e.Message;
            }                      
        }

        private string ReadFile( )
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("File not available");
            }

            var directoryName = Path.GetDirectoryName(_filePath);
            var fileName = Path.GetFileName(_filePath);
            var fileExtension = Path.GetExtension(_filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            var fileContent = File.ReadAllText(_filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}