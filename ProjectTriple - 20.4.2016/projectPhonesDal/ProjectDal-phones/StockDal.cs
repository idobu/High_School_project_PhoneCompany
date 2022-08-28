using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProjectDal_phones
{
    public class StockDal
    {
        /// <summary>
        /// פעולת הכנסה של מידע למסד הנתונים
        /// </summary>
        /// <param name="PhonesInStock"></param>
        /// <param name="Pcolor"></param>
        /// <param name="Pcompany"></param>
        /// <param name="Price"></param>
        /// <param name="CreationYear"></param>
        /// <param name="SerialNum"></param>
        /// <param name="Pname"></param>
        public static void AddPhoneToStock(int PhonesInStock, string Pcolor, string Pcompany, int Price, int CreationYear,int SerialNum,string Pname)
        {
            DataSet ds = OleDbHelper.Fill("select * from tblStock", "tblStock");

            DataRow dr = ds.Tables["tblStock"].NewRow();

            dr["PhonesInStock"] = PhonesInStock;
            dr["Pcompany"] = Pcompany;
            dr["Pcolor"] = Pcolor;
            dr["Price"] = Price;
            dr["CreationYear"] = CreationYear;
            dr["SerialNum"] = SerialNum;
            dr["Pname"] = Pname;
            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["tblStock"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.UpdateDB(ds, "select * from tblStock", "tblStock");
        }
        /// <summary>
        /// פעולה להחזרת כל הטלפונים במאגר
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from tblStock", "tblStock");
        }
        /// <summary>
        /// החזרת טלפון ספציפי לפי מס סידורי שלו
        /// </summary>
        /// <param name="IDPhone"></param>
        /// <returns></returns>
        public static DataSet GetValue(int IDPhone)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblStock where IDPhone={0}", IDPhone), "tblStock");
            return ds;
        }
        /// <summary>
        /// החזרת כל הטלפונים בשביל הצגה להזמנות 
        /// </summary>
        /// <returns></returns>
        public static DataSet GetPhonesForOrder_All()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select DISTINCT tblStock.Pname,tblStock.Pcolor,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear,tblStock.SerialNum FROM tblStock WHERE tblStock.PhonesInStock >= 1 "), "tblStock");
            return ds;
        }
        ////////////////// הסבר על הקבוצות בתיק הפרוייקט
        /// <summary>
        /// החזרת הטלפונים לפי קבוצה מס 1 והצבעים שנשלחו
        /// </summary>
        /// <param name="NeededColors"></param>
        /// <returns></returns>
        public static DataSet GetPhonesForOrder_OS_group1(string[] NeededColors)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select DISTINCT tblStock.Pname,tblStock.Pcolor,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear,tblStock.SerialNum FROM tblStock WHERE (tblStock.Pcolor='{0}' OR tblStock.Pcolor='{1}' OR tblStock.Pcolor='{2}') AND tblStock.PhonesInStock >= 1 AND tblStock.Pcompany='Apple'", NeededColors[0], NeededColors[1], NeededColors[2]), "tblStock");
            return ds;
        }
        /// <summary>
        ///  החזרת הטלפונים לפי קבוצה מס 2 והצבעים שנשלחו
        /// </summary>
        /// <param name="NeededColors"></param>
        /// <returns></returns>
        public static DataSet GetPhonesForOrder_OS_group2(string[] NeededColors)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select DISTINCT tblStock.Pname,tblStock.Pcolor,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear,tblStock.SerialNum FROM tblStock WHERE (tblStock.Pcolor='{0}' OR tblStock.Pcolor='{1}' OR tblStock.Pcolor='{2}') AND tblStock.PhonesInStock >= 1 AND (tblStock.Pcompany='Motorola' OR tblStock.Pcompany='Nokia' OR tblStock.Pcompany='LG' OR tblStock.Pcompany='Samsung' OR tblStock.Pcompany='Sony') ", NeededColors[0].ToString(), NeededColors[1].ToString(), NeededColors[2].ToString()), "tblStock");
            return ds;
        }
        /// <summary>
        /// החזרת הטלפונים לפי קבוצה מס 3 והצבעים שנשלחו
        /// </summary>
        /// <param name="NeededColors"></param>
        /// <returns></returns>
        public static DataSet GetPhonesForOrder_OS_group3(string[] NeededColors)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select DISTINCT tblStock.Pname,tblStock.Pcolor,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear,tblStock.SerialNum FROM tblStock WHERE (tblStock.Pcolor='{0}' OR tblStock.Pcolor='{1}' OR tblStock.Pcolor='{2}') AND tblStock.PhonesInStock >= 1 AND (tblStock.Pcompany='Microsoft' OR tblStock.Pcompany='HTC' )  ", NeededColors[0].ToString(), NeededColors[1].ToString(), NeededColors[2].ToString()), "tblStock");
            return ds;
        }
        /// <summary>
        /// החזרת הטלפונים הנקנים האחרונים אצל הלקוח
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetPhonesForOrder_Favorits(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select DISTINCT tblStock.Pname,tblStock.Pcolor,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear,tblStock.SerialNum FROM tblStock,tblPhone,tblPhoneOrder WHERE tblStock.PhonesInStock >= 1 AND tblPhone.IDPhone=tblStock.IDPhone AND tblPhone.OrderID =tblPhoneOrder.OrderID AND tblPhoneOrder.PersonID={0}", PersonID), "tblStock");
            return ds;
        }
        /// <summary>
        /// התייחסות והחזרה של טלפון לפי המאפיינים שלו
        /// </summary>
        /// <param name="color"></param>
        /// <param name="Pname"></param>
        /// <param name="Pcompany"></param>
        /// <returns></returns>
        public static DataSet GetSpecificPhone(string color,string Pname,string Pcompany)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT * FROM tblStock WHERE tblStock.Pname='{0}' AND tblStock.Pcompany='{1}' AND tblStock.Pcolor='{2}'", Pname, Pcompany,color), "tblStock");
            return ds;
        }
        /// <summary>
        /// החזרת טלפונים חדשים מהשנתיים האחרונות
        /// </summary>
        /// <returns></returns>
        public static DataSet GetPhonesForOrder_NewInShop()
        {
            int FromYear = DateTime.Now.Year - 2;
            int NowYear = DateTime.Now.Year;
            DataSet ds = OleDbHelper.Fill(string.Format("select tblStock.Pname,tblStock.Pcolor,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear,tblStock.SerialNum FROM tblStock WHERE tblStock.CreationYear >= {0} AND tblStock.PhonesInStock >= 1 AND tblStock.CreationYear <= {1}", FromYear, NowYear), "tblStock");
            return ds;
        }
        /// <summary>     
        ///     (החזרת טלפונים חדשים מהשנתיים האחרונות לפי דרישות שונות של השירות (רק שם ומחיר 
        ///      ודרישות של המפרסם 
        /// </summary>
        /// <returns></returns
        public static DataSet GetPhonesForService_NewInShop()
        {
            int FromYear = DateTime.Now.Year - 2;
            int NowYear = DateTime.Now.Year;
            DataSet ds = OleDbHelper.Fill(string.Format("select tblStock.Pname,tblStock.Pcompany,tblStock.Price FROM tblStock WHERE tblStock.CreationYear >= {0} AND tblStock.PhonesInStock >= 1 AND tblStock.CreationYear <= {1}", FromYear, NowYear), "tblStock");
            return ds;
        }
       
        
       
        /// <summary>
        /// עדכון השורה של הטלפון במאגר המכירות
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="IDPhone"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        public static void UpdateRow<T>(int IDPhone, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT * FROM tblStock WHERE IDPhone={0}", IDPhone), "tblStock");
            if (ds.Tables["tblStock"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblStock"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblStock", "tblStock");
            }
        }
        /// <summary>
        /// אם קיים הטלפון במאגר המכירות
        /// </summary>
        /// <param name="IDPhone"></param>
        /// <returns></returns>
        public static bool DoesExist(int IDPhone)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT IDPhone FROM tblStock WHERE IDPhone={0}", IDPhone), "tblStock");
            if (ds.Tables["tblStock"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// מחיקת הטלפון מהמכירות
        /// </summary>
        /// <param name="IDPhone"></param>
        public static void DeleteRow(int IDPhone)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblStock WHERE IDPhone={0}", IDPhone), "tblStock");
            OleDbHelper.UpdateDB(ds, "select * from tblStock", "tblStock");
        }
        /// <summary>
        /// החזרת מספר הסידורי של הטלפון האחרון שנוסף
        /// </summary>
        /// <returns></returns>
        public static int GetMax()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT MAX(IDPhone) FROM tblStock"), "tblStock");
            DataRow dr = ds.Tables["tblStock"].Rows[0];
            int x = int.Parse(dr[0].ToString());
            return x;
        }
    }
}
