﻿
namespace Kursovaya
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWTime = new System.Windows.Forms.Label();
            this.labelDismissial = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelTasks = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelVacation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.labelWTime);
            this.panel1.Controls.Add(this.labelDismissial);
            this.panel1.Controls.Add(this.labelEmployee);
            this.panel1.Controls.Add(this.labelEducation);
            this.panel1.Controls.Add(this.labelTasks);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelVacation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 443);
            this.panel1.TabIndex = 7;
            // 
            // labelWTime
            // 
            this.labelWTime.AutoSize = true;
            this.labelWTime.BackColor = System.Drawing.Color.Maroon;
            this.labelWTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelWTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWTime.ForeColor = System.Drawing.Color.Transparent;
            this.labelWTime.Location = new System.Drawing.Point(10, 126);
            this.labelWTime.Name = "labelWTime";
            this.labelWTime.Size = new System.Drawing.Size(130, 27);
            this.labelWTime.TabIndex = 14;
            this.labelWTime.Text = "Время смен";
            this.labelWTime.Click += new System.EventHandler(this.labelWTime_Click);
            // 
            // labelDismissial
            // 
            this.labelDismissial.AutoSize = true;
            this.labelDismissial.BackColor = System.Drawing.Color.Maroon;
            this.labelDismissial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDismissial.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDismissial.ForeColor = System.Drawing.Color.Transparent;
            this.labelDismissial.Location = new System.Drawing.Point(11, 245);
            this.labelDismissial.Name = "labelDismissial";
            this.labelDismissial.Size = new System.Drawing.Size(132, 27);
            this.labelDismissial.TabIndex = 11;
            this.labelDismissial.Text = "Увольнения";
            this.labelDismissial.Click += new System.EventHandler(this.labelDismissial_Click);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.BackColor = System.Drawing.Color.Maroon;
            this.labelEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmployee.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.labelEmployee.Location = new System.Drawing.Point(11, 9);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(272, 27);
            this.labelEmployee.TabIndex = 8;
            this.labelEmployee.Text = "База данных сотрудников";
            this.labelEmployee.Click += new System.EventHandler(this.labelEmployee_Click_1);
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.BackColor = System.Drawing.Color.Maroon;
            this.labelEducation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEducation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEducation.ForeColor = System.Drawing.Color.Transparent;
            this.labelEducation.Location = new System.Drawing.Point(11, 87);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(144, 27);
            this.labelEducation.TabIndex = 13;
            this.labelEducation.Text = "Образование";
            this.labelEducation.Click += new System.EventHandler(this.labelEducation_Click);
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.BackColor = System.Drawing.Color.Maroon;
            this.labelTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTasks.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTasks.ForeColor = System.Drawing.Color.Transparent;
            this.labelTasks.Location = new System.Drawing.Point(11, 166);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(84, 27);
            this.labelTasks.TabIndex = 9;
            this.labelTasks.Text = "Задачи";
            this.labelTasks.Click += new System.EventHandler(this.labelTasks_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Maroon;
            this.labelPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.ForeColor = System.Drawing.Color.Transparent;
            this.labelPosition.Location = new System.Drawing.Point(11, 48);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(129, 27);
            this.labelPosition.TabIndex = 12;
            this.labelPosition.Text = "Должности";
            this.labelPosition.Click += new System.EventHandler(this.labelPosition_Click);
            // 
            // labelVacation
            // 
            this.labelVacation.AutoSize = true;
            this.labelVacation.BackColor = System.Drawing.Color.Maroon;
            this.labelVacation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVacation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVacation.ForeColor = System.Drawing.Color.Transparent;
            this.labelVacation.Location = new System.Drawing.Point(12, 204);
            this.labelVacation.Name = "labelVacation";
            this.labelVacation.Size = new System.Drawing.Size(97, 27);
            this.labelVacation.TabIndex = 10;
            this.labelVacation.Text = "Отпуска";
            this.labelVacation.Click += new System.EventHandler(this.labelVacation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 443);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления персоналом";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDismissial;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelVacation;
        private System.Windows.Forms.Label labelWTime;
        private System.Windows.Forms.Label labelEducation;
    }
}

