using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDal_phones;
using System.Data;

namespace PhonesProjectBL
{
    public class ComplainBL
    {
        private int IDComp;                  //מספר תלונה

        public int IDComp2
        {
            get { return IDComp; }
            set { IDComp = value;}
        }
        private int PersonID;                //מספר לקוח

        public int PersonID2
        {
            get { return PersonID; }
            set { PersonID = value; }
        }
        private DateTime ComplainDateTime;   //זמן שליחת התלונה

        public DateTime ComplainDateTime2
        {
            get { return ComplainDateTime; }
            set { ComplainDateTime = value;
            ProjectDal_phones.ComplainsDal.Updatetbl(PersonID, value, 2);
            }
        }
        private string CompSubject;          //נושא התלונה

        public string CompSubject2
        {
            get { return CompSubject; }
            set { CompSubject = value;
            ProjectDal_phones.ComplainsDal.Updatetbl(PersonID, value, 3);
            }
        }
        private string Text;                 //גוף התלונה

        public string Text2
        {
            get { return Text; }
            set { Text = value;
            ProjectDal_phones.ComplainsDal.Updatetbl(PersonID, value, 4);
            }
        }
        // פעולות בונות ליצירת תלונה חדשה
        public ComplainBL()
        {
        }
       
        public ComplainBL(int IDComp,int PID, DateTime ComplainDateTime, string CompSubject, string Text)
        {

            if (!ProjectDal_phones.ClientDal.DoesExist(IDComp))
            {
                ProjectDal_phones.ComplainsDal.AddComplain(PID, ComplainDateTime, CompSubject, Text);
                this.PersonID = PID;
                this.CompSubject = CompSubject;
                this.ComplainDateTime = ComplainDateTime;
                this.Text = Text;
                this.IDComp = ProjectDal_phones.ComplainsDal.GetMax();
            }
            else
            {
                
            }
            
        }
        // החזרת תלונה מהמאגר של התלונות והתייחסות עליה
        public ComplainBL(int PersonID,int IDComp)
        {
            DataSet a = ProjectDal_phones.ComplainsDal.GetOneValueForPerson(PersonID, IDComp);
            DataRow b = a.Tables["tblComplain"].Rows[0];
            this.IDComp = IDComp;
            this.PersonID = PersonID;
            this.ComplainDateTime = Convert.ToDateTime(b[2]);
            this.CompSubject = Convert.ToString(b[2]);
            this.Text =Convert.ToString(b[4]);
        }
        // פעולות לצורך עדכון התלונות השונות
        public int IDComp1
        {
            get { return IDComp; }
        }

        public int PersonID1
        {
            get { return PersonID; }
        }

        public DateTime ComplainDateTime1
        {
            get { return ComplainDateTime; }
            set { ComplainDateTime = value; }
        }

        public string CompSubject1
        {
            get { return CompSubject; }
            set { CompSubject = value; }
        }

        public string Text1
        {
            get { return Text; }
            set { Text = value; }
        }
        // פעולה לעדכון תלונה במאגר התלונות
        public int UpdateManager(string ToUpdate, object newinfo, int ID)
        {
           
            if (ToUpdate == "ComplainDateTime")
            {
                ComplainsDal.Updatetbl(ID, newinfo, 2);
                return 2;

            }
            if (ToUpdate == "ComplainSubject")
            {
                ComplainsDal.Updatetbl(ID, newinfo, 3);
                return 3;

            }
            if (ToUpdate == "ComplainText")
            {
                ComplainsDal.Updatetbl(ID, newinfo, 4);
                return 4;

            }
           
            return -1;
        
        }
        // הדפסת תלונה ופרטיה
        public override string ToString()
        {
            string a = this.IDComp + "" + this.PersonID + "" + this.ComplainDateTime + "" + this.CompSubject + "" + this.Text;
            return a;
        }
        /// <summary>
        /// פעולה לשם הצגת כל התלונות בההצגה ללקוח
        /// </summary>
        /// <returns></returns>
        public static DataSet GetAllComps()
        {
            return ProjectDal_phones.ComplainsDal.GetAll();
        }
        /// <summary>
        /// שימוש במחיקת התלונה לאחר קריאתה
        /// </summary>
        /// <param name="CompID"></param>
        public static void DeleteComp(int CompID)
        {
            ProjectDal_phones.ComplainsDal.DeleteRow(CompID);
        }
    }
}
