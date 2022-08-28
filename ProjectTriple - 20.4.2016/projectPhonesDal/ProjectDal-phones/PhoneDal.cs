using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProjectDal_phones
{
    public class PhoneDal
    {
        /// <summary>
        /// פעולת הכנסה של מידע למסד הנתונים
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="IDPhone"></param>
        /// <param name="Amount"></param>
        public static void AddPhone(int OrderID, int IDPhone,int Amount)
        {
            if (PhoneOrderDal.DoesExist(OrderID)== true)
            {
                DataSet ds = OleDbHelper.Fill("select * from tblPhone", "tblPhone");

                DataRow dr = ds.Tables["tblPhone"].NewRow();


                dr["OrderID"] = OrderID;
                dr["IDPhone"] = IDPhone;
                dr["Amount"] = Amount;
              
               
                // הוספת הרשומה/שורה ל
                // DATASET
                ds.Tables["tblPhone"].Rows.Add(dr);
                // עידכון מסד הנתונים
                OleDbHelper.UpdateDB(ds, "select * from tblPhone", "tblPhone");
            }
        }
        /// <summary>
        /// החזרת טלפונים בשימוש בהזמנה לפי מספר ההמזנה
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static DataSet GetAllOrder(int OrderID)
        {
            return OleDbHelper.Fill(string.Format("select * from tblPhone WHERE OrderID={0}", OrderID), "tblPhone");
        }
        /// <summary>
        /// מידע על הטלפונים בשימוש בהזמנה לפי מס הלקוח
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetAllPhoneDetails(int PersonID,int orderid)
        {
            return OleDbHelper.Fill(string.Format("select tblStock.Pcolor,tblStock.Pcompany,tblStock.CreationYear from tblPhone,tblPhoneOrder,tblStock WHERE tblPhone.OrderID=tblPhoneOrder.OrderID AND tblPhone.IDPhone=tblStock.IDPhone AND tblPhoneOrder.PersonID={0} AND tblPhoneOrder.OrderID <> {1} ", PersonID,orderid), "tblPhoneCheck");
        }
        /// <summary>
        /// החזרת טלפון ספציפי בשימוש בהזמנה או אצל לקוח
        /// </summary>
        /// <param name="IDPhone"></param>
        /// <param name="OrderID"></param>
        /// <returns></returns>

        public static DataSet GetAllForType(int IDPhone,int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * FROM tblPhone WHERE IDPhone={0} AND OrderID={1}", IDPhone, OrderID), "tblPhone");
            return ds;
        }
        /// <summary>
        /// החזרת כל הטלפונים בשימוש בהזמנה אצל לקוח לפי הדרישות
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetAllForClient(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select tblStock.Pname,tblPhone.OrderID,tblPhone.Amount FROM tblClient,tblPhone,tblPhoneOrder,tblStock WHERE tblPhone.IDPhone=tblStock.IDPhone AND tblPhone.OrderID =tblPhoneOrder.OrderID AND tblClient.PersonID =tblPhoneOrder.PersonID AND tblClient.PersonID ={0} ", PersonID), "tblPhone");
            return ds;
        }
        /// <summary>
        /// עדכון השורה של הטלפון בשימוש בהזמנה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="OrderID"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        /// <param name="PhoneNum"></param>
        public static void UpdateRow<T>(int OrderID, T newinfo, int place, int PhoneNum)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPhone where OrderID={0} AND IDPhone={1}", OrderID,PhoneNum), "tblPhone");
            if (ds.Tables["tblPhone"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblPhone"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblPhone", "tblPhone");
            }
        }
        /// <summary>
        /// בדיקת האם קיים המספר הסידורי של הטלפון שנשלח במספר ההזמנה שנשלחה
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="IDPhone"></param>
        /// <returns></returns>
        public static bool DoesExist(int OrderID,int IDPhone)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT OrderID FROM tblPhone WHERE  OrderID={0} AND IDPhone={1}", OrderID,IDPhone), "tblPhone");
            if (ds.Tables["tblPhone"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// מחיקת טלפון ספציפי משימוש אצל ההזמנה של הלקוח
        /// </summary>
        /// <param name="IDPhone"></param>
        /// <param name="OrderID"></param>
        public static void DeletePhoneFrom(int IDPhone,int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblPhone WHERE IDPhone={0} AND OrderID={1} ", IDPhone,OrderID), "tblPhone");
            OleDbHelper.UpdateDB(ds, "select * from tblPhone", "tblPhone");
        }
        /// <summary>
        /// מחיקת טלפונים הקשורים בהזמנה
        /// </summary>
        /// <param name="IDPhone"></param>
        /// <param name="OrderID"></param>
        public static void DeletePhone_Order(int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblPhone WHERE OrderID={0}", OrderID), "tblPhone");
            OleDbHelper.UpdateDB(ds, "select * from tblPhone", "tblPhone");
        }
    }
}
