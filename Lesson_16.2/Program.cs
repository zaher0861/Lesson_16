using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Lesson_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../Products.json");
            string jsonstring1 = sr.ReadToEnd();

            Product[] product1 = JsonSerializer.Deserialize<Product[]>(jsonstring1);
            Console.WriteLine(jsonstring1);
            Product maxPrice = product1[0];
            foreach (Product p in product1)
            {
                if (p.Price > maxPrice.Price)
                {
                    maxPrice = p;
                }
            }
            Console.WriteLine($"{maxPrice.Code} {maxPrice.Name} {maxPrice.Price}");
            Console.ReadKey();
        }
    }
}
