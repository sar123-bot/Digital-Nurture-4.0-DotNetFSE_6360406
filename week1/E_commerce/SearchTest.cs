using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.E_commerce
{
    public class SearchTest
    {
        static void Main(string[] args)
        {
            // Sample Products
            Product[] products = new Product[]
            {
            new Product(1, "Smartphone", "Electronics"),
            new Product(2, "Headphones", "Electronics"),
            new Product(3, "Keyboard", "Computer Accessories"),
            new Product(4, "Laptop", "Electronics"),
            new Product(5, "Mouse", "Computer Accessories")
            };

            // Target
            int targetId = 3;

            // ==========================
            // Linear Search
            // ==========================
            Console.WriteLine("\n=== Linear Search Demo ===");
            Stopwatch stopwatch = Stopwatch.StartNew();
            var linearResult = SearchService.LinearSearch(products, targetId);
            stopwatch.Stop();
            Console.WriteLine(linearResult != null
                ? $"Found: {linearResult.ProductName}"
                : "Product Not Found");
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedTicks} ticks");
            Console.WriteLine("Time Complexity: O(n)");

            // ==========================
            // Binary Search
            // ==========================
            Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
            Console.WriteLine("\n=== Binary Search Demo ===");
            stopwatch.Restart();
            var binaryResult = SearchService.BinarySearch(products, targetId);
            stopwatch.Stop();
            Console.WriteLine(binaryResult != null
                ? $"Found: {binaryResult.ProductName}"
                : "Product Not Found");
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedTicks} ticks");
            Console.WriteLine("Time Complexity: O(log n)");

            Console.ReadLine();
        }
    }

}
