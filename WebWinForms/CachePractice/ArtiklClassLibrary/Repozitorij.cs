using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtiklClassLibrary
{
    public static class Repozitorij
    {
        public static List<Artikl> artikli = new List<Artikl>();

        public static List<Artikl> DohvatiSveArtikle()
        {
            return artikli;
        }
    }
}
