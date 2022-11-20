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

        private void labelHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void tsLback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorisationForm aForm = new AutorisationForm(); 
            aForm.Show();
        }

        private void tsLback_MouseEnter(object sender, EventArgs e)
        {
            tsLback.ForeColor = Color.Green;
        }

        private void tsLback_MouseLeave(object sender, EventArgs e)
        {
            tsLback.ForeColor = Color.Silver;
        }
    }

        
    
}
