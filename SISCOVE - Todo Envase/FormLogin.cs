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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Password newPassword = new Password();
                DataTable TableData = new DataTable();
                Encrypt newEncrypt = new Encrypt();
                string EncryptedPassword = newEncrypt.Encryption(TextBoxPassword.Text);

                TableData = newPassword.Login(Convert.ToInt32(TextBox1.Text), EncryptedPassword);

                if (TableData.Rows.Count == 0)
                {
                    MessageBox.Show("Contraseña incorrecta!", "ERROR DE LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPassword.Checked == false)
            {
                TextBoxPassword.PasswordChar = '*';
            }
            else
            {
                TextBoxPassword.PasswordChar = '\0';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                ButtonEnter_Click(sender, e);
            }
        }
    }
}
