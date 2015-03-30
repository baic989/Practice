using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginScreen
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("LoginData");
            c["Username"] = txtUsername.Text;
            c["Password"] = txtPass.Text;
            Response.Cookies.Add(c);

            Response.Redirect("Default.aspx");
        }
    }
}