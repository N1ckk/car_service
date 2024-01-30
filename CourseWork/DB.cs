using CourseWork.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class DB
    {
        MySqlConnection connection1 = new MySqlConnection($"server=localhost;port=3306;username=root;password=39nIkItA93;database=car_service");
        //MySqlConnection connection1;
        public MySqlConnection Сonnection { get { return connection1; } set { connection1 = value; } }

        public DB()
        {

        }

        public void openConection()
        {
            if (connection1.State == System.Data.ConnectionState.Closed)
            {
                connection1.Open();
            }
        }

        public void closeConection()
        {
            if (connection1.State == System.Data.ConnectionState.Open)
                connection1.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection1;
        }
    }
}
