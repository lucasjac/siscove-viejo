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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void CheckBoxSituation_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSituation.Checked == true)
            {
                Label5.Visible = true;
                Label6.Visible = false;
            }
            else
            {
                Label5.Visible = false;
                Label6.Visible = true;
            }
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewOrders.Rows.Count; i += 2)
            {
                DataGridViewOrders.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            for (int i = 0; i < DataGridViewOrders2.Rows.Count; i+= 2)
            {
                DataGridViewOrders2.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void ToListOrders()
        {
            Orders newOrder = new Orders();
            DataGridViewOrders.DataSource = newOrder.ToList();
            Style();
            for (int i = 0; i < DataGridViewOrders.Rows.Count; i++)
            {
                if (Convert.ToInt32(DataGridViewOrders.Rows[i].Cells["refSituacion"].Value) == 1)
                {
                    DataGridViewOrders.Rows[i].Cells["Situacion"].Value = "ENTREGADO";
                    DataGridViewOrders.Rows[i].Cells["Situacion"].Style.BackColor = Color.Green;
                }
                else
                {
                    DataGridViewOrders.Rows[i].Cells["Situacion"].Value = "PENDIENTE";
                    DataGridViewOrders.Rows[i].Cells["Situacion"].Style.BackColor = Color.Red;
                }
            }
            for (int i = 0; i < DataGridViewOrders.Columns.Count; i++)
            {
                DataGridViewOrders.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            for (int i = 0; i < DataGridViewOrders2.Columns.Count; i++)
            {
                DataGridViewOrders2.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            ToListOrders();
            ToListCustomers();
            ToListProducts();
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
                Orders newOrder = new Orders();
                Stock newStock = new Stock();
                DateTime Date = DateTimePicker.Value;
                int Situation = 0;

                if (CheckBoxSituation.Checked == true)
                {
                    Situation = 1;
                }
                else
                {
                    Situation = 0;
                }

                if (TextBoxCode.Text == "0")
                {
                    int StockProduct = newStock.ReturnStock(Convert.ToInt32(ComboBoxProduct.SelectedValue));

                    if (NumericUpDownQuantity.Value > StockProduct)
                    {
                        MessageBox.Show("Cantidad insuficiente para la venta.", "CANTIDAD INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        newOrder.Save(Convert.ToInt32(TextBoxCode.Text), ComboBoxProduct.Text, ComboBoxClient.Text, Convert.ToInt32(NumericUpDownQuantity.Value), Situation, Date);
                        MessageBox.Show("Cliente registrado con éxito!", "REGISTRO DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    newOrder.Modify(Convert.ToInt32(TextBoxCode.Text), ComboBoxProduct.Text, ComboBoxClient.Text, Convert.ToInt32(NumericUpDownQuantity.Value), Situation, Date);
                    MessageBox.Show("Registro modificado con éxito!", "REGISTRO DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ToListOrders();

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
            ComboBoxProduct.SelectedIndex = -1;
            ComboBoxClient.SelectedIndex = -1;
            NumericUpDownQuantity.Value = 0;
            DateTimePicker.Value = DateTime.Today;
            CheckBoxSituation.Checked = false;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Orders newOrder = new Orders();
                DataGridViewOrders.DataSource = newOrder.Search(TextBoxSearch.Text);
                Style();
                for (int i = 0; i < DataGridViewOrders.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(DataGridViewOrders.Rows[i].Cells["refSituacion"].Value) == 1)
                    {
                        DataGridViewOrders.Rows[i].Cells["Situacion"].Value = "ENTREGADO";
                        DataGridViewOrders.Rows[i].Cells["Situacion"].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        DataGridViewOrders.Rows[i].Cells["Situacion"].Value = "PENDIENTE";
                        DataGridViewOrders.Rows[i].Cells["Situacion"].Style.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGridViewOrders.Columns[e.ColumnIndex].Name == "Editar")
                {
                    TextBoxCode.Text = DataGridViewOrders.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    ComboBoxProduct.Text = DataGridViewOrders.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                    ComboBoxClient.Text = DataGridViewOrders.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    NumericUpDownQuantity.Value = Convert.ToDecimal(DataGridViewOrders.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    DateTimePicker.Value = Convert.ToDateTime(DataGridViewOrders.Rows[e.RowIndex].Cells["Fecha"].Value.ToString());
                    if (Convert.ToDecimal(DataGridViewOrders.Rows[e.RowIndex].Cells["refSituacion"].Value) == 1)
                    {
                        CheckBoxSituation.Checked = true;
                    }
                    else
                    {
                        CheckBoxSituation.Checked = false;
                    }
                }
                else
                {
                    if (DataGridViewOrders.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Desea eliminar este pedido?", "ELIMINAR PEDIDOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Orders newOrder = new Orders();

                            newOrder.Delete(Convert.ToInt32(DataGridViewOrders.Rows[e.RowIndex].Cells["Codigo"].Value));
                            MessageBox.Show("Pedido eliminado con éxito!", "ELIMINAR PEDIDOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListOrders();
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

        private void ToListCustomers()
        {
            try
            {
                Customers newCustomer = new Customers();

                ComboBoxClient.DataSource = newCustomer.ToList();
                ComboBoxClient.DisplayMember = "NAME";
                ComboBoxClient.ValueMember = "ID_CUSTOMERS";
                ComboBoxClient.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Orders newOrder = new Orders();
                DataGridViewOrders2.DataSource = newOrder.Search2(DataGridViewOrders.Rows[e.RowIndex].Cells["Cliente"].Value.ToString(), Convert.ToInt32(DataGridViewOrders.Rows[e.RowIndex].Cells["refSituacion"].Value.ToString()));
                Style();
            }
        }

        private void Validate()
        {
            if (ComboBoxProduct.SelectedIndex == -1)
            {
                throw new Exception("El nombre del producto no fue establecido!");
            }

            if (ComboBoxClient.SelectedIndex == -1)
            {
                throw new Exception("El precio del producto no fue establecido!");
            }

            if (NumericUpDownQuantity.Value == 0)
            {
                throw new Exception("La cantidad no fue establecida!");
            }
        }
    }
}
