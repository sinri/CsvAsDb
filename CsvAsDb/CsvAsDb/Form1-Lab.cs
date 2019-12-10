using System.Data.SQLite;
using System.Windows.Forms;

namespace CsvAsDb
{
    public partial class Form1 : Form
    {
        void SqliteTest1()
        {
            WriteLog("Test Begins");

            WriteLog("Creating a db in memory...");
            string cs = "Data Source=:memory:";

            var con = new SQLiteConnection(cs);
            con.Open();

            WriteLog("Requiring SQLite Version...");
            string stm = "SELECT SQLITE_VERSION()";
            var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            WriteLog("SQLite version: " + version);

            cmd = new SQLiteCommand(con);
            cmd.CommandText = "DROP TABLE IF EXISTS cars";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cars(
                id INTEGER PRIMARY KEY,
                name TEXT, 
                price INT,
                code TEXT,
                x REAL
            )";
            cmd.ExecuteNonQuery();
            /*
            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Audi',52642,'A')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Mercedes',57127,'A')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Skoda',9000,'C')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Volvo',29000,'A')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Bentley',350000,'B')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Citroen',21000,'B')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Hummer',41400,'C')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES('Volkswagen',21600,'A')";
            cmd.ExecuteNonQuery();
            */

            cmd.CommandText = "INSERT INTO cars(name, price,code,x) VALUES(@name, @price,@code,@x)";

            cmd.Parameters.AddWithValue("@name", "BMW");
            cmd.Parameters.AddWithValue("@price", 36600);
            cmd.Parameters.AddWithValue("@code", "E");
            cmd.Parameters.AddWithValue("@x", "1.2");
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            WriteLog("Renew the table");

            //stm = "SELECT code, sum(price) as summary FROM cars group by code LIMIT 5";
            stm = "select * from cars limit 5";

            cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetInt32(2)}");
                //var name = rdr.GetString(rdr.GetOrdinal("code"));
                //var price = rdr.GetDouble(rdr.GetOrdinal("summary"));
                //WriteLog("Result: name=" + name + " price=" + price);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    WriteLog("Field: " + reader.GetName(i));
                    WriteLog("Type: " + reader.GetDataTypeName(i));
                    WriteLog("C#T: " + reader.GetFieldType(i));
                    WriteLog("Value: " + reader.GetValue(i));
                }
            }
        }
    }
}