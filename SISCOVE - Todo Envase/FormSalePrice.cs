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
    public partial class FormSalePrice : Form
    {

        public FormSalePrice()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                MaskedTextBoxPrice1.ReadOnly = false;
                NumericUpDownPrice.ReadOnly = false;
                MaskedTextBoxPrice2.ReadOnly = true;
                ButtonEqual.Enabled = true;
                Label1.ForeColor = Color.Black;
                Label2.ForeColor = Color.Black;
                Label3.ForeColor = Color.Black;
                Label4.ForeColor = Color.LightGray;
                MaskedTextBoxPrice2.Text = "";
            }
            else
            {
                MaskedTextBoxPrice1.ReadOnly = true;
                NumericUpDownPrice.ReadOnly = true;
                MaskedTextBoxPrice2.ReadOnly = false;
                ButtonEqual.Enabled = false;
                Label1.ForeColor = Color.LightGray;
                Label2.ForeColor = Color.LightGray;
                Label3.ForeColor = Color.LightGray;
                Label4.ForeColor = Color.Black;
                NumericUpDownPrice.Value = 0;
                MaskedTextBoxPrice1.Text = "";
                TextBoxResult.Text = "";
            }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (MaskedTextBoxPrice1.Text != "" && NumericUpDownPrice.Value > 0)
            {
                decimal percentage;

                percentage = Convert.ToDecimal(MaskedTextBoxPrice1.Text) * Convert.ToDecimal(NumericUpDownPrice.Value) / 100;
                decimal result = Convert.ToDecimal(MaskedTextBoxPrice1.Text) + percentage;

                TextBoxResult.Text = Convert.ToString(result);
            }
            else
            {
                if (MaskedTextBoxPrice1.Text == "")
                {
                    MessageBox.Show("El PRECIO DE COSTO no fue establecido.", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (NumericUpDownPrice.Value == 0)
                {
                    MessageBox.Show("El PORCENTAJE no fue establecido.", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (RadioButton1.Checked && TextBoxResult.Text != "")
            {
                Close();
            }
            else if (RadioButton2.Checked && MaskedTextBoxPrice2.Text != "")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Valor no encontrado.", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
