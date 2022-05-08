namespace SISCOVE___Todo_Envase
{
    partial class FormCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label0 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.MaskedTextBoxTel1 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.MaskedTextBoxRUC = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GroupBoxCalculation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaskedTextBoxTel3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBoxTel2 = new System.Windows.Forms.MaskedTextBox();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.ButtonCounter = new System.Windows.Forms.Button();
            this.TextBoxCounter = new System.Windows.Forms.TextBox();
            this.GroupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).BeginInit();
            this.GroupBoxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Nombre:";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCode.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(108, 18);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(75, 23);
            this.TextBoxCode.TabIndex = 4;
            this.TextBoxCode.TabStop = false;
            this.TextBoxCode.Text = "0";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.Location = new System.Drawing.Point(12, 18);
            this.Label0.Name = "Label0";
            this.Label0.Size = new System.Drawing.Size(77, 23);
            this.Label0.TabIndex = 3;
            this.Label0.Text = "Código:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(108, 62);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(170, 23);
            this.TextBoxName.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 146);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 23);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Tel/Cel:";
            // 
            // MaskedTextBoxTel1
            // 
            this.MaskedTextBoxTel1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxTel1.Location = new System.Drawing.Point(105, 17);
            this.MaskedTextBoxTel1.Mask = "(9999)000-000";
            this.MaskedTextBoxTel1.Name = "MaskedTextBoxTel1";
            this.MaskedTextBoxTel1.Size = new System.Drawing.Size(110, 23);
            this.MaskedTextBoxTel1.TabIndex = 5;
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSearch.Location = new System.Drawing.Point(392, 107);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(160, 62);
            this.GroupBoxSearch.TabIndex = 16;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Buscar";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(6, 22);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(148, 23);
            this.TextBoxSearch.TabIndex = 10;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DataGridViewCustomers
            // 
            this.DataGridViewCustomers.AllowUserToAddRows = false;
            this.DataGridViewCustomers.AllowUserToDeleteRows = false;
            this.DataGridViewCustomers.AllowUserToResizeColumns = false;
            this.DataGridViewCustomers.AllowUserToResizeRows = false;
            this.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Tel1,
            this.Tel2,
            this.Tel3,
            this.RUC,
            this.Editar,
            this.Eliminar});
            this.DataGridViewCustomers.Location = new System.Drawing.Point(12, 175);
            this.DataGridViewCustomers.Name = "DataGridViewCustomers";
            this.DataGridViewCustomers.ReadOnly = true;
            this.DataGridViewCustomers.RowHeadersVisible = false;
            this.DataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCustomers.Size = new System.Drawing.Size(540, 374);
            this.DataGridViewCustomers.TabIndex = 17;
            this.DataGridViewCustomers.TabStop = false;
            this.DataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCustomers_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_CUSTOMERS";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NAME";
            this.Cliente.HeaderText = "Cliente:";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 126;
            // 
            // Tel1
            // 
            this.Tel1.DataPropertyName = "TEL1";
            this.Tel1.HeaderText = "Tel/Cel 1:";
            this.Tel1.Name = "Tel1";
            this.Tel1.ReadOnly = true;
            this.Tel1.Width = 80;
            // 
            // Tel2
            // 
            this.Tel2.DataPropertyName = "TEL2";
            this.Tel2.HeaderText = "Tel/Cel 2:";
            this.Tel2.Name = "Tel2";
            this.Tel2.ReadOnly = true;
            this.Tel2.Width = 80;
            // 
            // Tel3
            // 
            this.Tel3.DataPropertyName = "TEL3";
            this.Tel3.HeaderText = "Tel/Cel 3:";
            this.Tel3.Name = "Tel3";
            this.Tel3.ReadOnly = true;
            this.Tel3.Width = 80;
            // 
            // RUC
            // 
            this.RUC.DataPropertyName = "RUC";
            this.RUC.HeaderText = "RUC:";
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 80;
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
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 23);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "RUC:";
            // 
            // MaskedTextBoxRUC
            // 
            this.MaskedTextBoxRUC.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxRUC.Location = new System.Drawing.Point(108, 104);
            this.MaskedTextBoxRUC.Mask = "9999999-9";
            this.MaskedTextBoxRUC.Name = "MaskedTextBoxRUC";
            this.MaskedTextBoxRUC.Size = new System.Drawing.Size(97, 23);
            this.MaskedTextBoxRUC.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton12;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::SISCOVE___Todo_Envase.Properties.Resources.Boton13;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 45;
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
            // GroupBoxCalculation
            // 
            this.GroupBoxCalculation.Controls.Add(this.label8);
            this.GroupBoxCalculation.Controls.Add(this.label7);
            this.GroupBoxCalculation.Controls.Add(this.label6);
            this.GroupBoxCalculation.Controls.Add(this.MaskedTextBoxTel3);
            this.GroupBoxCalculation.Controls.Add(this.MaskedTextBoxTel2);
            this.GroupBoxCalculation.Controls.Add(this.MaskedTextBoxTel1);
            this.GroupBoxCalculation.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCalculation.Location = new System.Drawing.Point(166, 72);
            this.GroupBoxCalculation.Name = "GroupBoxCalculation";
            this.GroupBoxCalculation.Size = new System.Drawing.Size(221, 97);
            this.GroupBoxCalculation.TabIndex = 31;
            this.GroupBoxCalculation.TabStop = false;
            this.GroupBoxCalculation.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tel/Cel 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tel/Cel 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tel/Cel 1:";
            // 
            // MaskedTextBoxTel3
            // 
            this.MaskedTextBoxTel3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxTel3.Location = new System.Drawing.Point(105, 64);
            this.MaskedTextBoxTel3.Mask = "(9999)000-000";
            this.MaskedTextBoxTel3.Name = "MaskedTextBoxTel3";
            this.MaskedTextBoxTel3.Size = new System.Drawing.Size(110, 23);
            this.MaskedTextBoxTel3.TabIndex = 7;
            // 
            // MaskedTextBoxTel2
            // 
            this.MaskedTextBoxTel2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxTel2.Location = new System.Drawing.Point(105, 40);
            this.MaskedTextBoxTel2.Mask = "(9999)000-000";
            this.MaskedTextBoxTel2.Name = "MaskedTextBoxTel2";
            this.MaskedTextBoxTel2.Size = new System.Drawing.Size(110, 23);
            this.MaskedTextBoxTel2.TabIndex = 6;
            // 
            // ButtonPrice
            // 
            this.ButtonPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrice.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrice.Location = new System.Drawing.Point(108, 134);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new System.Drawing.Size(52, 35);
            this.ButtonPrice.TabIndex = 4;
            this.ButtonPrice.Text = "...";
            this.ButtonPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
            // 
            // ButtonCounter
            // 
            this.ButtonCounter.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonCounter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonCounter.Location = new System.Drawing.Point(368, 12);
            this.ButtonCounter.Name = "ButtonCounter";
            this.ButtonCounter.Size = new System.Drawing.Size(19, 23);
            this.ButtonCounter.TabIndex = 32;
            this.ButtonCounter.Text = "-";
            this.ButtonCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCounter.UseVisualStyleBackColor = true;
            this.ButtonCounter.Click += new System.EventHandler(this.ButtonCounter_Click);
            // 
            // TextBoxCounter
            // 
            this.TextBoxCounter.Font = new System.Drawing.Font("Square721 BT", 9.75F);
            this.TextBoxCounter.Location = new System.Drawing.Point(277, 13);
            this.TextBoxCounter.Name = "TextBoxCounter";
            this.TextBoxCounter.ReadOnly = true;
            this.TextBoxCounter.Size = new System.Drawing.Size(85, 23);
            this.TextBoxCounter.TabIndex = 36;
            this.TextBoxCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxCounter.Visible = false;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.TextBoxCounter);
            this.Controls.Add(this.ButtonCounter);
            this.Controls.Add(this.GroupBoxCalculation);
            this.Controls.Add(this.ButtonPrice);
            this.Controls.Add(this.DataGridViewCustomers);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.MaskedTextBoxRUC);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Clientes";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).EndInit();
            this.GroupBoxCalculation.ResumeLayout(false);
            this.GroupBoxCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTel1;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DataGridViewCustomers;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxRUC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox GroupBoxCalculation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTel3;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTel2;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Button ButtonCounter;
        private System.Windows.Forms.TextBox TextBoxCounter;
    }
}