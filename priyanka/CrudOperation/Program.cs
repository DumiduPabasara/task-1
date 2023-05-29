
using System;
using System.Collections.Generic;
using System.IO;
//using System.Xml;
using Newtonsoft.Json;


namespace CrudOperation
{

    public class Program
    {
        private const string JsonFilePath = "products.json";
        private static List<Product> products;

        public static void Main(string[] args)
        {
            LoadProducts();

            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Create a product");
                Console.WriteLine("2. Read all products");
                Console.WriteLine("3. Update a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CreateProduct();
                            break;
                        case 2:
                            ReadProducts();
                            break;
                        case 3:
                            UpdateProduct();
                            break;
                        case 4:
                            DeleteProduct();
                            break;
                        case 5:
                            SaveProducts();
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
            }
        }
             private static void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        private static void LoadProducts()
        {
            if (File.Exists(JsonFilePath))
            {
                string json = File.ReadAllText(JsonFilePath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            else
            {
                products = new List<Product>();
            }
        }

        private static void SaveProducts()
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            // string json = JsonConvert.SerializeObject(products,(Newtonsoft Json.Formatting) System.Xml.Formatting.Indented);
            File.WriteAllText(JsonFilePath, json);
        }

        private static void CreateProduct()
        {
            Console.Write("Enter the product ID: ");
            int id = ReadIntFromConsole();

            Console.Write("Enter the product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the product price: ");
            decimal price = ReadDecimalFromConsole();

            Product newProduct = new Product { ID = id, Name = name, Price = price };
            products.Add(newProduct);

            Console.WriteLine("Product created successfully.");
        }

           private static decimal ReadDecimalFromConsole()
          {
            throw new NotImplementedException();
          }


        private static int ReadIntFromConsole()
        {
            throw new NotImplementedException();
        }

        private static void ReadProducts()
        {
            Console.WriteLine("Products:");

            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price}");
            }
        }

        private static void UpdateProduct()
        {
            Console.Write("Enter the product ID to update: ");

        }

    }
}