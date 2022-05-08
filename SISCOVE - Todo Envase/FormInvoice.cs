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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            ToListProducts();
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                int F;
                if (CheckBoxF.Checked == true)
                {
                    F = 1;
                }
                else
                {
                    F = 0;
                }
                Sales newSale = new Sales();
                DataGridViewSales.DataSource = newSale.SearchRecords3(ComboBoxProduct.Text, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, F);
                Style();
                for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
                {
                    DataGridViewSales.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Precio"].Value);
                    if (Convert.ToInt32(DataGridViewSales.Rows[i].Cells["refF"].Value) == 1)
                    {
                        DataGridViewSales.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        DataGridViewSales.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                    }
                }
                if (CheckBoxF.Checked == true)
                {
                    ButtonF.BackColor = Color.Blue;
                }
                else
                {
                    ButtonF.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewSales.Rows.Count; i += 2)
            {
                DataGridViewSales.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            for (int i = 0; i < DataGridViewSales.Columns.Count; i++)
            {
                DataGridViewSales.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void CheckBoxF_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Validate()
        {
            if (ComboBoxProduct.SelectedIndex == -1)
            {
                throw new Exception("El producto no fue establecido!");
            }
        }

        private void ButtonF_Click(object sender, EventArgs e)
        {
            int F;
            for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
            {
                Sales newSale = new Sales();
                if (Convert.ToInt32(DataGridViewSales.Rows[i].Cells["refF"].Value) == 1)
                {
                    F = 0;
                }
                else
                {
                    F = 1;
                }
                if(DataGridViewSales.Rows[i].Selected == true)
                {
                    newSale.Modify(Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Codigo"].Value), Convert.ToInt32(DataGridViewSales.Rows[i].Cells["CodigoSTock"].Value), Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Cantidad"].Value), Convert.ToDateTime(DataGridViewSales.Rows[i].Cells["Fecha"].Value), F, Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Precio"].Value));
                }
            }
            ButtonSearch_Click(sender, e);
        }

        private void DataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int c = 0;
            for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
            {
                if (DataGridViewSales.Rows[i].Selected == true)
                {
                    c = c + Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Cantidad"].Value);
                }
            }
            TextBoxQuantity.Text = Convert.ToString(c);
        }
    }
}
