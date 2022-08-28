using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDal_phones;
using System.Data;


namespace PhonesProjectBL
{
    public class PhoneOrderBL
    {
        private int OrderID;

        public int OrderID1
        {
            get { return OrderID; }
        }
        private int PersonID;

        public int PersonID1
        {
            get { return PersonID; }         
        }
        private DateTime OrderDateTime;

        public DateTime OrderDateTime1
        {
            get { return OrderDateTime; }
            set { OrderDateTime = value;
            ProjectDal_phones.PhoneOrderDal.UpdateRow(PersonID, value, 2);
            }
        }
     
        private List<PackageStockBL> PackageStock;
        private List<StockBL> PhoneStock;

        private int TotalPrice;

        public int TotalPrice1
        {
            get { return TotalPrice; }
            set { TotalPrice = value; }
        }

        private double TotalafterDiscount;

        public double TotalafterDiscount1
        {
            get { return TotalafterDiscount; }
            set { TotalafterDiscount = value; }
        }
        private string Clienting;

        public string Clienting1
        {
            get { return Clienting; }
            set { Clienting = value; }
        }

     
        /// <summary>
        /// פעולות בונות היוצרות סל קניות חדש(הזמנה) חדש ומזמנות 
        /// את השירותי רשת של הפרוייקטים dog world , Pizzaria
        /// ובדיקה אם הלקוח שמבצע את הקנייה חבר באחד או יותר מהחברות הללו ונתינת הנחה
        /// לחברים בחברות אלו
        /// </summary>
        public PhoneOrderBL()
        {
        }

        public PhoneOrderBL(int OrderID, int PersonID, DateTime OrderDateTime)
        {

            if (!PhoneOrderDal.DoesExist(OrderID))
            {
                PhoneOrderDal.AddOrder(PersonID, OrderDateTime);
                this.PersonID = PersonID;
                this.OrderDateTime = OrderDateTime;
                this.OrderID = ProjectDal_phones.PhoneOrderDal.Getmax();
            }
            else
            {
                this.PersonID = PersonID;
                this.OrderDateTime = OrderDateTime;
                this.OrderID = OrderID;
            }
            PackageStock = new List<PackageStockBL>();
            PhoneStock = new List<StockBL>();
            this.TotalPrice = 0;
            this.TotalafterDiscount = 0;
            //קריאה לשירות חדש()--->נקרא sapirservice
            SapirService.Service1 sapirservice = new SapirService.Service1();
            //קריאה לשירות חדש()--->נקרא adirservice
            AdirService.Service1 adirservice = new AdirService.Service1();
            ClientBL ClientService = new ClientBL(this.PersonID1);
            if (sapirservice.IsExistCourier(ClientService.PhoneNum1,ClientService.Fn)==true)
            {
                this.Clienting = "sapir";
            }
            else
            {   
                if (adirservice.CheckClient(ClientService.Fn,ClientService.Ln,ClientService.PhoneNum1))
                {
                    this.Clienting="adir";
                }
            }

           
        }
        /// <summary>
        /// התייחסות להזמנה נתונה במסד הנתונים
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="OrderID"></param>
        public PhoneOrderBL(int PersonID, int OrderID)
        {
            DataSet a = ProjectDal_phones.PhoneOrderDal.GetOneValueForPerson(PersonID, OrderID);
            DataRow b = a.Tables["tblPhoneOrder"].Rows[0];

            this.PersonID = Convert.ToInt32(b[1]);
            this.OrderDateTime = Convert.ToDateTime(b[2]);
            this.OrderID = Convert.ToInt32(b[0]);

            this.PackageStock = new List<PackageStockBL>();
            this.PhoneStock = new List<StockBL>();


            DataSet c = ProjectDal_phones.PhoneDal.GetAllOrder(OrderID);
            if (c != null)
            {
                foreach (DataRow DRow in c.Tables["tblPhone"].Rows)
                {
                    for (int i = 0; i < Convert.ToInt32(DRow[2]); i++)
                    {
                        StockBL Phone = new StockBL(Convert.ToInt32(DRow[0]));
                        this.PhoneStock.Add(Phone);

                    }
                }
            }

            DataSet d = ProjectDal_phones.PackageDal.GetAllOrder(OrderID);
            if (d != null)
            {
                foreach (DataRow DDRow in d.Tables["tblPackage"].Rows)
                {
                    for (int g = 0; g < Convert.ToInt32(DDRow[2]); g++)
                    {
                        PackageStockBL Package = new PackageStockBL(Convert.ToInt32(DDRow[0]));
                        this.PackageStock.Add(Package);
                    }
                }
            }
            this.GetTotalPrice();
        }
            
        


        
        /// <summary>
        ///  עורך מחיר של מחיר כללי של המוצרים בסל 
        /// </summary>
        public void GetTotalPrice()
        {
            this.TotalPrice = 0;
            foreach ( PackageStockBL a in this.PackageStock)
            {
                this.TotalPrice = this.TotalPrice + a.Price1;
            }

            foreach (StockBL b in this.PhoneStock)
            {
                this.TotalPrice = this.TotalPrice + b.Price2;
            }
        }
        /// <summary>
        /// עורך מחיר כולל של ההנחה והמחיר הסופי
        /// </summary>
        /// <param name="ClientingHim"></param>
        public void GetTotalPriceWith(string ClientingHim)
        {
            ClientBL T = new ClientBL(this.PersonID);
            if (ClientingHim == "sapir")
            {
                this.TotalafterDiscount = TotalPrice - (TotalPrice * 0.5);
            }
            if (ClientingHim == "adir")
            {
                this.TotalafterDiscount = TotalPrice - (TotalPrice * 0.3);
            }
            
        }
       /// <summary>
       /// פעולה המוסיפה טלפון ומבצעת בצורה ישירה את העדכונים ממסד הנתונים 
       /// </summary>
       /// <param name="Phone"></param>
       /// <param name="PersonID"></param>
       /// <param name="OrderID"></param>
        public void AddPhone(StockBL Phone, int PersonID, int OrderID)
        {
            if (Phone.PhonesInStock2 != 0)
            {
                if (ProjectDal_phones.PhoneDal.DoesExist(OrderID,Phone.IDPhone1))
                {
                    DataSet ds = ProjectDal_phones.PhoneDal.GetAllForType(Phone.IDPhone1, OrderID);
                    DataRow b = ds.Tables["tblPhone"].Rows[0];

  
                    {
                        ProjectDal_phones.PhoneDal.UpdateRow(OrderID, (Convert.ToInt32(b[2]) + 1), 2,Phone.IDPhone1);
                        int w = Phone.PhonesInStock2;
                        ProjectDal_phones.StockDal.UpdateRow(Phone.IDPhone1, w - 1, 1);
                        Phone.PhonesInStock2 = w - 1;
                        PhoneStock.Add(Phone);
                    }

                }
                else
                {
                    PhoneDal.AddPhone(OrderID, Phone.IDPhone1, 1);
                    int m = Phone.PhonesInStock2;
                    ProjectDal_phones.StockDal.UpdateRow(Phone.IDPhone1, m - 1, 1);
                    Phone.PhonesInStock2 = m - 1;
                    PhoneStock.Add(Phone);
                }


            }
            else
            {
                Console.WriteLine("No phones in stock!");
            }
        }
        /// <summary>
        /// פעולה המוסיפה חבילה ומבצעת בצורה ישירה את העדכונים ממסד הנתונים 
        /// </summary>
        /// <param name="Package"></param>
        /// <param name="PersonID"></param>
        /// <param name="OrderID"></param>
        public void AddPackage(PackageStockBL Package, int PersonID, int OrderID)
        {

            if (Package.PackageInStock1 != 0)
            {
                if (ProjectDal_phones.PackageDal.DoesExist(OrderID, Package.PackageNum1))
                {
                    DataSet ds = ProjectDal_phones.PackageDal.GetAllForType(Package.PackageNum1, OrderID);
                    DataRow b = ds.Tables["tblPackage"].Rows[0];

                    //if (Convert.ToInt32(b[2]) > 0)


                    ProjectDal_phones.PackageDal.UpdateRow(OrderID, (Convert.ToInt32(b[2]) + 1), 2,Package.PackageNum1);
                    ProjectDal_phones.PackageStockDal.UpdateRow(Package.PackageNum1, Package.PackageInStock1 - 1, 4);
                    Package.PackageInStock1 = Package.PackageInStock1 - 1;
                    PackageStock.Add(Package);


                }
                else
                {
                    ProjectDal_phones.PackageDal.AddPackage(OrderID, Package.PackageNum1, 1);
                    ProjectDal_phones.PackageStockDal.UpdateRow(Package.PackageNum1, Package.PackageInStock1 - 1, 4);
                    Package.PackageInStock1 = Package.PackageInStock1 - 1;
                    PackageStock.Add(Package);
                }



            }
        }



        /// <summary>
        /// הסרת טלפון ועדכונים ישירים ממסד הנתונים
        /// </summary>
        /// <param name="Phone"></param>
        /// <param name="OrderID"></param>
        public void RemovePhone( StockBL Phone, int OrderID)
        {
            DataSet ds = ProjectDal_phones.PhoneDal.GetAllForType(Phone.IDPhone1, OrderID);
            DataRow b = ds.Tables["tblPhone"].Rows[0];

            if (Convert.ToInt32(b[2]) > 1)
            {
                ProjectDal_phones.PhoneDal.UpdateRow(OrderID, (Convert.ToInt32(b[2]) - 1), 2,Phone.IDPhone1);
                int w = Phone.PhonesInStock2;
                ProjectDal_phones.StockDal.UpdateRow(Phone.IDPhone1, w + 1, 1);
                Phone.PhonesInStock2 = w + 1;
                StockBL a = this.PhoneStock.Find(StockBL => StockBL.IDPhone1 == Phone.IDPhone1);
                this.PhoneStock.Remove(a);
            }

            else
            {
                //ProjectDal_phones.PhoneDal.UpdateRow(OrderID, (Convert.ToInt32(b[2]) - 1), 2);
                int w = Phone.PhonesInStock2;
                ProjectDal_phones.StockDal.UpdateRow(Phone.IDPhone1, w + 1, 1);
                Phone.PhonesInStock2 = w + 1;
                StockBL a = this.PhoneStock.Find(StockBL => StockBL.IDPhone1 == Phone.IDPhone1);
                ProjectDal_phones.PhoneDal.DeletePhoneFrom(Phone.IDPhone1, OrderID);
                this.PhoneStock.Remove(a);
            }
        }
        /// <summary>
        /// הסרת חבילה ועדכונים ישירים ממסד הנתונים
        /// </summary>
        /// <param name="Package"></param>
        /// <param name="OrderID"></param>
        public void RemovePackage(PackageStockBL Package, int OrderID)
        {
            DataSet ds = ProjectDal_phones.PackageDal.GetAllForType(Package.PackageNum1, OrderID);
            DataRow b = ds.Tables["tblPackage"].Rows[0];
            if (Convert.ToInt32(b[2]) > 1)
            {
                ProjectDal_phones.PackageDal.UpdateRow(OrderID, (Convert.ToInt32(b[2]) - 1), 2,Package.PackageNum1);
                int w = Package.PackageInStock1;
                ProjectDal_phones.PackageStockDal.UpdateRow(Package.PackageNum1, w + 1, 4);
                Package.PackageInStock1 = w + 1;
                PackageStockBL a = this.PackageStock.Find(PackageStockBL => PackageStockBL.PackageNum1 == Package.PackageNum1);
                this.PackageStock.Remove(a);
            }

            else
            {
                int w = Package.PackageInStock1;
                ProjectDal_phones.PackageStockDal.UpdateRow(Package.PackageNum1, w + 1, 4);
                Package.PackageInStock1 = w + 1;
                PackageStockBL a = this.PackageStock.Find(PackageStockBL => PackageStockBL.PackageNum1 == Package.PackageNum1);
                ProjectDal_phones.PackageDal.DeletePackageFrom(Package.PackageNum1, OrderID);
                this.PackageStock.Remove(a);
            }

        }

        /// <summary>
        /// עדכון ממאגר הרבים של ההזמנות
        /// </summary>
        /// <param name="ToUpdate"></param>
        /// <param name="newinfo"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UpdateManager(string ToUpdate, object newinfo, int ID)
        {
            if (ToUpdate == "OrderDateTime")
            {
                PhoneOrderDal.UpdateRow(ID, newinfo, 2);
                return 1;

            }
            return -1;
        }
        /// <summary>
        /// הדפסת הזמנה ונתוניה
        /// </summary>
        /// <returns></returns>
        public string print()
        {
            string a = this.OrderID + "" + this.PersonID + "" + this.OrderDateTime + "" + this.PhoneStock.ToString()+ "" + this.PackageStock.ToString()+"\n";
            foreach(PackageStockBL w in PackageStock)
            {
                a += w.ToString();
                a += "\n";
            }
            foreach(StockBL b in PhoneStock)
            {
                a += b.ToString();
                a += "\n";
            }
            return a;
        }
        /// <summary>
        /// הפעלת פעולה להסרת הזמנה
        /// </summary>
        /// <param name="OrderID"></param>
        public static void RemoveThisOrder(int OrderID)
        {
            ProjectDal_phones.PhoneOrderDal.DeleteRow(OrderID);
        }
        /// <summary>
        /// החזרה של ההזמנה המקסימאלית והאחרונה
        /// </summary>
        /// <returns></returns>
       public static int GetMyMax()
       {
           return ProjectDal_phones.PhoneOrderDal.Getmax();
       }
        /// <summary>
        /// החזרת כל ההזמנות
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllOrders()
        {
            return ProjectDal_phones.PhoneOrderDal.GetAll();
        }
    }
}
