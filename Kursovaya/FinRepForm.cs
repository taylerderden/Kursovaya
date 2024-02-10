using DGVPrinterHelper;
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
    public partial class FinRepForm : Form
    {
        public FinRepForm()
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 11f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();                     
            
            if (cBPerson.Text != "" || cBPerson.Text != "Все сотрудники" && tBsum1.Text != "" && tBsum2.Text != "")
            {
                MySqlCommand command = new MySqlCommand("SELECT Payment_Date, Payment_Sum, Employee_FIO FROM `Payment` " +
                    "INNER JOIN `Employee` on Employee_idEmployee = idEmployee " +
                    "WHERE Employee_FIO = @fio AND Payment_Sum BETWEEN @sum1 AND @sum2; ", db.getConnection());
                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = cBPerson.Text;
                command.Parameters.Add("@sum1", MySqlDbType.VarChar).Value = tBsum1.Text;
                command.Parameters.Add("@sum2", MySqlDbType.VarChar).Value = tBsum2.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "Дата";
                dataGridView1.Columns[1].HeaderText = "Сумма";
                dataGridView1.Columns[2].HeaderText = "ФИО";
            }
            if(tBsum1.Text != "" && tBsum2.Text != "" && cBPerson.Text == "" || cBPerson.Text == "Все сотрудники")
            {
                MySqlCommand command = new MySqlCommand("SELECT `Payment_Date`, `Payment_Sum`, `Employee_FIO` FROM `Payment` " +
                "INNER JOIN `Employee` ON Employee_idEmployee = idEmployee " +
                "WHERE Payment_Sum BETWEEN @sum1 AND @sum2; ", db.getConnection());
                command.Parameters.Add("@sum1", MySqlDbType.VarChar).Value = tBsum1.Text;
                command.Parameters.Add("@sum2", MySqlDbType.VarChar).Value = tBsum2.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "Дата";
                dataGridView1.Columns[1].HeaderText = "Сумма";
                dataGridView1.Columns[2].HeaderText = "ФИО";
            }
            if(cBPerson.Text != "" && tBsum2.Text == "" && tBsum2.Text == "")
            {
                MySqlCommand command = new MySqlCommand("SELECT `Payment_Date`, `Payment_Sum`, `Employee_FIO` FROM `Payment` " +
                "INNER JOIN `Employee` on Employee_idEmployee = idEmployee WHERE Employee_FIO = @fio; ", db.getConnection());
                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = cBPerson.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "Дата";
                dataGridView1.Columns[1].HeaderText = "Сумма";
                dataGridView1.Columns[2].HeaderText = "ФИО";
            }
            if (cBPerson.Text == "" || cBPerson.Text == "Все сотрудники" && tBsum1.Text == "" && tBsum2.Text == "")
            {
                MySqlCommand command = new MySqlCommand("SELECT `Payment_Date`, `Payment_Sum`, `Employee_FIO` FROM `Payment` " +
                "INNER JOIN `Employee` on Employee_idEmployee = idEmployee; ", db.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "Дата";
                dataGridView1.Columns[1].HeaderText = "Сумма";
                dataGridView1.Columns[2].HeaderText = "ФИО";
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Финансовый отчет о выплатах сотрудникам";
            printer.SubTitle = string.Format("Дата: {0}", DateTime.Now.Date.ToString("dd/MM/yy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "HCM";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
