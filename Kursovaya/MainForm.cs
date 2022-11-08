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

        private void labelEmployee_Click(object sender, EventArgs e)
        {           
            EmployeeForm registerForm = new EmployeeForm();
            registerForm.Show();
        }

        private void labelPosition_Click(object sender, EventArgs e)
        {
            PositionForm registerForm = new PositionForm();
            registerForm.Show();
        }

        private void labelWTime_Click(object sender, EventArgs e)
        {
            WTimeForm registerForm = new WTimeForm();
            registerForm.Show();
        }

        private void labelDismissial_Click(object sender, EventArgs e)
        {
            DismissialForm registerForm = new DismissialForm();
            registerForm.Show();
        }

        private void labelVacation_Click(object sender, EventArgs e)
        {
            VacationForm registerForm = new VacationForm();
            registerForm.Show();
        }

        private void labelTasks_Click(object sender, EventArgs e)
        {
            TasksForm registerForm = new TasksForm();
            registerForm.Show();
        }

        private void labelEducation_Click(object sender, EventArgs e)
        {
            EducationForm registerForm = new EducationForm();
            registerForm.Show();
        }

        private void labelEmployee_Click_1(object sender, EventArgs e)
        {
            EmployeeForm registerForm = new EmployeeForm();
            registerForm.Show();
        }
    }

        
    
}
