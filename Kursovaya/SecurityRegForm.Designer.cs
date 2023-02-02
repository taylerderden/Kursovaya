
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.buttonRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cBCategory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(140, 117);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(372, 28);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(140, 154);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(372, 28);
            this.Password.TabIndex = 1;
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Depth = 0;
            this.buttonRegister.Icon = null;
            this.buttonRegister.Location = new System.Drawing.Point(159, 295);
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
            // SecurityRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 343);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SecurityRegForm";
            this.Text = "Данные для авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRegister;
        private System.Windows.Forms.CheckBox cBCategory;
    }
}