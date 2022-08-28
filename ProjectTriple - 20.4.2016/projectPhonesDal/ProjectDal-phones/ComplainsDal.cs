using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProjectDal_phones
{
    public class ComplainsDal
    {
        /// <summary>
        /// פעולה בונה של תלונה למאגר הלקוחות
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="ComplainDateTime"></param>
        /// <param name="ComplainSubject"></param>
        /// <param name="ComplainText"></param>
        public static void AddComplain(int PersonID, DateTime ComplainDateTime, string ComplainSubject, string ComplainText)
        {
            if (ClientDal.DoesExist(PersonID)==true)
            {
            DataSet ds = OleDbHelper.Fill("select * from tblComplain", "tblComplain");

            DataRow dr = ds.Tables["tblComplain"].NewRow();


            dr["PersonID"] = PersonID;
            dr["ComplainDateTime"] = ComplainDateTime;
            dr["ComplainSubject"] = ComplainSubject;
            dr["ComplainText"] = ComplainText;
            // הוספת הרשומה/שורה ל
            // DATASET
            ds.Tables["tblComplain"].Rows.Add(dr);
            // עידכון מסד הנתונים
            OleDbHelper.UpdateDB(ds, "select * from tblComplain", "tblComplain");
            }
        }
        /// <summary>
        /// פעולה שמעדכנת את השורה של התלונה
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PersonID"></param>
        /// <param name="newinfo"></param>
        /// <param name="place"></param>
        public static void Updatetbl<T>(int PersonID, T newinfo, int place)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblComplain where PesronID={0}", PersonID), "tblComplain");
            if (ds.Tables["tblComplain"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["tblComplain"].Rows[0];
                dr[place] = newinfo;
                OleDbHelper.UpdateDB(ds, "select * from tblComplain", "tblComplain");
            }
        }
        /// <summary>
        /// חיפוש תלונות לפי מספר סידורי של לקוח
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static DataSet GetAllValueForPerson(int PersonID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblComplain where PersonID={0}", PersonID), "tblComplain");
            return ds;
        }
        /// <summary>
        /// חיפוש תלונה והחזרתה לפי מספר סידורי של לקוח ומספר סידורי של תלונה
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="IDComp"></param>
        /// <returns></returns>
        public static DataSet GetOneValueForPerson(int PersonID,int IDComp)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("select * from tblComplain where PersonID={0} AND IDComp={0}", PersonID,IDComp), "tblComplain");
            return ds;
        }
        /// <summary>
        /// פעולה המחזירה את כל התלונות במאגר
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from tblComplain", "tblComplain");
        }
        /// <summary>
        /// פעולה הבודקת אם התלונה קיימת במאגר
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public static bool DoesExist(int PersonID)
        {

            DataSet ds = OleDbHelper.Fill(string.Format("SELECT PersonID FROM tblComplain WHERE PersonID={0}", PersonID), "tblComplain");
            if (ds.Tables["tblComplain"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// פעולה המוחקת תלונה מן המאגר
        /// </summary>
        /// <param name="CompID"></param>
        public static void DeleteRow(int CompID)
        {
            DataSet ds = OleDbHelper.Fill(string.Format("DELETE * FROM tblComplain WHERE IDComp={0}", CompID), "tblComplain");
            OleDbHelper.UpdateDB(ds, "select * from tblComplain", "tblComplain");
        }
        /// <summary>
        /// פעולה המחזירה את המספר הסידורי האחרון של תלונה שהוספה למאגר
        /// </summary>
        /// <returns></returns>
        public static int GetMax()
        {
            DataSet ds = OleDbHelper.Fill(string.Format("SELECT MAX(IDComp) FROM tblComplain"), "tblComplain");
            DataRow dr = ds.Tables["tblComplain"].Rows[0];
            int x = int.Parse(dr[0].ToString());
            return x;
        }
    }
}
