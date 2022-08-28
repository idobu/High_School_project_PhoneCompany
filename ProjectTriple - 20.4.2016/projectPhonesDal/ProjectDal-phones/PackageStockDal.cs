using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProjectDal_phones
{
    public class PackageStockDal
    {
        /// <summary>
        /// פעולת הכנסה של מידע למסד הנתונים
        /// </summary>
        /// <param name="Pnum"></param>
        /// <param name="Price"></param>
        /// <param name="PackageInfo"></param>
        /// <param name="PackageInStock"></param>
        public static void AddPackageToStock(string Prestriction, int Price, string PackageInfo, int PackageInStock)
        {
            DataSet ds = OleDbHelper.Fill("select * from tblPackageStock", "tblPackageStock");

            DataRow dr = ds.Tables["tblPackageStock"].NewRow();


            dr["Prestriction"] = Prestriction;
            dr["Price"] = Price;
            dr["PackageInfo"] = PackageInfo;
            dr["PackageInStock"] = PackageInStock;
        
            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["tblPackageStock"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.UpdateDB(ds, "select * from tblPackageStock", "tblPackageStock");
        }


        /// <summary>
        /// החזרת כל החבילות במאגר
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from tblPackageStock", "tblPackageStock");
        }
        /// <summary>
        /// החזרת חבילה ספציפית לפי מספרה
        /// </summary>
        /// <param name="PackageNum"></param>
        /// <returns></returns>
        public static DataSet GetValue(int PackageNum)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPackageStock where PackageNum={0}", PackageNum), "tblPackageStock");
            return ds;
        }
        /// <summary>
        /// עדכון השורה של החבילה במאגר
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PackageNum"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        public static void UpdateRow<T>(int PackageNum, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblPackageStock where PackageNum={0}", PackageNum), "tblPackageStock");
            if (ds.Tables["tblPackageStock"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblPackageStock"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblPackageStock", "tblPackageStock");
            }
        }
        /// <summary>
        /// האם קיימת מספר החבילה שנשלחה במאגר
        /// </summary>
        /// <param name="PackageNum"></param>
        /// <returns></returns>
        public static bool DoesExist(int PackageNum)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT PackageNum FROM tblPackageStock WHERE PackageNum={0}", PackageNum), "tblPackageStock");
            if (ds.Tables["tblPackageStock"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// מחיקה חבילה ממאגר החבילות הקיימות למכירה
        /// </summary>
        /// <param name="PackageNum"></param>
        public static void DeleteRow(int PackageNum)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblPackageStock WHERE PackageNum={0}", PackageNum), "tblPackageStock");
            OleDbHelper.UpdateDB(ds, "select * from tblPackageStock", "tblPackageStock");
        }
        /// <summary>
        /// החזרת חבילה ספציפית
        /// </summary>
        /// <param name="PackageInfo"></param>
        /// <param name="Price"></param>
        /// <returns></returns>
        public static DataSet GetSpecificPack(string PackageInfo,int Price)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT * FROM tblPackageStock WHERE tblPackageStock.PackageInfo='{0}' AND tblPackageStock.Price={1}", PackageInfo,Price), "tblSells");
            return ds;
        }
        /// <summary>
        /// החזרת החבילה האחרונה שנוספה
        /// </summary>
        /// <returns></returns>
        public static int GetMax()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT MAX(PackageNum) FROM tblPackageStock"), "tblPackageStock");
            DataRow dr = ds.Tables["tblPackageStock"].Rows[0];
            int x = int.Parse(dr[0].ToString());
            return x;
        }
        /// <summary>
        /// החזרת כל החבילות לפי דרישות של הצגה ללקוחות
        /// </summary>
        /// <returns></returns>
        public static DataSet GetPacksForOrder_All()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT DISTINCT tblPackageStock.Price,tblPackageStock.PackageInfo,tblPackageStock.Prestriction FROM tblPackageStock WHERE tblPackageStock.PackageInStock >= 1"), "tblPackage");
            return ds;
        }
        /// <summary>
        /// החזרת החבילו או חבילה כדוגמא לחבילות האהובות שנקנו לאחרונה אצל הלקוח
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetPacksForOrder_Favorits(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT DISTINCT tblPackageStock.Price,tblPackageStock.PackageInfo,tblPackageStock.Prestriction FROM tblPackageStock,tblPackage,tblPhoneOrder WHERE tblPackage.OrderID=tblPhoneOrder.OrderID AND tblPackageStock.PackageInStock >= 1 AND tblPackage.PackageNum=tblPackageStock.PackageNum AND tblPhoneOrder.PersonID={0}", PersonID), "tblPackage");
            return ds;
        }
        /// <summary>
        /// החזרת החבילות לפי דרישות של השירות והמפרסם
        /// </summary>
        /// <returns></returns>
        public static DataSet GetPacksForService()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT DISTINCT tblPackageStock.Price,tblPackageStock.PackageInfo,tblPackageStock.Prestriction FROM tblPackageStock WHERE tblPackageStock.Prestriction='without restriction'"), "tblPackage");
            return ds;
        }
    }
}
