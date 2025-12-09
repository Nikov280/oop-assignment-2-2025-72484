using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_assignment_2_2025_72484.Models
{
    
    public class Product
    {
        public string Name { get; set; }
        public List<int> Ratings { get; set; }
    }

    public static class ExamQuestion_3
    {
        
        public static readonly List<Product> SampleProducts = new List<Product>
        {
            new Product { Name = "Laptop", Ratings = new List<int> { 5, 4, 5, 3 } }, 
            new Product { Name = "Headphones", Ratings = new List<int> { 4, 3, 5 } }, 
            new Product { Name = "Keyboard", Ratings = new List<int> { 5, 5, 5, 4 } }, 
            new Product { Name = "Mouse", Ratings = new List<int> { 3, 3, 4 } }, 
            new Product { Name = "Webcam", Ratings = new List<int>() }
        };

        public static void Run()
        {
            Console.WriteLine("---");
            Console.WriteLine("Exam Question 3 executed.");
            var (display, topMessage) = AnalyzeProducts(SampleProducts);

            Console.WriteLine(display);
            
            Console.WriteLine(topMessage);
            
        }

        
        public static (string DisplayOutput, string TopProductMessage) AnalyzeProducts(List<Product> products)
        {
            var outputLines = new List<string>();
            Product bestProduct = null;
            double highestRating = -1;

            foreach (var product in products)
            {
                
                if (product.Ratings == null || product.Ratings.Count == 0)
                {
                    outputLines.Add($"{product.Name}: No ratings available");
                    continue;
                }

                
                double averageRating = product.Ratings.ConvertAll(r => (double)r).Average();

                
                double roundedRating = Math.Round(averageRating, 1);

                
                outputLines.Add($"{product.Name}: Average Rating = {roundedRating:F1}");

                
                if (averageRating > highestRating)
                {
                    highestRating = averageRating;
                    bestProduct = product;
                }
            }

            
            string topProductMessage = string.Empty;
            if (bestProduct != null)
            {
                
                double roundedHighestRating = Math.Round(highestRating, 1);
                topProductMessage = $"The top-rated product is {bestProduct.Name} with an average rating of {roundedHighestRating:F1}";
            }

            return (string.Join(Environment.NewLine, outputLines), topProductMessage);
        }
    }
}