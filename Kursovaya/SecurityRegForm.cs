using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class SecurityRegForm : MaterialForm
    {
        public SecurityRegForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            Login.Text = "Логин";
            Login.ForeColor = Color.Gray;

            Password.Text = "Пароль";
            Password.ForeColor = Color.Gray;

        }
        private string GetHash(string input) // хеширование пароля и логина
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        string Category;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
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

            if (cBCategory.Checked)
                Category = "Admin";

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandCheckData = new MySqlCommand("SELECT * FROM `Security` WHERE `Security_Login` = @uL", db.getConnection()); //проверка занятости лог и пароля
            commandCheckData.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = commandCheckData;
            adapter.Fill(table);

            if (table.Rows.Count == 0) //поиск записей
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `Security` (`Security_Login`, `Security_Password`, `Security_Category`, `Employee_idEmployee`) VALUES (@uL, @uP, @Cat, @ID);", db.getConnection());

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
                command.Parameters.Add("@Cat", MySqlDbType.VarChar).Value = Category;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ваши данные внесены, ожидайте подтверждения учетной записи!");
                }
                else
                    MessageBox.Show("Ошибка внесения данных!");

                db.closeConnection();
            }
            else
                MessageBox.Show("Данные уже существуют!"); //иначе предупреждение о том что данные уже существуют
        }

        private void btnAutoris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorisationForm aForm = new AutorisationForm(); //открытие формы авторизации
            aForm.Show();
        }

        private void SecurityRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Логин";
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Логин")
            {
                Login.Text = "";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Пароль";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Пароль")
            {
                Password.Text = "";
            }
        }
    }
}
