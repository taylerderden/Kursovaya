using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Kursovaya
{
    public partial class AutorisationForm : MaterialForm
    {
        public AutorisationForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            Password.UseSystemPasswordChar = true;

            Login.Text = "Логин";
            Login.ForeColor = Color.Gray;

            Password.Text = "Пароль";
            Password.ForeColor = Color.Gray;

            Login.MaxLength = 25;
            Password.MaxLength = 25;
        }
        private string GetHash(string input) // хеширование пароля и логина
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        async public void buttonLogin_Click(object sender, EventArgs e)
        {
            try                                      
            {
                // Create a request for the URL. // проверка подключения к интернету        
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.google.ru/");   //сюда любой домен     
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                request.Timeout = 10000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream ReceiveStream1 = response.GetResponseStream();
                StreamReader sr = new StreamReader(ReceiveStream1, true);
                string responseFromServer = sr.ReadToEnd();

                response.Close();

                String loginUser = GetHash(Login.Text); // запись логина
                String passUser = GetHash(Password.Text); // запись пароля

                if (Login.Text == "" || Login.Text == "Логин")
                {
                    MessageBox.Show("Введите логин!");
                    return;
                }
                if (Password.Text == "" || Password.Text == "Пароль")
                {
                    MessageBox.Show("Введите пароль!");
                    return;
                }

                //асинхронность
                await Task.Run(() =>
                {

                });

                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand commandAdmin = new MySqlCommand("SELECT * FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP AND `Security_Category` = 'Admin' AND `Confirmation` = '+'; ", db.getConnection()); //авторизация администратора
                commandAdmin.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                commandAdmin.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = commandAdmin;
                await Task.Run(() =>                 //асинхронно ищем записи
                {
                    adapter.Fill(table);
                }); 

                if (table.Rows.Count > 0) //поиск записей
                {
                    DataTable tableID = new DataTable();

                    MySqlDataAdapter adapterID = new MySqlDataAdapter();

                    MySqlCommand commandID = new MySqlCommand("SELECT `Employee_idEmployee` FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP", db.getConnection()); //авторизация администратора
                    commandID.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                    commandID.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                    adapterID.SelectCommand = commandID;
                    await Task.Run(() =>
                    {
                        adapterID.Fill(tableID);
                    });
                    
                    db.openConnection();

                    if (table.Rows.Count > 0) //поиск записей
                    {
                        string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                        Global.GlobalVar = id;
                    }
                    else
                        MessageBox.Show("Ваш ID не найден!"); //иначе ошибка

                    db.closeConnection();

                    this.Hide();
                    MainForm mainForm = new MainForm(); //если успешна то открытие формы для админа
                    mainForm.Show();
                }
                else //иначе ищет запись пользователя(сотрудника)
                {
                    MySqlCommand commandUser = new MySqlCommand("SELECT * FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP AND `Confirmation` = '+'; ", db.getConnection()); //авторизация пользователя(сотрудника)
                    commandUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                    commandUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                    adapter.SelectCommand = commandUser;
                    await Task.Run(() =>
                    {
                        adapter.Fill(table);
                    }); 

                    if (table.Rows.Count > 0)
                    {
                        DataTable tableID = new DataTable();

                        MySqlDataAdapter adapterID = new MySqlDataAdapter();

                        MySqlCommand commandID = new MySqlCommand("SELECT `Employee_idEmployee` FROM `Security` WHERE `Security_Login` = @uL AND `Security_Password` = @uP", db.getConnection()); //авторизация администратора
                        commandID.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                        commandID.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                        adapterID.SelectCommand = commandID;
                        await Task.Run(() =>
                        {
                            adapterID.Fill(tableID);
                        }); 

                        db.openConnection();

                        if (table.Rows.Count > 0) //поиск записей
                        {
                            string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                            Global.GlobalVar = id;
                        }
                        else
                            MessageBox.Show("Ваш ID не найден!"); //иначе ошибка

                        db.closeConnection();

                        this.Hide();
                        UserForm userForm = new UserForm(); //если успешна то открытие формы для сотрудника
                        userForm.Show();
                    }
                    else
                        MessageBox.Show("Вы не зарегистрированы в системе!"); //иначе ошибка
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Нет подключения к интернету!\nПроверьте ваш фаервол или настройки сетевого подключения!");
            }
            
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // Create a request for the URL.        
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.google.ru/");
                    request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                    request.Timeout = 10000;

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream ReceiveStream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(ReceiveStream1, true);
                    string responseFromServer = sr.ReadToEnd();

                    response.Close();

                    String loginUser = GetHash(Login.Text); // запись логина
                    String passUser = GetHash(Password.Text); // запись пароля

                    if (Login.Text == "" || Login.Text == "Логин")
                    {
                        MessageBox.Show("Введите логин!");
                        return;
                    }
                    if (Password.Text == "" || Password.Text == "Пароль")
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
                catch (Exception)
                {
                    MessageBox.Show("Нет подключения к интернету!\nПроверьте ваш фаервол или настройки сетевого подключения!");

                }
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Логин")
            {
                Login.Text = "";
            }
        }
        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Логин";
            }
        }
        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Пароль")
            {
                Password.Text = "";
            }
        }
        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Пароль";
            }
        }
        private void labelCheck_Click(object sender, EventArgs e)
        {
            if (labelCheck.Text == "●")
            {
                Password.UseSystemPasswordChar = false;
                labelCheck.Text = "👁";
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                labelCheck.Text = "●";
            }
        }
        private void labelCheck_DoubleClick(object sender, EventArgs e)
        {
            if (labelCheck.Text == "●")
            {
                Password.UseSystemPasswordChar = false;
                labelCheck.Text = "👁";
            }
            else
            {
                Password.UseSystemPasswordChar = true;
                labelCheck.Text = "●";
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm regForm = new RegistrationForm(); //если успешна то открытие формы для сотрудника
            regForm.Show();
        }
    }
    static class Global //для id
    {
        public static string _globalVar = "";
        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
}
