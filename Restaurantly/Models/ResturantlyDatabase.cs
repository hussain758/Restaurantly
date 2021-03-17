using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;


namespace Restaurantly.Models
{
    public class ResturantlyDatabase
    {
        public ResturantlyDatabase()
        {

        }
        public void OpenConnection()
        {
            string coonectionString = ConfigurationManager.ConnectionStrings["ResturantlyDb"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(coonectionString);
            sqlConnection.Open();

            sqlConnection.Close();
        }
    }
}