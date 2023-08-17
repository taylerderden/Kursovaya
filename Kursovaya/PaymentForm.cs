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
    public partial class PaymentForm : System.Windows.Forms.Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9f, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;

        }      
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Payment", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Выплаты";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Сумма";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
        }
        private void labelLoadData_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Payment", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Выплаты";
            dataGridView1.Columns[1].HeaderText = "Дата";
            dataGridView1.Columns[2].HeaderText = "Сумма";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
        }
        public Boolean isDataExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Payment WHERE `Payment_Date`= @D AND `Payment_Sum` = @R AND `Employee_idEmployee` = @EmId", db.getConnection());
            command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdate.Text;
            command.Parameters.Add("@R", MySqlDbType.VarChar).Value = tBsum.Text;
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
            if (tBdate.Text != "" && tBsum.Text != "" && tBEmId.Text != "")
            {

                if (isDataExists())
                {
                    return;
                }

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Payment`(`Payment_Date`,`Payment_Sum`, `Employee_idEmployee`) VALUES(@D, @R, @ID);", db.getConnection());
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdate.Text;
                command.Parameters.Add("@R", MySqlDbType.VarChar).Value = tBsum.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Payment", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Выплаты";
                    dataGridView1.Columns[1].HeaderText = "Дата";
                    dataGridView1.Columns[2].HeaderText = "Сумма";
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
            if (tBEmId.Text != "" && tBdate.Text != "" && tBsum.Text != "" && tBEmId.Text != "")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `Payment` SET `Payment_Date`= @D, `Payment_Sum`= @R WHERE `idPayment` = @idD AND `Employee_idEmployee` = @ID;", db.getConnection());
                command.Parameters.Add("@idD", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdate.Text;
                command.Parameters.Add("@R", MySqlDbType.VarChar).Value = tBsum.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Payment", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Выплаты";
                    dataGridView1.Columns[1].HeaderText = "Дата";
                    dataGridView1.Columns[2].HeaderText = "Сумма";
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
            if (tBid.Text != "" || tBdate.Text != "" || tBsum.Text != "" && tBEmId.Text != "")
            {
                try
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Payment` WHERE `idPayment` = @idD AND `Employee_idEmployee` = @ID;", db.getConnection());
                    command.Parameters.Add("@idD", MySqlDbType.VarChar).Value = tBid.Text; ;
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Payment", db.getConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        dataGridView1.Columns[0].HeaderText = "код_Выплаты";
                        dataGridView1.Columns[1].HeaderText = "Дата";
                        dataGridView1.Columns[2].HeaderText = "Сумма";
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
            if (tBid.Text != "" || tBdate.Text != "" || tBsum.Text != "" || tBEmId.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Payment WHERE `idPayment` = @idEd OR `Payment_Date`= @T OR `Payment_Sum`= @I OR `Employee_idEmployee` = @ID ;", db.getConnection());
                command.Parameters.Add("@idEd", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBdate.Text;
                command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBsum.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Выплаты";
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Сумма";
                dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
        }
    }
}
