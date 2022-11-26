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
            //создание глоб форм для открытия и закрытия
            EmployeeForm eForm = new EmployeeForm();
            PositionForm pForm = new PositionForm();
            EducationForm edForm = new EducationForm();
            WTimeForm wForm = new WTimeForm();
            TasksForm taskForm = new TasksForm();
            DismissalForm dForm = new DismissalForm();
            PaymentForm payForm = new PaymentForm();
            VacationForm vForm = new VacationForm();

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
            WTimeForm wForm = new WTimeForm();
            wForm.Show();
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
            PaymentForm payForm = new PaymentForm();
            payForm.Show();
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
            eForm.Hide();            
            pForm.Hide();           
            edForm.Hide();            
            wForm.Hide();            
            taskForm.Hide();            
            vForm.Hide();           
            dForm.Hide();            
            payForm.Hide();

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
    }

        
    
}
