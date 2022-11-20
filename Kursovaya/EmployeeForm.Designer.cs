
namespace Kursovaya
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnReload = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBack = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 309);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnReload,
            this.tsBtnBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnReload
            // 
            this.tsBtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnReload.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsBtnReload.ForeColor = System.Drawing.Color.Silver;
            this.tsBtnReload.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReload.Image")));
            this.tsBtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReload.Name = "tsBtnReload";
            this.tsBtnReload.Size = new System.Drawing.Size(43, 36);
            this.tsBtnReload.Text = "🗘";
            this.tsBtnReload.Click += new System.EventHandler(this.tsBtnReload_Click);
            this.tsBtnReload.MouseEnter += new System.EventHandler(this.tsBtnReload_MouseEnter);
            this.tsBtnReload.MouseLeave += new System.EventHandler(this.tsBtnReload_MouseLeave);
            // 
            // tsBtnBack
            // 
            this.tsBtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBack.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.tsBtnBack.ForeColor = System.Drawing.Color.Silver;
            this.tsBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBack.Image")));
            this.tsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBack.Margin = new System.Windows.Forms.Padding(1070, 1, 0, 2);
            this.tsBtnBack.Name = "tsBtnBack";
            this.tsBtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsBtnBack.Size = new System.Drawing.Size(40, 36);
            this.tsBtnBack.Text = "→";
            this.tsBtnBack.Click += new System.EventHandler(this.tsBtnBack_Click);
            this.tsBtnBack.MouseEnter += new System.EventHandler(this.tsBtnBack_MouseEnter);
            this.tsBtnBack.MouseLeave += new System.EventHandler(this.tsBtnBack_MouseLeave);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1157, 346);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnReload;
        private System.Windows.Forms.ToolStripButton tsBtnBack;
    }
}