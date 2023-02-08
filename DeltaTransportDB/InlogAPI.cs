﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaTransportDB
{
    public class InlogAPI
    {
        public string Password;
        public int HashedPassword;

        private MySqlConnection Conn;
        public AccountData ActiveAccount = new AccountData();

        private void OpenConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = ConfigurationManager.AppSettings["Connectie"];

            Conn.Open();
        }

        public void Signin()
        {
            OpenConn();

            
        }

        public void Hash()
        {
            HashedPassword = Password.GetHashCode();
        }
    }
}
