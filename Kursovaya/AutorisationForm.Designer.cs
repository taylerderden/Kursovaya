
namespace Kursovaya
{
    partial class AutorisationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorisationForm));
            this.buttonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.labelCheck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new LollipopTextBox();
            this.Login = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(12, 299);
            this.buttonLogin.MaximumSize = new System.Drawing.Size(333, 36);
            this.buttonLogin.MinimumSize = new System.Drawing.Size(333, 36);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = true;
            this.buttonLogin.Size = new System.Drawing.Size(333, 36);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "вход";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Depth = 0;
            this.buttonRegister.Icon = null;
            this.buttonRegister.Location = new System.Drawing.Point(13, 345);
            this.buttonRegister.MaximumSize = new System.Drawing.Size(333, 36);
            this.buttonRegister.MinimumSize = new System.Drawing.Size(333, 36);
            this.buttonRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Primary = true;
            this.buttonRegister.Size = new System.Drawing.Size(333, 36);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(13, 338);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(334, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // labelCheck
            // 
            this.labelCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCheck.AutoSize = true;
            this.labelCheck.BackColor = System.Drawing.Color.Transparent;
            this.labelCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheck.ForeColor = System.Drawing.Color.DimGray;
            this.labelCheck.Location = new System.Drawing.Point(324, 252);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(22, 24);
            this.labelCheck.TabIndex = 9;
            this.labelCheck.Text = "●";
            this.labelCheck.Click += new System.EventHandler(this.labelCheck_Click);
            this.labelCheck.DoubleClick += new System.EventHandler(this.labelCheck_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(50, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Human Capital Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources._4202111_envato_logo_social_social_media_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(127, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.FocusedColor = "Green";
            this.Password.FontColor = "#999999";
            this.Password.IsEnabled = true;
            this.Password.Location = new System.Drawing.Point(13, 252);
            this.Password.MaximumSize = new System.Drawing.Size(334, 24);
            this.Password.MaxLength = 32767;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.ReadOnly = false;
            this.Password.Size = new System.Drawing.Size(334, 24);
            this.Password.TabIndex = 6;
            this.Password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.UseSystemPasswordChar = false;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Login
            // 
            this.Login.FocusedColor = "Green";
            this.Login.FontColor = "#999999";
            this.Login.IsEnabled = true;
            this.Login.Location = new System.Drawing.Point(12, 222);
            this.Login.MaximumSize = new System.Drawing.Size(334, 24);
            this.Login.MaxLength = 32767;
            this.Login.Multiline = false;
            this.Login.Name = "Login";
            this.Login.ReadOnly = false;
            this.Login.Size = new System.Drawing.Size(334, 24);
            this.Login.TabIndex = 5;
            this.Login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Login.UseSystemPasswordChar = false;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(360, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 390);
            this.Name = "AutorisationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton buttonLogin;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRegister;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private LollipopTextBox Login;
        private LollipopTextBox Password;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}