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
    public partial class TimeRepForm : Form
    {
        public TimeRepForm()
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

            if (cBPerson.Text == "Все сотрудники" || cBPerson.Text == "")
            {
                MySqlCommand command = new MySqlCommand("SELECT  COUNT(*) AS Days, Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000) AS Hours, `Employee_FIO` FROM `WTime` " +
                "INNER JOIN `Employee` ON Employee_idEmployee = idEmployee GROUP BY `Employee_FIO`;", db.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "Дни";
                dataGridView1.Columns[1].HeaderText = "Рабочие часы";
                dataGridView1.Columns[2].HeaderText = "Сотрудник";
            }

            if (cBPerson.Text != "Все сотрудники" || cBPerson.Text != "")
            {
                MySqlCommand command = new MySqlCommand("SELECT  COUNT(*) AS Days, Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000) AS Hours, `Employee_FIO` FROM `WTime` " +
                "INNER JOIN `Employee` ON Employee_idEmployee = idEmployee WHERE Employee_FIO = @fio;", db.getConnection());
                command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = cBPerson.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].HeaderText = "Дни";
                dataGridView1.Columns[1].HeaderText = "Рабочие часы";
                dataGridView1.Columns[2].HeaderText = "Сотрудник";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Отчет об отработанных часах";
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
