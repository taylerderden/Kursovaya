using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace Kursovaya
{
    public partial class UserForm : MaterialForm
    {
        public UserForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView3.EnableHeadersVisualStyles = false;
        }
        public static DateTime GetNetworkTime()  //получение времени из сети
        {
            const string ntpServer = "time.windows.com";
            var ntpData = new byte[48];
            ntpData[0] = 0x1B;

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            var intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | ntpData[43];
            var fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | ntpData[47];

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        private void labelTasks_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `Tasks_Name`, `Tasks_Deadline` FROM Tasks WHERE `Employee_idEmployee` = @ID AND `Tasks_Complete` = ''", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = command;
            adapter.Fill(table);
           
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Сроки";
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {   
            labelTime.Text = Convert.ToString(GetNetworkTime().ToShortTimeString());
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Start();

            labelDay.Text = Convert.ToString(GetNetworkTime().ToShortDateString());

            //поиск данных о задачах, часах, выплатах
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Tasks_Name, Tasks_Deadline FROM Tasks WHERE Employee_idEmployee = @ID  AND `Tasks_Complete` = ''", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Сроки";

            //часы
            DataTable tableH = new DataTable();

            MySqlCommand commandH = new MySqlCommand("SELECT  COUNT(*) AS Days, Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000) AS Hours FROM `WTime` where `Employee_idEmployee` = @ID", db.getConnection());
            commandH.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandH;
            adapter.Fill(tableH);

            dataGridView2.DataSource = tableH;
            dataGridView2.Columns[0].HeaderText = "Дни";
            dataGridView2.Columns[1].HeaderText = "Рабочие часы";

            //выплаты
            DataTable tableP = new DataTable();

            MySqlCommand commandP = new MySqlCommand("SELECT Payment_Date, Payment_Sum FROM Payment WHERE Employee_idEmployee = @ID", db.getConnection());
            commandP.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandP;
            adapter.Fill(tableP);

            dataGridView3.DataSource = tableP;
            dataGridView3.Columns[0].HeaderText = "Дата";
            dataGridView3.Columns[1].HeaderText = "Сумма";

            //приветствие в лейбле
            DataTable tableDP = new DataTable();
            MySqlCommand commandDP = new MySqlCommand("SELECT Employee_FIO FROM Employee WHERE idEmployee = @ID", db.getConnection());
            commandDP.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandDP;
            adapter.Fill(tableDP);

            db.openConnection();
            if (tableDP.Rows.Count > 0) //поиск записей
            {
               labelRab.Text = "Добро пожаловать," + ' ' + commandDP.ExecuteScalar().ToString() + "!";
            }
            db.closeConnection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = Convert.ToString(GetNetworkTime().ToShortTimeString());
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandID = new MySqlCommand("SELECT * FROM `Employee` WHERE `idEmployee` = @ID;", db.getConnection()); //проверка id
            commandID.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandID;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //поиск записей
            {
                DataTable table2 = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT `WTime_Day` FROM `WTime` WHERE `WTime_Day` = @Day AND `Employee_idEmployee` = @ID;", db.getConnection()); //поиск
                command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

                adapter.SelectCommand = command;
                adapter.Fill(table2);

                if (table2.Rows.Count == 0) //поиск записей
                {
                    MySqlCommand commandStart = new MySqlCommand("INSERT INTO `WTime` (`WTime_Day`, `WTime_Start`, `Employee_idEmployee`) VALUES(@Day, @Time, @ID);", db.getConnection());
                    commandStart.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;
                    commandStart.Parameters.Add("@Time", MySqlDbType.VarChar).Value = labelTime.Text;
                    commandStart.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

                    db.openConnection();

                    if (commandStart.ExecuteNonQuery() == 1)
                        MessageBox.Show("Удачного дня!");
                    else
                        MessageBox.Show("Ошибка!");

                    db.closeConnection();
                }
                else
                    MessageBox.Show("Вы уже начали смену!");
            }
            else
                MessageBox.Show("ID не найден!");
        }

        private void btnFinishTime_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandID = new MySqlCommand("SELECT * FROM `Employee` WHERE `idEmployee` = @ID;", db.getConnection()); //проверка id
            commandID.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandID;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //поиск записей
            {
                MySqlCommand command = new MySqlCommand("UPDATE `WTime` SET `WTime_Finish` = @Time WHERE `WTime_Day` =@Day  AND `WTime_Finish` is null AND `Employee_idEmployee` = @ID;", db.getConnection());
                command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;
                command.Parameters.Add("@Time", MySqlDbType.VarChar).Value = labelTime.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("До свидания!");
                else
                    MessageBox.Show("Вы не начали смену!");

                db.closeConnection();
            }
            else
                MessageBox.Show("ID не найден!");
        }

        private void labelHours_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT  COUNT(*) AS Days, Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000) AS Hours FROM `WTime` where `Employee_idEmployee` = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView2.DataSource = table;
            dataGridView2.Columns[0].HeaderText = "Дни";
            dataGridView2.Columns[1].HeaderText = "Рабочие часы";
        }

        private void labelPayment_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Payment_Date, Payment_Sum FROM Payment WHERE Employee_idEmployee = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView3.DataSource = table;
            dataGridView3.Columns[0].HeaderText = "Дата";
            dataGridView3.Columns[1].HeaderText = "Сумма";
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `Tasks` SET `Tasks_Complete`= '+' WHERE `Employee_idEmployee` = @ID AND `Tasks_Name` = @tName;", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;
            command.Parameters.Add("@tName", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные обновлены");
                DataTable tableNew = new DataTable();

                MySqlCommand commandNew = new MySqlCommand("SELECT `Tasks_Name`, `Tasks_Deadline` FROM Tasks WHERE `Employee_idEmployee` = @ID AND `Tasks_Complete` = '' ", db.getConnection());
                commandNew.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

                adapter.SelectCommand = commandNew;
                adapter.Fill(tableNew);

                dataGridView1.DataSource = tableNew;
                dataGridView1.Columns[0].HeaderText = "Название";
                dataGridView1.Columns[1].HeaderText = "Сроки";
            }
            else
                MessageBox.Show("Ошибка!");

            db.closeConnection();
        }
            
    }
}

