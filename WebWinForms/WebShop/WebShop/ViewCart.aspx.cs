using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopClassLibrary;

namespace WebShop
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Session.Add("cart", new Cart());
            }

            Cart c = Session["cart"] as Cart;

            foreach (Product p in c.products)
            {
                LiteralControl ltr = new LiteralControl("Name: " + p.Name + "<br />" + "Price: " + p.Price.ToString()
                    + "<br />");

                pnlData.Controls.Add(ltr);
            }

            LiteralControl ltrCart = new LiteralControl("-------------------<br />Total:     " + c.Total);
            pnlData.Controls.Add(ltrCart);
        }
    }
}