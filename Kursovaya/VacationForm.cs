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
    public partial class VacationForm : Form
    {
        public VacationForm()
        {
            InitializeComponent();
        }

        private void labelHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelFullScreen_Click(object sender, EventArgs e)
        {

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

        private void VacationForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Vacation", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Отпуска";
            dataGridView1.Columns[1].HeaderText = "Вид";
            dataGridView1.Columns[2].HeaderText = "Начало";
            dataGridView1.Columns[3].HeaderText = "Конец";
            dataGridView1.Columns[4].HeaderText = "Кол-во дней";
            dataGridView1.Columns[5].HeaderText = "код_Сотрудника";
        }

        private void labelLoadData_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Vacation", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Отпуска";
            dataGridView1.Columns[1].HeaderText = "Вид";
            dataGridView1.Columns[2].HeaderText = "Начало";
            dataGridView1.Columns[3].HeaderText = "Конец";
            dataGridView1.Columns[4].HeaderText = "Кол-во дней";
            dataGridView1.Columns[5].HeaderText = "код_Сотрудника";
        }
        private void btnIns_Click(object sender, EventArgs e)
        {
            if (tBtype.Text != "" && tBstart.Text != "" && tBfinish.Text != "" && tBdays.Text != "" && tBEmId.Text != "")
            {

                if (isDataExists())
                {
                    return;
                }

                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Vacation`(`Vacation_Type`,`Vacation_Start`,`Vacation_Finish`,`Vacation_Days`,`Employee_idEmployee`) VALUES(@T, @S, @F, @D, @EmId);", db.getConnection());
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBtype.Text;
                command.Parameters.Add("@S", MySqlDbType.VarChar).Value = tBstart.Text;
                command.Parameters.Add("@F", MySqlDbType.VarChar).Value = tBfinish.Text;
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdays.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Vacation", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Отпуска";
                    dataGridView1.Columns[1].HeaderText = "Вид";
                    dataGridView1.Columns[2].HeaderText = "Начало";
                    dataGridView1.Columns[3].HeaderText = "Конец";
                    dataGridView1.Columns[4].HeaderText = "Кол-во дней";
                    dataGridView1.Columns[5].HeaderText = "код_Сотрудника";
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM Vacation WHERE `Vacation_Type`= @T AND `Vacation_Start` = @S AND `Vacation_Finish` = @F AND `Vacation_Days` = @D AND `Employee_idEmployee` = @EmId ", db.getConnection());
            command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBtype.Text;
            command.Parameters.Add("@S", MySqlDbType.VarChar).Value = tBstart.Text;
            command.Parameters.Add("@F", MySqlDbType.VarChar).Value = tBfinish.Text;
            command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdays.Text;
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (tBid.Text != "" && tBtype.Text != "" && tBstart.Text != "" && tBfinish.Text != "" && tBdays.Text != "" && tBEmId.Text != "")
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("UPDATE `Vacation` SET `Vacation_Type`= @T, `Vacation_Start`= @S, `Vacation_Finish`= @F, `Vacation_Days`= @D WHERE `Employee_idEmployee` = @EmId AND `idVacation` = @idV;", db.getConnection());
                command.Parameters.Add("@idV", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBtype.Text;
                command.Parameters.Add("@S", MySqlDbType.VarChar).Value = tBstart.Text;
                command.Parameters.Add("@F", MySqlDbType.VarChar).Value = tBfinish.Text;
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdays.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Vacation", db.getConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    dataGridView1.Columns[0].HeaderText = "код_Отпуска";
                    dataGridView1.Columns[1].HeaderText = "Вид";
                    dataGridView1.Columns[2].HeaderText = "Начало";
                    dataGridView1.Columns[3].HeaderText = "Конец";
                    dataGridView1.Columns[4].HeaderText = "Кол-во дней";
                    dataGridView1.Columns[5].HeaderText = "код_Сотрудника";
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
            if (tBid.Text != ""  && tBEmId.Text != "" )
            {
                try
                {
                    DB db = new DB();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Vacation` WHERE `idVacation` = @ID OR `Employee_idEmployee` = @EmId;", db.getConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                    command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Vacation", db.getConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;

                        dataGridView1.Columns[0].HeaderText = "код_Отпуска";
                        dataGridView1.Columns[1].HeaderText = "Вид";
                        dataGridView1.Columns[2].HeaderText = "Начало";
                        dataGridView1.Columns[3].HeaderText = "Конец";
                        dataGridView1.Columns[4].HeaderText = "Кол-во дней";
                        dataGridView1.Columns[5].HeaderText = "код_Сотрудника";
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
            if (tBid.Text != "" || tBtype.Text != "" || tBstart.Text != "" || tBfinish.Text != "" || tBdays.Text != "" || tBEmId.Text != "")
            {
                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Vacation WHERE `idVacation` = @ID OR `Vacation_Type`= @T OR `Vacation_Start`= @S OR `Vacation_Finish`= @F OR `Vacation_Days`= @D  OR `Employee_idEmployee`= @EmId;", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBid.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = tBtype.Text;
                command.Parameters.Add("@S", MySqlDbType.VarChar).Value = tBstart.Text;
                command.Parameters.Add("@F", MySqlDbType.VarChar).Value = tBfinish.Text;
                command.Parameters.Add("@D", MySqlDbType.VarChar).Value = tBdays.Text;
                command.Parameters.Add("@EmId", MySqlDbType.VarChar).Value = tBEmId.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "код_Отпуска";
                dataGridView1.Columns[1].HeaderText = "Вид";
                dataGridView1.Columns[2].HeaderText = "Начало";
                dataGridView1.Columns[3].HeaderText = "Конец";
                dataGridView1.Columns[4].HeaderText = "Кол-во дней";
                dataGridView1.Columns[5].HeaderText = "код_Сотрудника";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
        }
    }
}
