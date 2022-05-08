using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SISCOVE___Todo_Envase
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ToolStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ButtonSales_Click(object sender, EventArgs e)
        {
            FormSales newFormSales = new FormSales();

            newFormSales.ShowDialog();
        }

        private void ButtonPurchases_Click(object sender, EventArgs e)
        {
            FormPurchases newFormPurchases = new FormPurchases();

            newFormPurchases.ShowDialog();
        }

        private void ButtonRecords_Click(object sender, EventArgs e)
        {
            FormRecords newFormRecords = new FormRecords();

            newFormRecords.ShowDialog();
        }

        private void ButtonStock_Click(object sender, EventArgs e)
        {
            FormStock newFormStock = new FormStock();

            newFormStock.ShowDialog();
        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            FormOrders newFormOrders = new FormOrders();

            newFormOrders.ShowDialog();
        }

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers newFormCustomers = new FormCustomers();

            newFormCustomers.ShowDialog();
        }

        private void ButtonDistributors_Click(object sender, EventArgs e)
        {
            FormDistributors newFormDistributors = new FormDistributors();

            newFormDistributors.ShowDialog();
        }

        private void ButtonComparison_Click(object sender, EventArgs e)
        {
            FormComparison newFormComparison = new FormComparison();

            newFormComparison.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LabelDate.Text = DateTime.Today.ToShortDateString();
            Stock newStock = new Stock();
            DataTable TableData = new DataTable();
            TableData = newStock.ToList();
            int w = 0;

            for (int i = 0; i < TableData.Rows.Count; i++)
            {
                if (Convert.ToInt32(TableData.Rows[i]["QUANTITY"]) <= Convert.ToInt32(TableData.Rows[i]["WARNING"]))
                {
                    w = 1;
                }
            }

            if (w == 1)
            {
                MessageBox.Show("Hay productos con poca existencia en el inventario!", "STOCK:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {
            FormChangePassword newChangePassword = new FormChangePassword();
            newChangePassword.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void ButtonInvoice_Click(object sender, EventArgs e)
        {
            FormInvoice newFormInvoice = new FormInvoice();

            newFormInvoice.ShowDialog();
        }

        private void ButtonEnumerate_Click(object sender, EventArgs e)
        {

        }
    }
}
