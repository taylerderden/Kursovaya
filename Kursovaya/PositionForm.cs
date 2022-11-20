using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class PositionForm : Form
    {

        public PositionForm()
        {
            InitializeComponent();
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Position", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;



            dataGridView1.Columns[0].HeaderText = "код_Должности";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Зарплата";

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (isDataExists())
            {
                return;
            }

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `Position`(`Position_Name`,`Position_Salary`) VALUES(@Name, @Salary);", db.getConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
            command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = tBsalary.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные добавлены");

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM Position", db.getConnection());

                adapter.SelectCommand = command1;
                adapter.Fill(table);

                dataGridView1.DataSource = table;



                dataGridView1.Columns[0].HeaderText = "код_Должности";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Зарплата";
            }
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();

        }

        public Boolean isDataExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Position WHERE `Position_Name`= @Name AND `Position_Salary` = @Salary ", db.getConnection()); //проверка лог введенного пользов-м и указываем БД к которой подключ-ся 
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
            command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = tBsalary.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)   //проверка занятости логина, поиск записей в табл
            {
                MessageBox.Show("Данные уже введены!");
                return true;
            }
            else
                return false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            DB db = new DB();
                       
            MySqlCommand command = new MySqlCommand("UPDATE `Position` SET `Position_Name`= @Name, `Position_Salary`= @Salary WHERE `idPosition` = @ID;", db.getConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
            command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = tBsalary.Text;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные обновлены");
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM Position", db.getConnection());

                adapter.SelectCommand = command1;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Должности";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Зарплата";
            }               
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();
            
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("DELETE FROM `Position` WHERE `idPosition` = @ID;", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные удалены");
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand("SELECT * FROM Position", db.getConnection());

                adapter.SelectCommand = command1;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Должности";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Зарплата";
            }
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Position WHERE `idPosition` = @ID OR`Position_Name`= @Name OR `Position_Salary`= @Salary;", db.getConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
            command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = tBsalary.Text;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;



            dataGridView1.Columns[0].HeaderText = "код_Должности";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Зарплата";
        }

        private void labelHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void labelHide_MouseEnter(object sender, EventArgs e)
        {
            labelHide.ForeColor = Color.Orange;
        }

        private void labelHide_MouseLeave(object sender, EventArgs e)
        {
            labelHide.ForeColor = Color.Black;
        }

        private void labelFullScreen_MouseEnter(object sender, EventArgs e)
        {
            labelFullScreen.ForeColor = Color.White;
        }

        private void labelFullScreen_MouseLeave(object sender, EventArgs e)
        {
            labelFullScreen.ForeColor = Color.Black;
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }
    }
} 

