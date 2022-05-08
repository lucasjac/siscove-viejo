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
    public partial class FormDistributors : Form
    {
        public FormDistributors()
        {
            InitializeComponent();
        }

        private void Style()
        {
            for (int i = 0; i < DataGridViewDistributors.Rows.Count; i += 2)
            {
                DataGridViewDistributors.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void ToListDistributors()
        {
            Distributors newDistributor = new Distributors();
            DataGridViewDistributors.DataSource = newDistributor.ToList();
            Style();
            for (int i = 0; i < DataGridViewDistributors.Columns.Count; i++)
            {
                DataGridViewDistributors.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
        
        private void Clean()
        {
            TextBoxCode.Text = "0";
            TextBoxName.Clear();
            MaskedTextBoxTel1.Clear();
            MaskedTextBoxTel2.Clear();
            MaskedTextBoxTel3.Clear();
            TextBoxSearch.Clear();

        }

        private void FormDistributors_Load(object sender, EventArgs e)
        {
            ToListDistributors();
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
                Distributors newDistributor = new Distributors();
                if (TextBoxCode.Text == "0")
                {
                    newDistributor.Save(Convert.ToInt32(TextBoxCode.Text), TextBoxName.Text, MaskedTextBoxTel1.Text, MaskedTextBoxTel2.Text, MaskedTextBoxTel3.Text);
                    MessageBox.Show("Distribuidor registrado con éxito!", "REGISTRO DE DISTRIBUIDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    newDistributor.Modify(Convert.ToInt32(TextBoxCode.Text), TextBoxName.Text, MaskedTextBoxTel1.Text, MaskedTextBoxTel2.Text, MaskedTextBoxTel3.Text);
                    MessageBox.Show("Registro modificado con éxito!", "REGISTRO DE DISTRIBUIDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ToListDistributors();
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewDistributors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DataGridViewDistributors.Columns[e.ColumnIndex].Name == "Editar")
                {
                    TextBoxCode.Text = DataGridViewDistributors.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    TextBoxName.Text = DataGridViewDistributors.Rows[e.RowIndex].Cells["Distribuidor"].Value.ToString();
                    MaskedTextBoxTel1.Text = DataGridViewDistributors.Rows[e.RowIndex].Cells["Tel1"].Value.ToString();
                    MaskedTextBoxTel2.Text = DataGridViewDistributors.Rows[e.RowIndex].Cells["Tel2"].Value.ToString();
                    MaskedTextBoxTel3.Text = DataGridViewDistributors.Rows[e.RowIndex].Cells["Tel3"].Value.ToString();
                }
                else
                {
                    if (DataGridViewDistributors.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Desea eliminar a este distribuidor?", "ELIMINAR DISTRIBUIDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Distributors newDistributor = new Distributors();

                            newDistributor.Delete(Convert.ToInt32(DataGridViewDistributors.Rows[e.RowIndex].Cells["Codigo"].Value));
                            MessageBox.Show("Distribuidor eliminado con éxito!", "ELIMINAR DISTRIBUIDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ToListDistributors();
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
            Distributors newDistributor = new Distributors();
            try
            {
                DataGridViewDistributors.DataSource = newDistributor.Search(TextBoxSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Style();
        }

        private void Validate()
        {
            int sw = 0;
            int i = 0;
            while (i < DataGridViewDistributors.Rows.Count && sw == 0 && DataGridViewDistributors.Rows[i].Cells["Codigo"].Value.ToString() != TextBoxCode.Text)
            {
                if (DataGridViewDistributors.Rows[i].Cells["Distribuidor"].Value.ToString() == TextBoxName.Text)
                {
                    sw = 1;
                }
                i++;
            }
            if (sw == 1)
            {
                throw new Exception("Ya existe un proveedor con este nombre!");
            }
            if (TextBoxName.Text.Trim().Length == 0)
            {
                throw new Exception("El nombre no fue establecido!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextBoxTel1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            if(GroupBoxCalculation.Visible == false)
            {
                GroupBoxCalculation.Visible = true;
                TextBoxName.Visible = false;
            }
            else
            {
                GroupBoxCalculation.Visible = false;
                TextBoxName.Visible = true;
            }
        }

        private void ButtonCounter_Click(object sender, EventArgs e)
        {
            if (TextBoxCounter.Visible == false)
            {
                TextBoxCounter.Text = Convert.ToString(DataGridViewDistributors.Rows.Count);
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
