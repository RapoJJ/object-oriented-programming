using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

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
        private List<Movie> _moviesList;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        public string ReadWords()
        {
            try
            {
                string content = ReadFile();
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

            string directoryName = Path.GetDirectoryName(_filePath);
            string fileName = Path.GetFileName(_filePath);
            string fileExtension = Path.GetExtension(_filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(_filePath, Encoding.UTF8);
            return fileContent;
        }

        public void ReadJson()
        {
            try
            {
                //_moviesList = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(this._filePath));
                StreamReader r = new StreamReader(_filePath);
                string json = r.ReadToEnd();
                _moviesList = JsonConvert.DeserializeObject<List<Movie>>(json);               
                PrintJson();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Couldn't use the file, error that happened: {e.Message}");
            }
        }

        private void PrintJson()
        {
            foreach (Movie m in _moviesList)
            {
                Console.WriteLine($"Movie name: {m.Name}\tYear: {m.Year}");
            }
        }
    }
}
