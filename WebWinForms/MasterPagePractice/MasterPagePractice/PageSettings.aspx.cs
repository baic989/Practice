using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagePractice
{
    public partial class PageSettings : myPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlTheme.SelectedValue != "-")
            {
                HttpCookie cookie = new HttpCookie("themeCookie");
                cookie.Value = ddlTheme.SelectedValue;
                cookie.Expires = DateTime.Now.AddYears(100);

                Response.Cookies.Add(cookie);
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void ddlLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLang.SelectedValue != "-")
            {
                HttpCookie cookie = new HttpCookie("langCookie");
                cookie.Value = ddlLang.SelectedValue;
                cookie.Expires = DateTime.Now.AddYears(100);

                Response.Cookies.Add(cookie);
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}