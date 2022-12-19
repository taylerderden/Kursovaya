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
    public partial class PositionForm : System.Windows.Forms.Form
    {

        public PositionForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9f, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
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
            if (tBname.Text != "" && tBsalary.Text != "")
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
            else
                MessageBox.Show("Введите данные для добавления!");
        }

        public Boolean isDataExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Position WHERE `Position_Name`= @Name AND `Position_Salary` = @Salary ", db.getConnection()); 
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
            command.Parameters.Add("@Salary", MySqlDbType.VarChar).Value = tBsalary.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)   //проверка введенности данных
            {
                MessageBox.Show("Данные уже введены!");
                return true;
            }
            else
                return false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tBid.Text != "" && tBname.Text != "" && tBsalary.Text != "")
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
            else
                MessageBox.Show("Введите данные для обновления!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tBid.Text != "" || tBname.Text != "" || tBsalary.Text != "")
            {
                try
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Position` WHERE `idPosition` = @ID OR `Position_Name` = @Name;", db.getConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                    command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;

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
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите данные для удаления!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tBid.Text != "" || tBname.Text != "" || tBsalary.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Position WHERE `idPosition` = @ID OR `Position_Name`= @Name OR `Position_Salary`= @Salary;", db.getConnection());
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
            else
                MessageBox.Show("Введите данные для поиска!");
        }



        private void labelLoadData_Click(object sender, EventArgs e)
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

    }
} 

