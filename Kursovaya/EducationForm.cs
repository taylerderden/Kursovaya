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
    public partial class EducationForm : System.Windows.Forms.Form
    {
        public EducationForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9f, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
        }        
        private void EducationForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Education", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Образования";
            dataGridView1.Columns[1].HeaderText = "Тип";
            dataGridView1.Columns[2].HeaderText = "Учреждение";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";                                          
        }
        private void labelLoadData_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Education", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Образования";
            dataGridView1.Columns[1].HeaderText = "Тип";
            dataGridView1.Columns[2].HeaderText = "Учреждение";
            dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
        }
        public Boolean isDataExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Education WHERE `Education_Type`= @T AND `Education_Institution` = @I ", db.getConnection());
            command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBType.Text;
            command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBInst.Text;

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
            if (tBType.Text != "" && tBInst.Text != "" && tBEmId.Text != "")
            {

                if (isDataExists())
                {
                    return;
                }

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Education`(`Education_Type`,`Education_Institution`, `Employee_idEmployee`) VALUES(@T, @I, @ID);", db.getConnection());
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBType.Text;
                command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBInst.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Education", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Образования";
                    dataGridView1.Columns[1].HeaderText = "Тип";
                    dataGridView1.Columns[2].HeaderText = "Учреждение";
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
            if (tBid.Text != "" && tBType.Text != "" && tBInst.Text != "" && tBEmId.Text != "")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `Education` SET `Education_Type`= @T, `Education_Institution`= @I WHERE `idEducation` = @idEd AND `Employee_idEmployee` = @ID;", db.getConnection());
                command.Parameters.Add("@idEd", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBType.Text;
                command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBInst.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Education", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Образования";
                    dataGridView1.Columns[1].HeaderText = "Тип";
                    dataGridView1.Columns[2].HeaderText = "Учреждение";
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
            if (tBid.Text != "" || tBType.Text != "" || tBInst.Text != "" && tBEmId.Text !="")
            {
                try
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Education` WHERE `idEducation` = @idEd AND `Employee_idEmployee` = @ID AND `Education_Type` = @T AND `Education_Institution` = @I;", db.getConnection());
                    command.Parameters.Add("@idEd", MySqlDbType.VarChar).Value = tBid.Text;
                    command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBType.Text;
                    command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBInst.Text;                   
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Education", db.getConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        dataGridView1.Columns[0].HeaderText = "код_Образования";
                        dataGridView1.Columns[1].HeaderText = "Тип";
                        dataGridView1.Columns[2].HeaderText = "Учреждение";
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
            if (tBid.Text != "" || tBType.Text != "" || tBInst.Text != "" || tBEmId.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Education WHERE `idEducation` = @idEd OR `Education_Type`= @T OR `Education_Institution`= @I OR `Employee_idEmployee` = @ID ;", db.getConnection());
                command.Parameters.Add("@idEd", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBType.Text;
                command.Parameters.Add("@I", MySqlDbType.VarChar).Value = tBInst.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Образования";
                dataGridView1.Columns[1].HeaderText = "Тип";
                dataGridView1.Columns[2].HeaderText = "Учреждение";
                dataGridView1.Columns[3].HeaderText = "код_Сотрудника";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
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
            tBType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tBInst.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tBEmId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
