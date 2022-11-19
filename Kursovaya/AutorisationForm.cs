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


            Login.Text = "Ваш логин";
            Login.ForeColor = Color.Gray;

            Password.Text = "пароль";
            Password.ForeColor = Color.Gray;

            Login.MaxLength = 15;
            Password.MaxLength = 12;

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = Login.Text; // запись логина
            String passUser = Password.Text; // запись пароля

            if (Login.Text == "" || Login.Text == "Ваш логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (Password.Text == "" || Password.Text == "пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

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

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Ваш логин")
            {
                Login.Text = "";
                Login.ForeColor = Color.Silver;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Ваш логин";
                Login.ForeColor = Color.Gray;                
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "пароль")
            {
                Password.Text = "";
                Password.ForeColor = Color.Silver;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "пароль";
                Password.ForeColor = Color.Gray;
            }
        }

        private void labelID_Click(object sender, EventArgs e)
        {
            String loginUser = Login.Text; // запись логина
            String passUser = Password.Text; // запись пароля

            if (Login.Text == "" || Login.Text == "Ваш логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (Password.Text == "" || Password.Text == "пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandID = new MySqlCommand("SELECT `Employee_idEmployee` FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP", db.getConnection()); //авторизация администратора
            commandID.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            commandID.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = commandID;
            adapter.Fill(table);

            db.openConnection();

            if (table.Rows.Count > 0) //поиск записей
            {
                string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                labelID.Text = "ID:" + ' ' + id;
            }
            else
                MessageBox.Show("Failed!"); //иначе ошибка

            db.closeConnection();

            }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                Password.UseSystemPasswordChar = false;
                checkPass.Text = "👁";
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                checkPass.Text = "✱";
            }
                
            
        }
    }
    }
    

