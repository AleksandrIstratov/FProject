using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProject
{
    class MSSQLClass
    {
        private SqlConnection conn;
        public string connString = "server=FUJITSU\\WINCC;" +
                                       "Trusted_Connection=yes;" +
                                       "database=DBTest; " +
                                       "connection timeout=30");
        public void Connect()
        {
            this.conn = new SqlConnection(connString);
            try
            {
                this.conn.Open();
                //Console.WriteLine("Well done!");
                //SqlCommand cmd = new SqlCommand("SELECT name FROM [dbo].[TTable]", conn);
                //SqlDataReader data = cmd.ExecuteReader();
                //while (data.Read())
                //{
                //    Console.WriteLine(data.GetString(0));
                //}
            }
            catch (SqlException ex)
            {
               // Console.WriteLine("You failed!" + ex.Message);
            }
            //return conn;
        }

        public void Disconnect()
        {
            this.conn = null;
        } 
    }
}
