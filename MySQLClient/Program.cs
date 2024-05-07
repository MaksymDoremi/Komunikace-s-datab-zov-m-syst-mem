using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace MySQLClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseConnection.GetConnection().Open();

            // INSERT
            // use MySqlCommand to insert query 
            string query = "insert into Passenger(Name, Surname) values(@name, @surname)";

            using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@name", "Karel");
                cmd.Parameters.AddWithValue("@surname", "Novak");

                cmd.ExecuteNonQuery();
            }

            Passenger passenegr1;

            // SELECT
            // use MySqlDataAdapter to insert query
            // then use DataTable to retrieve data from databasee
            using (MySqlDataAdapter sda = new MySqlDataAdapter(new MySqlCommand("select * from Passenger", DatabaseConnection.GetConnection())))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine(dr["Name"] + " " + dr["Surname"]);

                    // mapping entities
                    passenegr1 = new Passenger((string)dr["Name"], (string)dr["Surname"]);
                }
            }

            // UPDATE
            // use MySqlCommand to insert query 
            query = "update Passenger set Name = @name, Surname = @surname where ID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@name", "new name");
                cmd.Parameters.AddWithValue("@surname", "new surname");

                cmd.ExecuteNonQuery();
            }

            // DELETE
            // use MySqlCommand to insert query 
            query = "delete from Passenger where ID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@id", 1);

                cmd.ExecuteNonQuery();
            }

            DatabaseConnection.GetConnection().Close();
        }
    }
}