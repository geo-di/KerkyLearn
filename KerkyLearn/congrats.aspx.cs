using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KerkyLearn
{
    public partial class congrats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (Session["user"] == null)
            {
                Session["previouspage"] = HttpContext.Current.Request.Url.AbsolutePath;
                Response.Redirect("login.aspx");
            } 
        }
    }
}