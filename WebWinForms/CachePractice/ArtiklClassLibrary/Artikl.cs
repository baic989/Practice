using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtiklClassLibrary
{
    public class Artikl
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public decimal Cijena { get; set; }
        public override string ToString()
        {
            return String.Format("ID:{} NAZIV:{} CIJENA:{}", ID, Ime, Cijena);
        }
    }
}
