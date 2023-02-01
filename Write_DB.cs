using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Datalogging
{
    public class Write_DB
    {
        private string conString = ConfigurationManager.ConnectionStrings["DB_Measurements"].ConnectionString;
      
        public void SQL_Query(string sqlQuery)
        {
            SqlConnection _con = new SqlConnection(conString);
            _con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery , _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public void Usp_SaveSensorData(double Value, DateTime datetime,string Quality , string TagName)
        {
            SqlConnection _con = new SqlConnection(conString);
            _con.Open();
            SqlCommand cmd = new SqlCommand("Usp_SaveSensorData", _con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TagName", TagName));
            cmd.Parameters.Add(new SqlParameter("@Value ", Value));
            cmd.Parameters.Add(new SqlParameter("@datetime ", datetime));
            cmd.Parameters.Add(new SqlParameter("@Quality ", Quality));
            cmd.ExecuteNonQuery();
            _con.Close();
        }
    }
}