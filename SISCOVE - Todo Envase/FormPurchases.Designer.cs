namespace SISCOVE___Todo_Envase
{
    partial class FormPurchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchases));
            this.DataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDistribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NumericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label0 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.DateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBoxProvenance = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.MaskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.CheckBoxF = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewPurchases
            // 
            this.DataGridViewPurchases.AllowUserToAddRows = false;
            this.DataGridViewPurchases.AllowUserToDeleteRows = false;
            this.DataGridViewPurchases.AllowUserToResizeColumns = false;
            this.DataGridViewPurchases.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CodigoStock,
            this.CodigoDistribuidora,
            this.Producto,
            this.Cantidad,
            this.Total,
            this.Precio,
            this.F,
            this.refF,
            this.Fecha,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPurchases.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewPurchases.Location = new System.Drawing.Point(12, 192);
            this.DataGridViewPurchases.Name = "DataGridViewPurchases";
            this.DataGridViewPurchases.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPurchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPurchases.RowHeadersVisible = false;
            this.DataGridViewPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPurchases.Size = new System.Drawing.Size(580, 357);
            this.DataGridViewPurchases.TabIndex = 1;
            this.DataGridViewPurchases.TabStop = false;
            this.DataGridViewPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPurchases_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_PURCHASES";
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
            // CodigoDistribuidora
            // 
            this.CodigoDistribuidora.DataPropertyName = "ID_DISTRIBUTORS";
            this.CodigoDistribuidora.HeaderText = "Código:";
            this.CodigoDistribuidora.Name = "CodigoDistribuidora";
            this.CodigoDistribuidora.ReadOnly = true;
            this.CodigoDistribuidora.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "PRODUCT";
            this.Producto.HeaderText = "Producto:";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 196;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "QUANTITY";
            this.Cantidad.HeaderText = "Cantidad:";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 83;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total:";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PRICE";
            this.Precio.HeaderText = "Precio:";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            // 
            // F
            // 
            this.F.HeaderText = "F:";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 30;
            // 
            // refF
            // 
            this.refF.DataPropertyName = "F";
            this.refF.HeaderText = "F";
            this.refF.Name = "refF";
            this.refF.ReadOnly = true;
            this.refF.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "DATE";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha:";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 97;
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
            // DateTimePicker
            // 
            this.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(147, 164);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(115, 23);
            this.DateTimePicker.TabIndex = 5;
            // 
            // NumericUpDownQuantity
            // 
            this.NumericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDownQuantity.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownQuantity.Location = new System.Drawing.Point(147, 134);
            this.NumericUpDownQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            this.NumericUpDownQuantity.Size = new System.Drawing.Size(74, 23);
            this.NumericUpDownQuantity.TabIndex = 4;
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(147, 40);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(269, 24);
            this.ComboBoxProduct.TabIndex = 1;
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCode.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(147, 9);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(75, 23);
            this.TextBoxCode.TabIndex = 10;
            this.TextBoxCode.TabStop = false;
            this.TextBoxCode.Text = "0";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.Location = new System.Drawing.Point(12, 9);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(77, 23);
            this.Label0.TabIndex = 6;
            this.Label0.Text = "Código:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(12, 163);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 23);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Fecha:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 135);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 23);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Cantidad:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 23);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Producto:";
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.DateTimePickerSearch);
            this.GroupBoxSearch.Controls.Add(this.ButtonSearch);
            this.GroupBoxSearch.Controls.Add(this.Label6);
            this.GroupBoxSearch.Location = new System.Drawing.Point(422, 105);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(170, 81);
            this.GroupBoxSearch.TabIndex = 17;
            this.GroupBoxSearch.TabStop = false;
            // 
            // DateTimePickerSearch
            // 
            this.DateTimePickerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePickerSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerSearch.Location = new System.Drawing.Point(10, 39);
            this.DateTimePickerSearch.Name = "DateTimePickerSearch";
            this.DateTimePickerSearch.Size = new System.Drawing.Size(115, 23);
            this.DateTimePickerSearch.TabIndex = 9;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton10;
            this.ButtonSearch.Location = new System.Drawing.Point(131, 30);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(29, 32);
            this.ButtonSearch.TabIndex = 10;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(6, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(68, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Buscar:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 23);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Procedencia:";
            // 
            // ComboBoxProvenance
            // 
            this.ComboBoxProvenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProvenance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProvenance.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProvenance.FormattingEnabled = true;
            this.ComboBoxProvenance.Location = new System.Drawing.Point(147, 73);
            this.ComboBoxProvenance.Name = "ComboBoxProvenance";
            this.ComboBoxProvenance.Size = new System.Drawing.Size(269, 24);
            this.ComboBoxProvenance.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 23);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Precio c/u:";
            // 
            // MaskedTextBoxPrice
            // 
            this.MaskedTextBoxPrice.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice.Location = new System.Drawing.Point(147, 105);
            this.MaskedTextBoxPrice.Name = "MaskedTextBoxPrice";
            this.MaskedTextBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.MaskedTextBoxPrice.TabIndex = 3;
            // 
            // ButtonNew
            // 
            this.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNew.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton09;
            this.ButtonNew.Location = new System.Drawing.Point(520, 9);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(72, 64);
            this.ButtonNew.TabIndex = 8;
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
            this.ButtonSave.Location = new System.Drawing.Point(432, 9);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(72, 64);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CheckBoxF
            // 
            this.CheckBoxF.AutoSize = true;
            this.CheckBoxF.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxF.Location = new System.Drawing.Point(391, 9);
            this.CheckBoxF.Name = "CheckBoxF";
            this.CheckBoxF.Size = new System.Drawing.Size(35, 20);
            this.CheckBoxF.TabIndex = 6;
            this.CheckBoxF.Text = "F";
            this.CheckBoxF.UseVisualStyleBackColor = true;
            // 
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 561);
            this.Controls.Add(this.CheckBoxF);
            this.Controls.Add(this.MaskedTextBoxPrice);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.NumericUpDownQuantity);
            this.Controls.Add(this.ComboBoxProvenance);
            this.Controls.Add(this.ComboBoxProduct);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGridViewPurchases);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Compras";
            this.Load += new System.EventHandler(this.FormPurchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).EndInit();
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPurchases;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuantity;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.DateTimePicker DateTimePickerSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox ComboBoxProvenance;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice;
        private System.Windows.Forms.CheckBox CheckBoxF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDistribuidora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn refF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}