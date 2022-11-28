
namespace Kursovaya
{
    partial class DismissalForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLoadData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHide = new System.Windows.Forms.Label();
            this.labelFullScreen = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tBEmId = new System.Windows.Forms.TextBox();
            this.tBreason = new System.Windows.Forms.TextBox();
            this.tBdate = new System.Windows.Forms.TextBox();
            this.tBid = new System.Windows.Forms.TextBox();
            this.labelInst = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 358);
            this.dataGridView1.TabIndex = 18;
            // 
            // labelLoadData
            // 
            this.labelLoadData.AutoSize = true;
            this.labelLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoadData.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoadData.Location = new System.Drawing.Point(709, 393);
            this.labelLoadData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadData.Name = "labelLoadData";
            this.labelLoadData.Size = new System.Drawing.Size(40, 27);
            this.labelLoadData.TabIndex = 36;
            this.labelLoadData.Text = "🔄";
            this.labelLoadData.Click += new System.EventHandler(this.labelLoadData_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelHide);
            this.panel2.Controls.Add(this.labelFullScreen);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 23);
            this.panel2.TabIndex = 37;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Увольнения";
            // 
            // labelHide
            // 
            this.labelHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHide.AutoSize = true;
            this.labelHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHide.ForeColor = System.Drawing.Color.Black;
            this.labelHide.Location = new System.Drawing.Point(877, 1);
            this.labelHide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHide.Name = "labelHide";
            this.labelHide.Size = new System.Drawing.Size(21, 29);
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
            this.labelFullScreen.Location = new System.Drawing.Point(896, 1);
            this.labelFullScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullScreen.Name = "labelFullScreen";
            this.labelFullScreen.Size = new System.Drawing.Size(25, 24);
            this.labelFullScreen.TabIndex = 1;
            this.labelFullScreen.Text = "⧉";
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
            this.labelClose.Location = new System.Drawing.Point(922, 4);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 23);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "❌";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(758, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(758, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 34);
            this.button2.TabIndex = 43;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(758, 350);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 34);
            this.button3.TabIndex = 42;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(758, 311);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 34);
            this.button4.TabIndex = 41;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // tBEmId
            // 
            this.tBEmId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBEmId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBEmId.Location = new System.Drawing.Point(564, 434);
            this.tBEmId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBEmId.Name = "tBEmId";
            this.tBEmId.Size = new System.Drawing.Size(148, 28);
            this.tBEmId.TabIndex = 51;
            // 
            // tBreason
            // 
            this.tBreason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBreason.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBreason.Location = new System.Drawing.Point(313, 434);
            this.tBreason.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBreason.Name = "tBreason";
            this.tBreason.Size = new System.Drawing.Size(241, 28);
            this.tBreason.TabIndex = 50;
            // 
            // tBdate
            // 
            this.tBdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBdate.Location = new System.Drawing.Point(81, 434);
            this.tBdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBdate.Name = "tBdate";
            this.tBdate.Size = new System.Drawing.Size(222, 28);
            this.tBdate.TabIndex = 49;
            // 
            // tBid
            // 
            this.tBid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBid.Location = new System.Drawing.Point(24, 434);
            this.tBid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBid.Name = "tBid";
            this.tBid.Size = new System.Drawing.Size(47, 28);
            this.tBid.TabIndex = 48;
            // 
            // labelInst
            // 
            this.labelInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInst.AutoSize = true;
            this.labelInst.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInst.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInst.Location = new System.Drawing.Point(309, 408);
            this.labelInst.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInst.Name = "labelInst";
            this.labelInst.Size = new System.Drawing.Size(79, 21);
            this.labelInst.TabIndex = 47;
            this.labelInst.Text = "Причина";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelType.Location = new System.Drawing.Point(77, 408);
            this.labelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 21);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "Дата";
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelID.Location = new System.Drawing.Point(20, 409);
            this.labelID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 21);
            this.labelID.TabIndex = 45;
            this.labelID.Text = "id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources._4308334_dismissal_employee_exit_job_layoff_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(758, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(560, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "id сотрудника";
            // 
            // DismissalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(955, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBEmId);
            this.Controls.Add(this.tBreason);
            this.Controls.Add(this.tBdate);
            this.Controls.Add(this.tBid);
            this.Controls.Add(this.labelInst);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelLoadData);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DismissalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DismissialForm";
            this.Load += new System.EventHandler(this.DismissalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelLoadData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHide;
        private System.Windows.Forms.Label labelFullScreen;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBEmId;
        private System.Windows.Forms.TextBox tBreason;
        private System.Windows.Forms.TextBox tBdate;
        private System.Windows.Forms.TextBox tBid;
        private System.Windows.Forms.Label labelInst;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
    }
}