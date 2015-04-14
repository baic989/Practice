using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopClassLibrary
{
    public static class ProductsRepo
    {
        public static List<Product> products = new List<Product>();

        public static void addProduct(Product p)
        {
            products.Add(p);
        }

        public static void removeProductById(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ID == id)
                {
                    products.RemoveAt(i);
                    break;
                }
            }
        }

        public static Product getProductById(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }

            return new Product() { Name = "Null" };
        }

        public static void updateProductById(int id, string name, double price, DateTime date)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    p.Name = name;
                    p.Price = price;
                    p.ExpirationDate = date;
                }
            }
        }

        static ProductsRepo()
        {
            Product p1 = new Product() { Name = "Milk", Price = 2.99 };
            Product p2 = new Product() { Name = "Chocolate", Price = 3.89 };

            products.Add(p1);
            products.Add(p2);
        }
    }
}
