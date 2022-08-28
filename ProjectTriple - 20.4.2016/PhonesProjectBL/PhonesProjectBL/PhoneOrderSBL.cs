using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhonesProjectBL
{
    public class PhoneOrderSBL
    {
        private List<PhoneOrderBL> Orders;


        public PhoneOrderSBL()
        {
            Orders = new List<PhoneOrderBL>();
            DataSet ds = ProjectDal_phones.PhoneOrderDal.GetAll();
            foreach (DataRow dr in ds.Tables["tblPhoneOrder"].Rows)
            {
                PhoneOrderBL a = new PhoneOrderBL(Convert.ToInt32(dr[0]),Convert.ToInt32(dr[1]),Convert.ToDateTime(dr[2]));
                this.Orders.Add(a);
            }
        }

        public void UpdateClient(int OrderID, object newinfo, string WhatTo)
        {
            //מציאת הקליינט
            PhoneOrderBL a = new PhoneOrderBL();
            for (int i = 0; i < Orders.Count(); i++)
            {
                if (Orders[i].OrderID1 == OrderID)
                {
                    a = Orders[i];
                }

            }
            // עדכונים של DB ושל BL
            int Place = a.UpdateManager(WhatTo, newinfo, OrderID);
        
            if (Place == 2)
            {
                a.OrderDateTime1 = Convert.ToDateTime(newinfo);
            }
            if (Place == -1)
            {
                Console.WriteLine("arguments were incorrect");
            }
        }

        public void DeleteOrder(int OrderID)
        {
            PhoneOrderBL b = null;
            ProjectDal_phones.PhoneOrderDal.DeleteRow(OrderID); ; //Delete order from DB

            foreach (PhoneOrderBL a in Orders)
            {
                if (a.OrderID1 == OrderID)
                {
                    b = a;
                }
            }
            if (b != null)
            {
                Orders.Remove(b);
                b = null;
            }
        }

        public string Print()
        {
            string b = "";
            foreach(PhoneOrderBL a in Orders)
            {
                b += a.ToString() + "";
                b += "\n";
            }
            return b;
        }
    }
}
