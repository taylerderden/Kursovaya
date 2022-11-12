using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
               
        private void UserForm_Load(object sender, EventArgs e)
        {                                  
            labelTime.Text = Convert.ToString(GetNetworkTime().ToShortTimeString());
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timer1_Tick);
            tmr.Start();

            labelDay.Text = Convert.ToString(GetNetworkTime().ToShortDateString());
        }
        private void timer1_Tick(object sender, EventArgs e)  //таймер обновления времени
        {
            labelTime.Text = Convert.ToString(GetNetworkTime().ToShortTimeString());
        }
        
        private void labelTasks_Click(object sender, EventArgs e)  //назначенные задачи
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
        
        private void btnStartTime_Click(object sender, EventArgs e) // начало смены
        {
            DB db = new DB();

            if (textBoxID.Text != "")
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `WTime` (`WTime_Day`, `WTime_Start`, `Employee_idEmployee`) VALUES(@Day, @Time, @ID);", db.getConnection());
                command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;
                command.Parameters.Add("@Time", MySqlDbType.VarChar).Value = labelTime.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxID.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Удачного дня!");
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }
            else
                MessageBox.Show("Введите ID");
        }

        private void btnFinishTime_Click(object sender, EventArgs e)  //конец смены
        {            
            DB db = new DB();

            if (textBoxID.Text != "")
            {
                MySqlCommand command = new MySqlCommand("UPDATE `WTime` SET `WTime_Finish` = @Time WHERE `WTime_Day` =@Day  AND `WTime_Finish` is null AND `Employee_idEmployee` = @ID;", db.getConnection());
                command.Parameters.Add("@Day", MySqlDbType.VarChar).Value = labelDay.Text;
                command.Parameters.Add("@Time", MySqlDbType.VarChar).Value = labelTime.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxID.Text;
            
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("До свидания!");
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }
            else
                MessageBox.Show("Введите ID");
        }

        private void labelHours_Click(object sender, EventArgs e)  //отработанное время 
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT  COUNT(*) AS Days, Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000) AS Hours FROM `WTime` where `Employee_idEmployee` = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxID.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView2.DataSource = table;
            dataGridView2.Columns[0].HeaderText = "Дни";
            dataGridView2.Columns[1].HeaderText = "Рабочие часы";

        }

        private void btnExit_Click(object sender, EventArgs e)      //выход в авторизацию
        {
            this.Hide();
            AutorisationForm aForm = new AutorisationForm(); 
            aForm.Show();
        }
    }
}
