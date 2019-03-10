using System;
using System.Collections.Generic;
using System.IO;
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

        public string PrintIdAndName()
        {
            string content = String.Empty;
            try
            {
                foreach (Product p in _productList)
                {
                    content += $"Id: {p.Id}\tName: {p.Name}\n";
                }

                return content;
            }
            catch (Exception e)
            {
                return $"{e.Message} Check the data of file!";
            }
        }

        public string FindProductById(int id)
        {
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        return p.ToString() + $"\nPrice: {p.Price} €\nAmount: {p.Amount}\nComment: {p.Comment}";
                    }
                }
            }
            catch (Exception e)
            {
                return $"{e.Message} Check the data of file!";
            }

            return "Cannot find product with this id number!";
        }

        public string FindProductsZeroStock()
        {
            bool productFound = false;
            string content = string.Empty;
            Console.WriteLine("Printing products that are out of stock.");
            try
            {
                foreach (Product p in _productList)
                {
                    if (p.Amount == 0)
                    {
                        productFound = true;
                        content += p.ToString() + "\n";
                    }
                }

                if (!productFound)
                {
                    content = "Nothing has ran out of stock!";
                }

                return content;
            }
            catch (Exception e)
            {
                return $"{e.Message} Check the data of file!";
            }
        }

        public string FindProductsByCategory(int choice)
        {
            string category = string.Empty;
            string content = string.Empty;
            switch (choice)
            {
                case 1:
                    category = "Lajittelu ja säilytys";
                    break;
                case 2:
                    category = "Paperit ja lehtiöt";
                    break;
                case 3:
                    category = "Kynät";
                    break;
                case 4:
                    category = "Kortit ja kirjekuoret";
                    break;
            }

            try
            {
                foreach (Product p in _productList)
                {
                    if (category == p.GroupName)
                    {
                        content += p.ToString() + "\n";
                    }
                }

                return content;
            }
            catch (Exception e)
            {
                return $"{e.Message} Check the data of file!";
            }

            ;
        }

        public void AddComment(int id)
        {
            bool productFound = false;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        productFound = true;
                        Console.WriteLine($"Found product {p.Name} with comment: '{p.Comment}'");
                        Console.Write("Write comment to add: ");
                        string comment = Console.ReadLine();
                        if (p.Comment.Contains(comment))
                        {
                            Console.WriteLine($"Comment '{comment}' is already in products comment!");
                        }
                        else
                        {
                            p.Comment += " " + comment;
                            Console.WriteLine($"Added comment '{comment}' to product '{p.Name}'." +
                                              $"\nProducts whole comment: '{p.Comment}'.");
                        }
                    }
                }

                if (!productFound)
                {
                    Console.WriteLine("Product with inputted ID couldn't be found!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Check the data of file!");
            }
        }

        public void DeleteComment(int id)
        {
            bool productFound = false;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        productFound = true;
                        Console.WriteLine($"Product {p.Name} with comment: '{p.Comment}'");
                        Console.Write("Do you want to delete this comment? [Y/N]");
                        ConsoleKeyInfo cki = Console.ReadKey();
                        switch (cki.Key)
                        {
                            case ConsoleKey.Y:
                                p.Comment = "";
                                Console.WriteLine("\nComment deleted!");
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("\nComment wasn't deleted.");
                                break;
                            default:
                                Console.WriteLine("\nWrong input! Comment wasn't deleted.");
                                break;
                        }
                    }
                }

                if (!productFound)
                {
                    Console.WriteLine("Product with inputted ID couldn't be found!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Check the data of file!");
            }
        }

        public void UpdateAmount(int id)
        {
            bool productFound = false;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        productFound = true;
                        Console.WriteLine($"Found product: {p.Name}\nStock amount: {p.Amount}");
                        while (true)
                        {
                            Console.Write("Input new amount: ");
                            if (int.TryParse(Console.ReadLine(), out int amount))
                            {
                                p.Amount = amount;
                                Console.WriteLine($"Product {p.Name} new stock amount is {p.Amount}.");
                                DeleteComment(p.Id);
                                break;
                            }

                            Console.WriteLine("Input wasn't number!");
                        }
                    }
                }

                if (!productFound)
                {
                    Console.WriteLine("Product with inputted ID couldn't be found!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Check the data of file!");
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