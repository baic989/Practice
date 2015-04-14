using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopClassLibrary
{
    public class Product
    {
        private static int classId = 0;
        private int _id;

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Product()
        {
            _id = ++classId;
        }
    }
}
