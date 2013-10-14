using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarehouseManager.DAC
{
    public class DBInfo
    {       
        public DBInfo()
        {
           /* Server = "195.0.100.15";
            DataBase = "InventoryMan";
            User = "prowler";
            Password = "recon";*/

            Server = "195.0.100.4";
            DataBase = "InventoryMan";
            User = "IngUser";
            Password = "#recon1205#";
        }
        private string server;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private string dataBase;

        public string DataBase
        {
            get { return dataBase; }
            set { dataBase = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }



        public string sqlSet() 
        {
            string res;
           res = "Data Source=" + Server + ";Network Library=DBMSSOCN; Initial Catalog=" + DataBase + ";User ID=" + User + ";Password=" + Password+";";
            return res;
        }
    }
}
