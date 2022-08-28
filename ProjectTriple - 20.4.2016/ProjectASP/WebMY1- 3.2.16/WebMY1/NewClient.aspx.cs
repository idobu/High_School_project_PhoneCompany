using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonesProjectBL;

namespace WebMY1
{
    public partial class NewClient : System.Web.UI.Page
    {
        private bool IsCalenderclick = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string userfirstname = FName.Text;
            string userlastname = LName.Text;
            
            if(Page.IsValid)
            {
                ClientBL a = new ClientBL(-1, userfirstname, userlastname, false, DateTime.Now, Convert.ToDateTime(this.DateCalendar.SelectedDate), Convert.ToInt32(Pword.Text),this.EmailBox.Text,this.PhoneBox.Text);
                this.Label7.Text = "Your Username is: " + a.ClientID1 + ".";
                Label7.Visible = true;
            }
            this.Confirmation.Enabled = false;
            this.ResetB.Enabled = false;
           
        }
        protected void CheckMyPage(object sender, EventArgs e)
        {

            if ((RequiredFieldValidator1.IsValid == true) && (RequiredFieldValidator2.IsValid == true) && (RequiredFieldValidator3.IsValid == true) && (RequiredFieldValidator4.IsValid == true) && (RegularExpressionValidator2.IsValid == true) && (RegularExpressionValidator3.IsValid == true) && (RegularExpressionValidator4.IsValid == true) && (RegularExpressionValidator5.IsValid == true) && (CompareValidator1.IsValid = true) && (this.IsCalenderclick = true))
            {
                this.Confirmation.Enabled = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainPage.aspx");
        }

        protected void DateCalendar_SelectionChanged(object sender, EventArgs e)
        {
            this.IsCalenderclick = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.FName.Text = "";
            this.LName.Text = "";
            this.Pword.Text = "";
            this.CPword.Text = "";
            this.EmailBox.Text = "";
        }

        protected void DateCalendar_DayRender(object sender, DayRenderEventArgs e)
        {

        }

       

      
    }
}