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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewCustomers.Rows.Count; i+= 2)
            {
                DataGridViewCustomers.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void ToListCustomers()
        {
            Customers newCustomer = new Customers();
            DataGridViewCustomers.DataSource = newCustomer.ToList();
            Style();
            for (int i = 0; i < DataGridViewCustomers.Columns.Count; i++)
            {
                DataGridViewCustomers.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            ToListCustomers();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                Customers newCustomer = new Customers();
                if (TextBoxCode.Text == "0")
                {
                    newCustomer.Save(TextBoxName.Text, MaskedTextBoxTel1.Text, MaskedTextBoxTel2.Text, MaskedTextBoxTel3.Text, MaskedTextBoxRUC.Text);
                    MessageBox.Show("Cliente registrado con éxito!", "REGISTRO DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    newCustomer.Modify(Convert.ToInt32(TextBoxCode.Text), TextBoxName.Text, MaskedTextBoxTel1.Text, MaskedTextBoxTel2.Text, MaskedTextBoxTel3.Text, MaskedTextBoxRUC.Text);
                    MessageBox.Show("Registro modificado con éxito!", "REGISTRO DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ToListCustomers();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clean()
        {
            TextBoxCode.Text = "0";
            TextBoxName.Clear();
            MaskedTextBoxTel1.Clear();
            MaskedTextBoxTel2.Clear();
            MaskedTextBoxTel3.Clear();
            MaskedTextBoxRUC.Clear();
            TextBoxSearch.Clear();

        }

        private void DataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGridViewCustomers.Columns[e.ColumnIndex].Name == "Editar")
                {
                    TextBoxCode.Text = DataGridViewCustomers.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    TextBoxName.Text = DataGridViewCustomers.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    MaskedTextBoxTel1.Text = DataGridViewCustomers.Rows[e.RowIndex].Cells["Tel1"].Value.ToString();
                    MaskedTextBoxTel2.Text = DataGridViewCustomers.Rows[e.RowIndex].Cells["Tel2"].Value.ToString();
                    MaskedTextBoxTel3.Text = DataGridViewCustomers.Rows[e.RowIndex].Cells["Tel3"].Value.ToString();
                    MaskedTextBoxRUC.Text = DataGridViewCustomers.Rows[e.RowIndex].Cells["RUC"].Value.ToString();
                }
                else 
                {
                    if (DataGridViewCustomers.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Desea eliminar a este cliente?", "ELIMINAR CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Customers newCustomer = new Customers();

                            newCustomer.Delete(Convert.ToInt32(DataGridViewCustomers.Rows[e.RowIndex].Cells["Codigo"].Value));
                            MessageBox.Show("Cliente eliminado con éxito!", "ELIMINAR CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListCustomers();
                            Clean();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Customers newCustomer = new Customers();
                DataGridViewCustomers.DataSource = newCustomer.Search(TextBoxSearch.Text);
                Style();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Validate()
        {
            int sw = 0;
            int i = 0;
            while (i < DataGridViewCustomers.Rows.Count && sw == 0 && DataGridViewCustomers.Rows[i].Cells["Codigo"].Value.ToString() != TextBoxCode.Text)
            {
                if (DataGridViewCustomers.Rows[i].Cells["Cliente"].Value.ToString() == TextBoxName.Text)
                {
                    sw = 1;
                }
                i++;
            }
            if (sw == 1)
            {
                throw new Exception("Ya existe un cliente con este nombre!");
            }
            if (TextBoxName.Text.Trim().Length == 0)
            {
                throw new Exception("El nombre no fue establecido!");
            }
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            if(GroupBoxCalculation.Visible == false)
            {
                GroupBoxCalculation.Visible = true;
                MaskedTextBoxRUC.Visible = false;
                TextBoxName.Visible = false;
            }
            else
            {
                GroupBoxCalculation.Visible = false;
                MaskedTextBoxRUC.Visible = true;
                TextBoxName.Visible = true;
            }
        }

        private void ButtonCounter_Click(object sender, EventArgs e)
        {
            if(TextBoxCounter.Visible == false)
            {
                TextBoxCounter.Text = Convert.ToString(DataGridViewCustomers.Rows.Count);
                TextBoxCounter.Visible = true;
            }
            else
            {
                TextBoxCounter.Clear();
                TextBoxCounter.Visible = false;
            }
        }
    }
}
