namespace SISCOVE___Todo_Envase
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.CheckBoxPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(120, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(188, 21);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Ingresar contraseña:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(120, 59);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(188, 23);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnter.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton14;
            this.ButtonEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEnter.Location = new System.Drawing.Point(222, 147);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonEnter.Size = new System.Drawing.Size(90, 32);
            this.ButtonEnter.TabIndex = 3;
            this.ButtonEnter.Text = "Entrar";
            this.ButtonEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton15;
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(12, 147);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonExit.Size = new System.Drawing.Size(90, 32);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Salir";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // PictureBoxLogin
            // 
            this.PictureBoxLogin.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Icon2;
            this.PictureBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxLogin.Name = "PictureBoxLogin";
            this.PictureBoxLogin.Size = new System.Drawing.Size(102, 99);
            this.PictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogin.TabIndex = 0;
            this.PictureBoxLogin.TabStop = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(151, 156);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(25, 23);
            this.TextBox1.TabIndex = 8;
            this.TextBox1.TabStop = false;
            this.TextBox1.Text = "0";
            this.TextBox1.Visible = false;
            // 
            // CheckBoxPassword
            // 
            this.CheckBoxPassword.AutoSize = true;
            this.CheckBoxPassword.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxPassword.Location = new System.Drawing.Point(169, 88);
            this.CheckBoxPassword.Name = "CheckBoxPassword";
            this.CheckBoxPassword.Size = new System.Drawing.Size(143, 18);
            this.CheckBoxPassword.TabIndex = 2;
            this.CheckBoxPassword.Text = "Visualizar contraseña.";
            this.CheckBoxPassword.UseVisualStyleBackColor = true;
            this.CheckBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 191);
            this.Controls.Add(this.CheckBoxPassword);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.PictureBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogin;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.CheckBox CheckBoxPassword;
    }
}