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
    public partial class FormPurchases : Form
    {
        public FormPurchases()
        {
            InitializeComponent();
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

        private void ToListDistributors()
        {
            try
            {
                Distributors newDistributors = new Distributors();

                ComboBoxProvenance.DataSource = newDistributors.ToList();
                ComboBoxProvenance.DisplayMember = "NAME";
                ComboBoxProvenance.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxProvenance.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewPurchases.Rows.Count; i += 2)
            {
                DataGridViewPurchases.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
            }
        }

        private void Clean()
        {
            TextBoxCode.Text = "0";
            ComboBoxProduct.SelectedIndex = -1;
            MaskedTextBoxPrice.Text = "";
            NumericUpDownQuantity.Value = 0;
            DateTimePicker.Value = DateTime.Today;
        }

        private void Clean2()
        {
            TextBoxCode.Text = "0";
            ComboBoxProduct.SelectedIndex = -1;
            ComboBoxProvenance.SelectedIndex = -1;
            MaskedTextBoxPrice.Text = "";
            NumericUpDownQuantity.Value = 0;
            DateTimePicker.Value = DateTime.Today;
        }

        private void Validate()
        {
            if (ComboBoxProduct.SelectedIndex == -1)
            {
                throw new Exception("El nombre del producto no fue establecido!");
            }

            if (ComboBoxProvenance.SelectedIndex == -1)
            {
                throw new Exception("La procedencia no fue establecida!");
            }

            if (MaskedTextBoxPrice.Text.Trim().Length == 0)
            {
                throw new Exception("El precio no fue establecido!");
            }

            if (NumericUpDownQuantity.Value == 0)
            {
                throw new Exception("La cantidad no fue establecida!");
            }
        }

        private void ToListPurchases()
        {
            Purchases newPurchase = new Purchases();
            DataGridViewPurchases.DataSource = newPurchase.ToList();
            Style();
            for (int i = 0; i < DataGridViewPurchases.Rows.Count; i++)
            {
                DataGridViewPurchases.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewPurchases.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewPurchases.Rows[i].Cells["Precio"].Value);
                if (Convert.ToInt32(DataGridViewPurchases.Rows[i].Cells["refF"].Value) == 1)
                {
                    DataGridViewPurchases.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                }
                else
                {
                    DataGridViewPurchases.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                }
            }
            for (int i = 0; i < DataGridViewPurchases.Columns.Count; i++)
            {
                DataGridViewPurchases.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void FormPurchases_Load(object sender, EventArgs e)
        {
            ToListProducts();
            ToListDistributors();
            ToListPurchases();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Stock newStock = new Stock();
                Distributors newDistributor = new Distributors();
                Purchases newPurchase = new Purchases();
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

                        newPurchase.Save(Convert.ToInt32(TextBoxCode.Text), Convert.ToInt32(ComboBoxProduct.SelectedValue), Convert.ToInt32(ComboBoxProvenance.SelectedValue), Convert.ToInt32(MaskedTextBoxPrice.Text), Convert.ToInt32(NumericUpDownQuantity.Text), Date, F);
                        int UpdateQuantity = StockProduct + Convert.ToInt32(NumericUpDownQuantity.Value);
                        newStock.UpdateStock(Convert.ToInt32(ComboBoxProduct.SelectedValue), UpdateQuantity);
                        MessageBox.Show("Compra guardada con éxito!", "REGISTRO DE COMPRAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListPurchases();
                        ToListProducts();
                        ToListDistributors();
                        Clean();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    int QuantitySale = newPurchase.ReturnPurchase(Convert.ToInt32(TextBoxCode.Text));
                    int StockProduct = newStock.ReturnStock(Convert.ToInt32(ComboBoxProduct.SelectedValue));
                    int FinalQuantity = Convert.ToInt32(NumericUpDownQuantity.Value) - QuantitySale;

                    newPurchase.Modify(Convert.ToInt32(TextBoxCode.Text), Convert.ToInt32(ComboBoxProduct.SelectedValue), Convert.ToInt32(ComboBoxProvenance.SelectedValue), Convert.ToInt32(MaskedTextBoxPrice.Text), Convert.ToInt32(NumericUpDownQuantity.Text), Date, F);
                    int UpdateQuantity = StockProduct + FinalQuantity;
                    newStock.UpdateStock(Convert.ToInt32(ComboBoxProduct.SelectedValue), UpdateQuantity);
                    MessageBox.Show("Compra modificada con éxito!", "REGISTRO DE COMPRAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ToListPurchases();
                    ToListProducts();
                    ToListDistributors();
                    Clean();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Clean2();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Purchases newPurchase = new Purchases();
                DataGridViewPurchases.DataSource = newPurchase.Search(Convert.ToDateTime(DateTimePickerSearch.Value.Date));
                Style();
                for (int i = 0; i < DataGridViewPurchases.Rows.Count; i++)
                {
                    DataGridViewPurchases.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewPurchases.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewPurchases.Rows[i].Cells["Precio"].Value);
                    if (Convert.ToInt32(DataGridViewPurchases.Rows[i].Cells["refF"].Value) == 1)
                    {
                        DataGridViewPurchases.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        DataGridViewPurchases.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGridViewPurchases.Columns[e.ColumnIndex].Name == "Editar")
                {
                    TextBoxCode.Text = DataGridViewPurchases.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    ComboBoxProduct.SelectedValue = DataGridViewPurchases.Rows[e.RowIndex].Cells["CodigoStock"].Value;
                    ComboBoxProvenance.SelectedValue = DataGridViewPurchases.Rows[e.RowIndex].Cells["CodigoDistribuidora"].Value;
                    MaskedTextBoxPrice.Text = DataGridViewPurchases.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                    NumericUpDownQuantity.Value = Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    DateTimePicker.Value = Convert.ToDateTime(DataGridViewPurchases.Rows[e.RowIndex].Cells["Fecha"].Value.ToString());
                    if (Convert.ToDecimal(DataGridViewPurchases.Rows[e.RowIndex].Cells["refF"].Value) == 1)
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
                    if (DataGridViewPurchases.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Desea eliminar esta compra?", "ELIMINAR COMPRAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Purchases newPurchase = new Purchases();

                            newPurchase.Delete(Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["Codigo"].Value));
                            MessageBox.Show("Compra eliminada con éxito!", "ELIMINAR COMPRAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListPurchases();
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
    }
}
