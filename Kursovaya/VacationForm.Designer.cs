
namespace Kursovaya
{
    partial class VacationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tBstart = new System.Windows.Forms.TextBox();
            this.tBtype = new System.Windows.Forms.TextBox();
            this.tBid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.labelLoadData = new System.Windows.Forms.Label();
            this.tBEmId = new System.Windows.Forms.TextBox();
            this.tBdays = new System.Windows.Forms.TextBox();
            this.tBfinish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBstart
            // 
            this.tBstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBstart.Location = new System.Drawing.Point(11, 453);
            this.tBstart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBstart.Name = "tBstart";
            this.tBstart.Size = new System.Drawing.Size(127, 25);
            this.tBstart.TabIndex = 24;
            // 
            // tBtype
            // 
            this.tBtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBtype.Location = new System.Drawing.Point(149, 453);
            this.tBtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBtype.Name = "tBtype";
            this.tBtype.Size = new System.Drawing.Size(124, 25);
            this.tBtype.TabIndex = 23;
            // 
            // tBid
            // 
            this.tBid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBid.Location = new System.Drawing.Point(11, 400);
            this.tBid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBid.Name = "tBid";
            this.tBid.Size = new System.Drawing.Size(127, 25);
            this.tBid.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(11, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "НАЧАЛО";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Green;
            this.labelName.Location = new System.Drawing.Point(146, 428);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 22);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "ТИП";
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.ForeColor = System.Drawing.Color.Green;
            this.labelID.Location = new System.Drawing.Point(8, 376);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 22);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 341);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(813, 549);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 33);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "НАЙТИ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Green;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(813, 508);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(147, 33);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "УДАЛИТЬ";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackColor = System.Drawing.Color.Green;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(813, 467);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(147, 33);
            this.btnUp.TabIndex = 26;
            this.btnUp.Text = "ОБНОВИТЬ";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnIns
            // 
            this.btnIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIns.BackColor = System.Drawing.Color.Green;
            this.btnIns.FlatAppearance.BorderSize = 0;
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIns.ForeColor = System.Drawing.Color.White;
            this.btnIns.Location = new System.Drawing.Point(813, 426);
            this.btnIns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(147, 33);
            this.btnIns.TabIndex = 25;
            this.btnIns.Text = "ДОБАВИТЬ";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // labelLoadData
            // 
            this.labelLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoadData.AutoSize = true;
            this.labelLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoadData.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoadData.ForeColor = System.Drawing.Color.Green;
            this.labelLoadData.Location = new System.Drawing.Point(938, 344);
            this.labelLoadData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoadData.Name = "labelLoadData";
            this.labelLoadData.Size = new System.Drawing.Size(48, 33);
            this.labelLoadData.TabIndex = 29;
            this.labelLoadData.Text = "🔄";
            this.labelLoadData.Click += new System.EventHandler(this.labelLoadData_Click);
            // 
            // tBEmId
            // 
            this.tBEmId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBEmId.Location = new System.Drawing.Point(146, 400);
            this.tBEmId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBEmId.Name = "tBEmId";
            this.tBEmId.Size = new System.Drawing.Size(127, 25);
            this.tBEmId.TabIndex = 36;
            // 
            // tBdays
            // 
            this.tBdays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBdays.Location = new System.Drawing.Point(151, 508);
            this.tBdays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBdays.Name = "tBdays";
            this.tBdays.Size = new System.Drawing.Size(122, 25);
            this.tBdays.TabIndex = 35;
            // 
            // tBfinish
            // 
            this.tBfinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBfinish.Location = new System.Drawing.Point(11, 508);
            this.tBfinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBfinish.Name = "tBfinish";
            this.tBfinish.Size = new System.Drawing.Size(127, 25);
            this.tBfinish.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(11, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "КОНЕЦ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(148, 484);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "ДНЕЙ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(146, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID СОТРУДНИКА";
            // 
            // VacationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBEmId);
            this.Controls.Add(this.tBdays);
            this.Controls.Add(this.tBfinish);
            this.Controls.Add(this.labelLoadData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.tBstart);
            this.Controls.Add(this.tBtype);
            this.Controls.Add(this.tBid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VacationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VacationForm";
            this.Load += new System.EventHandler(this.VacationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBstart;
        private System.Windows.Forms.TextBox tBtype;
        private System.Windows.Forms.TextBox tBid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label labelLoadData;
        private System.Windows.Forms.TextBox tBEmId;
        private System.Windows.Forms.TextBox tBdays;
        private System.Windows.Forms.TextBox tBfinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}