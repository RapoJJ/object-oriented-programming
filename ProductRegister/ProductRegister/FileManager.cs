using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ProductRegister
{
    class FileManager
    {
        private readonly string _filePath;
        private List<Product> _productList;

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

        private string ReadFile()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("File not available");
            }

            StreamReader r = new StreamReader(_filePath);
            string json = r.ReadToEnd();
            _productList = JsonConvert.DeserializeObject<List<Product>>(json);

            return PrintJson();           
        }

        private string PrintJson()
        {
            string content = "";
            foreach (Product p in _productList)
            {
                content += $"Product name: {p.Name}\nId Number: {p.Id}\nGroup name: {p.GroupName}\n--------------\n";
            }
            return content;
        }
    }
}