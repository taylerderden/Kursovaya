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
    public partial class EfficiencyForm : Form
    {
        public EfficiencyForm()
        {
            InitializeComponent();
        }

        private void EfficiencyForm_Load(object sender, EventArgs e)
        {
            /*SELECT Employee_FIO, (SELECT Count(idTasks) FROM `Tasks`
                INNER JOIN `Employee` ON Employee_idEmployee = idEmployee WHERE Employee_idEmployee = 1 AND Tasks_Complete = '+')/ 
                (Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000)) as `Коэффициент`
                FROM `Employee`
                INNER JOIN `WTime` ON idEmployee = Employee_idEmployee WHERE Employee_idEmployee = 1;          
             */
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //запрос поменять!!! для теста
            MySqlCommand command = new MySqlCommand("SELECT Employee_FIO, (Count(idTasks)/Sum(SUBTIME(`WTime_Finish`, `WTime_Start`)/10000)) as `Коэффициент`" +
                "FROM `Employee` INNER JOIN `WTime` ON Employee.idEmployee = WTime.Employee_idEmployee INNER JOIN `Tasks` ON Employee.idEmployee = Tasks.Employee_idEmployee group by Employee_FIO; ", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Коэффициент";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "n2";

        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {
            CreateChart(dataGridView1, "Эффективность", "Сотрудники");
        }

        private void CreateChart(DataGridView dataGridView, string nameTitle, string seriesName)
        {
            try
            {
                chart.Series.Clear();
                chart.Series.Add(seriesName);

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var name = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? "";
                    var value = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "";
                    chart.Series[seriesName].Points.AddXY(name, value);
                }
                chart.ChartAreas[0].AxisX.Title = dataGridView1.Columns[0].HeaderText;
                chart.ChartAreas[0].AxisY.Title = dataGridView1.Columns[1].HeaderText;
                //chart.ChartAreas[0].AxisY.Interval = 0.1;

                MessageBox.Show("График создан");
            }
            catch
            {

            }
        }

    }
}
