using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("Server=cfif31.ru;User ID=ISPr23-35_ZlobinDS;Password=ISPr23-35_ZlobinDS;Character Set=utf8; Port=3306;Database=ISPr23-35_ZlobinDS_kursovaya");
        public void openConnection() //открытие подключения к БД
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection() //закрытие подключения к БД
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
