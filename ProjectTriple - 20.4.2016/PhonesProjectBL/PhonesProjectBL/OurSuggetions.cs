using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDal_phones;
using System.Data;

namespace PhonesProjectBL
{
    public class OurSuggetions
    {
        private int ClientColor;                                      //מספר המתאר קבוצה כולשהי של לקוחות שאוהבים את קבוצת הצבע הבאה
        private int ClientCompany;                                    //מספר המתאר קבוצה כולשהי של לקוחות שאוהבים את קבוצת החברות הטלפונים הבאה
        private DataSet ClientPhones;                                 //טבלת הטלפונים והתיאורים שלהם
        private string[] NeededColors;

        /// <summary>
        /// בניית הפעולה להצעות של הפרוייקט
        /// </summary>
        /// <param name="PersonID"></param>
        public OurSuggetions(int PersonID,int currentorder)
        {
            NeededColors = new string[3];
            this.ClientPhones = ProjectDal_phones.PhoneDal.GetAllPhoneDetails(PersonID,currentorder);
            this.ClientCompany =CheckMyCompany();
            this.ClientColor = CheckMyColor();
        }
        /// <summary>
        /// פעולה לבדיקת הקבוצת צבעים האהובה של הלקוח לאורך היסטוריית הקניות שלו
        /// </summary>
        /// <returns></returns>
        public int CheckMyColor()
        {
            int[] ColorGroup= new int[4];
            ColorGroup[0]=0;
            ColorGroup[1]=0;
            ColorGroup[2]=0;
            ColorGroup[3]=0;
            int final;
            foreach(DataRow a in this.ClientPhones.Tables["tblPhoneCheck"].Rows)
            {
                if((a[0].ToString()=="Yellow")||(a[0].ToString()=="White")||(a[0].ToString() == "Azure"))
                {
                    ColorGroup[0]++;
                }
                if ((a[0].ToString() == "Blue") || (a[0].ToString() == "Pink")||(a[0].ToString() == "Green"))
                {
                    ColorGroup[1]++;
                }
                if ((a[0].ToString() == "Red") || (a[0].ToString() == "Orange") || (a[0].ToString() == "Brown"))
                {
                    ColorGroup[2]++;
                }
                if ((a[0].ToString() == "Grey") || (a[0].ToString() == "Black") || (a[0].ToString() == "Purpel"))
                {
                    ColorGroup[3]++;
                }
            }
            final = ColorGroup.Max();
            int Place = 0;
            for (int i = 0; i < ColorGroup.Length;i++)
            {
                if(final==ColorGroup[i])
                {
                    Place = i;
                }
            }
            if (Place + 1 == 1)
            {
                this.NeededColors[0] = "Yellow";
                this.NeededColors[1] = "White";
                this.NeededColors[2] = "Azure";
            }
            if (Place + 1 == 2)
            {
                this.NeededColors[0] = "Pink";
                this.NeededColors[1] = "Blue";
                this.NeededColors[2] = "Green";
            }
            if (Place + 1 == 3)
            {
                this.NeededColors[0] = "Red";
                this.NeededColors[1] = "Orange";
                this.NeededColors[2] = "Brown";
            }
            if (Place + 1 == 4)
            {
                this.NeededColors[0] = "Grey";
                this.NeededColors[1] = "Black";
                this.NeededColors[2] = "Purpel";
            }

            return Place + 1;
        
        }
        /// <summary>
        /// חברת טלפונים שהלקוח קנה הכי הרבה ממנה וסידורה לפי הקבוצה המתאימה
        /// </summary>
        /// <returns></returns>
        public int CheckMyCompany()
        {
            int[] CompanyGroup = new int[3];
            int final;
            foreach (DataRow a in this.ClientPhones.Tables["tblPhoneCheck"].Rows)
            {
                if ((a[1].ToString() == "Apple"))
                {
                    CompanyGroup[0]++;
                }
                if ((a[1].ToString() == "Samsung") || (a[1].ToString() == "LG") || (a[1].ToString() == "Nokia") || (a[1].ToString() == "Motorola") || (a[1].ToString() == "Sony"))
                {
                    CompanyGroup[1]++;
                }
                if ((a[1].ToString() == "HTC") || (a[1].ToString() == "Microsoft"))
                {
                    CompanyGroup[2]++;
                }
            }
            final = CompanyGroup.Max();
            int Place = 0;
            for (int i = 0; i < CompanyGroup.Length; i++)
            {
                if (final == CompanyGroup[i])
                {
                    Place = i;
                }
            }
            return Place + 1;
        }
        /// <summary>
        /// החזרת ההצעה של החברה
        /// </summary>
        /// <returns></returns>
        public DataSet GetMySuggestions()
        {
            DataSet Sugg=null;
            if(this.ClientCompany==1)
            {
                Sugg=ProjectDal_phones.StockDal.GetPhonesForOrder_OS_group1(this.NeededColors);
            }
            if(this.ClientCompany==2)
            {
                Sugg=ProjectDal_phones.StockDal.GetPhonesForOrder_OS_group2(this.NeededColors);
            }
            if(this.ClientCompany==3)
            {
                Sugg = ProjectDal_phones.StockDal.GetPhonesForOrder_OS_group3(this.NeededColors);
            }
            return Sugg;
        }
      
    }
}
