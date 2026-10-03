using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Store_Order_Processing
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product>product ,Func<Product,bool> predicate)
        { 
            List<Product> result = new List<Product>();
            foreach (var item in product)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static void PrintReport(List<Product> products , Action<Product>printaction)
        {
            foreach(var item in products)
            {
                printaction(item);
            }
        }


        public static List<T> TransformProducts<T>(List<Product> products , Func<Product,T> transformar)
        {
            List<T> result = new List<T>();
            foreach(var item in products)
            {
                result.Add(transformar(item));
            }
            return result;
        }


        public static List<Product> FilterProducts(List<Product> products,Func<Product,bool>predicate)
        {
            List<Product> result = new List<Product>();
            foreach (var item in products)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
                
            }
            return result;
        }

    }


}
