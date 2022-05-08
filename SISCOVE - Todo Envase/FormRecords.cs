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
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
        }

        private void TabControlRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToListPurchases();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StyleGreen()
        {
            for (int i = 0; i < DataGridViewRecordsSales.Rows.Count; i += 2)
            {
                DataGridViewRecordsSales.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void StyleRed()
        {
            for (int i = 0; i < DataGridViewRecordsPurchases.Rows.Count; i += 2)
            {
                DataGridViewRecordsPurchases.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
            }
        }

        private void CountFSales()
        {
            int f = 0;
            int nf = 0;
            for (int i = 0; i < DataGridViewRecordsSales.Rows.Count; i++)
            {
                if (Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["refF"].Value) == 1)
                {
                    f = f + Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Cantidad"].Value);
                }
                else
                {
                    nf = nf + Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Cantidad"].Value);
                }
            }
            TextBoxF1.Text = Convert.ToString(f);
            TextBoxNF1.Text = Convert.ToString(nf);
        }

        private void CountFPurchases()
        {
            int f = 0;
            int nf = 0;
            for (int i = 0; i < DataGridViewRecordsPurchases.Rows.Count; i++)
            {
                if (Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["refF2"].Value) == 1)
                {
                    f = f + Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Cantidad2"].Value);
                }
                else
                {
                    nf = nf + Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Cantidad2"].Value);
                }
            }
            TextBoxF2.Text = Convert.ToString(f);
            TextBoxNF2.Text = Convert.ToString(nf);
        }

        private void ToListSales()
        {
            Sales newSale = new Sales();
            DataGridViewRecordsSales.DataSource = newSale.ToList();
            StyleGreen();
            for (int i = 0; i < DataGridViewRecordsSales.Rows.Count; i++)
            {
                DataGridViewRecordsSales.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Precio"].Value);
                if (Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["refF"].Value) == 1)
                {
                    DataGridViewRecordsSales.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                }
                else
                {
                    DataGridViewRecordsSales.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                }
            }
            for (int i = 0; i < DataGridViewRecordsSales.Columns.Count; i++)
            {
                DataGridViewRecordsSales.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void ToListPurchases()
        {
            Purchases newPurchase = new Purchases();
            DataGridViewRecordsPurchases.DataSource = newPurchase.ToList();
            StyleRed();
            for (int i = 0; i < DataGridViewRecordsPurchases.Rows.Count; i++)
            {
                DataGridViewRecordsPurchases.Rows[i].Cells["Total2"].Value = Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Cantidad2"].Value) * Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Precio2"].Value);
                if (Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["refF2"].Value) == 1)
                {
                    DataGridViewRecordsPurchases.Rows[i].Cells["F2"].Style.BackColor = Color.Red;
                }
                else
                {
                    DataGridViewRecordsPurchases.Rows[i].Cells["F2"].Style.BackColor = Color.Blue;
                }
            }
            for (int i = 0; i < DataGridViewRecordsPurchases.Columns.Count; i++)
            {
                DataGridViewRecordsPurchases.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void FormRecords_Load(object sender, EventArgs e)
        {
            ToListPurchases();
            ToListSales();
            ToListProducts();
            ToListProducts2();
        }

        private void ButtonSearch1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxF1.Clear();
                TextBoxNF1.Clear();
                Sales newSale = new Sales();
                int c = 0;
                if (ComboBoxProduct1.SelectedIndex == -1)
                {
                    DataGridViewRecordsSales.DataSource = newSale.SearchRecords2(DateTimePicker1.Value.Date, DateTimePicker2.Value.Date);
                    StyleGreen();
                    for (int i = 0; i < DataGridViewRecordsSales.Rows.Count; i++)
                    {
                        DataGridViewRecordsSales.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Precio"].Value);
                        c = c + Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Total"].Value);
                        if (Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["refF"].Value) == 1)
                        {
                            DataGridViewRecordsSales.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DataGridViewRecordsSales.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                        }
                    }
                    TextBoxTotal1.Text = Convert.ToString(c);
                }
                else
                {
                    DataGridViewRecordsSales.DataSource = newSale.SearchRecords(ComboBoxProduct1.Text, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date);
                    StyleGreen();
                    for (int i = 0; i < DataGridViewRecordsSales.Rows.Count; i++)
                    {             
                        DataGridViewRecordsSales.Rows[i].Cells["Total"].Value = Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Cantidad"].Value) * Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Precio"].Value);
                        c = c + Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["Total"].Value);                       
                        if (Convert.ToInt32(DataGridViewRecordsSales.Rows[i].Cells["refF"].Value) == 1)
                        {
                            DataGridViewRecordsSales.Rows[i].Cells["F"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DataGridViewRecordsSales.Rows[i].Cells["F"].Style.BackColor = Color.Blue;
                        }
                    }
                    TextBoxTotal1.Text = Convert.ToString(c);
                    CountFSales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSearch2_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxF2.Clear();
                TextBoxNF2.Clear();
                Purchases newPurchase = new Purchases();
                int c = 0;
                if (ComboBoxProduct2.SelectedIndex == -1)
                {
                    DataGridViewRecordsPurchases.DataSource = newPurchase.SearchRecords2(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date);
                    StyleRed();
                    for (int i = 0; i < DataGridViewRecordsPurchases.Rows.Count; i++)
                    {
                        DataGridViewRecordsPurchases.Rows[i].Cells["Total2"].Value = Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Cantidad2"].Value) * Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Precio2"].Value);
                        c = c + Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Total2"].Value);
                        if (Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["refF2"].Value) == 1)
                        {
                            DataGridViewRecordsPurchases.Rows[i].Cells["F2"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DataGridViewRecordsPurchases.Rows[i].Cells["F2"].Style.BackColor = Color.Blue;
                        }
                    }
                    TextBoxTotal2.Text = Convert.ToString(c);
                }
                else
                {
                    DataGridViewRecordsPurchases.DataSource = newPurchase.SearchRecords(ComboBoxProduct2.Text, DateTimePicker3.Value.Date, DateTimePicker4.Value.Date);
                    StyleRed();
                    for (int i = 0; i < DataGridViewRecordsPurchases.Rows.Count; i++)
                    {
                        DataGridViewRecordsPurchases.Rows[i].Cells["Total2"].Value = Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Cantidad2"].Value) * Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Precio2"].Value);
                        c = c + Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["Total2"].Value);
                        if (Convert.ToInt32(DataGridViewRecordsPurchases.Rows[i].Cells["refF2"].Value) == 1)
                        {
                            DataGridViewRecordsPurchases.Rows[i].Cells["F2"].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            DataGridViewRecordsPurchases.Rows[i].Cells["F2"].Style.BackColor = Color.Blue;
                        }
                    }
                    TextBoxTotal2.Text = Convert.ToString(c);
                    CountFPurchases();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListProducts()
        {
            try
            {
                Stock newStock = new Stock();

                ComboBoxProduct1.DataSource = newStock.ToList();
                ComboBoxProduct1.DisplayMember = "PRODUCT";
                ComboBoxProduct1.ValueMember = "ID_STOCK";
                ComboBoxProduct1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListProducts2()
        {
            try
            {
                Stock newStock = new Stock();

                ComboBoxProduct2.DataSource = newStock.ToList();
                ComboBoxProduct2.DisplayMember = "PRODUCT";
                ComboBoxProduct2.ValueMember = "ID_STOCK";
                ComboBoxProduct2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTime.Today;
            DateTimePicker2.Value = DateTime.Today;
            ComboBoxProduct1.SelectedIndex = -1;
            ToListSales();
            TextBoxTotal1.Clear();
            TextBoxF1.Clear();
            TextBoxNF1.Clear();
        }

        private void PictureBoxPurchases_Click(object sender, EventArgs e)
        {
            DateTimePicker3.Value = DateTime.Today;
            DateTimePicker4.Value = DateTime.Today;
            ComboBoxProduct2.SelectedIndex = -1;
            ToListPurchases();
            TextBoxTotal2.Clear();
            TextBoxF2.Clear();
            TextBoxNF2.Clear();
        }
    }
}
