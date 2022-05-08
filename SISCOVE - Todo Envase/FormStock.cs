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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            if (GroupBoxSearch.Visible == true)
            {
                GroupBoxSearch.Visible = false;
                GroupBoxCalculation.Visible = true; 
            }
            else
            {
                GroupBoxSearch.Visible = true;
                GroupBoxCalculation.Visible = false;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                Stock newStock = new Stock();
                if (TextBoxCode.Text == "0")
                {
                    for (int i = 0; i < 1; i++)
                    {
                        newStock.Save(Convert.ToInt32(TextBoxCode.Text), TextBoxProduct.Text, Convert.ToInt32(TextBoxPrice1.Text), Convert.ToInt32(TextBoxPrice2.Text), Convert.ToInt32(TextBoxPrice3.Text), Convert.ToInt32(NumericUpDownQuantity.Value), Convert.ToInt32(NumericUpDownWarning.Value)); 
                    }
                    MessageBox.Show("Producto guardado con éxito!", "REGISTRO DE PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    newStock.Modify(Convert.ToInt32(TextBoxCode.Text), TextBoxProduct.Text, Convert.ToInt32(TextBoxPrice1.Text), Convert.ToInt32(TextBoxPrice2.Text), Convert.ToInt32(TextBoxPrice3.Text), Convert.ToInt32(NumericUpDownQuantity.Value), Convert.ToInt32(NumericUpDownWarning.Value));
                    MessageBox.Show("Producto modificado con éxito!", "REGISTRO DE PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (ComboBoxOrder.Text == "Por abecedario")
                {
                    DataGridViewStock.DataSource = newStock.ToList();
                }
                else
                {
                    DataGridViewStock.DataSource = newStock.ToList2();
                }
                Style();
                ToListProducts();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            ToListStock();
            ToListProducts();
            ComboBoxOrder.SelectedIndex = 0;
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewStock.Rows.Count; i += 2)
            {
                DataGridViewStock.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void ToListStock()
        {
            Stock newStock = new Stock();
            DataGridViewStock.DataSource = newStock.ToList();
            Style();
            for (int i = 0; i < DataGridViewStock.Columns.Count; i++)
            {
                DataGridViewStock.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            TextBoxCode.Text = "0";
            TextBoxProduct.Clear();
            TextBoxPrice1.Text = "0";
            TextBoxPrice2.Text = "0";
            TextBoxPrice3.Text = "0";
            NumericUpDownQuantity.Value = 0;
            NumericUpDownWarning.Value = 0;
        }

        private void DataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGridViewStock.Columns[e.ColumnIndex].Name == "Editar")
                {
                    TextBoxCode.Text = DataGridViewStock.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    TextBoxProduct.Text = DataGridViewStock.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    TextBoxPrice1.Text = DataGridViewStock.Rows[e.RowIndex].Cells["Precio1"].Value.ToString();
                    TextBoxPrice2.Text = DataGridViewStock.Rows[e.RowIndex].Cells["Precio2"].Value.ToString();
                    TextBoxPrice3.Text = DataGridViewStock.Rows[e.RowIndex].Cells["Precio3"].Value.ToString();
                    NumericUpDownQuantity.Value = Convert.ToDecimal(DataGridViewStock.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    NumericUpDownWarning.Value = Convert.ToDecimal(DataGridViewStock.Rows[e.RowIndex].Cells["Advertencia"].Value.ToString());
                }
                else
                {
                    if (DataGridViewStock.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Desea eliminar este producto?", "ELIMINAR PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Stock newStock = new Stock();

                            newStock.Delete(Convert.ToInt32(DataGridViewStock.Rows[e.RowIndex].Cells["Codigo"].Value));
                            MessageBox.Show("Producto eliminado con éxito!", "ELIMINAR PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListStock();
                            ToListProducts();
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

        private void ToListProducts()
        {
            try
            {
                for (int i = 0; i < DataGridViewStock.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DataGridViewStock.Rows[i].Cells["Cantidad"].Value) <= Convert.ToDecimal(DataGridViewStock.Rows[i].Cells["Advertencia"].Value))
                    {
                        DataGridViewStock.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }

        }

        private void Validate()
        {
            int sw = 0;
            int i = 0;
            while (i < DataGridViewStock.Rows.Count && sw == 0)
            {
                if (DataGridViewStock.Rows[i].Cells["Producto"].Value.ToString() == TextBoxProduct.Text && DataGridViewStock.Rows[i].Cells["Codigo"].Value.ToString() != TextBoxCode.Text)
                {
                    sw = 1;
                }
                i++;
            }
            if (sw == 1)
            {
                throw new Exception("Ya existe un producto con este nombre!");
            }
            if (TextBoxProduct.Text.Trim().Length == 0)
            {
                throw new Exception("El nombre del producto no fue establecido!");
            }

            if (TextBoxPrice1.Text.Trim().Length == 0)
            {
                throw new Exception("El precio 1 del producto no fue establecido!");
            }

            if (TextBoxPrice2.Text.Trim().Length == 0)
            {
                throw new Exception("El precio 2 del producto no fue establecido!");
            }

            if (TextBoxPrice3.Text.Trim().Length == 0)
            {
                throw new Exception("El precio 3 del producto no fue establecido!");
            }

            if (NumericUpDownQuantity.Value < 0)
            {
                throw new Exception("La cantidad establecida no es válida!");
            }

            if (NumericUpDownWarning.Value < 0)
            {
                throw new Exception("No pueden existir números negativos!");
            }
        }

        private void ButtonCounter_Click(object sender, EventArgs e)
        {
            if (TextBoxCounter.Visible == false)
            {
                TextBoxCounter.Text = Convert.ToString(DataGridViewStock.Rows.Count);
                TextBoxCounter.Visible = true;
            }
            else
            {
                TextBoxCounter.Clear();
                TextBoxCounter.Visible = false;
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Stock newStock = new Stock();
                if (ComboBoxOrder.Text == "Por abecedario")
                {
                    DataGridViewStock.DataSource = newStock.Search(TextBoxSearch.Text);
                }
                else
                {
                    DataGridViewStock.DataSource = newStock.Search2(TextBoxSearch.Text);
                }
                Style();
                ToListProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stock newStock = new Stock();
            if (ComboBoxOrder.Text == "Por abecedario" && TextBoxSearch.Text == "")
            {
                DataGridViewStock.DataSource = newStock.ToList();
            }
            else
            {
                if (ComboBoxOrder.Text == "Por cantidad" && TextBoxSearch.Text == "")
                {
                    DataGridViewStock.DataSource = newStock.ToList2();
                }
                else
                {
                    if(ComboBoxOrder.Text == "Por abecedario")
                    {
                        DataGridViewStock.DataSource = newStock.Search(TextBoxSearch.Text);
                    }
                    else
                    {
                        DataGridViewStock.DataSource = newStock.Search2(TextBoxSearch.Text);
                    }
                }
            }

            for (int i = 0; i < DataGridViewStock.Columns.Count; i++)
            {
                DataGridViewStock.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            Style();
            ToListProducts();
        }

        private void FormStock_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
