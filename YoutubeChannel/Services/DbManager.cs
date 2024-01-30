using System.Data.SQLite;
using System.Data;

namespace YoutubeChannel.Services
{
    public class DbManager
    {
        private readonly string _pathConnection;

        public DbManager(string pathConnection)
        {
            this._pathConnection = $"DataSource={Directory.GetCurrentDirectory()}{pathConnection};Version=3;Pooling=True;";
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_pathConnection);
        }

        public void CreateTablesIFNotExist()
        {
            string[] querys = new string[2];

            querys[0] = "CREATE TABLE IF NOT EXISTS user ( name TEXT, weight TEXT, Id INTEGER )";
            querys[1] = "CREATE TABLE IF NOT EXISTS water ( date TEXT UNIQUE, month TEXT NOT NULL, consumid TEXT )";
        
            using (SQLiteConnection connection = this.GetConnection())
            {
                connection.Open();

                for (int i = 0; i<2; i++)
                {
                    using (SQLiteCommand command = new SQLiteCommand(querys[i], connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = this.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public string[] ExecuteQuery(string query, int number)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                
                string[] VetorInfo = new string[number];

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    SQLiteDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        for (int i = 0; i < number; i++)
                        {
                            VetorInfo[i] = reader.GetString(i);
                        }
                    }

                    connection.Close();

                    return VetorInfo;
                }
            }
        }

        public List<string> ReadColumn(string query, string column)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                
                List<string> VetorInfo = new List<string>();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        VetorInfo.Add(reader[column].ToString());
                    }

                    connection.Close();

                    return VetorInfo;
                }
            }
        }
    }
}