using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SteribaseImporter.Query
{
    static class QueryTask
    {
        public static int GetHighestId(MySqlConnection sqlConnection)
        {
            int result = 0;
            var table = ConfigHandler.GetConfigValue(ConfigValues.table);
            var field = ConfigHandler.GetConfigValue(ConfigValues.field);
            try
            {
                sqlConnection.Open();
                var command = new MySqlCommand($"SELECT MAX({field}) AS {field} FROM {table};", sqlConnection);
                var rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    result = rdr.GetInt32(field);
                }
                rdr.Close();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                sqlConnection.Close();
            }
            return result;
        }
    }
}
