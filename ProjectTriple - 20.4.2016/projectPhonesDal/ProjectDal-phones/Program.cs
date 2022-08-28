using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ProjectDal_phones
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //ClientDal.AddClient("yossi", "haviv", "12/3/1998", "18/3/1928", true);
            //ClientDal.AddClient("ori", "cohen", "5/6/1999", "22/3/1968", true);
            //ClientDal.AddClient("ido", "bueno", "12/3/1998", "12/3/1948", true);
            //ClientDal.AddClient("yuval", "ostrovski", "7/8/2000", "11/3/1988", true);
            //ClientDal.AddClient("ronen", "haim", "12/3/1998", "19/3/1918", true);

            //DataSet ds = ClientDal.GetAll();
            //foreach (DataRow dr in ds.Tables["tblClient"].Rows)
            //
            //  Console.WriteLine("{0}  {1}   {2}  {3} {4}  {5}", dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            //
            //Console.ReadKey(); 
            //List<String> G=ClientDal.GetJoinDate("12/3/1998");
            //for (int i = 0; i < G.Count; i++)
            //{
            //    Console.WriteLine(G[i]);
            //}
            //Console.ReadLine();
            //bool a=ClientDal.DoesExist(120);
            //Console.WriteLine(a);
            //Console.ReadKey();
            //ClientDal.DeleteRow(120);
            //a = ClientDal.DoesExist(120);
            //Console.WriteLine(a);
            //Console.ReadKey();




            //PhoneOrderDal.AddOrder(143,"1/11/2015");
            //DataSet dm = PhoneOrderDal.GetAll();
            //foreach (DataRow dr in dm.Tables["tblPhoneOrder"].Rows)
            //
            //    Console.WriteLine("{0}  {1}   {2} ", dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            //
            //Console.ReadKey();
            //Console.WriteLine(PhoneOrderDal.DoesExist(143));
            //Console.ReadKey();
            //PhoneOrderDal.DeleteRow(143);
            //Console.ReadKey();
            //Console.WriteLine(PhoneOrderDal.DoesExist(143));
            //Console.ReadKey();
            //
            //
            //
            //PhoneOrderDal.AddOrder(143, "1/11/2015");
            //DataSet dn = PhoneOrderDal.GetAll();
            //foreach (DataRow dr in dn.Tables["tblPhoneOrder"].Rows)
            //
            //    Console.WriteLine("{0}  {1}   {2} ", dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            //
            //Console.ReadKey();
            //PhoneOrderDal.UpdateRow<string>(143, "12/4/1997", 2);
            //DataSet dh = PhoneOrderDal.GetAll();
            //foreach (DataRow dr in dh.Tables["tblPhoneOrder"].Rows)
            //
            //    Console.WriteLine("{0}  {1}   {2} ", dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            //
            //Console.ReadKey();





          //StockDal.AddPhoneToStock(8, "yellow", "Apple", 2000, "20/3/1997", 7958675);


          //DataSet dm = StockDal.GetAll();
          //foreach (DataRow dr in dm.Tables["tblStock"].Rows)
          //
          //    Console.WriteLine("{0}  {1}   {2}  {3} {4}  {5}", dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
          //
          //Console.ReadKey();
          // Console.WriteLine(StockDal.DoesExist(1));
          // 
          // Console.ReadKey();
          // StockDal.DeleteRow(1);
          // DataSet dd = StockDal.GetAll();
          // foreach (DataRow dr in dd.Tables["tblStock"].Rows)
          // 
          //     Console.WriteLine("{0}  {1}   {2}  {3} {4}  {5}", dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
          // 
          // Console.ReadKey();
          // Console.WriteLine(StockDal.DoesExist(1));
          // Console.ReadKey();

            //PhoneOrderDal.AddOrder(145, "12/3/1998");
            //PhoneOrderDal.AddOrder(146, "12/4/1998");
            //PhoneOrderDal.AddOrder(147, "12/3/1998");
            //
            //StockDal.AddPhoneToStock(5,"pink","Apple",1000,"16/5/2000",12345);


            //PhoneDal.AddPhone(27, 3);
            
            //DataSet a = PhoneOrderDal.PhonesInDate("12/3/1998");
            //
            //foreach (DataRow dr in a.Tables["tblKabala"].Rows)
            //
            //    Console.WriteLine("{0}  {1} {2} {3}", dr[0].ToString(), dr[1].ToString(),dr[2].ToString(),dr[3].ToString());
            //
            //Console.ReadKey();

            //DateTime a = new DateTime(1998,6,7);
            //PhoneOrderDal.AddOrder(126, a);

            //PhoneDal.AddPhone(27, 3);
            //PhoneOrderDal.KabalaPhones(27, 143);
        }
    }
}
