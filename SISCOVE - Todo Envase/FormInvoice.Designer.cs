namespace SISCOVE___Todo_Envase
{
    partial class FormInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGridViewSales = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxF = new System.Windows.Forms.CheckBox();
            this.ButtonF = new System.Windows.Forms.Button();
            this.TextBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton10;
            this.ButtonSearch.Location = new System.Drawing.Point(399, 39);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(29, 32);
            this.ButtonSearch.TabIndex = 23;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(102, 47);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(291, 24);
            this.ComboBoxProduct.TabIndex = 21;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 20);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Producto:";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker2.Location = new System.Drawing.Point(277, 9);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(116, 23);
            this.DateTimePicker2.TabIndex = 20;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(80, 9);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(116, 23);
            this.DateTimePicker1.TabIndex = 19;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(213, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 20);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "hasta:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 20);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Desde:";
            // 
            // DataGridViewSales
            // 
            this.DataGridViewSales.AllowUserToAddRows = false;
            this.DataGridViewSales.AllowUserToDeleteRows = false;
            this.DataGridViewSales.AllowUserToResizeColumns = false;
            this.DataGridViewSales.AllowUserToResizeRows = false;
            this.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CodigoStock,
            this.Producto,
            this.Cantidad,
            this.Total,
            this.F,
            this.Fecha,
            this.refF,
            this.Precio});
            this.DataGridViewSales.Location = new System.Drawing.Point(12, 77);
            this.DataGridViewSales.Name = "DataGridViewSales";
            this.DataGridViewSales.ReadOnly = true;
            this.DataGridViewSales.RowHeadersVisible = false;
            this.DataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSales.Size = new System.Drawing.Size(580, 443);
            this.DataGridViewSales.TabIndex = 24;
            this.DataGridViewSales.TabStop = false;
            this.DataGridViewSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSales_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_SALES";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // CodigoStock
            // 
            this.CodigoStock.DataPropertyName = "ID_STOCK";
            this.CodigoStock.HeaderText = "Código:";
            this.CodigoStock.Name = "CodigoStock";
            this.CodigoStock.ReadOnly = true;
            this.CodigoStock.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "PRODUCT";
            this.Producto.HeaderText = "Producto:";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 217;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "QUANTITY";
            this.Cantidad.HeaderText = "Cantidad:";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total:";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // F
            // 
            this.F.HeaderText = "F:";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 34;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "DATE";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha:";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 115;
            // 
            // refF
            // 
            this.refF.DataPropertyName = "F";
            this.refF.HeaderText = "F";
            this.refF.Name = "refF";
            this.refF.ReadOnly = true;
            this.refF.Visible = false;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PRICE";
            this.Precio.HeaderText = "Precio:";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            // 
            // CheckBoxF
            // 
            this.CheckBoxF.AutoSize = true;
            this.CheckBoxF.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxF.Location = new System.Drawing.Point(399, 9);
            this.CheckBoxF.Name = "CheckBoxF";
            this.CheckBoxF.Size = new System.Drawing.Size(35, 20);
            this.CheckBoxF.TabIndex = 25;
            this.CheckBoxF.Text = "F";
            this.CheckBoxF.UseVisualStyleBackColor = true;
            this.CheckBoxF.CheckedChanged += new System.EventHandler(this.CheckBoxF_CheckedChanged);
            // 
            // ButtonF
            // 
            this.ButtonF.BackColor = System.Drawing.Color.Red;
            this.ButtonF.Font = new System.Drawing.Font("Square721 BT", 12F);
            this.ButtonF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonF.Location = new System.Drawing.Point(503, 39);
            this.ButtonF.Name = "ButtonF";
            this.ButtonF.Size = new System.Drawing.Size(89, 32);
            this.ButtonF.TabIndex = 26;
            this.ButtonF.Text = "Facturar";
            this.ButtonF.UseVisualStyleBackColor = false;
            this.ButtonF.Click += new System.EventHandler(this.ButtonF_Click);
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxQuantity.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQuantity.Location = new System.Drawing.Point(533, 526);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.ReadOnly = true;
            this.TextBoxQuantity.Size = new System.Drawing.Size(59, 23);
            this.TextBoxQuantity.TabIndex = 27;
            this.TextBoxQuantity.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cantidad:";
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxQuantity);
            this.Controls.Add(this.ButtonF);
            this.Controls.Add(this.CheckBoxF);
            this.Controls.Add(this.DataGridViewSales);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ComboBoxProduct);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Facturas";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView DataGridViewSales;
        private System.Windows.Forms.CheckBox CheckBoxF;
        private System.Windows.Forms.Button ButtonF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn refF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox TextBoxQuantity;
        private System.Windows.Forms.Label label4;
    }
}