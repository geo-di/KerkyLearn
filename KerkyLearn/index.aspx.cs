using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace KerkyLearn
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {

                WelcomeMsg.Text = "Hello, " + Session["user"] + ". You are ready to start learning!";
                WelcomeMsg.Visible = true;
                reg_button.Visible = false;

            }
            

        }

        protected void btn_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }


    
}