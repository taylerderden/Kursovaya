using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = Login.Text; // запись логина
            String passUser = Password.Text; // запись пароля

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandAdmin = new MySqlCommand("SELECT * FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP AND `Security_Category` = 'Admin'", db.getConnection()); //авторизация администратора
            commandAdmin.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            commandAdmin.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = commandAdmin;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //поиск записей
            {
                this.Hide();
                MainForm mainForm = new MainForm(); //если успешна то открытие формы для админа
                mainForm.Show();
            }
            else //иначе ищет запись пользователя(сотрудника)
            {
                MySqlCommand commandUser = new MySqlCommand("SELECT * FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP", db.getConnection()); //авторизация пользователя(сотрудника)
                commandUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                commandUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = commandUser;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    UserForm userForm = new UserForm(); //если успешна то открытие формы для сотрудника
                    userForm.Show();
                }
                else
                    MessageBox.Show("Failed!"); //иначе ошибка
            }
                
        }
    }
    
}
