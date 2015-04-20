using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterPagePractice
{
    public class myPage : System.Web.UI.Page
    {
        public myPage()
        {

        }
        protected override void OnPreInit(EventArgs e)
        {
            if (Request.Cookies["themeCookie"] != null)
            {
                this.Theme = Request.Cookies["themeCookie"].Value;
            }
            base.OnPreInit(e);
        }

        protected override void InitializeCulture()
        {
            if (Request.Cookies["langCookie"] != null)
            {
                string culture = Request.Cookies["langCookie"].Value;

                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            }
            base.InitializeCulture();
        }
    }
}