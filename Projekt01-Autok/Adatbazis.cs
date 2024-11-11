using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt01_Autok
{
    internal class Adatbazis
    {
        public static MySqlConnection Connection = null;

        public string Server { get; set; }
        public string DbName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }   

        public Adatbazis(string server, string dbName, string username, string password)
        {
            this.Server = server;
            this.DbName = dbName;
            this.Username = username;
            this.Password = password;

            this.Csatlakozas();
        }

        public void Csatlakozas()
        {
            string connectionString = $"SERVER = {this.Server};";
            connectionString += $"DATABASE = {this.DbName};";
            connectionString += $"USERNAME = {this.Username};";
            connectionString += $"PASSWORD = {this.Password};";

            Connection = new MySqlConnection(connectionString) ;
        }

        public List<Sportkocsi> Adatlekeres()
        {
            List<Sportkocsi> SportkocsiLista = new List<Sportkocsi>();

            string query = "SELECT * FROM duduk;";
            MySqlConnection connection = Connection;

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    string marka = reader.GetString(1);
                    string tipus = reader.GetString(2);
                    int ar = reader.GetInt32(3);
                    string kep = reader.GetString(4);

                    Sportkocsi sk = new Sportkocsi(marka, tipus, ar, kep);
                    SportkocsiLista.Add(sk);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nem sikerült Csatlakozni! {ex.Message}");
            }

            return SportkocsiLista;
        }
    }
}
