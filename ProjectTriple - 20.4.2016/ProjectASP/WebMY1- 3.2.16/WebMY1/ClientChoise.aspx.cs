using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonesProjectBL;

namespace WebMY1
{
    public partial class ClientChoise : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientBL a = new ClientBL(Convert.ToInt32(Session["ClientID"]));
            Label1.Text = "Welcome " + a.Fn; 
        }

        protected void AccountExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainPage.aspx");
        }

        protected void Action_Click(object sender, EventArgs e)
        {
            Session["ClientIndex"] = MyChoise.SelectedIndex.ToString();
            Response.Redirect("~/ClientView.aspx");

        }

        protected void MyChoise_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.Action.Enabled = true;
        }

     
    }
}