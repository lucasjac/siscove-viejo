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
    public partial class FormComparison : Form
    {
        public FormComparison()
        {
            InitializeComponent();
        }

        private void ToListGroupBox1()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor1.DataSource = newDistributor.ToList();
                ComboBoxDistributor1.DisplayMember = "NAME";
                ComboBoxDistributor1.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor1.SelectedIndex = -1;

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

        private void ToListGroupBox2()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor2.DataSource = newDistributor.ToList();
                ComboBoxDistributor2.DisplayMember = "NAME";
                ComboBoxDistributor2.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor2.SelectedIndex = -1;

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

        private void ToListGroupBox3()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor3.DataSource = newDistributor.ToList();
                ComboBoxDistributor3.DisplayMember = "NAME";
                ComboBoxDistributor3.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor3.SelectedIndex = -1;

                ComboBoxProduct3.DataSource = newStock.ToList();
                ComboBoxProduct3.DisplayMember = "PRODUCT";
                ComboBoxProduct3.ValueMember = "ID_STOCK";
                ComboBoxProduct3.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListGroupBox4()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor4.DataSource = newDistributor.ToList();
                ComboBoxDistributor4.DisplayMember = "NAME";
                ComboBoxDistributor4.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor4.SelectedIndex = -1;

                ComboBoxProduct4.DataSource = newStock.ToList();
                ComboBoxProduct4.DisplayMember = "PRODUCT";
                ComboBoxProduct4.ValueMember = "ID_STOCK";
                ComboBoxProduct4.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListGroupBox5()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor5.DataSource = newDistributor.ToList();
                ComboBoxDistributor5.DisplayMember = "NAME";
                ComboBoxDistributor5.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor5.SelectedIndex = -1;

                ComboBoxProduct5.DataSource = newStock.ToList();
                ComboBoxProduct5.DisplayMember = "PRODUCT";
                ComboBoxProduct5.ValueMember = "ID_STOCK";
                ComboBoxProduct5.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListGroupBox6()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor6.DataSource = newDistributor.ToList();
                ComboBoxDistributor6.DisplayMember = "NAME";
                ComboBoxDistributor6.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor6.SelectedIndex = -1;

                ComboBoxProduct6.DataSource = newStock.ToList();
                ComboBoxProduct6.DisplayMember = "PRODUCT";
                ComboBoxProduct6.ValueMember = "ID_STOCK";
                ComboBoxProduct6.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListGroupBox7()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor7.DataSource = newDistributor.ToList();
                ComboBoxDistributor7.DisplayMember = "NAME";
                ComboBoxDistributor7.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor7.SelectedIndex = -1;

                ComboBoxProduct7.DataSource = newStock.ToList();
                ComboBoxProduct7.DisplayMember = "PRODUCT";
                ComboBoxProduct7.ValueMember = "ID_STOCK";
                ComboBoxProduct7.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListGroupBox8()
        {
            try
            {
                Distributors newDistributor = new Distributors();
                Stock newStock = new Stock();

                ComboBoxDistributor8.DataSource = newDistributor.ToList();
                ComboBoxDistributor8.DisplayMember = "NAME";
                ComboBoxDistributor8.ValueMember = "ID_DISTRIBUTORS";
                ComboBoxDistributor8.SelectedIndex = -1;

                ComboBoxProduct8.DataSource = newStock.ToList();
                ComboBoxProduct8.DisplayMember = "PRODUCT";
                ComboBoxProduct8.ValueMember = "ID_STOCK";
                ComboBoxProduct8.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchPrice1()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor1.SelectedValue), Convert.ToInt32(ComboBoxProduct1.SelectedValue));
                MaskedTextBoxPrice1.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la primera búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice2()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor2.SelectedValue), Convert.ToInt32(ComboBoxProduct2.SelectedValue));
                MaskedTextBoxPrice2.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la segunda búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice3()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor3.SelectedValue), Convert.ToInt32(ComboBoxProduct3.SelectedValue));
                MaskedTextBoxPrice3.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la tercera búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice4()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor4.SelectedValue), Convert.ToInt32(ComboBoxProduct4.SelectedValue));
                MaskedTextBoxPrice4.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la cuarta búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice5()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor5.SelectedValue), Convert.ToInt32(ComboBoxProduct5.SelectedValue));
                MaskedTextBoxPrice5.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la quinta búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice6()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor6.SelectedValue), Convert.ToInt32(ComboBoxProduct6.SelectedValue));
                MaskedTextBoxPrice6.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la sexta búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice7()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor7.SelectedValue), Convert.ToInt32(ComboBoxProduct7.SelectedValue));
                MaskedTextBoxPrice7.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la séptima búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPrice8()
        {
            try
            {
                Purchases newPurchase = new Purchases();

                int PricePurchase = newPurchase.ReturnPrice(Convert.ToInt32(ComboBoxDistributor8.SelectedValue), Convert.ToInt32(ComboBoxProduct8.SelectedValue));
                MaskedTextBoxPrice8.Text = Convert.ToString(PricePurchase);
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró ninguna compra realizada en base a la octava búsqueda.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormComparison_Load(object sender, EventArgs e)
        {
            ToListGroupBox1();
            ToListGroupBox2();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (NumericUpDownQuantity.Value >= 3)
            {
                GroupBox3.Enabled = true;
                ToListGroupBox3();
            }
            else
            {
                GroupBox3.Enabled = false;
                ComboBoxDistributor3.SelectedIndex = -1;
                ComboBoxProduct3.SelectedIndex = -1;
                MaskedTextBoxPrice3.Text = "";
            }

            if (NumericUpDownQuantity.Value >= 4)
            {
                GroupBox4.Enabled = true;
                ToListGroupBox4();
            }
            else
            {
                GroupBox4.Enabled = false;
                ComboBoxDistributor4.SelectedIndex = -1;
                ComboBoxProduct4.SelectedIndex = -1;
                MaskedTextBoxPrice4.Text = "";
            }

            if (NumericUpDownQuantity.Value >= 5)
            {
                GroupBox5.Enabled = true;
                ToListGroupBox5();
            }
            else
            {
                GroupBox5.Enabled = false;
                ComboBoxDistributor5.SelectedIndex = -1;
                ComboBoxProduct5.SelectedIndex = -1;
                MaskedTextBoxPrice5.Text = "";
            }

            if (NumericUpDownQuantity.Value >= 6)
            {
                GroupBox6.Enabled = true;
                ToListGroupBox6();
            }
            else
            {
                GroupBox6.Enabled = false;
                ComboBoxDistributor6.SelectedIndex = -1;
                ComboBoxProduct6.SelectedIndex = -1;
                MaskedTextBoxPrice6.Text = "";
            }

            if (NumericUpDownQuantity.Value >= 7)
            {
                GroupBox7.Enabled = true;
                ToListGroupBox7();
            }
            else
            {
                GroupBox7.Enabled = false;
                ComboBoxDistributor7.SelectedIndex = -1;
                ComboBoxProduct7.SelectedIndex = -1;
                MaskedTextBoxPrice7.Text = "";
            }

            if (NumericUpDownQuantity.Value == 8)
            {
                GroupBox8.Enabled = true;
                ToListGroupBox8();
            }
            else
            {
                GroupBox8.Enabled = false;
                ComboBoxDistributor8.SelectedIndex = -1;
                ComboBoxProduct8.SelectedIndex = -1;
                MaskedTextBoxPrice8.Text = "";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxProduct2.Text = ComboBoxProduct1.Text;

            if (GroupBox3.Enabled == true)
            {
                ComboBoxProduct3.Text = ComboBoxProduct1.Text;
            }

            if (GroupBox4.Enabled == true)
            {
                ComboBoxProduct4.Text = ComboBoxProduct1.Text;
            }

            if (GroupBox5.Enabled == true)
            {
                ComboBoxProduct5.Text = ComboBoxProduct1.Text;
            }

            if (GroupBox6.Enabled == true)
            {
                ComboBoxProduct6.Text = ComboBoxProduct1.Text;
            }

            if (GroupBox7.Enabled == true)
            {
                ComboBoxProduct7.Text = ComboBoxProduct1.Text;
            }

            if (GroupBox8.Enabled == true)
            {
                ComboBoxProduct8.Text = ComboBoxProduct1.Text;
            }
        }

        private void ButtonComparison_Click(object sender, EventArgs e)
        {
            SearchPrice1();
            SearchPrice2();

            if (GroupBox3.Enabled == true)
            {
                SearchPrice3();
            }

            if (GroupBox4.Enabled == true)
            {
                SearchPrice4();
            }

            if (GroupBox5.Enabled == true)
            {
                SearchPrice5();
            }

            if (GroupBox6.Enabled == true)
            {
                SearchPrice6();
            }

            if (GroupBox7.Enabled == true)
            {
                SearchPrice7();
            }

            if (GroupBox8.Enabled == true)
            {
                SearchPrice8();
            }
        }

        private void NumericUpDownQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                ButtonSearch_Click(sender, e);
            }
        }
    }
}
