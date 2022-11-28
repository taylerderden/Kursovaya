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
    public partial class DismissalForm : Form
    {
        public DismissalForm()
        {
            InitializeComponent();
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

        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }
        private void labelFullScreen_MouseEnter(object sender, EventArgs e)
        {
            labelFullScreen.ForeColor = Color.White;
        }

        private void labelFullScreen_MouseLeave(object sender, EventArgs e)
        {
            labelFullScreen.ForeColor = Color.Black;
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
        private void labelHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelFullScreen_Click(object sender, EventArgs e)
        {

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
    }
}
