using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArtemProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string fileString = File.ReadAllText(@"C:\Users\Simon\Desktop\before.txt");
            List<string> ListOfWords = fileString.Split(' ').ToList();
            Console.WriteLine("Words from file =>");
            foreach (var a in ListOfWords)
                Console.Write(a + " ");
            Console.WriteLine("\nWords in reversal order writen into file After.txt");
            ListOfWords.Reverse();
            var path = @"C:\Users\Simon\Desktop\after.txt";
            File.WriteAllLines(path, ListOfWords);
            Console.WriteLine(new string('-', 50));

           

            Dictionary<string, int> pairs = new Dictionary<string, int>()
            {
                ["A"] = 1,
                ["d"] = 1,
                ["C"] = 2,
                ["B"] = 2,
            };
            foreach (var keyValue in pairs)
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

            foreach (var keyValue in pairs)
            {
                foreach (var secondKeyValue in pairs)
                    if (keyValue.Value != secondKeyValue.Value)
                        Console.Write(keyValue.Key + secondKeyValue.Key);

                Console.Write(" ");
            }
            Console.WriteLine("\n"+new string('-', 50));

            
            Dictionary<string, int> Product = new Dictionary<string, int>
            {
                ["Milk"] = 15,
                ["Potato"] = 7,
                ["Wine"] = 130,
                ["Sugar"] = 27,
                ["Water"] = 30,
                ["Meat"] = 110,
                ["Salmon"] = 230
            };
            var ProductsWithPriceLessThan100 = from a in Product where a.Value < 100 select a;
            var ProductsWithPriceMoreThan100 = Product.Select(a => a).Where(a => a.Value > 100);
            Console.WriteLine("Products with price less than 100");
            foreach(var a in ProductsWithPriceLessThan100)
                Console.WriteLine(a.Key + " - " + a.Value);
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Products with price more than 100");
            foreach (var a in ProductsWithPriceMoreThan100)
                Console.WriteLine(a.Key + " - " + a.Value);
            Console.ReadLine();
        }
    }
}
