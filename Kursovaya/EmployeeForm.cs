using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class EmployeeForm : System.Windows.Forms.Form
    {
  
        private MySqlCommandBuilder sqlBuilder = null;        

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        public EmployeeForm()
        {
            InitializeComponent();

            tBsearch.MaxLength = 25;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void LoadData()
        {
            DB db = new DB();
            try
            {
                adapter = new MySqlDataAdapter("SELECT *, 'Delete' AS Действия FROM `Employee`", db.getConnection());
                                                             
                sqlBuilder = new MySqlCommandBuilder(adapter);
                
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand(); 
                
                dataSet = new DataSet();

                adapter.Fill(dataSet, "Employee");

                dataGridView1.DataSource = dataSet.Tables["Employee"];
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }
            }
            catch(Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Employee"].Clear();

                adapter.Fill(dataSet, "Employee");

                dataGridView1.DataSource = dataSet.Tables["Employee"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {          
            LoadData();

            dataGridView1.Columns[0].HeaderText = "код_Сотрудника";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Пол";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Стаж";
            dataGridView1.Columns[5].HeaderText = "Отдел";
            dataGridView1.Columns[6].HeaderText = "код_Должности";

            ReloadData();          
        }

        private void tsBtnReload_Click(object sender, EventArgs e)
        {        
            ReloadData();           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                    if (task == "Delete")
                    {
                        try
                        {
                            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int rowIndex = e.RowIndex;

                                dataGridView1.Rows.RemoveAt(rowIndex);
                                dataSet.Tables["Employee"].Rows[rowIndex].Delete();

                                adapter.Update(dataSet, "Employee");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Удалите данные из дочерних таблиц!");
                        }
                            
                    }                   
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Employee"].NewRow();

                        row["idEmployee"] = dataGridView1.Rows[rowIndex].Cells["idEmployee"].Value;
                        row["Employee_FIO"] = dataGridView1.Rows[rowIndex].Cells["Employee_FIO"].Value;
                        row["Employee_Gender"] = dataGridView1.Rows[rowIndex].Cells["Employee_Gender"].Value;
                        row["Employee_Phone"] = dataGridView1.Rows[rowIndex].Cells["Employee_Phone"].Value;
                        row["Employee_Experience"] = dataGridView1.Rows[rowIndex].Cells["Employee_Experience"].Value;
                        row["Employee_Department"] = dataGridView1.Rows[rowIndex].Cells["Employee_Department"].Value;
                        row["Position_idPosition"] = dataGridView1.Rows[rowIndex].Cells["Position_idPosition"].Value;

                        dataSet.Tables["Employee"].Rows.Add(row);

                        dataSet.Tables["Employee"].Rows.RemoveAt(dataSet.Tables["Employee"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[7].Value = "Delete";

                        adapter.Update(dataSet, "Employee");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Employee"].Rows[r]["idEmployee"] = dataGridView1.Rows[r].Cells["idEmployee"].Value;
                        dataSet.Tables["Employee"].Rows[r]["Employee_FIO"] = dataGridView1.Rows[r].Cells["Employee_FIO"].Value;
                        dataSet.Tables["Employee"].Rows[r]["Employee_Gender"] = dataGridView1.Rows[r].Cells["Employee_Gender"].Value;
                        dataSet.Tables["Employee"].Rows[r]["Employee_Phone"] = dataGridView1.Rows[r].Cells["Employee_Phone"].Value;
                        dataSet.Tables["Employee"].Rows[r]["Employee_Experience"] = dataGridView1.Rows[r].Cells["Employee_Experience"].Value;
                        dataSet.Tables["Employee"].Rows[r]["Employee_Department"] = dataGridView1.Rows[r].Cells["Employee_Department"].Value;
                        dataSet.Tables["Employee"].Rows[r]["Position_idPosition"] = dataGridView1.Rows[r].Cells["Position_idPosition"].Value;

                        adapter.Update(dataSet, "Employee");

                        dataGridView1.Rows[e.RowIndex].Cells[7].Value = "Delete";
                    }

                    ReloadData();
                }
                
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if(newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, lastRow] = linkCell;

                    row.Cells["Действия"].Value = "Insert";

                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, rowIndex] = linkCell;

                    editingRow.Cells["Действия"].Value = "Update";
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dataGridView1.CurrentCell.ColumnIndex == 0)         //на месте _3_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 3)         //на месте _3_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if(textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
            
            if (dataGridView1.CurrentCell.ColumnIndex == 6)         //на месте _6_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)        //метод на проверку можно ли в ячейку писать цифру(букву)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT *, 'Delete' AS Действия FROM Employee WHERE CONCAT(`idEmployee`, `Employee_FIO`, `Employee_Gender`, `Employee_Phone`, `Employee_Experience`, `Employee_Department`, `Position_idPosition`)like '%" + tBsearch.Text +"%'", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "код_Сотрудника";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Пол";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Стаж";
            dataGridView1.Columns[5].HeaderText = "Отдел";
            dataGridView1.Columns[6].HeaderText = "код_Должности";

            sqlBuilder = new MySqlCommandBuilder(adapter);

            sqlBuilder.GetInsertCommand();
            sqlBuilder.GetUpdateCommand();
            sqlBuilder.GetDeleteCommand();

            dataSet = new DataSet();

            adapter.Fill(dataSet, "Employee");

            dataGridView1.DataSource = dataSet.Tables["Employee"];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                dataGridView1[7, i] = linkCell;
            }

        }
    }
}
