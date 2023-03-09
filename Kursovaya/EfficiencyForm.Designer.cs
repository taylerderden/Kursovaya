
namespace Kursovaya
{
    partial class EfficiencyForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelectEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCreateChart = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(516, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 71);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Минимум задач за 1 час = 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Формула: Задачи/Часы";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(744, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.AutoSize = true;
            this.btnSelectEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectEmployee.Depth = 0;
            this.btnSelectEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEmployee.Icon = null;
            this.btnSelectEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectEmployee.Location = new System.Drawing.Point(516, 90);
            this.btnSelectEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Primary = true;
            this.btnSelectEmployee.Size = new System.Drawing.Size(222, 36);
            this.btnSelectEmployee.TabIndex = 30;
            this.btnSelectEmployee.Text = "выбрать сотрудника";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 129);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(617, 466);
            this.chart.TabIndex = 31;
            this.chart.Text = "chart1";
            // 
            // btnCreateChart
            // 
            this.btnCreateChart.AutoSize = true;
            this.btnCreateChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateChart.Depth = 0;
            this.btnCreateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateChart.Icon = null;
            this.btnCreateChart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateChart.Location = new System.Drawing.Point(765, 558);
            this.btnCreateChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateChart.Name = "btnCreateChart";
            this.btnCreateChart.Primary = true;
            this.btnCreateChart.Size = new System.Drawing.Size(174, 36);
            this.btnCreateChart.TabIndex = 32;
            this.btnCreateChart.Text = "создать график";
            this.btnCreateChart.UseVisualStyleBackColor = true;
            this.btnCreateChart.Click += new System.EventHandler(this.btnCreateChart_Click);
            // 
            // EfficiencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 607);
            this.Controls.Add(this.btnCreateChart);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnSelectEmployee);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EfficiencyForm";
            this.Text = "EfficiencyForm";
            this.Load += new System.EventHandler(this.EfficiencyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSelectEmployee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreateChart;
    }
}