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
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            ToListProducts();
            ToListSales();
        }

        private void ToListProducts()
        {
            try
            {
                Stock newStock = new Stock();

                ComboBoxProduct.DataSource = newStock.ToList();
                ComboBoxProduct.DisplayMember = "PRODUCT";
                ComboBoxProduct.ValueMember = "ID_STOCK";
                ComboBoxProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Stock newStock = new Stock();
                Sales newSale = new Sales();
                Validate();
                DateTime Date = DateTimePicker.Value.Date;
                int F = 0;

                if (CheckBoxF.Checked == true)
                {
                    F = 1;
                }
                else
                {
                    F = 0;
                }

                if (TextBoxCode.Text == "0")
                {
                    try
                    {
                        int StockProduct = newStock.ReturnStock(Convert.ToInt32(ComboBoxProduct.SelectedValue));

                        if (NumericUpDownQuantity.Value > StockProduct)
                        {
                            MessageBox.Show("Cantidad insuficiente para la venta.", "CANTIDAD INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            newSale.Save(Convert.ToInt32(TextBoxCode.Text), Convert.ToInt32(ComboBoxProduct.SelectedValue), Convert.ToInt32(NumericUpDownQuantity.Text), Date, F, Convert.ToInt32(ComboBoxPrice.Text));
                            int UpdateQuantity = StockProduct - Convert.ToInt32(NumericUpDownQuantity.Value);
                            newStock.UpdateStock(Convert.ToInt32(ComboBoxProduct.SelectedValue), UpdateQuantity);
                            MessageBox.Show("Venta guardada con éxito!", "REGISTRO DE VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListSales();
                            ToListProducts();
                            Clean();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    int QuantitySale = newSale.ReturnSale(Convert.ToInt32(TextBoxCode.Text));
                    int StockProduct = newStock.ReturnStock(Convert.ToInt32(ComboBoxProduct.SelectedValue));
                    int FinalQuantity = Convert.ToInt32(NumericUpDownQuantity.Value) - QuantitySale;

                    if (FinalQuantity > StockProduct)
                    {
                        throw new Exception("Cantidad insuficiente para la venta.");
                    }
                    else
                    {
                        newSale.Modify(Convert.ToInt32(TextBoxCode.Text), Convert.ToInt32(ComboBoxProduct.SelectedValue), Convert.ToInt32(NumericUpDownQuantity.Text), Date, F, Convert.ToInt32(ComboBoxPrice.Text));
                        int UpdateQuantity = StockProduct - FinalQuantity;
                        newStock.UpdateStock(Convert.ToInt32(ComboBoxProduct.SelectedValue), UpdateQuantity);
                        MessageBox.Show("Venta modificada con éxito!", "REGISTRO DE VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListSales();
                        ToListProducts();
                        Clean();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clean()
        {
            TextBoxCode.Text = "0";
            ComboBoxProduct.SelectedIndex = -1;
            ComboBoxPrice.Items.Clear();
            ComboBoxPrice.Text = "";
            NumericUpDownQuantity.Value = 0;
            DateTimePicker.Value = DateTime.Today;
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewSales1.Rows.Count; i += 2)
            {
                DataGridViewSales1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            for (int i = 0; i < DataGridViewSales2.Rows.Count; i += 2)
            {
                DataGridViewSales2.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void ToListSales()
        {
            Sales newSale = new Sales();
            DataGridViewSales2.DataSource = newSale.ToList();
            Style();
            for (int i = 0; i < DataGridViewSales2.Rows.Count; i++)
            {
                DataGridViewSales2.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["Precio"].Value);
                if (Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["refF"].Value) == 1)
                {
                    DataGridViewSales2.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                }
                else
                {
                    DataGridViewSales2.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                }
            }
            for (int i = 0; i < DataGridViewSales2.Columns.Count; i++)
            {
                DataGridViewSales2.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Sales newSale = new Sales();
                if (ComboBoxProduct1.SelectedIndex == -1)
                {
                    DataGridViewSales2.DataSource = newSale.SearchRecords2(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date);
                    Style();
                    for (int i = 0; i < DataGridViewSales2.Rows.Count; i++)
                    {
                        DataGridViewSales2.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["Precio"].Value);
                        if (Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["refF"].Value) == 1)
                        {
                            DataGridViewSales2.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DataGridViewSales2.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                        }
                    }
                }
                else
                {
                    DataGridViewSales2.DataSource = newSale.SearchRecords(ComboBoxProduct1.Text, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date);
                    Style();
                    for (int i = 0; i < DataGridViewSales2.Rows.Count; i++)
                    {
                        DataGridViewSales2.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["Precio"].Value);
                        if (Convert.ToInt32(DataGridViewSales2.Rows[i].Cells["refF"].Value) == 1)
                        {
                            DataGridViewSales2.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DataGridViewSales2.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGridViewSales2.Columns[e.ColumnIndex].Name == "Editar")
                {
                    TextBoxCode.Text = DataGridViewSales2.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    ComboBoxProduct.Text = DataGridViewSales2.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    NumericUpDownQuantity.Value = Convert.ToInt32(DataGridViewSales2.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    ComboBoxPrice.Text = DataGridViewSales2.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                    DateTimePicker.Value = Convert.ToDateTime(DataGridViewSales2.Rows[e.RowIndex].Cells["Fecha"].Value.ToString());
                    if (Convert.ToDecimal(DataGridViewSales2.Rows[e.RowIndex].Cells["refF"].Value) == 1)
                    {
                        CheckBoxF.Checked = true;
                    }
                    else
                    {
                        CheckBoxF.Checked = false;
                    }
                }
                else
                {
                    if (DataGridViewSales2.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Desea eliminar esta venta?", "ELIMINAR VENTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Sales newSale = new Sales();

                            newSale.Delete(Convert.ToInt32(DataGridViewSales2.Rows[e.RowIndex].Cells["Codigo"].Value));
                            MessageBox.Show("Venta eliminada con éxito!", "ELIMINAR VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListSales();
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

        private void Validate()
        {
            if (ComboBoxProduct.SelectedIndex == -1)
            {
                throw new Exception("El nombre del producto no fue establecido!");
            }

            if (NumericUpDownQuantity.Value == 0)
            {
                throw new Exception("La cantidad no fue establecida!");
            }

            if (ComboBoxPrice.Text.Trim().Length == 0)
            {
                throw new Exception("El precio de la venta no fue establecido!");
            }
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchPrice1()
        {
            try
            {
                Stock newStock = new Stock();

                int PriceSale = newStock.ReturnPrice1(Convert.ToInt32(ComboBoxProduct.SelectedValue));
                ComboBoxPrice.Items.Add(Convert.ToString(PriceSale));
                ComboBoxPrice.Text = Convert.ToString(PriceSale);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ningun precio establecido de este producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice2()
        {
            try
            {
                Stock newStock = new Stock();

                int PriceSale = newStock.ReturnPrice2(Convert.ToInt32(ComboBoxProduct.SelectedValue));
                ComboBoxPrice.Items.Add(Convert.ToString(PriceSale));
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ningun precio establecido de este producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice3()
        {
            try
            {
                Stock newStock = new Stock();

                int PriceSale = newStock.ReturnPrice3(Convert.ToInt32(ComboBoxProduct.SelectedValue));
                ComboBoxPrice.Items.Add(Convert.ToString(PriceSale));
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ningun precio establecido de este producto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProduct.SelectedIndex != -1 && ComboBoxProduct.SelectedIndex != 0)
            {
                ComboBoxPrice.Items.Clear();
                SearchPrice1();
                SearchPrice2();
                SearchPrice3();
            }
        }

        private void ComboBoxProduct_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void ValidatePrice()
        {
            
        }

        private void ComboBoxProduct_DropDownClosed(object sender, EventArgs e)
        {
            if (ComboBoxProduct.SelectedIndex == 0)
            {
                ComboBoxPrice.Items.Clear();
                SearchPrice1();
                SearchPrice2();
                SearchPrice3();
            }
        }

        private void ComboBoxProduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonSearch2_Click(object sender, EventArgs e)
        {
            if(ComboBoxProduct.Text == "")
            {
                ToListProducts();
            }
            else
            {
                try
                {
                    Stock newStock = new Stock();

                    ComboBoxProduct.DataSource = newStock.Search(ComboBoxProduct.Text);
                    ComboBoxProduct.DisplayMember = "PRODUCT";
                    ComboBoxProduct.ValueMember = "ID_STOCK";
                    ComboBoxProduct.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
