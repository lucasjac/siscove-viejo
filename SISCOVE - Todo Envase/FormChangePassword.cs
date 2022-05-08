using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOVE___Todo_Envase
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxNewPassword.Text != TextBoxCheckPassword.Text)
            {
                MessageBox.Show("Las contraseñas no concuerdan.", "ERROR DE CAMBIO DE CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Password newPassword = new Password();
                    Encrypt newEncrypt = new Encrypt();
                    string EncryptedPassword = newEncrypt.Encryption(TextBoxNewPassword.Text);

                    newPassword.Modify(Convert.ToInt32(TextBox1.Text), EncryptedPassword);
                    MessageBox.Show("Contraseña guardada con éxito.", "CONTRASEÑA GUARDADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clean()
        {
            TextBoxNewPassword.Clear();
            TextBoxCheckPassword.Clear();
        }
    }
}
