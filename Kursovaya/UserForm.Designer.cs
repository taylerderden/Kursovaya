
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelPayment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.btnFinishTime = new System.Windows.Forms.Button();
            this.btnStartTime = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelTasks = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHide = new System.Windows.Forms.Label();
            this.labelFullScreen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.labelPayment);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.labelHours);
            this.panel1.Controls.Add(this.btnFinishTime);
            this.panel1.Controls.Add(this.btnStartTime);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.labelTasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 513);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(27, 382);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(401, 119);
            this.dataGridView3.TabIndex = 14;
            // 
            // labelPayment
            // 
            this.labelPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPayment.AutoSize = true;
            this.labelPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPayment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPayment.ForeColor = System.Drawing.Color.White;
            this.labelPayment.Location = new System.Drawing.Point(22, 352);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(174, 27);
            this.labelPayment.TabIndex = 13;
            this.labelPayment.Text = "Узнать выплаты";
            this.labelPayment.Click += new System.EventHandler(this.labelPayment_Click);
            this.labelPayment.MouseEnter += new System.EventHandler(this.labelPayment_MouseEnter);
            this.labelPayment.MouseLeave += new System.EventHandler(this.labelPayment_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources._4308331_clock_hours_man_personal_schedule_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(448, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(448, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(406, 118);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTime.AutoSize = true;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(521, 247);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 26);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Время";
            // 
            // labelDay
            // 
            this.labelDay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(443, 220);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(60, 26);
            this.labelDay.TabIndex = 8;
            this.labelDay.Text = "День";
            // 
            // labelHours
            // 
            this.labelHours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHours.ForeColor = System.Drawing.Color.White;
            this.labelHours.Location = new System.Drawing.Point(22, 190);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(286, 27);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Узнать отработанные часы";
            this.labelHours.Click += new System.EventHandler(this.labelHours_Click);
            this.labelHours.MouseEnter += new System.EventHandler(this.labelHours_MouseEnter);
            this.labelHours.MouseLeave += new System.EventHandler(this.labelHours_MouseLeave);
            // 
            // btnFinishTime
            // 
            this.btnFinishTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishTime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinishTime.Location = new System.Drawing.Point(448, 425);
            this.btnFinishTime.Name = "btnFinishTime";
            this.btnFinishTime.Size = new System.Drawing.Size(145, 35);
            this.btnFinishTime.TabIndex = 6;
            this.btnFinishTime.Text = "Закрыть смену";
            this.btnFinishTime.UseVisualStyleBackColor = true;
            this.btnFinishTime.Click += new System.EventHandler(this.btnFinishTime_Click);
            // 
            // btnStartTime
            // 
            this.btnStartTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStartTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTime.Location = new System.Drawing.Point(448, 303);
            this.btnStartTime.Name = "btnStartTime";
            this.btnStartTime.Size = new System.Drawing.Size(145, 35);
            this.btnStartTime.TabIndex = 5;
            this.btnStartTime.Text = "Открыть смену";
            this.btnStartTime.UseVisualStyleBackColor = true;
            this.btnStartTime.Click += new System.EventHandler(this.btnStartTime_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(334, 41);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 27);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 108);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxID.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.ForeColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(382, 42);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(41, 27);
            this.textBoxID.TabIndex = 2;
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTasks.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTasks.ForeColor = System.Drawing.Color.White;
            this.labelTasks.Location = new System.Drawing.Point(22, 42);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(154, 27);
            this.labelTasks.TabIndex = 1;
            this.labelTasks.Text = "Узнать задачи";
            this.labelTasks.Click += new System.EventHandler(this.labelTasks_Click);
            this.labelTasks.MouseEnter += new System.EventHandler(this.labelTasks_MouseEnter);
            this.labelTasks.MouseLeave += new System.EventHandler(this.labelTasks_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panel2.Size = new System.Drawing.Size(605, 28);
            this.panel2.TabIndex = 20;
            // 
            // labelHide
            // 
            this.labelHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHide.AutoSize = true;
            this.labelHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHide.ForeColor = System.Drawing.Color.Black;
            this.labelHide.Location = new System.Drawing.Point(523, 0);
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
            this.labelFullScreen.Location = new System.Drawing.Point(542, 0);
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
            this.labelClose.Location = new System.Drawing.Point(568, 3);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 23);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "❌";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(605, 455);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button btnFinishTime;
        private System.Windows.Forms.Button btnStartTime;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHide;
        private System.Windows.Forms.Label labelFullScreen;
        private System.Windows.Forms.Label labelClose;
    }
}