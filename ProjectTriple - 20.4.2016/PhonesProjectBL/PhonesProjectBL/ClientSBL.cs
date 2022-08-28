using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectDal_phones;

namespace PhonesProjectBL
{
    public class ClientSBL
    {
        private List<ClientBL> Clients;

        public List<ClientBL> Clients1
        {
            get { return Clients; }
            set { Clients = value; }
        }


        public ClientSBL()
        {
            this.Clients1 = new List<ClientBL>();
            DataSet ds = ProjectDal_phones.ClientDal.GetAll();
            foreach (DataRow dr in ds.Tables["tblClient"].Rows)
            {
                ClientBL a = new ClientBL(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToBoolean(dr[3]), Convert.ToDateTime(dr[4]), Convert.ToDateTime(dr[5]), Convert.ToInt32(dr[6]),Convert.ToString(dr[7]),Convert.ToString(dr[8]));
                this.Clients.Add(a);
            }
        }
        public void AddABuiltClient(ClientBL a)
        {
            if(!ClientDal.DoesExist(a.ClientID1))
            {
                ClientDal.AddClient(a.Fn, a.Ln, a.JoinDate1, a.BirthDate1, a.Active1,a.Password1,a.Email1,a.PhoneNum1);
                if (Clients == null)
                {
                    Clients = new List<ClientBL>();
                    Clients.Add(a);
                }
                else
                {
                    Clients.Add(a);
                }
                
            }
        }


        public void UpdateClient(int ClientID, object newinfo, string WhatTo)
        {
            //מציאת הקליינט
            ClientBL a = new ClientBL();
            for (int i = 0; i < Clients.Count(); i++)
            {
                if (Clients[i].ClientID1 == ClientID)
                {
                    a = Clients[i];
                }

            }
            // עדכונים של DB ושל BL
            int Place = a.UpdateManager(WhatTo, newinfo, ClientID);
            if (Place != -1)
            {
                if (Place == 1)
                {
                    a.Fn = Convert.ToString(newinfo);
                }
                if (Place == 2)
                {
                    a.Ln = Convert.ToString(newinfo);
                }
                if (Place == 3)
                {
                    a.Active1 = Convert.ToBoolean(newinfo);
                }
                if (Place == 4)
                {
                    a.JoinDate1 = Convert.ToDateTime(newinfo);
                }
                if (Place == 5)
                {
                    a.BirthDate1 = Convert.ToDateTime(newinfo);
                }
                if(Place == 6)
                {
                    a.Password1 = Convert.ToInt32(newinfo);
                }
            }
            if (Place == -1)
                Console.WriteLine("arguments were incorrect");
            }
        public void DeleteClient(int ID)
        {
            ClientBL b = null;
            ProjectDal_phones.ClientDal.DeleteRow(ID); //Delete client from DB

            foreach (ClientBL a in Clients)
            {
                if (a.ClientID1 == ID)
                {
                    b = a;
                }
            }
            if (b != null)
            {
                Clients.Remove(b);
                b = null;
            }
        }
        public string Print()
        {
            string b = "";
            foreach(ClientBL a in Clients)
            {
                b += a.ToString() + "";
                b += "\n";
            }
            return b;
        }
        }
    }
       


    

