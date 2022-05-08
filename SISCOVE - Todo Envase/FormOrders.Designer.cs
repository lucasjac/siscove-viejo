namespace SISCOVE___Todo_Envase
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.ComboBoxClient = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NumericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label0 = new System.Windows.Forms.Label();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.DataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refSituacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewOrders2 = new System.Windows.Forms.DataGridView();
            this.refCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.CheckBoxSituation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders2)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxClient
            // 
            this.ComboBoxClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClient.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClient.FormattingEnabled = true;
            this.ComboBoxClient.Location = new System.Drawing.Point(119, 48);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.Size = new System.Drawing.Size(267, 24);
            this.ComboBoxClient.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Cliente:";
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(119, 86);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(267, 24);
            this.ComboBoxProduct.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 86);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 23);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Producto:";
            // 
            // NumericUpDownQuantity
            // 
            this.NumericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDownQuantity.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownQuantity.Location = new System.Drawing.Point(119, 125);
            this.NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            this.NumericUpDownQuantity.Size = new System.Drawing.Size(74, 23);
            this.NumericUpDownQuantity.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 125);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 23);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Cantidad:";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCode.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(119, 12);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(75, 23);
            this.TextBoxCode.TabIndex = 11;
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
            this.Label0.TabIndex = 10;
            this.Label0.Text = "Código:";
            // 
            // ButtonNew
            // 
            this.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNew.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton09;
            this.ButtonNew.Location = new System.Drawing.Point(480, 12);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(72, 64);
            this.ButtonNew.TabIndex = 7;
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
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // DataGridViewOrders
            // 
            this.DataGridViewOrders.AllowUserToAddRows = false;
            this.DataGridViewOrders.AllowUserToDeleteRows = false;
            this.DataGridViewOrders.AllowUserToResizeColumns = false;
            this.DataGridViewOrders.AllowUserToResizeRows = false;
            this.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.refSituacion,
            this.Situacion,
            this.Fecha,
            this.Producto,
            this.Cantidad,
            this.Editar,
            this.Eliminar});
            this.DataGridViewOrders.Location = new System.Drawing.Point(12, 193);
            this.DataGridViewOrders.Name = "DataGridViewOrders";
            this.DataGridViewOrders.ReadOnly = true;
            this.DataGridViewOrders.RowHeadersVisible = false;
            this.DataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewOrders.Size = new System.Drawing.Size(540, 228);
            this.DataGridViewOrders.TabIndex = 14;
            this.DataGridViewOrders.TabStop = false;
            this.DataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrders_CellContentClick);
            this.DataGridViewOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrders_CellContentDoubleClick);
            this.DataGridViewOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewOrders_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_ORDERS";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "CUSTOMER";
            this.Cliente.HeaderText = "Cliente:";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 210;
            // 
            // refSituacion
            // 
            this.refSituacion.DataPropertyName = "SITUATION";
            this.refSituacion.HeaderText = "Situación:";
            this.refSituacion.Name = "refSituacion";
            this.refSituacion.ReadOnly = true;
            this.refSituacion.Visible = false;
            this.refSituacion.Width = 133;
            // 
            // Situacion
            // 
            this.Situacion.HeaderText = "Situación:";
            this.Situacion.Name = "Situacion";
            this.Situacion.ReadOnly = true;
            this.Situacion.Width = 134;
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
            this.Fecha.Width = 86;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "PRODUCT";
            this.Producto.HeaderText = "Producto:";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "QUANTITY";
            this.Cantidad.HeaderText = "Cantidad:";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Visible = false;
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
            // DataGridViewOrders2
            // 
            this.DataGridViewOrders2.AllowUserToAddRows = false;
            this.DataGridViewOrders2.AllowUserToDeleteRows = false;
            this.DataGridViewOrders2.AllowUserToResizeColumns = false;
            this.DataGridViewOrders2.AllowUserToResizeRows = false;
            this.DataGridViewOrders2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrders2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refCodigo,
            this.refCliente,
            this.refSituation,
            this.refFecha,
            this.RefProducto,
            this.RefCantidad});
            this.DataGridViewOrders2.Location = new System.Drawing.Point(12, 427);
            this.DataGridViewOrders2.Name = "DataGridViewOrders2";
            this.DataGridViewOrders2.ReadOnly = true;
            this.DataGridViewOrders2.RowHeadersVisible = false;
            this.DataGridViewOrders2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewOrders2.Size = new System.Drawing.Size(540, 122);
            this.DataGridViewOrders2.TabIndex = 14;
            this.DataGridViewOrders2.TabStop = false;
            // 
            // refCodigo
            // 
            this.refCodigo.DataPropertyName = "ID_ORDERS";
            this.refCodigo.HeaderText = "Código:";
            this.refCodigo.Name = "refCodigo";
            this.refCodigo.ReadOnly = true;
            this.refCodigo.Visible = false;
            // 
            // refCliente
            // 
            this.refCliente.DataPropertyName = "CUSTOMER";
            this.refCliente.HeaderText = "Cliente:";
            this.refCliente.Name = "refCliente";
            this.refCliente.ReadOnly = true;
            this.refCliente.Visible = false;
            // 
            // refSituation
            // 
            this.refSituation.DataPropertyName = "SITUATION";
            this.refSituation.HeaderText = "Situación:";
            this.refSituation.Name = "refSituation";
            this.refSituation.ReadOnly = true;
            this.refSituation.Visible = false;
            // 
            // refFecha
            // 
            this.refFecha.DataPropertyName = "DATE";
            this.refFecha.HeaderText = "Fecha:";
            this.refFecha.Name = "refFecha";
            this.refFecha.ReadOnly = true;
            this.refFecha.Visible = false;
            // 
            // RefProducto
            // 
            this.RefProducto.DataPropertyName = "PRODUCT";
            this.RefProducto.HeaderText = "Producto:";
            this.RefProducto.Name = "RefProducto";
            this.RefProducto.ReadOnly = true;
            this.RefProducto.Width = 385;
            // 
            // RefCantidad
            // 
            this.RefCantidad.DataPropertyName = "QUANTITY";
            this.RefCantidad.HeaderText = "Cantidad:";
            this.RefCantidad.Name = "RefCantidad";
            this.RefCantidad.ReadOnly = true;
            this.RefCantidad.Width = 152;
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSearch.Location = new System.Drawing.Point(392, 123);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(160, 62);
            this.GroupBoxSearch.TabIndex = 15;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Buscar";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(6, 22);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(148, 23);
            this.TextBoxSearch.TabIndex = 8;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePicker.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(119, 164);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(115, 23);
            this.DateTimePicker.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 162);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 23);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Fecha:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(412, 94);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(82, 16);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "A entregar";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(412, 94);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 16);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Entregado";
            this.Label5.Visible = false;
            // 
            // CheckBoxSituation
            // 
            this.CheckBoxSituation.AutoSize = true;
            this.CheckBoxSituation.Location = new System.Drawing.Point(398, 96);
            this.CheckBoxSituation.Name = "CheckBoxSituation";
            this.CheckBoxSituation.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxSituation.TabIndex = 5;
            this.CheckBoxSituation.UseVisualStyleBackColor = true;
            this.CheckBoxSituation.CheckedChanged += new System.EventHandler(this.CheckBoxSituation_CheckedChanged);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.CheckBoxSituation);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.DataGridViewOrders2);
            this.Controls.Add(this.DataGridViewOrders);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.NumericUpDownQuantity);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ComboBoxProduct);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ComboBoxClient);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Pedidos";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders2)).EndInit();
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxClient;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuantity;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridView DataGridViewOrders;
        private System.Windows.Forms.DataGridView DataGridViewOrders2;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.CheckBox CheckBoxSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn refCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn refCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn refSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn refFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn refSituacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}