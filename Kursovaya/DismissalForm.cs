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
    public partial class DismissalForm : System.Windows.Forms.Form
    {
        public DismissalForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9f, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
        }
        private void DismissalForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Dismissal", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Увольнения";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Причина";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
        }      
        public Boolean isDataExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Dismissal WHERE `Dismissal_Date`= @D AND `Dismissal_Reason` = @R AND `Employee_idEmployee` = @EmId", db.getConnection());
            command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdate.Text;
            command.Parameters.Add("@R", MySqlDbType.VarChar).Value = tBreason.Text;
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
            if (tBdate.Text != "" && tBreason.Text != "" && tBEmId.Text != "")
            {

                if (isDataExists())
                {
                    return;
                }

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Dismissal`(`Dismissal_Date`,`Dismissal_Reason`, `Employee_idEmployee`) VALUES(@D, @R, @ID);", db.getConnection());
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdate.Text;
                command.Parameters.Add("@R", MySqlDbType.VarChar).Value = tBreason.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Dismissal", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Увольнения";
                    dataGridView1.Columns[1].HeaderText = "Дата";
                    dataGridView1.Columns[2].HeaderText = "Причина";
                    dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
                }
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();

            }
            else
                MessageBox.Show("Введите данные для добавления!");
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tBEmId.Text != "" && tBdate.Text != "" && tBreason.Text != "" && tBEmId.Text != "")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `Dismissal` SET `Dismissal_Date`= @D, `Dismissal_Reason`= @R WHERE `idDismissal` = @idD AND `Employee_idEmployee` = @ID;", db.getConnection());
                command.Parameters.Add("@idD", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdate.Text;
                command.Parameters.Add("@R", MySqlDbType.VarChar).Value = tBreason.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Dismissal", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Увольнения";
                    dataGridView1.Columns[1].HeaderText = "Дата";
                    dataGridView1.Columns[2].HeaderText = "Причина";
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
            if (tBid.Text != "" || tBdate.Text != "" || tBreason.Text != "" && tBEmId.Text != "")
            {
                try
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Dismissal` WHERE `idDismissal` = @idD AND `Employee_idEmployee` = @ID;", db.getConnection());
                    command.Parameters.Add("@idD", MySqlDbType.VarChar).Value = tBid.Text;;
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Dismissal", db.getConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        dataGridView1.Columns[0].HeaderText = "код_Увольнения";
                        dataGridView1.Columns[1].HeaderText = "Дата";
                        dataGridView1.Columns[2].HeaderText = "Причина";
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
            if (tBid.Text != "" || tBdate.Text != "" || tBreason.Text != "" || tBEmId.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Dismissal WHERE `idDismissal` = @idEd OR `Dismissal_Date`= @T OR `Dismissal_Reason`= @I OR `Employee_idEmployee` = @ID ;", db.getConnection());
                command.Parameters.Add("@idEd", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBdate.Text;
                command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBreason.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Увольнения";
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Причина";
                dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
        }
        private void labelLoadData_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Dismissal", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Увольнения";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Причина";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
        }
        private void tBEmId_TextChanged(object sender, EventArgs e) //при заполнении тбокса с id ищет фио сотрудника
        {
            if (tBEmId.Text != "") //поиск фио по id
            {
                DB db = new DB();
                DataTable tableFIO = new DataTable();

                MySqlDataAdapter adapterFIO = new MySqlDataAdapter();

                MySqlCommand commandFIO = new MySqlCommand("SELECT Employee_FIO FROM Employee WHERE idEmployee = @id", db.getConnection());
                commandFIO.Parameters.Add("@id", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapterFIO.SelectCommand = commandFIO;
                adapterFIO.Fill(tableFIO);

                db.openConnection();
                if (tableFIO.Rows.Count > 0)
                {
                    tbFIO.Text = commandFIO.ExecuteScalar().ToString();
                }
                else
                    tbFIO.Text = "";
                db.closeConnection();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tBdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tBreason.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tBEmId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
