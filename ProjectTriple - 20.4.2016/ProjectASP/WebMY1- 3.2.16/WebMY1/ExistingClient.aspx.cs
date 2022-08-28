using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonesProjectBL;
using System.Data;

namespace WebMY1
{
    public partial class ExistingClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable a = new DataTable();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientBL a = new ClientBL(Convert.ToInt32(UserName.Text));
            Session["ClientID"] = a.ClientID1;
            if ((a.IsExist(Convert.ToInt32(UserName.Text)) == true) && (a != null))
            {

                if ((Convert.ToInt32(Pword.Text) == a.Password1) && (this.Page.IsValid)&&(a.Active1==true))
                {
                    Response.Redirect("~/ClientChoise.aspx");
                }
                else
                {
                    if ((Convert.ToInt32(Pword.Text) == a.Password1) && (this.Page.IsValid) && (a.Active1 == false))
                    {
                        this.WarningText.Visible = true;
                    }
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
      
            Response.Redirect("~/NewClient.aspx");
    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainPage.aspx");
        }

    }
}
