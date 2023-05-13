using MaterialSkin.Controls;
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
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            tbFIO.Text = "Фамилия И.О.";
            tbFIO.ForeColor = Color.Gray;

            tbPhone.Text = "89008007000";
            tbPhone.ForeColor = Color.Gray;
        }
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Employee` WHERE `Employee_Phone` = @Tel", db.getConnection()); //проверка фио введенного пользов-м и указываем БД к которой подключ-ся 
            command.Parameters.Add("@Tel", MySqlDbType.VarChar).Value = tbPhone.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)   //проверка занятости данных, поиск записей в табл
            {
                MessageBox.Show("Данные уже существуют!");
                return true;
            }
            else
                return false;
        }
        string Gen, Pos;

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
            }
            else
            {
                checkBoxFemale.Checked = true;
            }           
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
            }
            else
            {
                checkBoxMale.Checked = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorisationForm aForm = new AutorisationForm(); //если успешна то открытие формы для админа
            aForm.Show();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbFIO_Enter(object sender, EventArgs e)
        {
            if (tbFIO.Text == "Фамилия И.О.")
            {
                tbFIO.Text = "";
            }
        }

        private void tbFIO_Leave(object sender, EventArgs e)
        {
            if (tbFIO.Text == "")
            {
                tbFIO.Text = "Фамилия И.О.";
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "89008007000")
            {
                tbPhone.Text = "";
            }
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPhone.Text = "89008007000";
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text == "" || tbFIO.Text == "Фамилия И.О.") //проверка заполненности
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }
            if (tbPhone.Text == "" || tbPhone.Text == "89008007000") //проверка заполненности
            {
                MessageBox.Show("Введите телефон!");
                return;
            }            
            
            if (checkBoxMale.Checked)
                Gen = "Муж";
            if (checkBoxFemale.Checked)
                Gen = "Жен";

            if(Gen == null)
            {
                MessageBox.Show("Выберите пол!");
                return;
            }

            if (cBExp.Text == "")
            {
                MessageBox.Show("Выберите опыт работы!");
                return;
            }
            if (cBDep.Text == "")
            {
                MessageBox.Show("Выберите отдел!");
                return;
            }

            if (cBPos.Text != "")
            {
                DB db0 = new DB();

                DataTable tableP = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command0 = new MySqlCommand("SELECT `idPosition` FROM `Position` WHERE `Position_Name` = @Pos", db0.getConnection()); 
                command0.Parameters.Add("@Pos", MySqlDbType.VarChar).Value = cBPos.Text;

                adapter.SelectCommand = command0;
                adapter.Fill(tableP);

                db0.openConnection();
                if (tableP.Rows.Count > 0)
                {
                    Pos = command0.ExecuteScalar().ToString();   // извлекаем id
                }
                else
                    MessageBox.Show("Ошибка выбора должности!");
                db0.closeConnection();
            }
            else
                MessageBox.Show("Введите должность!");

            if (isUserExists()) //проверка занятости данных
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Employee` (`Employee_FIO`, `Employee_Gender`, `Employee_Phone`, `Employee_Experience`, `Employee_Department`, `Position_idPosition`) VALUES (@FIO, @Gen, @Tel, @Exp, @Dep, @Pos);", db.getConnection());
                                                                                                                                                                                             
            command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = tbFIO.Text;                                                                                                          
            command.Parameters.Add("@Gen", MySqlDbType.VarChar).Value = Gen;                                                                                                                 
            command.Parameters.Add("@Tel", MySqlDbType.VarChar).Value = tbPhone.Text;                                                                                                        
            command.Parameters.Add("@Exp", MySqlDbType.VarChar).Value = cBExp.SelectedItem;                                                                                                  
            command.Parameters.Add("@Dep", MySqlDbType.VarChar).Value = cBDep.SelectedItem;
            command.Parameters.Add("@Pos", MySqlDbType.VarChar).Value = Pos;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно внесены");

                DataTable tableID = new DataTable();
                MySqlDataAdapter adapterID = new MySqlDataAdapter();

                MySqlCommand commandID = new MySqlCommand("SELECT `idEmployee` FROM `Employee` WHERE `Employee_FIO` = @FIO", db.getConnection()); //
                commandID.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = tbFIO.Text;

                adapterID.SelectCommand = commandID;
                adapterID.Fill(tableID);

                if (tableID.Rows.Count > 0) //поиск записей
                {
                    string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                    Global.GlobalVar = id;
                }
                else
                    MessageBox.Show("Ошибка ID!"); //иначе ошибка

                this.Hide();
                SecurityRegForm secForm = new SecurityRegForm(); //если успешна то открытие формы для админа
                secForm.Show();
            }
            else
                MessageBox.Show("Ошибка внесения данных!");

            db.closeConnection();         
        }
    }
}
