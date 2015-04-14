using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopClassLibrary;

namespace WebShop
{
    public partial class WebUserHeaderControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart c = Session["cart"] as Cart;
            lblTotal.Text = c.Total.ToString();
        }

        protected void lbCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }
    }
}