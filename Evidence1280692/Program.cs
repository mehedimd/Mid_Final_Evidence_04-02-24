using Product_Category_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence1280692
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------- Answer 01 ------------------------------
            // console color change
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            // List of Product Categories
            List<ProductCategory> productCategories = new List<ProductCategory>()
            {
                new ProductCategory()
                {
                    CategoryID = 1,
                    CategoryName = "Bikes"
                },
                new ProductCategory()
                {
                    CategoryID = 2,
                    CategoryName = "Clothing"
                }
            };
            // List of Product Models
            List<ProductModel> productModels = new List<ProductModel>()
            {
                new ProductModel()
                {
                    ModelId = 1,
                    ModelName = "Mountain Bike Socks"
                },
                new ProductModel()
                {
                    ModelId = 2,
                    ModelName = "Men's Sports Shorts"
                }
            };
            // List of Products
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Mountain-100 Silver, 42",
                    ProductNumber = "BK-M82S-42",
                    Color = "Silver",
                    StandardCost = 1912.1544,
                    ListPrice = 3399.99,
                    Size = 42,
                    Weight = 9421.06,
                    CategoryId = 1,
                    ModelId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "LL Road Frame - Red, 44",
                    ProductNumber = "FR-R38R-44",
                    Color = "Red",
                    StandardCost = 2500.50,
                    ListPrice = 3399.99,
                    Size = 44,
                    Weight = 9421.06,
                    CategoryId = 2,
                    ModelId = 2
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "LL Road Frame - Red, 48",
                    ProductNumber = "FR-R38R-48",
                    Color = "Red",
                    StandardCost = 1912.1544,
                    ListPrice = 1399.99,
                    Size = 48,
                    Weight = 9101.04,
                    CategoryId = 2,
                    ModelId = 2
                }
            };
            // --------------------- Join Three List using LINQ --------------------
            var allProductDetails = from product in products
                                    join categories in productCategories
                                    on product.CategoryId equals categories.CategoryID
                                    join models in productModels
                                    on product.ModelId equals models.ModelId
                                    select new
                                    {
                                        Id = product.ProductId,
                                        Name = product.ProductName,
                                        ProductNumber = product.ProductNumber,
                                        Color = product.Color,
                                        StandardCost = product.StandardCost,
                                        ListPrice = product.ListPrice,
                                        Size = product.Size,
                                        Weight = product.Weight,
                                        Category = categories.CategoryName,
                                        Model = models.ModelName
                                    };
            // Retrive Product Details
            Console.WriteLine("=========================== Product Details ======================================");
            foreach (var product in allProductDetails)
            {
                Console.WriteLine($"Product ID: {product.Id} Name: {product.Name}, " +
                    $" ProductNumber: {product.ProductNumber}, Color: {product.Color}, StandardCost: {product.StandardCost}, ListPrice: {product.ListPrice}," +
                    $" Size: {product.Size}, Weight: {product.Weight}, Category: {product.Category}, Model: {product.Model} \n");
            }



            Console.ReadKey();
        }
    }
}
