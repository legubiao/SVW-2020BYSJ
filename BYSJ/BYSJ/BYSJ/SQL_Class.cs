using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BYSJ
{
    class SQL_Class
    {
        SqlConnectionStringBuilder sqlStr;
        SqlConnection sqlConn;
        public SQL_Class()
        {
            sqlStr = new SqlConnectionStringBuilder();
            sqlStr.DataSource = "47.97.244.178";
            sqlStr.InitialCatalog = "SVW";
            sqlStr.UserID = "SA";
            sqlStr.Password = "ZslNB2020";
           
            sqlConn = new SqlConnection(sqlStr.ToString());
        }

        public bool IDCHeck(string username, string password)
        {
            sqlConn.Open();
            string sqlCommStr = "SELECT password FROM pwd WHERE name ='" + username + "'";
            SqlCommand sqlComm = new SqlCommand(sqlCommStr, sqlConn);
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            dataReader.Read();
            

            if ((String)dataReader["password"] == password)
            {
                dataReader.Close();
                sqlConn.Close();
                return true;
            }
            else
            {
                dataReader.Close();
                sqlConn.Close();
                return false;
            }
        }
    }
}
