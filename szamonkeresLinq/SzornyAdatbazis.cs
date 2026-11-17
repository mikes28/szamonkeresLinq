using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace szamonkeresLinq
{
    internal class SzornyAdatbazis
    {


        private static string server = "localhost";
        private static string databaseName = "fantasybestariumdb";
        private static string userName = "root";
        private static string password = "";

        private static string connectionString =
       $"Server={server};Database={databaseName};Uid={userName};Pwd={password};";

       public static List<Szorny> Feltolt()
        {
            List<Szorny> szornyek = new List<Szorny>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM szornyek";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        int veszelyessegiSzint = reader.GetInt32("veszelyessegi_szint");
                        string elohely = reader.GetString("elohely");
                        string foGyengeseg = reader.GetString("fo_gyengeseg");
                        string leggyakoribbZsakmany = reader.GetString("leggyakoribb_zsakmany");
                        bool veszelyesE = reader.GetBoolean("veszelyes_e");
                        Szorny szorny = new Szorny(id, nev, veszelyessegiSzint, elohely, foGyengeseg, leggyakoribbZsakmany, veszelyesE);
                        szornyek.Add(szorny);
                    }

                    if (szornyek.Count == 0)
                    {
                        Console.WriteLine("Nincs szörny az adatbázisban.");
                    }
                }
            }
            return szornyek;
        }


    }
}
