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

            if (Login.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (cBCategory.Checked)
                Category = "Admin";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Security` (`Security_Login`, `Security_Password`, `Security_Category`, `Employee_idEmployee`) VALUES (@uL, @uP, @Cat, @ID);", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@Cat", MySqlDbType.VarChar).Value = Category;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегистрированы!");                
            }
            else
                MessageBox.Show("Ошибка внесения данных!");

            db.closeConnection();
        }
    }
}
