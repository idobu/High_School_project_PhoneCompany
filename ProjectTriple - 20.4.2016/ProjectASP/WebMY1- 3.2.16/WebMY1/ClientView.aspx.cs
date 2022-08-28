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
    public partial class ClientView : System.Web.UI.Page
    {
        private int MyIndex;
        private int MyId;

        protected void Page_Load(object sender, EventArgs e)
        {
            MyId = Convert.ToInt32(Session["ClientID"]);
            MyIndex = Convert.ToInt32(Session["ClientIndex"]);
            if(this.MyIndex==3)
            {
                Response.Redirect("~/MyStore.aspx");
            }
            if (!Page.IsPostBack)
            {
                if (MyIndex != 4)
                {
                    MyViews.ActiveViewIndex = MyIndex;
                    ClientBL b = new ClientBL(MyId);
                    if (MyIndex == 0)
                    {
                        this.UserNameLabel.Text = Convert.ToString(MyId);
                        this.FirstName.Text = b.Fn;
                        this.LastName.Text = b.Ln;
                        this.PhoneClient.Text = b.PhoneNum1;
                        this.EmailBox.Text = b.Email1;
                        this.DateCal.SelectedDate = b.BirthDate1;
                    }
                    if (MyIndex == 2)
                    {
                        DataSet m = PhonesProjectBL.StockBL.ReturnMyPhones(MyId);
                        m.Tables["tblPhone"].Columns[0].ColumnName = "Phone Name";
                        m.Tables["tblPhone"].Columns[1].ColumnName = "Order number";
                        m.Tables["tblPhone"].Columns[2].ColumnName = "Amount of phones";
                        this.Phones.DataSource = m;


                        DataSet w = PhonesProjectBL.PackageStockBL.ReturnMyPackages(MyId);
                        w.Tables["tblPackage"].Columns[0].ColumnName = "Package name";
                        w.Tables["tblPackage"].Columns[1].ColumnName = "Order number";
                        w.Tables["tblPackage"].Columns[2].ColumnName = "Amount";
                        this.Packs.DataSource = w;



                        this.Packs.DataBind();
                        this.Phones.DataBind();
                    }
                }
                if(MyIndex== 4)
                {
                    MyViews.ActiveViewIndex = MyIndex-1;
                }
            }
            
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void PassBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ClientChoise.aspx");
        }

        protected void Confirmation_Click(object sender, EventArgs e)
        {
            ClientBL a = new ClientBL(MyId);
            if (Page.IsValid)
            {
            a.Fn = FirstName.Text;
            a.Ln = LastName.Text;
            a.Email1 = EmailBox.Text;
                if(this.DateCal.SelectedDate != null)
                {
                 a.JoinDate1 = DateCal.SelectedDate;
                }
            }
            Response.Redirect("~/ClientChoise.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ClientChoise.aspx");
        }

        protected void CPassword_Click(object sender, EventArgs e)
        {
            ClientBL f = new ClientBL(MyId);
            if(Page.IsValid)
            {
                f.Password1 = Convert.ToInt32(Npass.Text);
            }
            Response.Redirect("~/ClientChoise.aspx");
        }

        protected void TableBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ClientChoise.aspx");
        }

        protected void AcceptComp_Click(object sender, EventArgs e)
        {
            ComplainBL a = new ComplainBL(-1, MyId, DateTime.Now, TextBox1.Text, TextBox2.Text);
            Response.Redirect("~/ClientChoise.aspx");
        }

        protected void BackComp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ClientChoise.aspx");
        }
    }
}