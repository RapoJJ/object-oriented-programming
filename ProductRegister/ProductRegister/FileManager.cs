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
            r.Close();
            return PrintJson();           
        }

        private string PrintJson()
        {
            string content = "";
            foreach (Product p in _productList)
            {
                content += p.ToString() + "\n";
            }
            return content;
        }


        public string FindProduct(int id)
        {
            string content = string.Empty;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        return p.ToString() + $" Amount: {p.Amount} Comment: {p.Comment}";
                    }
                }
            }
            catch (Exception e)
            {
                return $"{e.Message} List of products hasn't been read yet, use choice A first!";
            }
            return "Cannot find product with this id number!";
        }


        public void AddComment(string comment, int id)
        {
            foreach (Product p in _productList)
            {
                if (id == p.Id)
                {
                    if (p.Comment == comment)
                    {
                        Console.WriteLine($"Comment ({comment}) is the same as old comment!");
                    }
                    else
                    {
                        p.Comment += " " + comment;
                        Console.WriteLine($"Added comment to product {p.Name} and the added comment was {comment}.");
                    }                  
                }
            }
        }

        public void UpdateFile()
        {
            string json = JsonConvert.SerializeObject(_productList);

            StreamWriter w = new StreamWriter(_filePath);

            w.Write(json);

            w.Close();
        }
    }
}