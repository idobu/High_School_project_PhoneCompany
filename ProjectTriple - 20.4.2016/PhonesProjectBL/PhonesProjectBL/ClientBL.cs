using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectDal_phones;

namespace PhonesProjectBL
{
    public class ClientBL
    {


        private int ClientID;    //מספר לקוח

        public int ClientID1
        {
          get { return ClientID; }
        }
        private string fn;           //שם פרטי

        public string Fn
        {
          get { return fn; }
          set 
          { 
              fn = value;
              ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 1);

          }
        }
        private string ln;           //שם משפחה

        public string Ln
        {
            get
            { return ln; } 
          
          set 
          {
              ln = value;
              ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 2);
          }
        }
        private bool Active;         //פעיל

        public bool Active1
        {
          get { return Active; }
          set 
          { 
              Active = value;
              ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 3);

          }
        }
        private DateTime JoinDate;   //תאריך הצטרפות

        public DateTime JoinDate1
        {
          get { return JoinDate; }
            set
            {
                ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 4);
 
              JoinDate = value; }
        }
        private DateTime BirthDate;  //תאריך לידה

        public DateTime BirthDate1
        {
          get { return BirthDate; }
          set { BirthDate = value;
          ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 5);
          }
        }

        private int Password;            // סיסמת הלקוח

        public int Password1
        {
            get { return Password; }
            set { Password = value;
            ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 6);
            }
        }
        private string Email;          // מייל הלקוח

        public string Email1
        {
            get { return Email; }
            set { Email = value;
            ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 7);
            }
        }
        private string PhoneNum;         // מספר טלפון לעדכונים ואימות פרטים

        public string PhoneNum1
        {
            get { return PhoneNum; }
            set
            {
                PhoneNum = value;
                ProjectDal_phones.ClientDal.UpdateRow(this.ClientID, value, 8);
            }
            
        }
        // פעולות בונות של הלקוח במאגר
        public ClientBL()
        {
        }

        public ClientBL(int id, string FN, string LN, bool Active, DateTime JoinDate, DateTime BirthDate,int UPassword, string Email,string PN)
        {
            if (!ClientDal.DoesExist(id))
            {
                this.Password = UPassword;
                this.Active = false;
                ClientDal.AddClient(FN, LN, JoinDate, BirthDate, Active,Password,Email,PN);
                this.fn = FN;
                this.ln = LN;
                this.BirthDate = BirthDate;
                this.JoinDate = JoinDate;
                this.Email = Email;
                this.PhoneNum = PN;
                
                this.ClientID = ProjectDal_phones.ClientDal.GetMax111();
            }
            else
            {
        
            }
           
        }
        // פעולה מחזירה לקוח קיים במאגר
        public ClientBL(int ID)
        {

            if(ClientDal.DoesExist(ID))
            {
            DataSet a = ProjectDal_phones.ClientDal.GetValue(ID);
            DataRow b = a.Tables["tblClient"].Rows[0];
            this.ClientID = Convert.ToInt32(b[0]);
            this.fn = Convert.ToString(b[1]);
            this.ln = Convert.ToString(b[2]);
            this.Active = Convert.ToBoolean(b[3]);
            this.JoinDate = Convert.ToDateTime(b[4]);
            this.BirthDate = Convert.ToDateTime(b[5]);
            this.Password = Convert.ToInt32(b[6]);
            this.Email = Convert.ToString(b[7]);
            this.PhoneNum = Convert.ToString(b[8]);
            }
        }
        /// <summary>
        /// פעולה לבדיקה אם קיים במאגר הלקוחות לפי שם מספר טלפון ושם משפחה
        /// </summary>
        /// <param name="PersonName"></param>
        /// <param name="PLN"></param>
        /// <param name="PN"></param>
        /// <returns></returns>
        public bool IsExistName(string PersonName,string PLN,string PN)
        {
            if (ProjectDal_phones.ClientDal.DoesExistName(PersonName, PLN, PN) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// מציאת לקוח קיים במאגר לפי מספרו הסידורי
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public bool IsExist(int PersonID)
        {
            if (ProjectDal_phones.ClientDal.DoesExist(PersonID) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// פעולה לעדכון הלקוחות במאגר הרבים
        /// </summary>
        /// <param name="ToUpdate"></param>
        /// <param name="newinfo"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UpdateManager(string ToUpdate,object newinfo,int ID)
        {
            if(ToUpdate=="FirstName")
            {
                ClientDal.UpdateRow(ID, newinfo,1);       
                return 1;
                 
            }
            if(ToUpdate=="LastName")
            {
                ClientDal.UpdateRow(ID, newinfo, 2);
                return 2;
               
            }       
            if(ToUpdate=="Active")
            {
                ClientDal.UpdateRow(ID, newinfo, 3);
                return 3;
                
            }  
            if(ToUpdate=="JoinDate")
            {
                ClientDal.UpdateRow(ID, newinfo, 4);
                return 4;
                
            }
            if (ToUpdate == "BirthDate")
            {
                ClientDal.UpdateRow(ID, newinfo, 5);
                return 5;

            }
            if(ToUpdate=="Password")
            {
                ClientDal.UpdateRow(ID, newinfo, 6);
                return 6;
            }
            if (ToUpdate == "EMail")
            {
                ClientDal.UpdateRow(ID, newinfo, 7);
            }
            return -1;
        }
        //הדפסת לקוח ופרטיו
        public override string ToString()
        {
            string a =this.ClientID+" "+ this.fn + " " + this.ln + " " + this.Active + " " + this.JoinDate.ToString() + " " + this.BirthDate.ToString();
            return a;
        }
        /// <summary>
        /// החזרת לקוחות שלא הופעלו אצל המנהל ונמצאים בהמתנה
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnMyDeactive()
        {
            DataSet Notactive = ProjectDal_phones.ClientDal.GetAllNotActive();
            return Notactive;
        }
        /// <summary>
        /// החזרת כל הלקוחות למען הצגתם אצל המנהל
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnAll()
        {
            DataSet Clients = ProjectDal_phones.ClientDal.GetAll();
            return Clients;
        }
        /// <summary>
        /// שימוש במחיקת הלקוח ממאגר הלקוחות
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteClient(int id)
        {
            ProjectDal_phones.ClientDal.DeleteRow(id);
        }

        }

        


      
}
     



   

