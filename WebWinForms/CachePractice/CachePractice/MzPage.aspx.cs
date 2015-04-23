using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using ArtiklClassLibrary;

namespace CachePractice
{
    public partial class MzPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["artikli"] == null)
            {
                Cache.Insert("artikli", Repozitorij.DohvatiSveArtikle(), null, Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 30));

                DateTime vrijemeKesiranja = DateTime.Now;
                Cache.Insert("vrijemeKesiranja", vrijemeKesiranja, null, Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 30));
            }

            List<Artikl> artikli = (List<Artikl>)Cache["artikli"];
            DateTime vrijeme = (DateTime)Cache["vrijemeKesiranja"];

            foreach (Artikl a in artikli)
            {
                blArtikli.Items.Add(a.ToString());
            }

            lblVrijeme.Text = vrijeme.ToLongTimeString();
        }
    }
}