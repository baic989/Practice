using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopClassLibrary;

namespace WebShop.Administration
{
    public partial class Administration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Session.Add("cart", new Cart());
            }

            WebProductControl addItemCtrl = LoadControl("~/WebProductControl.ascx") as WebProductControl;

            addItemCtrl.addNewProduct();

            pnlAdd.Controls.Add(addItemCtrl);

            foreach (Product p in ProductsRepo.products)
            {
                WebProductControl ctrl = LoadControl("~/WebProductControl.ascx") as WebProductControl;
                ctrl.editProduct(p);

                pnlEdit.Controls.Add(ctrl);
            }
        }
    }
}