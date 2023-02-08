using MySql.Data.MySqlClient;
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

        public List<AccountData> AllAccounts = new List<AccountData>();

        private MySqlConnection Conn;
        public AccountData ActiveAccount = new AccountData();
        public AccountData NewAccount = new AccountData();

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

        public void SignUp()
        {
            OpenConn();

            var cmd = new MySqlCommand("INSERT INTO account(Nickname, Password, Age) " +
                "VALUES ('"+ NewAccount.Nickname +"','"+ NewAccount.PassWord +"','"+ NewAccount.Age +"')", Conn);
            var reader = cmd.ExecuteReader();

            reader.Close();
            Conn.Close();
        }

        public void Hash()
        {
            HashedPassword = Password.GetHashCode();
        }

        public void GetAllAccounts()
        {
            OpenConn();

            var cmd = new MySqlCommand("SELECT id, Nickname, Age, Password, Bio, idFavoTruck FROM account;", Conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                AccountData TijdelijkAccount = new AccountData();

                TijdelijkAccount.id = reader.GetInt32("id");
                TijdelijkAccount.Nickname = reader.GetString("Nickname");
                TijdelijkAccount.Age = reader.GetInt16("Age");
                TijdelijkAccount.PassWord = reader.GetInt32("password");
                TijdelijkAccount.Bio = reader.GetString("Bio");
                TijdelijkAccount.idFavoTruck = reader.GetInt32("idFavoTruck");

                AllAccounts.Add(TijdelijkAccount);
            }
        }
    }
}
