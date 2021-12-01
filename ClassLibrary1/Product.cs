using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public struct Product
    {        
        public string Name { get; set; }
        public string Shop { get; set; }

        public static Product[] SortbyShop(Product[] products)
        {
            Product[] products2 = new Product[products.Length];
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < products.Length - 1; i++)
                {
                    if (products[i].Shop.CompareTo(products[i + 1].Shop) > 0)
                    {
                        products2[i] = products[i];
                        products[i] = products[i + 1];
                        products[i + 1] = products2[i];
                        flag = true;
                    }
                }
            }
            return products;
        }
        public static List<Product> ProductsInShop(Product[] products,string shopName)
        {
            List<Product> products2 = new List<Product>();
            foreach (var product in products)
            {
                if (product.Shop == shopName)
                {
                    products2.Add(product);
                }                
            }
            if (products2.Count == 0)
            {
                throw new MyException($"магазина с названием {shopName} не существует");
            }

            return products2;
        }
    }
}
