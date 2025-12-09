using Xunit;
using System.Collections.Generic;
using System.Linq;
using oop_assignment_2_2025_72484.Models;

public class UnitTestQuestion_3Test
{
    [Fact(DisplayName = "it should caculate the best product")]
    public void AnalyzeProducts_ShouldDetermineHighestRatedProduct()
    {
        
        var products = new List<Product>
        {
            
            new Product { Name = "Laptop", Ratings = new List<int> { 5, 4, 5, 3 } }, 
            
            
            new Product { Name = "Headphones", Ratings = new List<int> { 4, 3, 5 } },
            
            
            new Product { Name = "Keyboard", Ratings = new List<int> { 5, 5, 5, 4 } },
            
            
            new Product { Name = "Mouse", Ratings = new List<int> { 3, 3, 4 } },
            
            
            new Product { Name = "Webcam", Ratings = new List<int>() }
        };

        
        const string expectedTopMessage = "The top-rated product is Keyboard with an average rating of 4.8";

        
        var (display, topMessage) = ExamQuestion_3.AnalyzeProducts(products);

        
        Assert.Equal(expectedTopMessage, topMessage);

        
        Assert.Contains("Laptop: Average Rating = 4.2", display);

        
        Assert.Contains("Headphones: Average Rating = 4.0", display);

        
        Assert.Contains("Keyboard: Average Rating = 4.8", display);

        
        Assert.Contains("Mouse: Average Rating = 3.3", display);

        
        Assert.Contains("Webcam: No ratings available", display);
    }
}