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
        int level;
        public SQL_Class()
        {
            
        }

        public bool IDCHeck(string username, string password)
        {
            loginInit();
            sqlConn.Open();
            string sqlCommStr = "SELECT password,level FROM pwd WHERE name ='" + username + "'";
            SqlCommand sqlComm = new SqlCommand(sqlCommStr, sqlConn);
            SqlDataReader dataReader = sqlComm.ExecuteReader();
            dataReader.Read();
            this.level = (int)dataReader["level"];

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

        public void userCheck()
        {
            switch (this.level)
            {
                case 1:level1();break;
                case 2: level2(); break;
                case 3: level3(); break;
                case 4: level4(); break;
                default:level1();
                    break;               
            }
        }
        void loginInit()
        {
            //登陆时用的登录账户，只有查看权限，没有更改权限
            //同时也对应等级最低的员工，只能看不能改
            sqlStr = new SqlConnectionStringBuilder();
            sqlStr.DataSource = "47.97.244.178";
            sqlStr.InitialCatalog = "SVW";
            sqlStr.UserID = "Login_Account";
            sqlStr.Password = "HzbAxxZsl2020";

            sqlConn = new SqlConnection(sqlStr.ToString());
        }
        void level1()
        {
            sqlStr.UserID = "Level1_User";
            sqlStr.Password = "Miaorui233";
        }
        void level2()
        {
            //对应等级稍高些的员工，可以增加维护记录，但是不能修改
            //实际权限和Level3一样，要依靠本机程序来实现限制
            sqlStr.UserID = "Level23_User";
            sqlStr.Password = "Chenlu233";
        }
        void level3()
        {
            //对应等级更高的员工，在level2基础上，可以修改维护记录，也可以修改备件条目
            sqlStr.UserID = "Level23_User";
            sqlStr.Password = "Chenlu233";
        }
        void level4()
        {
            //最高级别，在level3基础上，可以删除其他的员工
            sqlStr.UserID = "Level4_Ma";
            sqlStr.Password = "Xiatb666";
        }
    }
}
