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

        public void LoadJson()
        {
            try
            {
                //_moviesList = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(this._filePath));
                var r = new StreamReader(_filePath);
                var json = r.ReadToEnd();
                _moviesList = JsonConvert.DeserializeObject<List<Movie>>(json);               
                PrintJson();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }           
        }

        public void PrintJson()
        {
            foreach (var m in _moviesList)
            {
                Console.WriteLine($"Movie name: {m.Name}\tYear: {m.Year}");
            }
        }
    }
}