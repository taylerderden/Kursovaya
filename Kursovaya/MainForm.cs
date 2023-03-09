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
using MySql.Data.MySqlClient;

namespace Kursovaya
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);            
        }

        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT Employee_FIO FROM Employee WHERE idEmployee = @ID", db.getConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.openConnection();
            if (table.Rows.Count > 0) //поиск записей
            {
                labelName.Text = command.ExecuteScalar().ToString();
            }       
            else
                MessageBox.Show("Неизвестный сотрудник!");
            db.closeConnection();

            MySqlCommand commandCount = new MySqlCommand("SELECT COUNT(*) AS Notconf FROM `Security` WHERE `Confirmation` = '' OR `Confirmation` is NULL;", db.getConnection()); // проверка числа неподтвержденных записей
            commandCount.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandCount;
            adapter.Fill(table);

            db.openConnection();
            if (table.Rows.Count > 0) //поиск записей
            {
                labelCountConfidence.Text = commandCount.ExecuteScalar().ToString();
            }
            else
                labelCountConfidence.Text = "0";
            db.closeConnection();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.Green;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new EmployeeForm());
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            btnPosition.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new PositionForm());
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            btnEducation.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new EducationForm());
        }

        private void btnWTime_Click(object sender, EventArgs e)
        {
            btnWTime.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new WTimeForm());
        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new TasksForm());
        }

        private void btnVacation_Click(object sender, EventArgs e)
        {
            btnVacation.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new VacationForm());
        }

        private void btnDismissial_Click(object sender, EventArgs e)
        {
            btnDismissial.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new DismissalForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            btnPayment.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;

            LoadForm(new PaymentForm());
        }
        private void MainForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnSecurity.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;

            panelSubmenuReport.Visible = true;
        }

        private void btnFinRep_Click(object sender, EventArgs e)
        {
            panelSubmenuReport.Visible = false;
            LoadForm(new FinRepForm());
        }

        private void btnTimeRep_Click(object sender, EventArgs e)
        {
            panelSubmenuReport.Visible = false;
            LoadForm(new TimeRepForm());
        }

        private void btnEfRep_Click(object sender, EventArgs e)
        {
            panelSubmenuReport.Visible = false;
            LoadForm(new EfficiencyForm());
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            btnSecurity.BackColor = Color.Green;
            btnEmployee.BackColor = Color.DarkGreen;
            btnPosition.BackColor = Color.DarkGreen;
            btnEducation.BackColor = Color.DarkGreen;
            btnWTime.BackColor = Color.DarkGreen;
            btnVacation.BackColor = Color.DarkGreen;
            btnTasks.BackColor = Color.DarkGreen;
            btnDismissial.BackColor = Color.DarkGreen;
            btnReport.BackColor = Color.DarkGreen;
            btnPayment.BackColor = Color.DarkGreen;

            LoadForm(new SecurityForm());

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandCount = new MySqlCommand("SELECT COUNT(*) AS Notconf FROM `Security` WHERE `Confirmation` = '' OR `Confirmation` is NULL;", db.getConnection()); // проверка числа неподтвержденных записей
            commandCount.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandCount;
            adapter.Fill(table);

            db.openConnection();
            if (table.Rows.Count > 0) //поиск записей
            {
                labelCountConfidence.Text = commandCount.ExecuteScalar().ToString();
            }
            else
                labelCountConfidence.Text = "0";
            db.closeConnection();
        }
    }
}
