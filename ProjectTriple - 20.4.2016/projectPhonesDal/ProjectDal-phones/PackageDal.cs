using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProjectDal_phones
{
    public class PackageDal
    {
        /// <summary>
        /// פעולה הבונה ללקוח קיים ומאושר חבילה עד לאישור ההזמנה
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="PackageNum"></param>
        /// <param name="Amount"></param>
        public static void AddPackage(int OrderID, int PackageNum,int Amount)
        {
            DataSet ds = OleDbHelper.Fill("select * from tblPackage", "tblPackage");

            DataRow dr = ds.Tables["tblPackage"].NewRow();

            dr["OrderID"] = OrderID;
            dr["PackageNum"] = PackageNum;
            dr["Amount"] = Amount;
       
        
           
            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["tblPackage"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.UpdateDB(ds, "select * from tblPackage", "tblPackage");
        }
        /// <summary>
        /// פעולה המחזירה את החבילות לפי ההזמנה הספציפית
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static DataSet GetAllOrder(int OrderID)
        {
            return OleDbHelper.Fill(string.Format("select * from tblPackage WHERE OrderID={0}",OrderID),"tblPackage");
        }
        /// <summary>
        /// החזרת חבילה ספציפית מתוך המאגר של הלקוח לפי החבילה וההזמנה
        /// </summary>
        /// <param name="PackageID"></param>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static DataSet GetAllForType(int PackageID,int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPackage where PackageNum={0} AND OrderID={1}", PackageID,OrderID), "tblPackage");
            return ds;
        }
        /// <summary>
        /// פעולה שמחזירה את כל המידע על החבילו של הלקוח
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetAllForClient(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select tblPackageStock.PackageInfo,tblPackage.OrderID,tblPackage.Amount FROM tblPackageStock,tblClient,tblPackage,tblPhoneOrder WHERE tblPackage.PackageNum=tblPackageStock.PackageNum AND tblPackage.OrderID =tblPhoneOrder.OrderID AND tblClient.PersonID =tblPhoneOrder.PersonID AND tblClient.PersonID={0}", PersonID), "tblPackage");
            return ds;
        }
      // public static DataSet GetValue(int PackageNum)
      // {
      //     DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPackage where PackageNum={0}", PackageNum), "tblPackage");
      //     return ds;
      // }
        /// <summary>
        /// עדכון שורה בחבילות של הלקוח במספר הסידורי שנשלח לפי המידע שנשלח
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="OrderID"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        /// <param name="PackageNum"></param>
        public static void UpdateRow<T>(int OrderID, T newinfo, int place,int PackageNum)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPackage where tblPackage.PackageNum={0} AND OrderID={1}", PackageNum,OrderID), "tblPackage");
            if (ds.Tables["tblPackage"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblPackage"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblPackage", "tblPackage");
            }
        }
        /// <summary>
        /// בדיקת קיימות של חבילה כולשהי אצל מאגר המכירות ללקוחות
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="PackageID"></param>
        /// <returns></returns>
        public static bool DoesExist(int OrderID,int PackageID)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT OrderID FROM tblPackage WHERE OrderID={0} AND PackageNum={1}", OrderID,PackageID), "tblPackage");
            if (ds.Tables["tblPackage"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// מחיקת חבילה של לקוח בהזמנה מהמאגר לפי מספר לקוח ומספר הזמנה
        /// </summary>
        /// <param name="PackageID"></param>
        /// <param name="OrderID"></param>
        public static void DeletePackageFrom(int PackageID,int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblPackage WHERE PackageNum={0} AND OrderID={1}", PackageID, OrderID), "tblPackage");
            OleDbHelper.UpdateDB(ds, "select * from tblPackage", "tblPackage");
        }
        /// <summary>
        /// מחיקת החבילות הקשורות בהזמנה
        /// </summary>
        /// <param name="PackageID"></param>
        /// <param name="OrderID"></param>
        public static void DeletePackage_Order( int OrderID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblPackage WHERE OrderID={0}",OrderID), "tblPackage");
            OleDbHelper.UpdateDB(ds, "select * from tblPackage", "tblPackage");
        }
       
       
    }
}
