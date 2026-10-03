using System.Reflection.Emit;

namespace Online_Store_Order_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {


                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 }
            };

            #region Task 01 : Smart Product Search
            //Console.WriteLine("---Electronic---");
            //List<Product> ElectronicsProducts = Product.SearchProducts(catalog,P=>P.Category=="Electronics");
            //foreach(var product in ElectronicsProducts)
            //{
            //    Console.WriteLine($"{product.Name}-${product.Price}(Stock:{product.Stock})");
            //}

            //Console.WriteLine("\n---Under $50---");
            //List<Product> Under50Products = Product.SearchProducts(catalog,P=>P.Price<50);
            //foreach(var product in Under50Products)
            //{
            //    Console.WriteLine($"{product.Name}-${product.Price}(Stock:{product.Stock})");
            //}

            //Console.WriteLine("\n---Stock>0---");
            //List<Product> InStockProducts = Product.SearchProducts(catalog,P=>P.Stock>0);
            //foreach(var product in InStockProducts)
            //{
            //    Console.WriteLine($"{product.Name}-${product.Price}(Stock:{product.Stock})");
            //}

            //Console.WriteLine("\n---Under $100---");
            //List<Product> Under100Products = Product.SearchProducts(catalog,P=>P.Price<100);
            //foreach(var product in Under100Products)
            //{
            //    Console.WriteLine($"{product.Name}-${product.Price}(Stock:{product.Stock})");
            //}

            #endregion

            #region Task 03 : Custom Report Generator
            //Console.WriteLine("---Short Report---");
            //Product.PrintReport(catalog,p=> Console.WriteLine($"{p.Name}-${p.Price}"));

            //Console.WriteLine("\n---Detailed Report---");
            //Product.PrintReport(catalog,p=> Console.WriteLine($"[{ p.Category}]{p.Name}| Price:${p.Price}| Stock:{p.Stock}"));


            //List<string> SummaryList = Product.TransformProducts<string>(catalog,p=> $"{p.Name}(${p.Price})");
            //foreach(var item in SummaryList)
            //{
            //    Console.WriteLine(item);
            //}

            //string Expensive = "Expensive!", Affordable = "Affordable";
            //List<string> PriceLabel = Product.TransformProducts<string>(catalog,P=>$"{P.Name}:{(P.Price > 100 ? "Expensive!" : "Affordable")}");

            //foreach (var item in PriceLabel)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Product> products = Product.FilterProducts(catalog,p=>p.Stock<20);
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"[LOW STOCK]{product.Name}:only {product.Stock} left!");
            //}




            #endregion

        }
    }
}

