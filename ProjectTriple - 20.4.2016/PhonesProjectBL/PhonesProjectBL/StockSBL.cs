using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhonesProjectBL
{
    public class StockSBL
    {
        private List<StockBL> Phones;

        public StockSBL()
        {
            Phones = new List<StockBL>();
            DataSet ds = ProjectDal_phones.StockDal.GetAll();
            foreach (DataRow dr in ds.Tables["tblStock"].Rows)
            {
                StockBL a = new StockBL(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToInt32(dr[4]), Convert.ToInt32(dr[5]), Convert.ToInt32(dr[6]),Convert.ToString(dr[7]));
                this.Phones.Add(a);
            }
        }

        public void UpdateComplain(int IDPhone, object newinfo, string WhatTo)
        {
            //מציאת התלונה
            StockBL a = new StockBL();
            for (int i = 0; i < this.Phones.Count(); i++)
            {
                if (Phones[i].IDPhone1 == IDPhone)
                {
                    a = Phones[i];

                }

            }
            // עדכונים של DB ושל BL
            int Place = a.UpdateManager(WhatTo, newinfo, IDPhone);
            if (Place != -1)
            {

                if (Place == 1)
                {
                    a.PhonesInStock2 = Convert.ToInt32(newinfo);
                }
                if (Place == 2)
                {
                    a.Pcolor2 = Convert.ToString(newinfo);
                }
                if (Place == 3)
                {
                    a.Pcompany2 = Convert.ToString(newinfo);
                }
                if (Place == 4)
                {
                    a.Price2 = Convert.ToInt32(newinfo);
                }
                if (Place == 5)
                {
                    a.CreationYear2 = Convert.ToInt32(newinfo);
                }
                if (Place == 6)
                {
                    a.SerialNum2 = Convert.ToInt32(newinfo);

                }

            }
            if (Place == -1)
            {
                Console.WriteLine("arguments were incorrect");
            }
        }


        public void DeletePhone(int ID)
        {
            
            StockBL b = null;
            ProjectDal_phones.StockDal.DeleteRow(ID); ; //Delete phone from DB

            foreach (StockBL a in Phones)
            {
                if (a.IDPhone1 == ID)
                {
                    b = a;
                }
            }
            if (b != null)
            {
                Phones.Remove(b);
                b = null;
            }
        }

        public string Print()
        {
            string b = "";
            foreach (StockBL a in Phones)
            {
                b += a.ToString() + "";
                b += "\n";
            }
            return b;
        }
    }
}

