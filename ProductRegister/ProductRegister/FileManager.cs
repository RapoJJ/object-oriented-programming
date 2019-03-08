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
                return $"{e.Message}";
            }
            return "Cannot find product with this id number!";
        }


        public void AddComment(int id, string comment)
        {
            bool productFound = false;
            foreach (Product p in _productList)
            {
                if (id == p.Id)
                {
                    productFound = true;
                    if (p.Comment == comment)
                    {
                        Console.WriteLine($"Comment ({comment}) is the same as old comment!");
                    }
                    else
                    {
                        p.Comment += " " + comment;
                        Console.WriteLine($"Added comment to product {p.Name} and the added comment was {comment}. " +
                                          $"\nProducts whole comment is {p.Comment}.");
                    }                  
                }
            }
            if (!productFound)
            {
                Console.WriteLine("Product with inputted ID couldn't be found!");
            }
        }

        public void DeleteComment(int id)
        {
            bool productFound = false;
            foreach (Product p in _productList)
            {
                if (id == p.Id)
                {
                    productFound = true;
                    Console.WriteLine($"Found product {p.Name} and it's comment is {p.Comment}");
                    Console.Write("Are you sure you want to delete the comment? [Y/N]");
                    ConsoleKeyInfo cki = Console.ReadKey();

                    if (cki.Key == ConsoleKey.Y)
                    {
                        p.Comment = "";
                        Console.WriteLine("\nComment deleted!");
                    }
                    else if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("\nComment wasn't deleted.");
                    }
                    else
                    {
                        Console.WriteLine("\nWrong input! Comment wasn't deleted.");
                    }

                }
            }
            if (!productFound)
            {
                Console.WriteLine("Product with inputted ID couldn't be found!");
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