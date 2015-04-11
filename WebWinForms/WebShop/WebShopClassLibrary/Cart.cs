using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopClassLibrary
{
    public class Cart
    {
        public List<Product> products = new List<Product>();

        public void addProduct(Product p)
        {
            products.Add(p);
        }

        public void removeProductById(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    products.Remove(p);
                }
            }
        }
    }
}
