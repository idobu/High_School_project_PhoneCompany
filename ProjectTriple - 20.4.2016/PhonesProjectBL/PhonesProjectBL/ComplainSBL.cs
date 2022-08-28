using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhonesProjectBL
{
    public class ComplainSBL
    {
        private List<ComplainBL> Complains;

        public List<ComplainBL> Complains1
        {
            get { return Complains; }
        }

        public ComplainSBL()
        {
            Complains = new List<ComplainBL>();
            DataSet ds = ProjectDal_phones.ComplainsDal.GetAll();
            foreach (DataRow dr in ds.Tables["tblComplain"].Rows)
            {
                ComplainBL a = new ComplainBL(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToDateTime(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4]));
                this.Complains.Add(a); 
            }

       }

        public void UpdateComplain(int ID, object newinfo, string WhatTo)
        {
            //מציאת התלונה
            ComplainBL a = new ComplainBL();
            for (int i = 0; i < this.Complains.Count(); i++)
            {
                if (Complains[i].IDComp1 == ID)
                {
                    a = Complains[i];
                  
                }

            }
            // עדכונים של DB ושל BL
            int Place = a.UpdateManager(WhatTo,newinfo,ID);
            if (Place != -1)
            {
                
                if (Place == 2)
                {
                    a.ComplainDateTime1 = Convert.ToDateTime(newinfo);
                }
                if (Place == 3)
                {
                    a.CompSubject1 = Convert.ToString(newinfo);
                }
                if (Place == 4)
                {
                    a.Text1 = Convert.ToString(newinfo);
                }
               
            }
            if (Place == -1)
            {
                Console.WriteLine("arguments were incorrect");
            }
        }

        public void DeleteComplain(int ID)
        {
            
            ComplainBL b = null;
            ProjectDal_phones.ComplainsDal.DeleteRow(ID); ; //Delete complain from DB

            foreach (ComplainBL a in Complains)
            {
                if (a.IDComp1 == ID)
                {
                    b = a;
                }
            }
            if (b != null)
            {
                Complains.Remove(b);
                b = null;
            }
        }

        public string Print()
        {
            string b = "";
            foreach(ComplainBL a in Complains)
            {
                b += a.ToString() + "";
                b += "\n";
            }
            return b;
        }
        
    }
}
