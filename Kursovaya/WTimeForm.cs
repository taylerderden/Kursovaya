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
    public partial class WTimeForm : System.Windows.Forms.Form
    {
        public WTimeForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 9f, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
        }
        private void WTimeForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM WTime", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Смены";
            dataGridView1.Columns[1].HeaderText = "День";
            dataGridView1.Columns[2].HeaderText = "Начало";
            dataGridView1.Columns[3].HeaderText = "Конец";
            dataGridView1.Columns[4].HeaderText = "код_Сотрудника";
        }
        private void labelLoadData_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM WTime", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Смены";
            dataGridView1.Columns[1].HeaderText = "День";
            dataGridView1.Columns[2].HeaderText = "Начало";
            dataGridView1.Columns[3].HeaderText = "Конец";
            dataGridView1.Columns[4].HeaderText = "код_Сотрудника";
        }     
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tBid.Text != "" || tBday.Text != "" || tBstart.Text != "" || tBfin.Text != "" || tBEmId.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM WTime WHERE `idWTime` = @ID OR `WTime_Day`= @Day OR `WTime_Start`= @St OR `WTime_Finish`= @Fin OR `Employee_idEmployee`= @EmId;", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = tBday.Text;
                command.Parameters.Add("@St", MySqlDbType.VarChar).Value = tBstart.Text;
                command.Parameters.Add("@Fin", MySqlDbType.VarChar).Value = tBfin.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Смены";
                dataGridView1.Columns[1].HeaderText = "День";
                dataGridView1.Columns[2].HeaderText = "Начало";
                dataGridView1.Columns[3].HeaderText = "Конец";
                dataGridView1.Columns[4].HeaderText = "код_Сотрудника";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tBstart.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tBfin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tBday.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tBEmId.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
    }
}
