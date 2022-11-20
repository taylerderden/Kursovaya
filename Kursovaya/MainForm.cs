using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
              
        private void tsBtnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm eForm = new EmployeeForm();
            eForm.Show();
        }

        private void tsBtnPosition_Click(object sender, EventArgs e)
        {
            PositionForm pForm = new PositionForm();
            pForm.Show();
        }

        private void tsBtnEducation_Click(object sender, EventArgs e)
        {
            EducationForm edForm = new EducationForm();
            edForm.Show();
        }

        private void tsBtnWTime_Click(object sender, EventArgs e)
        {
            WTimeForm tForm = new WTimeForm();
            tForm.Show();
        }

        private void tsBtnTasks_Click(object sender, EventArgs e)
        {
            TasksForm taskForm = new TasksForm();
            taskForm.Show();
        }

        private void tsBtnVacation_Click(object sender, EventArgs e)
        {
            VacationForm vForm = new VacationForm();
            vForm.Show();
        }

        private void tsBtnDismissal_Click(object sender, EventArgs e)
        {
            DismissalForm dForm = new DismissalForm();
            dForm.Show();
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorisationForm aForm = new AutorisationForm();
            aForm.Show();
        }

        private void tsBtnPayment_Click(object sender, EventArgs e)
        {
            PaymentForm pForm = new PaymentForm();
            pForm.Show();
        }
    }

        
    
}
