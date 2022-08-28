using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDal_phones;
using System.Data;

namespace PhonesProjectBL
{
    public class PackageStockBL
    {
        private int PackageNum;                  //קוד החבילה

        public int PackageNum1
        {
            get { return PackageNum; }
        }
        private string Prestriction;                        //מספר טלפון

        public string Pnum1
        {
            get { return Prestriction; }
            set
            {
                Prestriction= value;
            ProjectDal_phones.PackageStockDal.UpdateRow(PackageNum, value, 1);
            }
        }
        private int Price;                       //מחיר

        public int Price1
        {
            get { return Price; }
            set { Price = value;
            ProjectDal_phones.PackageStockDal.UpdateRow(PackageNum, value, 2);
            }
        }
        private string PackageInfo;              //מידע על חבילה

        public string PackageInfo1
        {
            get { return PackageInfo; }
            set { PackageInfo = value;
            ProjectDal_phones.PackageStockDal.UpdateRow(PackageNum, value, 3);
            }
        }
        private int PackageInStock;

        public int PackageInStock1
        {
            get { return PackageInStock; }
            set { PackageInStock = value;
            ProjectDal_phones.PackageStockDal.UpdateRow(PackageNum, value, 4);
            }
        }

   
        /// <summary>
        /// פעולות בונות לפי דרישות ההוספה של החבילה
        /// </summary>
        public PackageStockBL()
        {
        }
        public PackageStockBL(int PackageNum, string Prestriction, int Price, string PackageInfo, int PackageInStock)
        {
            if (!ProjectDal_phones.PackageStockDal.DoesExist(PackageNum))
            {
                ProjectDal_phones.PackageStockDal.AddPackageToStock(Prestriction, Price, PackageInfo, PackageInStock);
                this.PackageInfo = PackageInfo;
                this.Prestriction = Prestriction;
                this.Price = Price;
                this.PackageInStock = PackageInStock;
                this.PackageNum = ProjectDal_phones.PackageStockDal.GetMax();
                //this.PackagesInSal = 0;
            }
            else
            {
                this.PackageInfo = PackageInfo;
                this.Prestriction = Prestriction;
                this.Price = Price;
                this.PackageNum = PackageNum;
                this.PackageInStock = PackageInStock;
                //this.PackagesInSal = 0;
            }
        }
        /// <summary>
        /// פעולה להוספה כמות נוספת של חבילות למאגר כאשר נגמרו החבילות או מספר נמוך
        /// </summary>
        /// <param name="PackageID"></param>
        /// <param name="AddToStock"></param>
        public PackageStockBL(int PackageID,int AddToStock)
        {
            DataSet a = ProjectDal_phones.PackageStockDal.GetValue(PackageID);
            DataRow b = a.Tables["tblPackageStock"].Rows[0];
            this.PackageInStock = AddToStock + Convert.ToInt32(b[4]);
            ProjectDal_phones.PackageStockDal.UpdateRow(PackageID, AddToStock + Convert.ToInt32(b[4]), 4);
            this.PackageInfo =Convert.ToString(b[3]);
            this.Prestriction = Convert.ToString(b[1]);
            this.Price = Convert.ToInt32(b[2]);
            this.PackageNum = Convert.ToInt32(b[0]);
        }
        /// <summary>
        /// התייחסות לחבילה ספציפית מהמסד נתונים
        /// </summary>
        /// <param name="PackageID"></param>
        public PackageStockBL(int PackageID)
        {
            if(ProjectDal_phones.PackageStockDal.DoesExist(PackageID));
            {
            DataSet a = ProjectDal_phones.PackageStockDal.GetValue(PackageID);
            DataRow b = a.Tables["tblPackageStock"].Rows[0];
            this.PackageInStock = Convert.ToInt32(b[4]);
            this.PackageInfo = Convert.ToString(b[3]);
            this.Prestriction = Convert.ToString(b[1]);
            this.Price = Convert.ToInt32(b[2]);
            this.PackageNum = Convert.ToInt32(b[0]);
            }
        }
        /// <summary>
        /// פנייה לחביה והבאתה מהמסד נתונים ע"י מחיר ומידע
        /// </summary>
        /// <param name="PackageInfo"></param>
        /// <param name="Price"></param>
        public PackageStockBL(string PackageInfo,int Price)
        {
            DataSet a = ProjectDal_phones.PackageStockDal.GetSpecificPack(PackageInfo, Price);
            if (a.Tables["tblSells"].Rows.Count != 0)
            {
                DataRow b = a.Tables["tblSells"].Rows[0];
                this.PackageInStock = Convert.ToInt32(b[4]);
                this.PackageInfo = Convert.ToString(b[3]);
                this.Prestriction = Convert.ToString(b[1]);
                this.Price = Convert.ToInt32(b[2]);
                this.PackageNum = Convert.ToInt32(b[0]);
            }
        }
           
        /// <summary>
        /// עדכון פריט יחיד מתוך מאגר הרבים של החבילות
        /// </summary>
        /// <param name="ToUpdate"></param>
        /// <param name="newinfo"></param>
        /// <param name="PackageNum"></param>
        /// <returns></returns>
        public int UpdateManager(string ToUpdate, object newinfo, int PackageNum)
        {
            if (ToUpdate == "Pnum")
            {
                PackageStockDal.UpdateRow(PackageNum, newinfo, 1);
                return 1;

            }
            if (ToUpdate == "Price")
            {
                PackageStockDal.UpdateRow(PackageNum, newinfo, 2);
                return 2;

            }
            if (ToUpdate == "PackageInfo")
            {
                PackageStockDal.UpdateRow(PackageNum, newinfo, 3);
                return 3;

            }
            if (ToUpdate == "PackageInStock")
            {
                PackageStockDal.UpdateRow(PackageNum, newinfo, 4);
                return 1;

            }
            return -1;
        }
        /// <summary>
        /// החזרת כל החבילות של הלקוח המסויים הזה
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DataSet ReturnMyPackages(int ID)
        {
            DataSet dr = ProjectDal_phones.PackageDal.GetAllForClient(ID);
            return dr;
        }
        /// <summary>
        /// החזרת כל החבילות הניתנות למכירה ממאגר הנתונים
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnPackages_All()
        {
            DataSet dr = ProjectDal_phones.PackageStockDal.GetPacksForOrder_All();
            return dr;
        }
        /// <summary>
        /// החזרת טבלה מכילה את החבילות האהובות האחרונות של הלקוח
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DataSet ReturnPackages_Favorits(int ID)
        {
            DataSet dr = ProjectDal_phones.PackageStockDal.GetPacksForOrder_Favorits(ID);
            return dr;
        }
        /// <summary>
        /// החזרת כל החבילות 
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnEverything()
        {
            return ProjectDal_phones.PackageStockDal.GetAll();
        }
        /// <summary>
        /// החזרת חבילות ללא הגבלה בלבד
        /// </summary>
        /// <returns></returns>
        public static DataSet ReturnRestrictionOnly_Packs()
        {
            return ProjectDal_phones.PackageStockDal.GetPacksForService();
        }
        /// <summary>
        /// הדפסת נתונים על החבילה
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string a = this.PackageNum + "" + this.Prestriction + "" + this.Price + "" + this.PackageInfo;
            return a;
        }
    }
}
