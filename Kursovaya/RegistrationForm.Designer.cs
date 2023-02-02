
namespace Kursovaya
{
    partial class RegistrationForm
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
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.cBExp = new System.Windows.Forms.ComboBox();
            this.cBDep = new System.Windows.Forms.ComboBox();
            this.cBPos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonReg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(208, 115);
            this.tbFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(641, 28);
            this.tbFIO.TabIndex = 0;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(208, 151);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(468, 28);
            this.tbPhone.TabIndex = 2;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxMale.Location = new System.Drawing.Point(743, 151);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(51, 29);
            this.checkBoxMale.TabIndex = 8;
            this.checkBoxMale.Text = "♂️";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxFemale.Location = new System.Drawing.Point(801, 151);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(48, 29);
            this.checkBoxFemale.TabIndex = 9;
            this.checkBoxFemale.Text = "♀";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // cBExp
            // 
            this.cBExp.FormattingEnabled = true;
            this.cBExp.Items.AddRange(new object[] {
            "1 год",
            "2 года",
            "3 года",
            "4 года",
            "5 и более лет"});
            this.cBExp.Location = new System.Drawing.Point(208, 187);
            this.cBExp.Name = "cBExp";
            this.cBExp.Size = new System.Drawing.Size(105, 29);
            this.cBExp.TabIndex = 10;
            // 
            // cBDep
            // 
            this.cBDep.FormattingEnabled = true;
            this.cBDep.Items.AddRange(new object[] {
            "Управленческий",
            "Бухгалтерский",
            "Кадровый",
            "Внедрения",
            "Клиентский",
            "Технический",
            "Хозяйственный"});
            this.cBDep.Location = new System.Drawing.Point(401, 187);
            this.cBDep.Name = "cBDep";
            this.cBDep.Size = new System.Drawing.Size(160, 29);
            this.cBDep.TabIndex = 11;
            // 
            // cBPos
            // 
            this.cBPos.FormattingEnabled = true;
            this.cBPos.Items.AddRange(new object[] {
            "Директор",
            "Бухгалтер",
            "Программист",
            "Оператор",
            "Руководитель",
            "Зам.директора",
            "Менеджер",
            "HR-специалист",
            "Сисадмин",
            "Уборщик",
            "Секретарь",
            "Охранник"});
            this.cBPos.Location = new System.Drawing.Point(696, 187);
            this.cBPos.Name = "cBPos";
            this.cBPos.Size = new System.Drawing.Size(153, 29);
            this.cBPos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Тел:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(682, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(140, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Стаж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(319, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Отдел:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(567, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Должность:";
            // 
            // buttonReg
            // 
            this.buttonReg.AutoSize = true;
            this.buttonReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Depth = 0;
            this.buttonReg.Icon = null;
            this.buttonReg.Location = new System.Drawing.Point(948, 270);
            this.buttonReg.MaximumSize = new System.Drawing.Size(333, 36);
            this.buttonReg.MinimumSize = new System.Drawing.Size(37, 36);
            this.buttonReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Primary = true;
            this.buttonReg.Size = new System.Drawing.Size(40, 36);
            this.buttonReg.TabIndex = 19;
            this.buttonReg.Text = "→";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Depth = 0;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(12, 270);
            this.btnBack.MaximumSize = new System.Drawing.Size(333, 36);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(40, 36);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources._4202111_envato_logo_social_social_media_icon;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBPos);
            this.Controls.Add(this.cBDep);
            this.Controls.Add(this.cBExp);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFIO);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistrationForm";
            this.Text = "        Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.ComboBox cBExp;
        private System.Windows.Forms.ComboBox cBDep;
        private System.Windows.Forms.ComboBox cBPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton buttonReg;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}