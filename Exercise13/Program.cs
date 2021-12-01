using System;
using System.Collections;
using ClassLibrary1;
using System.Collections.Generic;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {             
            Product p1 = new Product { Name="Bread", Shop = "G" };
            Product p2 = new Product { Name = "Paper", Shop = "C" };
            Product p3 = new Product { Name = "Orange", Shop = "A" };
            Product p4 = new Product { Name = "Apple", Shop = "C" };
            Product p5 = new Product { Name = "Coat", Shop = "C" };
            Product p6 = new Product { Name = "Laptop", Shop = "B" };

            Product[] products = new Product[6] { p1,p2,p3,p4,p5,p6};
            Console.WriteLine("\nBefore sort:");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} - {item.Shop}");
            }            
           
            products = Product.SortbyShop(products);

            Console.WriteLine("\nAfter sort:");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} - {item.Shop}");
            }
            Console.WriteLine("\nEnter shop:");
            string shopName = Console.ReadLine();
            List<Product> productsInShop = Product.ProductsInShop(products, shopName);
            foreach (var item in productsInShop)
            {
                Console.WriteLine(item.Name);
            }
        }        
    }
}
