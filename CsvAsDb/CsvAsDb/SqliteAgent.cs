using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvAsDb
{
    class SqliteAgent
    {
        public string TableName { get; set; }
        public List<SqliteTableFieldDefinition> FieldDefinitions { get; set; }
        public SQLiteConnection sqliteConnection;

        public SqliteAgent(string tableName)
        {
            InitializeMemoryDatabase();
            TableName = tableName;
        }

        public void InitializeMemoryDatabase()
        {
            string cs = "Data Source=:memory:";

            sqliteConnection = new SQLiteConnection(cs);
            sqliteConnection.Open();
        }

        public string GetSqliteVersion()
        {
            string stm = "SELECT SQLITE_VERSION()";
            var cmd = new SQLiteCommand(stm, sqliteConnection);
            return cmd.ExecuteScalar().ToString();
        }

        public void EnsureTableWithFields( List<string> fieldNames)
        {
            FieldDefinitions = new List<SqliteTableFieldDefinition>();
            foreach(string fn in fieldNames)
            {
                SqliteTableFieldDefinition x = new SqliteTableFieldDefinition();
                x.fieldName = fn;
                x.fieldType = "TEXT";
                FieldDefinitions.Add(x);
            }

            EnsureTableWithFields(FieldDefinitions);
        }

        public void EnsureTableWithFields(List<SqliteTableFieldDefinition> fields)
        {
            FieldDefinitions = fields;

            string removeTableSql = "drop table if exists " + TableName + ";";
            var cmd1 = new SQLiteCommand(removeTableSql, sqliteConnection);
            cmd1.ExecuteNonQuery();

            var randomIdFieldName="random_id_"+(new Random()).Next();

            string createTableSql = "create table " + TableName + " ( ";
            foreach(var definition in fields)
            {
                createTableSql += definition.fieldName + " " + definition.fieldType + ", ";
            }
            createTableSql += randomIdFieldName + " INTEGER PRIMARY KEY );";

            var cmd2 = new SQLiteCommand(createTableSql, sqliteConnection);
            cmd2.ExecuteNonQuery();
        }

        public class SqliteTableFieldDefinition
        {
            public string fieldName;
            public string fieldType;// TEXT INT REAL NUMERIC etc.
        }

        public void InsertRow(Dictionary<string,string> rowData)
        {
            var cmd = new SQLiteCommand(sqliteConnection);

            string insertSql = "INSERT INTO " + TableName + " ( ";
            for(int i=0;i< FieldDefinitions.Count();i++)
            {
                insertSql += FieldDefinitions[i].fieldName + (i < FieldDefinitions.Count() - 1 ? "," : "") + " ";
            }
            insertSql += " ) VALUES ( ";
            for (int i = 0; i < FieldDefinitions.Count(); i++)
            {
                insertSql += "@"+FieldDefinitions[i].fieldName + (i < FieldDefinitions.Count() - 1 ? "," : "") + " ";
            }
            insertSql += ")";
            cmd.CommandText = insertSql;

            //cmd.CommandText = "INSERT INTO cars(name, price,code) VALUES(@name, @price,@code)";

            for (int i = 0; i < FieldDefinitions.Count(); i++)
            {
                cmd.Parameters.AddWithValue("@" + FieldDefinitions[i].fieldName, rowData[FieldDefinitions[i].fieldName]);
            }

            //cmd.Parameters.AddWithValue("@name", "BMW");
            //cmd.Parameters.AddWithValue("@price", 36600);
            //cmd.Parameters.AddWithValue("@code", "E");
            
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }

        public SQLiteDataReader QueryResultRows(string sql)
        {
            var cmd = new SQLiteCommand(sqliteConnection);
            cmd.CommandText = sql;
            var reader=cmd.ExecuteReader();

            return reader;
        }
    }
}
