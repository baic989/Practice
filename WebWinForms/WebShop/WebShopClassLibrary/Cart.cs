using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopClassLibrary
{
    public class Cart
    {
        double total;

        public double Total
        {
            get { return total; }
        }

        public List<Product> products = new List<Product>();

        public void addProduct(Product p)
        {
            products.Add(p);
            total += p.Price;
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

        public void updateCart()
        {
            List<Product> newCart = new List<Product>();

            foreach (Product p in products)
            {
                try
                {
                    newCart.Add(ProductsRepo.getProductById(p.ID));
                }
                catch
                {

                }
            }

            products = newCart;
        }
    }
}
