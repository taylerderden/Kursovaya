
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPosition = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEducation = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWTime = new System.Windows.Forms.ToolStripButton();
            this.tsBtnTasks = new System.Windows.Forms.ToolStripButton();
            this.tsBtnVacation = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDismissal = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 443);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(718, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnEmployee,
            this.tsBtnPosition,
            this.tsBtnEducation,
            this.tsBtnWTime,
            this.tsBtnTasks,
            this.tsBtnVacation,
            this.tsBtnDismissal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 48);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnEmployee
            // 
            this.tsBtnEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnEmployee.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEmployee.Image")));
            this.tsBtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEmployee.Name = "tsBtnEmployee";
            this.tsBtnEmployee.Size = new System.Drawing.Size(120, 45);
            this.tsBtnEmployee.Text = "Сотрудники";
            this.tsBtnEmployee.Click += new System.EventHandler(this.tsBtnEmployee_Click);
            // 
            // tsBtnPosition
            // 
            this.tsBtnPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnPosition.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnPosition.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPosition.Image")));
            this.tsBtnPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPosition.Name = "tsBtnPosition";
            this.tsBtnPosition.Size = new System.Drawing.Size(111, 45);
            this.tsBtnPosition.Text = "Должности";
            this.tsBtnPosition.Click += new System.EventHandler(this.tsBtnPosition_Click);
            // 
            // tsBtnEducation
            // 
            this.tsBtnEducation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnEducation.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnEducation.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEducation.Image")));
            this.tsBtnEducation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEducation.Name = "tsBtnEducation";
            this.tsBtnEducation.Size = new System.Drawing.Size(125, 45);
            this.tsBtnEducation.Text = "Образование";
            this.tsBtnEducation.Click += new System.EventHandler(this.tsBtnEducation_Click);
            // 
            // tsBtnWTime
            // 
            this.tsBtnWTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnWTime.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnWTime.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnWTime.Image")));
            this.tsBtnWTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnWTime.Name = "tsBtnWTime";
            this.tsBtnWTime.Size = new System.Drawing.Size(73, 45);
            this.tsBtnWTime.Text = "Смены";
            this.tsBtnWTime.Click += new System.EventHandler(this.tsBtnWTime_Click);
            // 
            // tsBtnTasks
            // 
            this.tsBtnTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnTasks.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnTasks.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTasks.Image")));
            this.tsBtnTasks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTasks.Name = "tsBtnTasks";
            this.tsBtnTasks.Size = new System.Drawing.Size(74, 45);
            this.tsBtnTasks.Text = "Задачи";
            this.tsBtnTasks.Click += new System.EventHandler(this.tsBtnTasks_Click);
            // 
            // tsBtnVacation
            // 
            this.tsBtnVacation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnVacation.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnVacation.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnVacation.Image")));
            this.tsBtnVacation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnVacation.Name = "tsBtnVacation";
            this.tsBtnVacation.Size = new System.Drawing.Size(85, 45);
            this.tsBtnVacation.Text = "Отпуска";
            this.tsBtnVacation.Click += new System.EventHandler(this.tsBtnVacation_Click);
            // 
            // tsBtnDismissal
            // 
            this.tsBtnDismissal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnDismissal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnDismissal.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDismissal.Image")));
            this.tsBtnDismissal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDismissal.Name = "tsBtnDismissal";
            this.tsBtnDismissal.Size = new System.Drawing.Size(116, 45);
            this.tsBtnDismissal.Text = "Увольнения";
            this.tsBtnDismissal.Click += new System.EventHandler(this.tsBtnDismissal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления персоналом";
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripButton tsBtnPosition;
        private System.Windows.Forms.ToolStripButton tsBtnEducation;
        private System.Windows.Forms.ToolStripButton tsBtnWTime;
        private System.Windows.Forms.ToolStripButton tsBtnTasks;
        private System.Windows.Forms.ToolStripButton tsBtnVacation;
        private System.Windows.Forms.ToolStripButton tsBtnDismissal;
    }
}

