using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDal_phones;
using System.Data;


namespace PhonesProjectBL
{
     class Program
    {
        static void Main(string[] args)
        {
            //DateTime a = new DateTime (1997,5,2);
            //DateTime b = new DateTime(1987, 12, 2);
            //DateTime c = new DateTime(1989, 11, 23);
            //DateTime d = new DateTime(1976, 11, 21);
            //
            //ClientBL client1 = new ClientBL(0, "Ido", "Bueno", true,a, b);
            //ClientBL client2 = new ClientBL(0,"Ilan", "Zendel", true, c, d);

            //ClientsBL W = new ClientsBL();
            //W.UpdateClient(284, "Zendel", "LastName");
            //Console.WriteLine(W.ToString());
            //PhoneOrderBL b = new PhoneOrderBL(4,126,a);  283
            //ClientSBL.DeleteClient

            //ClientSBL a = new ClientSBL();
            //Console.WriteLine(a.Print());
            //Console.ReadLine();
            //a.UpdateClient(143, "adi", "FirstName");
            //Console.WriteLine(a.Print());
            //Console.ReadLine();

            //הדפסה של הלקוחות
            //a.DeleteClient(283);
            //Console.WriteLine(a.Print());
            //Console.ReadLine();
            //a.DeleteClient  
            //מחיקה והדפסה



           //// StockBL c= new StockBL(3,5,"pink","Apple",1000,2010,12345);
           //// StockBL v = new StockBL(9, 6, "red", "Samsung", 2000, 2012, 54321);
           //// StockBL h = new StockBL(10, 7, "blue", "LG", 2000, 2012, 23464);
           //// StockBL m = new StockBL(11, 8, "yellow", "nokia", 2000, 2012, 90754);
           // //יצירת סטוק חדש עם כמות חדשה של טלפונים
           
           ////PackageStockBL g = new PackageStockBL(4, "053-9483746", 1300, "best", 5);
           // 
           // //יצירת סטוק חדש של חבילות עם כמות חדשה של חבילות
           // DateTime b = new DateTime();
           // PhoneOrderBL a = new PhoneOrderBL(29, 126, b);
           // //a.AddPhone(c, 126, 29);
           // a.AddPhone(c, 126, 29);
           // a.AddPackage(d, 126, 29);
           // a.AddPackage(g, 126, 29);
           // a.AddPhone(m, 126, 29);
           // a.AddPhone(h, 126, 29);
           // a.AddPhone(v, 126, 29);
           // //a.AddPackage(d, 126, 29);
           // //a.AddPackage(d, 126, 29);
           // a.RemovePackage(d, 29);
           // a.RemovePhone(h, 29);
           // //a.RemovePackage(d, 29);
           // //a.RemovePhone(c, 29);
           // //a.RemovePhone(c,29);
           // 
           // a.GetTotalPrice();
           // Console.WriteLine(a.TotalPrice1);
           // Console.ReadLine();
           // StockBL w = new StockBL(3, 3);
           // PackageStockBL j = new PackageStockBL(1, 3);
            StockBL a = new StockBL(3);
            PackageStockBL b = new PackageStockBL(1);
            PhoneOrderBL r = new PhoneOrderBL(143, 27);
            r.AddPhone(a, 143, 27);
            r.AddPackage(b, 143, 27);
        }
    }
}
