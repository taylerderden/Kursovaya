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
    public partial class EmployeeForm : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapter = null;

        private DataTable table = null;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Employee", db.getConnection());            

            adapter.SelectCommand = command;
            adapter.Fill(table);
                                 
            dataGridView1.DataSource = table;



            dataGridView1.Columns[0].HeaderText = "код_Сотрудника";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Пол";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Стаж";
            dataGridView1.Columns[5].HeaderText = "Отдел";
            dataGridView1.Columns[6].HeaderText = "код_Должности";
        }
    }
}
