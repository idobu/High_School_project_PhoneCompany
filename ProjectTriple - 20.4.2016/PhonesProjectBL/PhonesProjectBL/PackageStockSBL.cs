using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhonesProjectBL
{
    public class PackageStockSBL
    {
        private List<PackageStockBL> PackageStocks;


        public PackageStockSBL()
        {
            PackageStocks = new List<PackageStockBL>();
            DataSet ds = ProjectDal_phones.ClientDal.GetAll();
            foreach (DataRow dr in ds.Tables["tblPackageStock"].Rows)
            {
                PackageStockBL a = new PackageStockBL(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), Convert.ToInt32(dr[4]));
                this.PackageStocks.Add(a);
            }
        }


        public void UpdatePackage(int PackageNum, object newinfo, string WhatTo)
        {
            //מציאת החבילה
            PackageStockBL a = new PackageStockBL();
            for (int i = 0; i < PackageStocks.Count(); i++)
            {
                if (PackageStocks[i].PackageNum1 == PackageNum)
                {
                    a = PackageStocks[i];
                }

            }
            // עדכונים של DB ושל BL
            int Place = a.UpdateManager(WhatTo, newinfo, PackageNum);
            if (Place != -1)
            {
                if (Place == 1)
                {
                    a.Pnum1 = Convert.ToString(newinfo);
                }
                if (Place == 2)
                {
                    a.Price1 = Convert.ToInt32(newinfo);
                }
                if (Place == 3)
                {
                    a.PackageInfo1 = Convert.ToString(newinfo);
                }
            }
            if (Place == -1)
            {
                Console.WriteLine("arguments were incorrect");
            }
        }

        public void DeletePackageStock(int PackageNum)
        {
            
            PackageStockBL b = null;
            ProjectDal_phones.PackageStockDal.DeleteRow(PackageNum); ; //Delete package from DB

            foreach (PackageStockBL a in PackageStocks)
            {
                if (a.PackageNum1 == PackageNum)
                {
                    b = a;
                }
            }
            if (b != null)
            {
                PackageStocks.Remove(b);
                b = null;
            }
        }

        public string Print()
        {
            string b = "";
            foreach(PackageStockBL a in PackageStocks)
            {
                b += a.ToString() + "";
                b += "\n";
            }
            return b;
        }
        

    }
}
