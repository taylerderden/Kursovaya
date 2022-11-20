
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHide = new System.Windows.Forms.Label();
            this.labelFullScreen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPosition = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEducation = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWTime = new System.Windows.Forms.ToolStripButton();
            this.tsBtnTasks = new System.Windows.Forms.ToolStripButton();
            this.tsBtnVacation = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDismissal = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPayment = new System.Windows.Forms.ToolStripButton();
            this.tsLback = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 443);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.labelHide);
            this.panel2.Controls.Add(this.labelFullScreen);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 30);
            this.panel2.TabIndex = 16;
            // 
            // labelHide
            // 
            this.labelHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHide.AutoSize = true;
            this.labelHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHide.ForeColor = System.Drawing.Color.Black;
            this.labelHide.Location = new System.Drawing.Point(979, 0);
            this.labelHide.Name = "labelHide";
            this.labelHide.Size = new System.Drawing.Size(22, 29);
            this.labelHide.TabIndex = 8;
            this.labelHide.Text = "–";
            this.labelHide.Click += new System.EventHandler(this.labelHide_Click);
            this.labelHide.MouseEnter += new System.EventHandler(this.labelHide_MouseEnter);
            this.labelHide.MouseLeave += new System.EventHandler(this.labelHide_MouseLeave);
            // 
            // labelFullScreen
            // 
            this.labelFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullScreen.AutoSize = true;
            this.labelFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFullScreen.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullScreen.ForeColor = System.Drawing.Color.Black;
            this.labelFullScreen.Location = new System.Drawing.Point(998, 0);
            this.labelFullScreen.Name = "labelFullScreen";
            this.labelFullScreen.Size = new System.Drawing.Size(32, 26);
            this.labelFullScreen.TabIndex = 1;
            this.labelFullScreen.Text = "⧉";
            this.labelFullScreen.Click += new System.EventHandler(this.labelFullScreen_Click);
            this.labelFullScreen.MouseEnter += new System.EventHandler(this.labelFullScreen_MouseEnter);
            this.labelFullScreen.MouseLeave += new System.EventHandler(this.labelFullScreen_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Location = new System.Drawing.Point(1024, 3);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 23);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "❌";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnEmployee,
            this.tsBtnPosition,
            this.tsBtnEducation,
            this.tsBtnWTime,
            this.tsBtnTasks,
            this.tsBtnVacation,
            this.tsBtnDismissal,
            this.tsBtnPayment,
            this.tsLback});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 45);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnEmployee
            // 
            this.tsBtnEmployee.BackColor = System.Drawing.Color.Silver;
            this.tsBtnEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnEmployee.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEmployee.Image")));
            this.tsBtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEmployee.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnEmployee.Name = "tsBtnEmployee";
            this.tsBtnEmployee.Size = new System.Drawing.Size(120, 40);
            this.tsBtnEmployee.Text = "Сотрудники";
            this.tsBtnEmployee.Click += new System.EventHandler(this.tsBtnEmployee_Click);
            // 
            // tsBtnPosition
            // 
            this.tsBtnPosition.BackColor = System.Drawing.Color.Silver;
            this.tsBtnPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnPosition.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnPosition.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPosition.Image")));
            this.tsBtnPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPosition.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnPosition.Name = "tsBtnPosition";
            this.tsBtnPosition.Size = new System.Drawing.Size(111, 40);
            this.tsBtnPosition.Text = "Должности";
            this.tsBtnPosition.Click += new System.EventHandler(this.tsBtnPosition_Click);
            // 
            // tsBtnEducation
            // 
            this.tsBtnEducation.BackColor = System.Drawing.Color.Silver;
            this.tsBtnEducation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnEducation.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnEducation.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEducation.Image")));
            this.tsBtnEducation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEducation.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnEducation.Name = "tsBtnEducation";
            this.tsBtnEducation.Size = new System.Drawing.Size(125, 40);
            this.tsBtnEducation.Text = "Образование";
            this.tsBtnEducation.Click += new System.EventHandler(this.tsBtnEducation_Click);
            // 
            // tsBtnWTime
            // 
            this.tsBtnWTime.BackColor = System.Drawing.Color.Silver;
            this.tsBtnWTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnWTime.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnWTime.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnWTime.Image")));
            this.tsBtnWTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnWTime.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnWTime.Name = "tsBtnWTime";
            this.tsBtnWTime.Size = new System.Drawing.Size(73, 40);
            this.tsBtnWTime.Text = "Смены";
            this.tsBtnWTime.Click += new System.EventHandler(this.tsBtnWTime_Click);
            // 
            // tsBtnTasks
            // 
            this.tsBtnTasks.BackColor = System.Drawing.Color.Silver;
            this.tsBtnTasks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnTasks.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnTasks.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTasks.Image")));
            this.tsBtnTasks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTasks.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnTasks.Name = "tsBtnTasks";
            this.tsBtnTasks.Size = new System.Drawing.Size(74, 40);
            this.tsBtnTasks.Text = "Задачи";
            this.tsBtnTasks.Click += new System.EventHandler(this.tsBtnTasks_Click);
            // 
            // tsBtnVacation
            // 
            this.tsBtnVacation.BackColor = System.Drawing.Color.Silver;
            this.tsBtnVacation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnVacation.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnVacation.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnVacation.Image")));
            this.tsBtnVacation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnVacation.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnVacation.Name = "tsBtnVacation";
            this.tsBtnVacation.Size = new System.Drawing.Size(85, 40);
            this.tsBtnVacation.Text = "Отпуска";
            this.tsBtnVacation.Click += new System.EventHandler(this.tsBtnVacation_Click);
            // 
            // tsBtnDismissal
            // 
            this.tsBtnDismissal.BackColor = System.Drawing.Color.Silver;
            this.tsBtnDismissal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnDismissal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnDismissal.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDismissal.Image")));
            this.tsBtnDismissal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDismissal.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnDismissal.Name = "tsBtnDismissal";
            this.tsBtnDismissal.Size = new System.Drawing.Size(116, 40);
            this.tsBtnDismissal.Text = "Увольнения";
            this.tsBtnDismissal.Click += new System.EventHandler(this.tsBtnDismissal_Click);
            // 
            // tsBtnPayment
            // 
            this.tsBtnPayment.BackColor = System.Drawing.Color.Silver;
            this.tsBtnPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnPayment.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnPayment.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPayment.Image")));
            this.tsBtnPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPayment.Margin = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.tsBtnPayment.Name = "tsBtnPayment";
            this.tsBtnPayment.Size = new System.Drawing.Size(92, 40);
            this.tsBtnPayment.Text = "Выплаты";
            this.tsBtnPayment.Click += new System.EventHandler(this.tsBtnPayment_Click);
            // 
            // tsLback
            // 
            this.tsLback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLback.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsLback.ForeColor = System.Drawing.Color.Silver;
            this.tsLback.Margin = new System.Windows.Forms.Padding(60, 1, 0, 2);
            this.tsLback.Name = "tsLback";
            this.tsLback.Size = new System.Drawing.Size(38, 42);
            this.tsLback.Text = "→";
            this.tsLback.Click += new System.EventHandler(this.tsLback_Click);
            this.tsLback.MouseEnter += new System.EventHandler(this.tsLback_MouseEnter);
            this.tsLback.MouseLeave += new System.EventHandler(this.tsLback_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 443);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления персоналом";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnEmployee;
        private System.Windows.Forms.ToolStripButton tsBtnPosition;
        private System.Windows.Forms.ToolStripButton tsBtnEducation;
        private System.Windows.Forms.ToolStripButton tsBtnWTime;
        private System.Windows.Forms.ToolStripButton tsBtnTasks;
        private System.Windows.Forms.ToolStripButton tsBtnVacation;
        private System.Windows.Forms.ToolStripButton tsBtnDismissal;
        private System.Windows.Forms.ToolStripButton tsBtnPayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHide;
        private System.Windows.Forms.Label labelFullScreen;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ToolStripLabel tsLback;
    }
}

