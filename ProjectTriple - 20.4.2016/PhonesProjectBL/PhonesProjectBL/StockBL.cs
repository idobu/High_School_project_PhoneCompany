using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDal_phones;
using System.Data;
namespace PhonesProjectBL
{
    public class StockBL
    {
        private int IDPhone;               //מספר של טלפון במחסן

        public int IDPhone1
        {
            get { return IDPhone; }
        }
        private int PhonesInStock;         //מספר טלפונים במחסן

        public int PhonesInStock2
        {
            get { return PhonesInStock; }
            set { PhonesInStock = value;
            ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 1);
            }
        }
        private string Pcolor;             //צבע טלפון

        public string Pcolor2
        {
            get { return Pcolor; }
            set { Pcolor = value;
            ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 2);
            }
        }
        private string Pcompany;           //חברת ייצור הטלפון

        public string Pcompany2
        {
            get { return Pcompany; }
            set
            {
                Pcompany = value; 
                ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 3);
            }
        }
        private int Price;                 //מחיר

        public int Price2
        {
            get { return Price; }
            set
            {
                Price = value;
                ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 4);
            }
        }
        private int CreationYear;          //שנת ייצור

        public int CreationYear2
        {
            get { return CreationYear; }
            set { CreationYear = value;
            ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 5);
            }
        }
        private int SerialNum;             //מספר סיריאל של הטלפון

        public int SerialNum2
        {
            get { return SerialNum; }
            set { SerialNum = value;
            ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 6);
            }
        }
        private string Pname;

        public string Pname1
        {
            get { return Pname; }
            set { Pname = value;
            ProjectDal_phones.StockDal.UpdateRow(IDPhone, value, 7);
            }
        }

        public StockBL()
        {
        }
        /// <summary>
        /// פעולה בונה לטלפון חדש במערכת
        /// </summary>
        /// <param name="IDPhone"></param>
        /// <param name="PhonesInStock"></param>
        /// <param name="Pcolor"></param>
        /// <param name="Pcompany"></param>
        /// <param name="Price"></param>
        /// <param name="CreationYear"></param>
        /// <param name="SerialNum"></param>
        /// <param name="Pname"></param>
        public StockBL(int IDPhone ,int PhonesInStock, string Pcolor, string Pcompany, int Price, int CreationYear, int SerialNum,string Pname)
        {
            if (!StockDal.DoesExist(IDPhone))
            {
                ProjectDal_phones.StockDal.AddPhoneToStock(PhonesInStock, Pcolor, Pcompany, Price, CreationYear, SerialNum,Pname);
                this.PhonesInStock = PhonesInStock;
                this.Pcolor = Pcolor;
                this.Pcompany = Pcompany;
                this.Price = Price;
                this.CreationYear = CreationYear;
                this.SerialNum = SerialNum;
                this.Pname = Pname;
                this.IDPhone = ProjectDal_phones.StockDal.GetMax();
            }
            else
            {
                
            }
       
        }
        public StockBL(int IDPhone,int AddToStock)
        {
            DataSet a = ProjectDal_phones.StockDal.GetValue(IDPhone);
            DataRow b = a.Tables["tblStock"].Rows[0];
            this.PhonesInStock = AddToStock + Convert.ToInt32(b[1]);
            ProjectDal_phones.StockDal.UpdateRow(IDPhone, AddToStock + Convert.ToInt32(b[1]), 1);
            this.Pcolor = Convert.ToString(b[2]);
            this.Pcompany = Convert.ToString(b[3]);
            this.Price = Convert.ToInt32(b[4]);
            this.CreationYear = Convert.ToInt32(b[5]);
            this.SerialNum = Convert.ToInt32(b[6]);
            this.Pname = Convert.ToString(b[7]);
            this.IDPhone = Convert.ToInt32(b[0]);
        }
        public StockBL(int IDPhone)
        {
            DataSet a = ProjectDal_phones.StockDal.GetValue(IDPhone);
            DataRow b = a.Tables["tblStock"].Rows[0];
            this.PhonesInStock = Convert.ToInt32(b[1]);
            this.Pcolor = Convert.ToString(b[2]);
            this.Pcompany = Convert.ToString(b[3]);
            this.Price = Convert.ToInt32(b[4]);
            this.CreationYear = Convert.ToInt32(b[5]);
            this.SerialNum = Convert.ToInt32(b[6]);
            this.Pname = Convert.ToString(b[7]);
            this.IDPhone = Convert.ToInt32(b[0]);
        }
        public StockBL(string color,string Pname,string Pcompany)
        {
            DataSet a = ProjectDal_phones.StockDal.GetSpecificPhone(color, Pname, Pcompany);
            if(a.Tables["tblStock"].Rows.Count!=0)
            {
            DataRow b = a.Tables["tblStock"].Rows[0];
            this.PhonesInStock = Convert.ToInt32(b[1]);
            this.Pcolor = Convert.ToString(b[2]);
            this.Pcompany = Convert.ToString(b[3]);
            this.Price = Convert.ToInt32(b[4]);
            this.CreationYear = Convert.ToInt32(b[5]);
            this.SerialNum = Convert.ToInt32(b[6]);
            this.Pname = Convert.ToString(b[7]);
            this.IDPhone = Convert.ToInt32(b[0]);
            }
        }

        
        /// <summary>
        /// שינוי ערכים בפונציית רבים של הטלפונים
        /// </summary>
        /// <param name="ToUpdate"></param>
        /// <param name="newinfo"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UpdateManager(string ToUpdate, object newinfo, int ID)
        {
            if (ToUpdate == "PhonesInStock")
            {
               StockDal.UpdateRow(ID ,newinfo, 1);
                return 1;

            }
            if (ToUpdate == "Pcolor")
            {
                StockDal.UpdateRow(ID, newinfo, 2);
                return 2;

            }
            if (ToUpdate == "Pcompany")
            {
                StockDal.UpdateRow(ID, newinfo, 3);
                return 3;

            }
            if (ToUpdate == "Price")
            {
                StockDal.UpdateRow(ID, newinfo, 4);
                return 4;

            }
            if (ToUpdate == "CreationYear")
            {
                StockDal.UpdateRow(ID, newinfo, 5);
                return 5;

            }
            if (ToUpdate == "SerialNum")
            {
                StockDal.UpdateRow(ID, newinfo, 5);
                return 6;

            }
            if (ToUpdate == "Pname")
            {
                StockDal.UpdateRow(ID, newinfo, 6);
                return 7;

            }
            return -1;
        }

        /// <summary>
        /// הדפסה של ערכי הטלפון
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string a = this.IDPhone + "" + this.PhonesInStock + "" + this.Pcolor + "" + this.Pcompany + ""+this.CreationYear+"" + this.SerialNum;
            return a;
        }
        /// <summary>
        /// החזרת כל הטלפונים
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnAllPhones()
        {
            return ProjectDal_phones.StockDal.GetAll();
        }
        /// <summary>
        /// החזרת הטלפונים שקשורים בהזמנות שיש  ללקוח
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DataSet ReturnMyPhones(int ID)
        {
            DataSet dr = ProjectDal_phones.PhoneDal.GetAllForClient(ID);
            return dr;
        }
        /// <summary>
        /// החזרת טלפונים בשביל המכירות
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnGetPhonesForOrder_All()
        {
            DataSet dr = ProjectDal_phones.StockDal.GetPhonesForOrder_All();
            return dr;
        }
        /// <summary>
        /// החזרת טלפונים מומלצים ללקוח
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet ReturnClientPhones(int PersonID)
        {
            DataSet dr = ProjectDal_phones.StockDal.GetPhonesForOrder_Favorits(PersonID);
            return dr;
        }
        /// <summary>
        /// החזרת טלפונים חדשים ברווח של שנתיים 
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnClientNewPhones()
        {
            DataSet dr = ProjectDal_phones.StockDal.GetPhonesForOrder_NewInShop();
            return dr;
        }
        /// <summary>
        /// החזרת טלפונים בשביל הפרסום לשירותי הרשת
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnClientServiceNewPhones()
        {
            DataSet dr = ProjectDal_phones.StockDal.GetPhonesForService_NewInShop();
            return dr;
        }
    }
}
