
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
            this.tSBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tSBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tSBtnDel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 665);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBtnSearch,
            this.tSBtnAdd,
            this.tSBtnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBtnSearch
            // 
            this.tSBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnSearch.Image")));
            this.tSBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnSearch.Name = "tSBtnSearch";
            this.tSBtnSearch.Size = new System.Drawing.Size(56, 24);
            this.tSBtnSearch.Text = "Поиск";
            // 
            // tSBtnAdd
            // 
            this.tSBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnAdd.Image")));
            this.tSBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnAdd.Name = "tSBtnAdd";
            this.tSBtnAdd.Size = new System.Drawing.Size(80, 24);
            this.tSBtnAdd.Text = "Добавить";
            // 
            // tSBtnDel
            // 
            this.tSBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tSBtnDel.Image")));
            this.tSBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBtnDel.Name = "tSBtnDel";
            this.tSBtnDel.Size = new System.Drawing.Size(69, 24);
            this.tSBtnDel.Text = "Удалить";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 696);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.ToolStripButton tSBtnSearch;
        private System.Windows.Forms.ToolStripButton tSBtnAdd;
        private System.Windows.Forms.ToolStripButton tSBtnDel;
    }
}