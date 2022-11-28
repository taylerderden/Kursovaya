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

            Password.UseSystemPasswordChar = false;

            Login.Text = "Ваш логин";
            Login.ForeColor = Color.Gray;

            Password.Text = "пароль";
            Password.ForeColor = Color.Gray;

            Login.MaxLength = 15;
            Password.MaxLength = 12;

        }
      
        public void buttonLogin_Click(object sender, EventArgs e)
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
                    DataTable tableID = new DataTable();

                    MySqlDataAdapter adapterID = new MySqlDataAdapter();

                    MySqlCommand commandID = new MySqlCommand("SELECT `Employee_idEmployee` FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP", db.getConnection()); //авторизация администратора
                    commandID.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                    commandID.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                    adapterID.SelectCommand = commandID;
                    adapterID.Fill(tableID);

                    db.openConnection();

                    if (table.Rows.Count > 0) //поиск записей
                    {
                        string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                        Global.GlobalVar = id;                                              
                    }
                    else
                        MessageBox.Show("Failed!"); //иначе ошибка

                    db.closeConnection();

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
            }
            else
                MessageBox.Show("Failed!"); //иначе ошибка

            db.closeConnection();

        }


        private void AutorisationForm_Load(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelCheck_Click(object sender, EventArgs e)
        {
            if (labelCheck.Text == "✱")
            {
                Password.UseSystemPasswordChar = true;
                labelCheck.Text = "👁";
            }
            else
            {
                Password.UseSystemPasswordChar = false;
                labelCheck.Text = "✱";
            }
        }

        private void labelCheck_DoubleClick(object sender, EventArgs e)
        {
            if (labelCheck.Text == "✱")
            {
                Password.UseSystemPasswordChar = true;
                labelCheck.Text = "👁";
            }
            else
            {
                Password.UseSystemPasswordChar = false;
                labelCheck.Text = "✱";
            }
        }

        private void labelFullScreen_Click(object sender, EventArgs e)
        {

        }
        private void labelFullScreen_MouseEnter(object sender, EventArgs e)
        {
            labelFullScreen.ForeColor = Color.White;
        }

        private void labelFullScreen_MouseLeave(object sender, EventArgs e)
        {
            labelFullScreen.ForeColor = Color.Black;
        }

        private void AutorisationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {                
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;                                         
            }


        }

        private void labelHide_MouseEnter(object sender, EventArgs e)
        {
            labelHide.ForeColor = Color.Orange;
        }

        private void labelHide_MouseLeave(object sender, EventArgs e)
        {
            labelHide.ForeColor = Color.Black;
        }

        private void labelHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
        }

        
    }
    static class Global
    {
        public static string _globalVar = "";

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
}
    

