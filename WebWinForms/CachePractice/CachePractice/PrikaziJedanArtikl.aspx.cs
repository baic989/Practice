using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachePractice
{
    public partial class PrikaziJedanArtikl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrikazi_Click(object sender, EventArgs e)
        {
            int IDArtikl;
            int.TryParse(txtID.Text, out IDArtikl);

            try
            {
                Response.Redirect("DetaljiArtikla.aspx?IDArtikl=" + + IDArtikl);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                Response.Redirect("ErrorPage.aspx?error=" + message);
            }
        }
    }
}