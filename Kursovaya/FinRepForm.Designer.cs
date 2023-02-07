
namespace Kursovaya
{
    partial class FinRepForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBsum1 = new System.Windows.Forms.TextBox();
            this.tBsum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cBPerson = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Green;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(672, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 25);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "ПОИСК";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "от:";
            // 
            // tBsum1
            // 
            this.tBsum1.Location = new System.Drawing.Point(42, 12);
            this.tBsum1.Name = "tBsum1";
            this.tBsum1.Size = new System.Drawing.Size(133, 25);
            this.tBsum1.TabIndex = 2;
            // 
            // tBsum2
            // 
            this.tBsum2.Location = new System.Drawing.Point(219, 12);
            this.tBsum2.Name = "tBsum2";
            this.tBsum2.Size = new System.Drawing.Size(133, 25);
            this.tBsum2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "до:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 549);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(807, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 25);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "ПЕЧАТЬ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cBPerson
            // 
            this.cBPerson.FormattingEnabled = true;
            this.cBPerson.Items.AddRange(new object[] {
            "Антиповский Л.С."});
            this.cBPerson.Location = new System.Drawing.Point(465, 12);
            this.cBPerson.Name = "cBPerson";
            this.cBPerson.Size = new System.Drawing.Size(188, 25);
            this.cBPerson.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "сотрудник:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(209)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.cBPerson);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBsum2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBsum1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 48);
            this.panel1.TabIndex = 9;
            // 
            // FinRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinRepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinRepForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBsum1;
        private System.Windows.Forms.TextBox tBsum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cBPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}