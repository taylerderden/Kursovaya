
namespace Kursovaya
{
    partial class EducationForm
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
            this.tBInst = new System.Windows.Forms.TextBox();
            this.tBType = new System.Windows.Forms.TextBox();
            this.tBid = new System.Windows.Forms.TextBox();
            this.labelInst = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBEmId = new System.Windows.Forms.TextBox();
            this.labelEmId = new System.Windows.Forms.Label();
            this.labelLoadData = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBInst
            // 
            this.tBInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBInst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBInst.Location = new System.Drawing.Point(14, 514);
            this.tBInst.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBInst.Name = "tBInst";
            this.tBInst.Size = new System.Drawing.Size(235, 25);
            this.tBInst.TabIndex = 28;
            // 
            // tBType
            // 
            this.tBType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBType.Location = new System.Drawing.Point(14, 453);
            this.tBType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBType.Name = "tBType";
            this.tBType.Size = new System.Drawing.Size(239, 25);
            this.tBType.TabIndex = 27;
            // 
            // tBid
            // 
            this.tBid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBid.Location = new System.Drawing.Point(14, 398);
            this.tBid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBid.Name = "tBid";
            this.tBid.Size = new System.Drawing.Size(239, 25);
            this.tBid.TabIndex = 26;
            // 
            // labelInst
            // 
            this.labelInst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInst.AutoSize = true;
            this.labelInst.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInst.ForeColor = System.Drawing.Color.Green;
            this.labelInst.Location = new System.Drawing.Point(10, 488);
            this.labelInst.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInst.Name = "labelInst";
            this.labelInst.Size = new System.Drawing.Size(144, 22);
            this.labelInst.TabIndex = 25;
            this.labelInst.Text = "УЧРЕЖДЕНИЕ";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.ForeColor = System.Drawing.Color.Green;
            this.labelType.Location = new System.Drawing.Point(10, 427);
            this.labelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(50, 22);
            this.labelType.TabIndex = 24;
            this.labelType.Text = "ТИП";
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.ForeColor = System.Drawing.Color.Green;
            this.labelID.Location = new System.Drawing.Point(10, 372);
            this.labelID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 22);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 354);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tBEmId
            // 
            this.tBEmId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBEmId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBEmId.Location = new System.Drawing.Point(14, 569);
            this.tBEmId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tBEmId.Name = "tBEmId";
            this.tBEmId.Size = new System.Drawing.Size(235, 25);
            this.tBEmId.TabIndex = 40;
            this.tBEmId.TextChanged += new System.EventHandler(this.tBEmId_TextChanged);
            // 
            // labelEmId
            // 
            this.labelEmId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEmId.AutoSize = true;
            this.labelEmId.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmId.ForeColor = System.Drawing.Color.Green;
            this.labelEmId.Location = new System.Drawing.Point(10, 543);
            this.labelEmId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmId.Name = "labelEmId";
            this.labelEmId.Size = new System.Drawing.Size(165, 22);
            this.labelEmId.TabIndex = 41;
            this.labelEmId.Text = "ID СОТРУДНИКА";
            // 
            // labelLoadData
            // 
            this.labelLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoadData.AutoSize = true;
            this.labelLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoadData.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoadData.ForeColor = System.Drawing.Color.Green;
            this.labelLoadData.Location = new System.Drawing.Point(941, 357);
            this.labelLoadData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoadData.Name = "labelLoadData";
            this.labelLoadData.Size = new System.Drawing.Size(48, 33);
            this.labelLoadData.TabIndex = 46;
            this.labelLoadData.Text = "🔄";
            this.labelLoadData.Click += new System.EventHandler(this.labelLoadData_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(768, 562);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 32);
            this.btnSearch.TabIndex = 45;
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
            this.btnDel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(768, 514);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(205, 32);
            this.btnDel.TabIndex = 44;
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
            this.btnUp.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(768, 465);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(205, 32);
            this.btnUp.TabIndex = 43;
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
            this.btnIns.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIns.ForeColor = System.Drawing.Color.White;
            this.btnIns.Location = new System.Drawing.Point(768, 417);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(205, 32);
            this.btnIns.TabIndex = 42;
            this.btnIns.Text = "ДОБАВИТЬ";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(280, 543);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "СОТРУДНИК";
            // 
            // tbFIO
            // 
            this.tbFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFIO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbFIO.Enabled = false;
            this.tbFIO.Location = new System.Drawing.Point(284, 569);
            this.tbFIO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(235, 25);
            this.tbFIO.TabIndex = 47;
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.labelLoadData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.labelEmId);
            this.Controls.Add(this.tBEmId);
            this.Controls.Add(this.tBInst);
            this.Controls.Add(this.tBType);
            this.Controls.Add(this.tBid);
            this.Controls.Add(this.labelInst);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EducationForm";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBInst;
        private System.Windows.Forms.TextBox tBType;
        private System.Windows.Forms.TextBox tBid;
        private System.Windows.Forms.Label labelInst;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBEmId;
        private System.Windows.Forms.Label labelEmId;
        private System.Windows.Forms.Label labelLoadData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFIO;
    }
}