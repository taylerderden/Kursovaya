
namespace Kursovaya
{
    partial class SecurityRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityRegForm));
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.buttonRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cBCategory = new System.Windows.Forms.CheckBox();
            this.btnAutoris = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(140, 117);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(372, 28);
            this.Login.TabIndex = 0;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(140, 154);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(372, 28);
            this.Password.TabIndex = 1;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Depth = 0;
            this.buttonRegister.Icon = null;
            this.buttonRegister.Location = new System.Drawing.Point(165, 244);
            this.buttonRegister.MaximumSize = new System.Drawing.Size(333, 36);
            this.buttonRegister.MinimumSize = new System.Drawing.Size(333, 36);
            this.buttonRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Primary = true;
            this.buttonRegister.Size = new System.Drawing.Size(333, 36);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // cBCategory
            // 
            this.cBCategory.AutoSize = true;
            this.cBCategory.Location = new System.Drawing.Point(423, 189);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(89, 26);
            this.cBCategory.TabIndex = 5;
            this.cBCategory.Text = "Админ";
            this.cBCategory.UseVisualStyleBackColor = true;
            // 
            // btnAutoris
            // 
            this.btnAutoris.AutoSize = true;
            this.btnAutoris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAutoris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoris.Depth = 0;
            this.btnAutoris.Icon = null;
            this.btnAutoris.Location = new System.Drawing.Point(165, 295);
            this.btnAutoris.MaximumSize = new System.Drawing.Size(333, 36);
            this.btnAutoris.MinimumSize = new System.Drawing.Size(333, 36);
            this.btnAutoris.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutoris.Name = "btnAutoris";
            this.btnAutoris.Primary = true;
            this.btnAutoris.Size = new System.Drawing.Size(333, 36);
            this.btnAutoris.TabIndex = 6;
            this.btnAutoris.Text = "авторизация";
            this.btnAutoris.UseVisualStyleBackColor = true;
            this.btnAutoris.Click += new System.EventHandler(this.btnAutoris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources._4202111_envato_logo_social_social_media_icon;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SecurityRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAutoris);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecurityRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        Данные для авторизации";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityRegForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRegister;
        private System.Windows.Forms.CheckBox cBCategory;
        private MaterialSkin.Controls.MaterialRaisedButton btnAutoris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}