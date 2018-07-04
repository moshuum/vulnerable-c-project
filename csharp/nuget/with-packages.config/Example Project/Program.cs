using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            string createQuery = @"CREATE TABLE IF NOT EXISTS
                                 [TableExample] (
                                 [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                 [Name] NVARCHAR(2048) NULL)";

            string createTmpTable = @"create table tmpTable
                                    as 
                                    select * from TableExample"; /* vulnerable statement (CVE-2018-8740) */ 


            System.Data.SQLite.SQLiteConnection.CreateFile("example.db");
            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection("data source=example.db"))
            {
                using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = createQuery;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO TableExample(Name) values('first user')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO TableExample(Name) values('second user')";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = createTmpTable;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO tmpTable(Id, Name) values('3','tmp user')";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "SELECT * from tmpTable";
                    using (System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("Displaying Temporary table with 'create table [table name] as' syntax ");
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Id"] + ". " + reader["Name"]);
                        }
                        conn.Close();
                        Console.WriteLine("end \nPlease refer (CVE-2018-8740)");
                    }
                }
            }
            Console.ReadLine();


        }
    }
}
