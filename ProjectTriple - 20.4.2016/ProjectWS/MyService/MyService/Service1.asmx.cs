using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using PhonesProjectBL;

namespace MyService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        /// <summary>
        /// פעולה המחזירה משתנה בוליאני של הימצאות לקוח או לא במסד הנתונים
        /// </summary>
        /// <param name="ClientID"></param>
        /// <returns></returns>
        [WebMethod]
        public bool CheckUserExistence(string ClientName, string ClientLastname,string PhoneNumber)
        {
            ClientBL a = new ClientBL();
            return a.IsExistName(ClientName, ClientLastname, PhoneNumber); ;
        }
        /// <summary>
        /// פעולה השולחת טבלה לצורך פרסום הטלפונים
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet CommTable_Phones()
        {
            return StockBL.ReturnClientNewPhones();
        }
        /// <summary>
        /// פעולה השולחת טבלה לצורך פרסום הטלפונים
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public DataSet CommTable_PhonesDogs()
        {
            return StockBL.ReturnClientServiceNewPhones();
        }

    }
}