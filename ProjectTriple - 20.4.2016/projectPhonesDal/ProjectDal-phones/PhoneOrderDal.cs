using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProjectDal_phones
{
    public class PhoneOrderDal
    {
        /// <summary>
        /// פעולת הכנסה של מידע למסד הנתונים
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="OrderDateTime"></param>
        public static void AddOrder(int PersonID, DateTime OrderDateTime)
        {
            if (ClientDal.DoesExist(PersonID) == true)
            {
                DataSet ds = OleDbHelper.Fill("select * from tblPhoneOrder", "tblPhoneOrder");

                DataRow dr = ds.Tables["tblPhoneOrder"].NewRow();


                dr["PersonID"] = PersonID;
                dr["OrderDateTime"] = OrderDateTime;
               
                // הוספת הרשומה/שורה ל
                // DATASET
                ds.Tables["tblPhoneOrder"].Rows.Add(dr);
                // עידכון מסד הנתונים
                OleDbHelper.UpdateDB(ds, "select * from tblPhoneOrder", "tblPhoneOrder");
            }
        }
        /// <summary>
        /// החזרת כל ההזמנות
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from tblPhoneOrder", "tblPhoneOrder");
        }
        /// <summary>
        /// החזרת מידע על ההזמנה לפי מס הלקוח והזמנה
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static DataSet GetOneValueForPerson(int PersonID,int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPhoneOrder where PersonID={0} AND OrderID={1} ", PersonID,OrderID), "tblPhoneOrder");      //הזמנה מיוחדת 1
            return ds;
        }
        /// <summary>
        /// החזרת מידע על כל ההזמנות של הלקוח לפי מס הלקוח והזמנה
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static DataSet GetMultiplyValueForPerson(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPhoneOrder where PersonID={0}", PersonID), "tblPhoneOrder");                              //כל ההזמנות שקשורות ללקוח
            return ds;
        }
        /// <summary>
        /// עדכון שורה במאגר של ההזמנות
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PersonID"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        public static void UpdateRow<T>(int PersonID, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPhoneOrder where PersonID={0}", PersonID), "tblPhoneOrder");
            if (ds.Tables["tblPhoneOrder"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblPhoneOrder"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblPhoneOrder", "tblPhoneOrder");
            }
        }
        /// <summary>
        /// בדיקה האם קיימת ההזמנה במאגר הנתונים
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static bool DoesExist(int OrderID)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT OrderID FROM tblPhoneOrder WHERE OrderID={0}", OrderID), "tblPhoneOrder");
            if (ds.Tables["tblPhoneOrder"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// מחיקת הזמנה
        /// </summary>
        /// <param name="OrderID"></param>
        public static void DeleteRow(int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblPhoneOrder WHERE OrderID={0}", OrderID), "tblPhoneOrder");
            OleDbHelper.UpdateDB(ds, "select * from tblPhoneOrder", "tblPhoneOrder");
        }
        /// <summary>
        /// החזרת הזמנות לפי תאריך
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public static DataSet PhonesInDate(DateTime Date)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT tblPhoneOrder.OrderDateTime,tblStock.Pcompany,tblStock.Price,tblStock.CreationYear FROM tblPhone,tblPhoneOrder,tblStock WHERE tblPhoneOrder.OrderID=tblPhone.OrderID AND tblPhone.IDPhone=tblStock.IDPhone AND tblPhoneOrder.OrderDateTime={0}",Date), "tblKabala");
            return ds;
        }
        /// <summary>
        /// החזרת הזמנה אחרונה שנוצרה לפי מיקום מקסימאלי
        /// </summary>
        /// <returns></returns>
        public static int Getmax()
        {
             DataSet ds = OleDbHelper.Fill(string.Format("SELECT MAX(OrderID) FROM tblPhoneOrder"), "tblOrder");
             DataRow dr = ds.Tables["tblOrder"].Rows[0];
            int x = int.Parse(dr[0].ToString());
            return x;
        }
    }
}
