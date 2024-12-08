/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Tools Class file
 *===========================================================*/

using Assignment05.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAL
{
    /// <summary>
    /// Tools class method
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// Method to get max ID from database using table name and id name
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="idName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetMaxID(string tableName, string idName)
        {
            int maxId = 0;
            String sql = $"SELECT MAX({idName}) FROM {tableName}";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command;

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                maxId = reader.GetInt32(0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            {
                connection.Close();
            }

            return maxId;
        }
    }
}
