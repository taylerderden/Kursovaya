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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string a = Convert.ToString(dateTime.ToShortDateString());
            labelDay.Text = a;
            string b = Convert.ToString(dateTime.ToShortTimeString());
            labelTime.Text = b;
        }

        private void labelTasks_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Tasks_Name, Tasks_Deadline FROM Tasks WHERE Employee_idEmployee = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxID.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Сроки";

        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            DB db = new DB();
          
            MySqlCommand command = new MySqlCommand("INSERT INTO `WTime` (`WTime_Day`, `WTime_Start`, `Employee_idEmployee`) VALUES(@Day, @DT, @ID);", db.getConnection());
            command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;
            command.Parameters.Add("@DT", MySqlDbType.VarChar).Value = labelTime.Text;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxID.Text;
            
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Удачного дня!");
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();

        }

        private void btnFinishTime_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("UPDATE `WTime` SET `WTime_Finish` = @DT WHERE `Employee_idEmployee` = @ID;", db.getConnection());           
            command.Parameters.Add("@DT", MySqlDbType.VarChar).Value = labelTime.Text;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("До свидания!");
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();
        }
    }
}
