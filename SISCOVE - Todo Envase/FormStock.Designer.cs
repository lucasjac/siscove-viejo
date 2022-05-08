namespace SISCOVE___Todo_Envase
{
    partial class FormStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxProduct = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NumericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label0 = new System.Windows.Forms.Label();
            this.DataGridViewStock = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advertencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCOVEDataSet = new SISCOVE___Todo_Envase.SISCOVEDataSet();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.NumericUpDownWarning = new System.Windows.Forms.NumericUpDown();
            this.stockTableAdapter = new SISCOVE___Todo_Envase.SISCOVEDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new SISCOVE___Todo_Envase.SISCOVEDataSetTableAdapters.TableAdapterManager();
            this.TextBoxCounter = new System.Windows.Forms.TextBox();
            this.ButtonCounter = new System.Windows.Forms.Button();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.GroupBoxOrder = new System.Windows.Forms.GroupBox();
            this.ComboBoxOrder = new System.Windows.Forms.ComboBox();
            this.GroupBoxCalculation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPrice3 = new System.Windows.Forms.TextBox();
            this.TextBoxPrice2 = new System.Windows.Forms.TextBox();
            this.TextBoxPrice1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCOVEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWarning)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            this.GroupBoxOrder.SuspendLayout();
            this.GroupBoxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 23);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Producto:";
            // 
            // TextBoxProduct
            // 
            this.TextBoxProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxProduct.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProduct.Location = new System.Drawing.Point(195, 53);
            this.TextBoxProduct.Name = "TextBoxProduct";
            this.TextBoxProduct.Size = new System.Drawing.Size(191, 23);
            this.TextBoxProduct.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 23);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Cantidad:";
            // 
            // NumericUpDownQuantity
            // 
            this.NumericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDownQuantity.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownQuantity.Location = new System.Drawing.Point(195, 127);
            this.NumericUpDownQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            this.NumericUpDownQuantity.Size = new System.Drawing.Size(52, 23);
            this.NumericUpDownQuantity.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 92);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(159, 23);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Precio de venta:";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxCode.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(195, 12);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(75, 23);
            this.TextBoxCode.TabIndex = 19;
            this.TextBoxCode.TabStop = false;
            this.TextBoxCode.Text = "0";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.Location = new System.Drawing.Point(12, 12);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(77, 23);
            this.Label0.TabIndex = 18;
            this.Label0.Text = "Código:";
            // 
            // DataGridViewStock
            // 
            this.DataGridViewStock.AllowUserToAddRows = false;
            this.DataGridViewStock.AllowUserToDeleteRows = false;
            this.DataGridViewStock.AllowUserToResizeColumns = false;
            this.DataGridViewStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio1,
            this.Precio2,
            this.Precio3,
            this.Cantidad,
            this.Advertencia,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewStock.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewStock.Location = new System.Drawing.Point(12, 204);
            this.DataGridViewStock.Name = "DataGridViewStock";
            this.DataGridViewStock.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewStock.RowHeadersVisible = false;
            this.DataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStock.Size = new System.Drawing.Size(540, 345);
            this.DataGridViewStock.TabIndex = 20;
            this.DataGridViewStock.TabStop = false;
            this.DataGridViewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStock_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_STOCK";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "PRODUCT";
            this.Producto.HeaderText = "Producto:";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 165;
            // 
            // Precio1
            // 
            this.Precio1.DataPropertyName = "PRICE1";
            this.Precio1.HeaderText = "Precio 1:";
            this.Precio1.Name = "Precio1";
            this.Precio1.ReadOnly = true;
            this.Precio1.Width = 72;
            // 
            // Precio2
            // 
            this.Precio2.DataPropertyName = "PRICE2";
            this.Precio2.HeaderText = "Precio 2:";
            this.Precio2.Name = "Precio2";
            this.Precio2.ReadOnly = true;
            this.Precio2.Width = 72;
            // 
            // Precio3
            // 
            this.Precio3.DataPropertyName = "PRICE3";
            this.Precio3.HeaderText = "Precio 3:";
            this.Precio3.Name = "Precio3";
            this.Precio3.ReadOnly = true;
            this.Precio3.Width = 72;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "QUANTITY";
            this.Cantidad.HeaderText = "Cantidad:";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 65;
            // 
            // Advertencia
            // 
            this.Advertencia.DataPropertyName = "WARNING";
            this.Advertencia.HeaderText = "Advertencia:";
            this.Advertencia.Name = "Advertencia";
            this.Advertencia.ReadOnly = true;
            this.Advertencia.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton12;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 45;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton13;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 45;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.sISCOVEDataSet;
            // 
            // sISCOVEDataSet
            // 
            this.sISCOVEDataSet.DataSetName = "SISCOVEDataSet";
            this.sISCOVEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ButtonPrice
            // 
            this.ButtonPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrice.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrice.Location = new System.Drawing.Point(195, 86);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new System.Drawing.Size(52, 35);
            this.ButtonPrice.TabIndex = 2;
            this.ButtonPrice.Text = "...";
            this.ButtonPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNew.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton09;
            this.ButtonNew.Location = new System.Drawing.Point(480, 12);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(72, 64);
            this.ButtonNew.TabIndex = 9;
            this.ButtonNew.Text = "Nuevo";
            this.ButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton081;
            this.ButtonSave.Location = new System.Drawing.Point(392, 12);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(72, 64);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Square721 BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(12, 163);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(180, 21);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Advertir a partir de:";
            // 
            // NumericUpDownWarning
            // 
            this.NumericUpDownWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDownWarning.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownWarning.Location = new System.Drawing.Point(195, 163);
            this.NumericUpDownWarning.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericUpDownWarning.Name = "NumericUpDownWarning";
            this.NumericUpDownWarning.Size = new System.Drawing.Size(52, 23);
            this.NumericUpDownWarning.TabIndex = 7;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DistributorsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = SISCOVE___Todo_Envase.SISCOVEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TextBoxCounter
            // 
            this.TextBoxCounter.Font = new System.Drawing.Font("Square721 BT", 9.75F);
            this.TextBoxCounter.Location = new System.Drawing.Point(276, 12);
            this.TextBoxCounter.Name = "TextBoxCounter";
            this.TextBoxCounter.ReadOnly = true;
            this.TextBoxCounter.Size = new System.Drawing.Size(85, 23);
            this.TextBoxCounter.TabIndex = 35;
            this.TextBoxCounter.TabStop = false;
            this.TextBoxCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxCounter.Visible = false;
            // 
            // ButtonCounter
            // 
            this.ButtonCounter.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonCounter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonCounter.Location = new System.Drawing.Point(367, 12);
            this.ButtonCounter.Name = "ButtonCounter";
            this.ButtonCounter.Size = new System.Drawing.Size(19, 23);
            this.ButtonCounter.TabIndex = 12;
            this.ButtonCounter.Text = "-";
            this.ButtonCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCounter.UseVisualStyleBackColor = true;
            this.ButtonCounter.Click += new System.EventHandler(this.ButtonCounter_Click);
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSearch.Location = new System.Drawing.Point(331, 136);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(221, 62);
            this.GroupBoxSearch.TabIndex = 36;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Buscar";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(6, 22);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(209, 23);
            this.TextBoxSearch.TabIndex = 11;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // GroupBoxOrder
            // 
            this.GroupBoxOrder.Controls.Add(this.ComboBoxOrder);
            this.GroupBoxOrder.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxOrder.Location = new System.Drawing.Point(390, 82);
            this.GroupBoxOrder.Name = "GroupBoxOrder";
            this.GroupBoxOrder.Size = new System.Drawing.Size(162, 52);
            this.GroupBoxOrder.TabIndex = 40;
            this.GroupBoxOrder.TabStop = false;
            this.GroupBoxOrder.Text = "Ordenar por:";
            // 
            // ComboBoxOrder
            // 
            this.ComboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrder.FormattingEnabled = true;
            this.ComboBoxOrder.Items.AddRange(new object[] {
            "Por abecedario",
            "Por cantidad"});
            this.ComboBoxOrder.Location = new System.Drawing.Point(6, 22);
            this.ComboBoxOrder.Name = "ComboBoxOrder";
            this.ComboBoxOrder.Size = new System.Drawing.Size(151, 24);
            this.ComboBoxOrder.TabIndex = 10;
            this.ComboBoxOrder.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrder_SelectedIndexChanged);
            // 
            // GroupBoxCalculation
            // 
            this.GroupBoxCalculation.Controls.Add(this.label8);
            this.GroupBoxCalculation.Controls.Add(this.label7);
            this.GroupBoxCalculation.Controls.Add(this.label6);
            this.GroupBoxCalculation.Controls.Add(this.TextBoxPrice3);
            this.GroupBoxCalculation.Controls.Add(this.TextBoxPrice2);
            this.GroupBoxCalculation.Controls.Add(this.TextBoxPrice1);
            this.GroupBoxCalculation.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCalculation.Location = new System.Drawing.Point(253, 82);
            this.GroupBoxCalculation.Name = "GroupBoxCalculation";
            this.GroupBoxCalculation.Size = new System.Drawing.Size(221, 104);
            this.GroupBoxCalculation.TabIndex = 41;
            this.GroupBoxCalculation.TabStop = false;
            this.GroupBoxCalculation.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Precio 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio 1:";
            // 
            // TextBoxPrice3
            // 
            this.TextBoxPrice3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice3.Location = new System.Drawing.Point(102, 75);
            this.TextBoxPrice3.Name = "TextBoxPrice3";
            this.TextBoxPrice3.Size = new System.Drawing.Size(109, 23);
            this.TextBoxPrice3.TabIndex = 5;
            this.TextBoxPrice3.Text = "0";
            // 
            // TextBoxPrice2
            // 
            this.TextBoxPrice2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice2.Location = new System.Drawing.Point(102, 44);
            this.TextBoxPrice2.Name = "TextBoxPrice2";
            this.TextBoxPrice2.Size = new System.Drawing.Size(109, 23);
            this.TextBoxPrice2.TabIndex = 4;
            this.TextBoxPrice2.Text = "0";
            // 
            // TextBoxPrice1
            // 
            this.TextBoxPrice1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice1.Location = new System.Drawing.Point(102, 13);
            this.TextBoxPrice1.Name = "TextBoxPrice1";
            this.TextBoxPrice1.Size = new System.Drawing.Size(109, 23);
            this.TextBoxPrice1.TabIndex = 3;
            this.TextBoxPrice1.Text = "0";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.GroupBoxCalculation);
            this.Controls.Add(this.GroupBoxOrder);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.TextBoxCounter);
            this.Controls.Add(this.ButtonCounter);
            this.Controls.Add(this.ButtonPrice);
            this.Controls.Add(this.DataGridViewStock);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.NumericUpDownWarning);
            this.Controls.Add(this.NumericUpDownQuantity);
            this.Controls.Add(this.TextBoxProduct);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Stock de mercaderías";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormStock_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCOVEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWarning)).EndInit();
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            this.GroupBoxOrder.ResumeLayout(false);
            this.GroupBoxCalculation.ResumeLayout(false);
            this.GroupBoxCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxProduct;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuantity;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.DataGridView DataGridViewStock;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.NumericUpDown NumericUpDownWarning;
        private SISCOVEDataSet sISCOVEDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private SISCOVEDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private SISCOVEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advertencia;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.TextBox TextBoxCounter;
        private System.Windows.Forms.Button ButtonCounter;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.GroupBox GroupBoxOrder;
        private System.Windows.Forms.ComboBox ComboBoxOrder;
        private System.Windows.Forms.GroupBox GroupBoxCalculation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TextBoxPrice3;
        public System.Windows.Forms.TextBox TextBoxPrice2;
        public System.Windows.Forms.TextBox TextBoxPrice1;
    }
}