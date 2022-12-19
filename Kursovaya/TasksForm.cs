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
    public partial class TasksForm : System.Windows.Forms.Form
    {
        public TasksForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9f, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tasks", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Задачи";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Срок выполнения";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
            
        }

        public Boolean isDataExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tasks WHERE `Tasks_Name`= @Name AND `Tasks_Deadline` = @Dline AND `Employee_idEmployee` = @EmId ", db.getConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
            command.Parameters.Add("@Dline", MySqlDbType.VarChar).Value = tBDeadline.Text;
            command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

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

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (tBname.Text != "" && tBDeadline.Text != "" && tBEmId.Text != "")
            {

                if (isDataExists())
                {
                    return;
                }

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Tasks`(`Tasks_Name`,`Tasks_Deadline`, `Employee_idEmployee`) VALUES(@Name, @Dline, @EmId);", db.getConnection());
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
                command.Parameters.Add("@Dline", MySqlDbType.VarChar).Value = tBDeadline.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Tasks", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Задачи";
                    dataGridView1.Columns[1].HeaderText = "Название";
                    dataGridView1.Columns[2].HeaderText = "Срок выполнения";
                    dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
                }
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }
            else
                MessageBox.Show("Введите данные для добавления!");
        }

        private void labelLoadData_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tasks", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Задачи";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Срок выполнения";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tBid.Text != "" && tBname.Text != "" && tBDeadline.Text != "" && tBEmId.Text != "")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `Tasks` SET `Tasks_Name`= @Name, `Tasks_Deadline`= @Dline, `Employee_idEmployee` = @EmId WHERE `idTasks` = @ID;", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
                command.Parameters.Add("@Dline", MySqlDbType.VarChar).Value = tBDeadline.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Tasks", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Задачи";
                    dataGridView1.Columns[1].HeaderText = "Название";
                    dataGridView1.Columns[2].HeaderText = "Срок выполнения";
                    dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
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
            if (tBid.Text != "" || tBname.Text != "" && tBDeadline.Text != "" && tBEmId.Text != "")
            {
                try
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Tasks` WHERE `idTasks` = @ID OR `Tasks_Name` = @Name;", db.getConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                    command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Tasks", db.getConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        dataGridView1.Columns[0].HeaderText = "код_Задачи";
                        dataGridView1.Columns[1].HeaderText = "Название";
                        dataGridView1.Columns[2].HeaderText = "Срок выполнения";
                        dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
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
            if (tBid.Text != "" || tBname.Text != "" || tBDeadline.Text != "" || tBEmId.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Tasks WHERE `idTasks` = @ID OR `Tasks_Name`= @Name OR `Tasks_Deadline`= @Dline OR `Employee_idEmployee`= @EmId;", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBname.Text;
                command.Parameters.Add("@Dline", MySqlDbType.VarChar).Value = tBDeadline.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Задачи";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Срок выполнения";
                dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
        }
    }
}
