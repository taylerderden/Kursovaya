using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class SecurityForm : Form
    {
        private MySqlCommandBuilder sqlBuilder = null;

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        private DataSet dataSet = null;

        private bool newRowAdding = false;
        public SecurityForm()
        {
            InitializeComponent();

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
                adapter = new MySqlDataAdapter("SELECT *, 'Delete' AS Действия FROM `Security`", db.getConnection());

                sqlBuilder = new MySqlCommandBuilder(adapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                adapter.Fill(dataSet, "Security");

                dataGridView1.DataSource = dataSet.Tables["Security"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[6, i] = linkCell;
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Security"].Clear();

                adapter.Fill(dataSet, "Security");

                dataGridView1.DataSource = dataSet.Tables["Security"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[6, i] = linkCell;
                }

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SecurityForm_Load(object sender, EventArgs e)
        {
            LoadData();

            dataGridView1.Columns[0].HeaderText = "код_Записи";
            dataGridView1.Columns[1].HeaderText = "Логин";
            dataGridView1.Columns[2].HeaderText = "Пароль";
            dataGridView1.Columns[3].HeaderText = "Категория";
            dataGridView1.Columns[4].HeaderText = "код_Сотрудника";
            dataGridView1.Columns[5].HeaderText = "Подтвержденность учетной записи";

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = false;

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
                if (e.ColumnIndex == 6)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                    if (task == "Delete")
                    {
                        try
                        {
                            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int rowIndex = e.RowIndex;

                                dataGridView1.Rows.RemoveAt(rowIndex);
                                dataSet.Tables["Security"].Rows[rowIndex].Delete();

                                adapter.Update(dataSet, "Security");
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

                        DataRow row = dataSet.Tables["Security"].NewRow();

                        row["idSecurity"] = dataGridView1.Rows[rowIndex].Cells["idSecurity"].Value;
                        row["Security_Login"] = dataGridView1.Rows[rowIndex].Cells["Security_Login"].Value;
                        row["Security_Password"] = dataGridView1.Rows[rowIndex].Cells["Security_Password"].Value;
                        row["Security_Category"] = dataGridView1.Rows[rowIndex].Cells["Security_Category"].Value;
                        row["Employee_idEmployee"] = dataGridView1.Rows[rowIndex].Cells["Employee_idEmployee"].Value;
                        row["Confirmation"] = dataGridView1.Rows[rowIndex].Cells["Confirmation"].Value;

                        dataSet.Tables["Security"].Rows.Add(row);

                        dataSet.Tables["Security"].Rows.RemoveAt(dataSet.Tables["Security"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Delete";

                        adapter.Update(dataSet, "Security");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Security"].Rows[r]["idSecurity"] = dataGridView1.Rows[r].Cells["idSecurity"].Value;
                        dataSet.Tables["Security"].Rows[r]["Security_Login"] = dataGridView1.Rows[r].Cells["Security_Login"].Value;
                        dataSet.Tables["Security"].Rows[r]["Security_Password"] = dataGridView1.Rows[r].Cells["Security_Password"].Value;
                        dataSet.Tables["Security"].Rows[r]["Security_Category"] = dataGridView1.Rows[r].Cells["Security_Category"].Value;
                        dataSet.Tables["Security"].Rows[r]["Employee_idEmployee"] = dataGridView1.Rows[r].Cells["Employee_idEmployee"].Value;
                        dataSet.Tables["Security"].Rows[r]["Confirmation"] = dataGridView1.Rows[r].Cells["Confirmation"].Value;

                        adapter.Update(dataSet, "Security");

                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Delete";
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
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[6, lastRow] = linkCell;

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

                    dataGridView1[6, rowIndex] = linkCell;

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

            if (dataGridView1.CurrentCell.ColumnIndex == 5)         //на месте _5_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                    textBox.MaxLength = 1;
                }
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)        //метод на проверку можно ли в ячейку писать цифру(букву)
        {
            if (e.KeyChar != '+' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
    }
}
