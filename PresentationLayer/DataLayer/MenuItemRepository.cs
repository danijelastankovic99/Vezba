using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
  public class MenuItemRepository
    {
        public List<MenuItem> GetAllMenuItems ()
        {
            List<MenuItem> mn = new List<MenuItem>();
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM MenuItems";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    MenuItem m = new MenuItem();
                    m.Id= sqlDataReader.GetInt32(0);
                    m.Title = sqlDataReader.GetString(1);
                    m.Description = sqlDataReader.GetString(2);
                    m.Price = sqlDataReader.GetDecimal(3);
                    mn.Add(m);

                }

            }
            return mn;
        }
        public int InsertMenuItem (MenuItem m)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO MenuItems VALUES ('{0}','{1}',{2})", m.Title, m.Description, m.Price);
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
            
        }
        public int UpdateMenuItem(MenuItem m)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE MenuItems SET Title = '{0}',Description = '{1}',Price = {2}"+"WHERE Id={3}", m.Title, m.Description, m.Price,m.Id);
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }

        }
    }
}
