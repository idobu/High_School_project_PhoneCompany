using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesProjectBL
{
    public class ManagerBL
    {
        /// <summary>
        /// פעולה בונה פשוטה של מנהל
        /// </summary>
        public ManagerBL()
        {
        }
        /// <summary>
        /// מחיקה כללית של הזמנה ממאגר ההזמנות
        /// </summary>
        /// <param name="OrderID"></param>
        public void RemoveOrderFromDB(int OrderID)
        {
            ProjectDal_phones.PhoneDal.DeletePhone_Order(OrderID);
            ProjectDal_phones.PackageDal.DeletePackage_Order(OrderID);
            ProjectDal_phones.PhoneOrderDal.DeleteRow(OrderID);
        }
    
    }
}
