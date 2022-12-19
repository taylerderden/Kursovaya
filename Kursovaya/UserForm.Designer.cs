
namespace Kursovaya
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelTasks = new System.Windows.Forms.Label();
            this.btnStartTime = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinishTime = new MaterialSkin.Controls.MaterialRaisedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelRab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            resources.ApplyResources(this.dataGridView3, "dataGridView3");
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.Color.Green;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            // 
            // labelPayment
            // 
            resources.ApplyResources(this.labelPayment, "labelPayment");
            this.labelPayment.BackColor = System.Drawing.Color.White;
            this.labelPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPayment.ForeColor = System.Drawing.Color.DimGray;
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Click += new System.EventHandler(this.labelPayment_Click);
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.ForeColor = System.Drawing.Color.DimGray;
            this.labelTime.Name = "labelTime";
            // 
            // labelDay
            // 
            resources.ApplyResources(this.labelDay, "labelDay");
            this.labelDay.BackColor = System.Drawing.Color.White;
            this.labelDay.ForeColor = System.Drawing.Color.DimGray;
            this.labelDay.Name = "labelDay";
            // 
            // dataGridView2
            // 
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Green;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            // 
            // labelHours
            // 
            resources.ApplyResources(this.labelHours, "labelHours");
            this.labelHours.BackColor = System.Drawing.Color.White;
            this.labelHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHours.ForeColor = System.Drawing.Color.DimGray;
            this.labelHours.Name = "labelHours";
            this.labelHours.Click += new System.EventHandler(this.labelHours_Click);
            // 
            // labelTasks
            // 
            resources.ApplyResources(this.labelTasks, "labelTasks");
            this.labelTasks.BackColor = System.Drawing.Color.White;
            this.labelTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTasks.ForeColor = System.Drawing.Color.DimGray;
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Click += new System.EventHandler(this.labelTasks_Click);
            // 
            // btnStartTime
            // 
            resources.ApplyResources(this.btnStartTime, "btnStartTime");
            this.btnStartTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTime.Depth = 0;
            this.btnStartTime.Icon = null;
            this.btnStartTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Primary = true;
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // btnFinishTime
            // 
            resources.ApplyResources(this.btnFinishTime, "btnFinishTime");
            this.btnFinishTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishTime.Depth = 0;
            this.btnFinishTime.Icon = null;
            this.btnFinishTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishTime.Name = "btnFinishTime";
            this.btnFinishTime.Primary = true;
            this.btnFinishTime.UseVisualStyleBackColor = true;
            this.btnFinishTime.Click += new System.EventHandler(this.btnFinishTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Honeydew;
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.Name = "monthCalendar1";
            // 
            // labelRab
            // 
            resources.ApplyResources(this.labelRab, "labelRab");
            this.labelRab.BackColor = System.Drawing.Color.White;
            this.labelRab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRab.ForeColor = System.Drawing.Color.DimGray;
            this.labelRab.Name = "labelRab";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources._4202111_envato_logo_social_social_media_icon;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            resources.ApplyResources(this.materialDivider1, "materialDivider1");
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRab);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFinishTime);
            this.Controls.Add(this.btnStartTime);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelTasks);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelTasks;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartTime;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinishTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelRab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}