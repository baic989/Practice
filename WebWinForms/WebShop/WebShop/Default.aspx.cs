﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopClassLibrary;

namespace WebShop
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Session.Add("cart", new Cart());
            }

            foreach (Product p in ProductsRepo.products)
            {
                WebProductControl ctrl = LoadControl("~/WebProductControl.ascx") as WebProductControl;
                ctrl.showProduct(p);
                pnlData.Controls.Add(ctrl);
            }
        }
    }
}