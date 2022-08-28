using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace ProjectDal_phones
{
    public class ClientDal
    {
        /// <summary>
        /// פעולה בונה של הלקוח למאגר הלקוחות
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="JoinDate"></param>
        /// <param name="BirthDate"></param>
        /// <param name="Active"></param>
        /// <param name="Upassword"></param>
        /// <param name="Email"></param>
        public static void AddClient(string FirstName, string LastName, DateTime JoinDate, DateTime BirthDate, bool Active,int Upassword,string Email,string PhoneNumber)
        {
            DataSet ds = OleDbHelper.Fill("select * from tblClient", "tblClient");

            DataRow dr = ds.Tables["tblClient"].NewRow();

            dr["FirstName"] = FirstName;
            dr["LastName"] = LastName;
            dr["JoinDate"] = JoinDate;
            dr["BirthDate"] = BirthDate;
            dr["Active"] = Active;
            dr["UPassword"] = Upassword;
            dr["EMail"] = Email;
            dr["ClientPN"] = PhoneNumber;
            // הוספת הרשומה שורה ל
            // DATASET
            ds.Tables["tblClient"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.UpdateDB(ds, "select * from tblClient", "tblClient");
        }
        /// <summary>
        /// פעולה מחזירה את כל הלקוחות הקיימים
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from tblClient", "tblClient");
        }
        /// <summary>
        /// פעולה המחזריה את כל הלקוחות הלא מאושרים ולא פעילים
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllNotActive()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblClient where Active={0}",false ), "tblClient");
            return ds;
        }
        /// <summary>
        /// החזרת לקוח ספציפי מתוך מאגר הלקוחות
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetValue(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblClient where PersonID={0}", PersonID), "tblClient");
            return ds;
        }
        /// <summary>
        /// עדכון שורה במאגר השורות הלקוחות
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PersonID"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        public static void UpdateRow<T>(int PersonID, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblClient where PersonID={0}", PersonID), "tblClient");
            if (ds.Tables["tblClient"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblClient"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblClient", "tblClient");
            }
        }
        /// <summary>
        /// פעולה המחזירה את הלקוחות לפי תאריך ספציפי של הצטרפות
        /// </summary>
        /// <param name="JoinDate"></param>
        /// <returns></returns>
        public static List<string> GetJoinDate(string JoinDate)
        {
            List<String> Dates = new List<string>();
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT FirstName, LastName,JoinDate FROM tblClient WHERE JoinDate='{0}'", JoinDate), "tblClient");
            foreach (DataRow dr in ds.Tables["tblClient"].Rows)
            {
                string a = dr[0].ToString() + " " + dr[1].ToString();
                Dates.Add(a);
            }
            return Dates;
        }
        /// <summary>
        /// פעולה מחזירה את הלקוח ומאשרת שהוא קיים במאגר
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static bool DoesExist(int PersonID)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT PersonID FROM tblClient WHERE PersonID={0}", PersonID), "tblClient");
            if( ds.Tables["tblClient"].Rows.Count  >0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// פעולה מחזירה את הלקוח ומאשרת שהוא קיים במאגר לפי שם
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static bool DoesExistName(string PersonName,string PersonLN,string PN)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT PersonID FROM tblClient WHERE FirstName='{0}' AND LastName='{1}' AND ClientPN='{2}'", PersonName,PersonLN,PN), "tblClient");
            if (ds.Tables["tblClient"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// פעולת הסרת לקוח לגמרי מן המאגר
        /// </summary>
        /// <param name="PersonID"></param>
        public static void DeleteRow(int PersonID)
       {
           DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblClient WHERE PersonID={0}", PersonID), "tblClient");
           OleDbHelper.UpdateDB(ds, "select * from tblClient", "tblClient");
       }
        /// <summary>
        /// פעולה המחזריה את הלקוח האחרון שהוסף
        /// </summary>
        /// <returns></returns>
        public static int GetMax111()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT MAX(PersonID) FROM tblClient"), "tblClient");
            DataRow dr = ds.Tables["tblClient"].Rows[0];
            int x = int.Parse(dr[0].ToString());
            return x;
        }
       
    }
}

