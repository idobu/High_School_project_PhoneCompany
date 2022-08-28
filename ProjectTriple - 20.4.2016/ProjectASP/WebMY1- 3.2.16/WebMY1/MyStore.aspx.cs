using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhonesProjectBL;
using System.Data;
using System.Net.Mail;

namespace WebMY1
{
    public partial class MyStore : System.Web.UI.Page
    {
        private int MyId;
        private PhoneOrderBL Cart;
        /// <summary>
        /// טעינה ראשונית של הדף 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyId = Convert.ToInt32(Session["ClientID"]);

            if (!IsPostBack)
            {
                this.Cart = new PhoneOrderBL(-1, MyId, DateTime.Now);
                if(this.Cart.Clienting1=="sapir")
                {
                    this.Label21.Visible = true;
                    this.TotalPriceafter.Visible = true;
                    this.Label20.Visible = true;
                    this.Label25.Visible = true;
                }
                if(this.Cart.Clienting1=="adir")
                {
                    this.Label21.Visible = true;
                    this.TotalPriceafter.Visible = true;
                    this.Label22.Visible = true;
                    this.Label24.Visible = true;
                }
                // בחירה התחלתית של כל הטלפונים להצגה ראשונים
                DataSet a = PhonesProjectBL.StockBL.ReturnGetPhonesForOrder_All();
                a.Tables["tblStock"].Columns[0].ColumnName = "Phone Name";
                a.Tables["tblStock"].Columns[1].ColumnName = "Phone Color";
                a.Tables["tblStock"].Columns[2].ColumnName = "Phone Company";
                a.Tables["tblStock"].Columns[4].ColumnName = "Creation Year";
                a.Tables["tblStock"].Columns[5].ColumnName = "Serial Number";
                this.StorePhones.DataSource = a;
                this.StorePhones.DataBind();

                // בחירה התחלתית של כל החבילות להצגה ראשונים
                DataSet h = PhonesProjectBL.PackageStockBL.ReturnPackages_All();
                h.Tables["tblPackage"].Columns[1].ColumnName = "Package Information";
                h.Tables["tblPackage"].Columns[2].ColumnName = "Restriction";
                this.StorePacks.DataSource = h;
                this.StorePacks.DataBind(); 


            }
            else
            {
                this.Cart = new PhoneOrderBL(MyId, PhonesProjectBL.PhoneOrderBL.GetMyMax());
            }
        }

       
        /// <summary>
        /// בחירת הסוג של קטגוריה של טלפונים
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ClientPickPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ClientPickPhone.SelectedIndex == 0)
            {
                DataSet a = PhonesProjectBL.StockBL.ReturnGetPhonesForOrder_All();
                a.Tables["tblStock"].Columns[0].ColumnName = "Phone Name";
                a.Tables["tblStock"].Columns[1].ColumnName = "Phone Color";
                a.Tables["tblStock"].Columns[2].ColumnName = "Phone Company";
                a.Tables["tblStock"].Columns[4].ColumnName = "Creation Year";
                a.Tables["tblStock"].Columns[5].ColumnName = "Serial Number";
                this.StorePhones.DataSource = a;
                this.StorePhones.DataBind();
            }
            if (this.ClientPickPhone.SelectedIndex == 1)
            {
                DataSet b = PhonesProjectBL.StockBL.ReturnClientPhones(MyId);
                b.Tables["tblStock"].Columns[0].ColumnName = "Phone Name";
                b.Tables["tblStock"].Columns[1].ColumnName = "Phone Color";
                b.Tables["tblStock"].Columns[2].ColumnName = "Phone Company";
                b.Tables["tblStock"].Columns[4].ColumnName = "Creation Year";
                b.Tables["tblStock"].Columns[5].ColumnName = "Serial Number";
                this.StorePhones.DataSource = b;
                this.StorePhones.DataBind();
            }
            if (this.ClientPickPhone.SelectedIndex == 2)
            {
                OurSuggetions ClientSugg = new OurSuggetions(MyId,this.Cart.OrderID1);
                DataSet c = ClientSugg.GetMySuggestions();
                c.Tables["tblStock"].Columns[0].ColumnName = "Phone Name";
                c.Tables["tblStock"].Columns[1].ColumnName = "Phone Color";
                c.Tables["tblStock"].Columns[2].ColumnName = "Phone Company";
                c.Tables["tblStock"].Columns[4].ColumnName = "Creation Year";
                c.Tables["tblStock"].Columns[5].ColumnName = "Serial Number";
                this.StorePhones.DataSource = c;
                this.StorePhones.DataBind();
            }
            if (this.ClientPickPhone.SelectedIndex == 3)
            {
                DataSet d = PhonesProjectBL.StockBL.ReturnClientNewPhones();
                d.Tables["tblStock"].Columns[0].ColumnName = "Phone Name";
                d.Tables["tblStock"].Columns[1].ColumnName = "Phone Color";
                d.Tables["tblStock"].Columns[2].ColumnName = "Phone Company";
                d.Tables["tblStock"].Columns[4].ColumnName = "Creation Year";
                d.Tables["tblStock"].Columns[5].ColumnName = "Serial Number";
                this.StorePhones.DataSource = d;
                this.StorePhones.DataBind();

            }
        }

        protected void AddPhone_Click(object sender, EventArgs e)
        {
            if(this.StorePhones !=null)
            {

            }
        }
        /// <summary>
        /// פעולה המבטלת את ההשהיה על כפתור האישור
        /// </summary>
        protected void DisableConf()
        {
            if ((this.YourPhones.Items.Count == 0) && (this.YourPacks.Items.Count == 0))
            {
                this.AcceptPur.Enabled = false;
            }
            else
            {
                this.AcceptPur.Enabled = true;
            }
        }

        /// <summary>
        /// בחירת קטגוריה של החבילה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ClientPickPack_SelectedIndexChanged(object sender, EventArgs e)               
        {
            if (this.ClientPickPack.SelectedIndex == 0)                                                  
            {
                DataSet h = PhonesProjectBL.PackageStockBL.ReturnPackages_All();
                h.Tables["tblPackage"].Columns[1].ColumnName = "Package Information";
                h.Tables["tblPackage"].Columns[2].ColumnName = "Restriction";
                this.StorePacks.DataSource = h;
                this.StorePacks.DataBind(); 
                
            }
            if (this.ClientPickPack.SelectedIndex == 1)                                                  
            {
                DataSet m = PhonesProjectBL.PackageStockBL.ReturnPackages_Favorits(MyId);
                m.Tables["tblPackage"].Columns[1].ColumnName = "Package Information";
                m.Tables["tblPackage"].Columns[2].ColumnName = "Restriction";
                this.StorePacks.DataSource = m;
                this.StorePacks.DataBind(); 
            }
        }
        /// <summary>
        /// פעולה לבחירת כמות הטלפונים מהסוג שניתן
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void phoneamount_SelectedIndexChanged(object sender, EventArgs e)                              //כמות טלפונים
        {
            StockBL thisphone = new StockBL(this.StorePhones.SelectedRow.Cells[3].Text, this.StorePhones.SelectedRow.Cells[2].Text, this.StorePhones.SelectedRow.Cells[4].Text);
            int m = Convert.ToInt32(phoneamount.SelectedIndex);
            if (thisphone.PhonesInStock2 != 0)
            {
                for (int g = 0; g < m + 1; g++)
                {
                    this.YourPhones.Items.Add("Phone: " + this.StorePhones.SelectedRow.Cells[2].Text + " Colored: " + this.StorePhones.SelectedRow.Cells[3].Text + " From Company: " + this.StorePhones.SelectedRow.Cells[4].Text + " Priced: " + this.StorePhones.SelectedRow.Cells[5].Text);
                    StockBL addedPhone = new StockBL(this.StorePhones.SelectedRow.Cells[3].Text, this.StorePhones.SelectedRow.Cells[2].Text, this.StorePhones.SelectedRow.Cells[4].Text);
                    this.Cart.AddPhone(addedPhone, MyId, Cart.OrderID1);
                }


                StockBL thisphone1 = new StockBL(this.StorePhones.SelectedRow.Cells[3].Text, this.StorePhones.SelectedRow.Cells[2].Text, this.StorePhones.SelectedRow.Cells[4].Text);
                this.phoneamount.Items.Clear();
                for (int i = 1; i < thisphone1.PhonesInStock2 + 1; i++)
                {
                    phoneamount.Items.Add(Convert.ToString(i));
                }
                this.Cart.GetTotalPrice();
                if (this.Cart.TotalPrice1 > 0)
                {
                    if(this.Label20.Visible==true)
                    {
                        this.Cart.GetTotalPriceWith("sapir");
                    }
                    if (this.Label22.Visible == true)
                    {
                        this.Cart.GetTotalPriceWith("adir");
                    }
                }
                else
                {
                    this.Cart.TotalafterDiscount1 = 0;
                }
                this.TotalPriceafter.Text = Convert.ToString(this.Cart.TotalafterDiscount1);
            
                this.Totalprice.Text = Convert.ToString(this.Cart.TotalPrice1);
            }
            else
            {
                this.StorePhones.SelectedRow.Cells[1].Text = "Sorry, but this Phone in unavailable in the stock right now";
                this.StorePhones.SelectedRow.Enabled = false;
            }
            this.DisableConf();
        }
   
        
               
        /// <summary>
        /// בחירת סוג הטלפון מהטבלה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)                                //הוספת טלפון
        {
            StockBL thisPhone = new StockBL(this.StorePhones.SelectedRow.Cells[3].Text, this.StorePhones.SelectedRow.Cells[2].Text, this.StorePhones.SelectedRow.Cells[4].Text);
            int NumberOfPacks = thisPhone.PhonesInStock2;
            if (thisPhone.PhonesInStock2 != 0)
            {
                this.phoneamount.Items.Clear();
                for (int i = 1; i < NumberOfPacks + 1; i++)
                {
                    phoneamount.Items.Add(Convert.ToString(i));
                }
            }
            else
            {
                this.StorePhones.SelectedRow.Cells[1].Text="Sorry, but this Phone in unavailable in the stock right now";
                this.StorePhones.SelectedRow.Enabled = false;
            }
        }
         /// <summary>
         /// הסרת הטלפון מהרשימה מצד הסל של הלקוח
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void YourPhones_SelectedIndexChanged(object sender, EventArgs e)                               // הסרת טלפון
        {
            string Pname = MyStore.Between(this.YourPhones.SelectedItem.ToString(), "Phone: ", "Colored:");
            string color = MyStore.Between(this.YourPhones.SelectedItem.ToString(), "Colored: ", "From");
            string Company = MyStore.Between(this.YourPhones.SelectedItem.ToString(), "Company: ", "Priced:");

            this.YourPhones.Items.Remove(this.YourPhones.SelectedItem);
            
            StockBL removedPhone = new StockBL(color,Pname,Company);
            this.Cart.RemovePhone(removedPhone, Cart.OrderID1);
            this.Cart.GetTotalPrice();
            if (this.Cart.TotalPrice1 > 0)
            {
                if (this.Label20.Visible == true)
                {
                    this.Cart.GetTotalPriceWith("sapir");
                }
                if (this.Label22.Visible == true)
                {
                    this.Cart.GetTotalPriceWith("adir");
                }
            }
            this.TotalPriceafter.Text = Convert.ToString(this.Cart.TotalafterDiscount1);
            
            this.Totalprice.Text = Convert.ToString(this.Cart.TotalPrice1);
            StockBL thisphone1 = new StockBL(color, Pname, Company);
            this.phoneamount.Items.Clear();
            for (int i = 1; i < thisphone1.PhonesInStock2+1;i++ )
            {
                phoneamount.Items.Add(Convert.ToString(i));
            }
            //foreach (DataRow a in this.StorePacks.Rows)
            //{
            //    PackageStockBL Thispack = new PackageStockBL(a[2].ToString(), (int)a[1]);
            //    if (Thispack.PackageInStock1 == 0)
            //    {
            //        a.Delete();
            //    }
            //}
            this.DisableConf();
        }
   
        /// <summary>
        /// בחירת כמות החבילות מהסוג שנבחר
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                PackageStockBL thispack = new PackageStockBL(this.StorePacks.SelectedRow.Cells[3].Text, (Convert.ToInt32(this.StorePacks.SelectedRow.Cells[2].Text)));     // כמות חבילות
                int m = Convert.ToInt32(packamount.SelectedIndex);
                if (thispack.PackageInStock1 != 0)
                {
                    for (int g = 0; g < m+1; g++)
                    {
                        this.YourPacks.Items.Add("Pack:" + this.StorePacks.SelectedRow.Cells[3].Text + " Its Price: " + this.StorePacks.SelectedRow.Cells[2].Text + ".");
                        PackageStockBL addPack = new PackageStockBL(this.StorePacks.SelectedRow.Cells[3].Text, Convert.ToInt32(this.StorePacks.SelectedRow.Cells[2].Text));
                        this.Cart.AddPackage(addPack, MyId, this.Cart.OrderID1);
                    }
                    PackageStockBL thispack1 = new PackageStockBL(this.StorePacks.SelectedRow.Cells[3].Text, (Convert.ToInt32(this.StorePacks.SelectedRow.Cells[2].Text)));
                    this.packamount.Items.Clear();
                    for (int i = 1; i < thispack1.PackageInStock1 + 1; i++)
                    {
                        packamount.Items.Add(Convert.ToString(i));
                    }
                    this.Cart.GetTotalPrice();
                    if (this.Cart.TotalPrice1 > 0)
                    {
                        if (this.Label20.Visible == true)
                        {
                            this.Cart.GetTotalPriceWith("sapir");
                        }
                        if (this.Label22.Visible == true)
                        {
                            this.Cart.GetTotalPriceWith("adir");
                        }
                    }
                    this.TotalPriceafter.Text = Convert.ToString(this.Cart.TotalafterDiscount1);
                    
                    this.Totalprice.Text = Convert.ToString(this.Cart.TotalPrice1);
                }
                else
                {
                    this.packamount.Items.Clear();
                    this.StorePacks.SelectedRow.Cells[1].Text = "Sorry, but this package in unavailable in the stock right now";
                    this.StorePacks.SelectedRow.Enabled = false;
                }

                this.DisableConf();   
        }
        /// <summary>
        /// בחירת סוג חבילה מהטבלה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void StorePacks_SelectedIndexChanged(object sender, EventArgs e)                                                                                     //הוספת חבילה
        {
            PackageStockBL thispack = new PackageStockBL(this.StorePacks.SelectedRow.Cells[3].Text, (Convert.ToInt32(this.StorePacks.SelectedRow.Cells[2].Text)));
            int NumberOfPacks = thispack.PackageInStock1;
            if (thispack.PackageInStock1 != 0)
            {
                this.packamount.Items.Clear();
                for (int i = 1; i < NumberOfPacks + 1; i++)
                {
                    packamount.Items.Add(Convert.ToString(i));
                }
            }
            else
            {
                this.StorePacks.SelectedRow.Cells[1].Text = "Sorry, but this package in unavailable in the stock right now";
                this.StorePacks.SelectedRow.Enabled = false;
            }

            //foreach (GridViewRow a in this.StorePacks.Rows)
            //{
            //    PackageStockBL Thispack = new PackageStockBL(a[2].ToString(), (int)a[1]);
            //    if (Thispack.PackageInStock1 == 0)
            //    {
            //        a.Delete();
            //    }
            //}
            //for (int i = 0; this.YourPacks.Columns.Count > i; )
            //{
            //    this.YourPacks.Columns.RemoveAt(i);
            //}
           
        }
        /// <summary>
        /// הסרת חבילה מצד הלקוח בסל הקניות
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void YourPacks_SelectedIndexChanged(object sender, EventArgs e)                                   //הסרת חבילה
        {
            int Price = Convert.ToInt32(MyStore.Between(this.YourPacks.SelectedItem.Text, "Price: ", "."));
            string Packinfo = MyStore.Between(this.YourPacks.SelectedItem.Text, "Pack: ", "Its");

            this.YourPacks.Items.Remove(this.YourPacks.SelectedItem);
            PackageStockBL removePack = new PackageStockBL(Packinfo, Price);
            this.Cart.RemovePackage(removePack, this.Cart.OrderID1);
            this.Cart.GetTotalPrice();
            if (this.Cart.TotalPrice1 > 0)
            {
                if (this.Label20.Visible == true)
                {
                    this.Cart.GetTotalPriceWith("sapir");
                }
                if (this.Label22.Visible == true)
                {
                    this.Cart.GetTotalPriceWith("adir");
                }
            }
            this.TotalPriceafter.Text = Convert.ToString(this.Cart.TotalafterDiscount1);
            this.Totalprice.Text = Convert.ToString(this.Cart.TotalPrice1);
          
            PackageStockBL thispack1 = new PackageStockBL(this.StorePacks.SelectedRow.Cells[3].Text, (Convert.ToInt32(this.StorePacks.SelectedRow.Cells[2].Text)));
            this.packamount.Items.Clear();
            for (int i = 1; i < thispack1.PackageInStock1 + 1; i++)
            {
                packamount.Items.Add(Convert.ToString(i));
            }
         
            this.DisableConf();
        }
       /// <summary>
       /// מציאת נתונים במשפט לקבלת נתונים לחיפוש בעזרתם
       /// </summary>
       /// <param name="Text"></param>
       /// <param name="FirstString"></param>
       /// <param name="LastString"></param>
       /// <returns></returns>
        public static string Between(string Text, string FirstString, string LastString)                   //מציאת נתונים במשפט -2
        {
            string STR = Text;
            string STRFirst = FirstString;
            string STRLast = LastString;
            string FinalString;

            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        /// <summary>
        /// פעולת שליחת המייל על ביטול בקשת הלקוח להיכנס למערכת
        /// </summary>
        /// <param name="email"></param>
        private void SendEmail(string email)
        {
            MailAddress from = new MailAddress("phonecompany78@gmail.com");
            MailAddress to = new MailAddress(email);

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(from.Address, "Administrato");

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Report on activity in your account";
            if((this.Label20.Visible==true) ||(this.Label22.Visible==true))
            {
                message.Body = "Dear client, You have just accepted a order in PhoneStore company, the order price: " + this.TotalPriceafter.Text + "Shekels.";
            }
            else
            {
                message.Body = "Dear client, You have just accepted a order in PhoneStore company, the order price: " + this.Totalprice.Text+ "Shekels.";
            }
            
                client.Send(message);
    
        }
        /// <summary>
        /// פעולת חזרה המבטלת גם את העסקה שנפתחה ומוחקת אותה מהזיכרון
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ReturnBack_Click(object sender, EventArgs e)
        {
            if(this.AcceptPur.Enabled==true)
            {
            foreach(ListItem a in YourPacks.Items)
            {
                int Price = Convert.ToInt32(MyStore.Between(a.Text, "Price: ", "."));
                string Packinfo = MyStore.Between(a.Text, "Pack: ", "Its");
                PackageStockBL removed = new PackageStockBL(Packinfo,Price);
                this.Cart.RemovePackage(removed, this.Cart.OrderID1);
            }
            foreach (ListItem b in YourPhones.Items)
            {
                string Pname = MyStore.Between(b.Text, "Phone: ", "Colored:");
                string color = MyStore.Between(b.Text, "Colored: ", "From");
                string Company = MyStore.Between(b.Text, "Company: ", "Priced:");
                StockBL removed = new StockBL(color, Pname, Company);
                this.Cart.RemovePhone(removed, this.Cart.OrderID1);
            }
            PhonesProjectBL.PhoneOrderBL.RemoveThisOrder(Cart.OrderID1);
            Response.Redirect("~/ClientChoise.aspx");
            }
            else
            {
                Response.Redirect("~/ClientChoise.aspx");
            }
        }
        /// <summary>
        /// אישור העסקה ושליחה ללקוח מייל על אישורה
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AcceptPur_Click(object sender, EventArgs e)
        {
            Cart.OrderDateTime1 = DateTime.Now;
            this.ChangeControlStatus(false);
            this.ReturnBack.Enabled = true;

            this.Label8.Visible = true;

            ClientBL user = new ClientBL(MyId);
            this.SendEmail(user.Email1);

            Response.Redirect("~/AcceptPage.aspx");


        }
        /// <summary>
        /// פעולה המבטלת את הכלים בדף
        /// </summary>
        /// <param name="status"></param>
        public void ChangeControlStatus(bool status)
        {

            foreach (Control c in Page.Controls)
                foreach (Control ctrl in c.Controls)

                    if (ctrl is TextBox)

                        ((TextBox)ctrl).Enabled = status;

                    else if (ctrl is Button)

                        ((Button)ctrl).Enabled = status;

                    else if (ctrl is RadioButton)

                        ((RadioButton)ctrl).Enabled = status;

                    else if (ctrl is ImageButton)

                        ((ImageButton)ctrl).Enabled = status;

                    else if (ctrl is CheckBox)

                        ((CheckBox)ctrl).Enabled = status;

                    else if (ctrl is DropDownList)

                        ((DropDownList)ctrl).Enabled = status;

                    else if (ctrl is HyperLink)

                        ((HyperLink)ctrl).Enabled = status;

        }

        protected void StorePhones_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

       

        
    }
}