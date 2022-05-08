namespace SISCOVE___Todo_Envase
{
    partial class FormDistributors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDistributors));
            this.DataGridViewDistributors = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.MaskedTextBoxTel1 = new System.Windows.Forms.MaskedTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBoxCalculation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaskedTextBoxTel3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBoxTel2 = new System.Windows.Forms.MaskedTextBox();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.ButtonCounter = new System.Windows.Forms.Button();
            this.TextBoxCounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDistributors)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            this.GroupBoxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewDistributors
            // 
            this.DataGridViewDistributors.AllowUserToAddRows = false;
            this.DataGridViewDistributors.AllowUserToDeleteRows = false;
            this.DataGridViewDistributors.AllowUserToResizeColumns = false;
            this.DataGridViewDistributors.AllowUserToResizeRows = false;
            this.DataGridViewDistributors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDistributors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Distribuidor,
            this.Tel1,
            this.Tel2,
            this.Tel3,
            this.Editar,
            this.Eliminar});
            this.DataGridViewDistributors.Location = new System.Drawing.Point(12, 150);
            this.DataGridViewDistributors.Name = "DataGridViewDistributors";
            this.DataGridViewDistributors.ReadOnly = true;
            this.DataGridViewDistributors.RowHeadersVisible = false;
            this.DataGridViewDistributors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDistributors.Size = new System.Drawing.Size(540, 399);
            this.DataGridViewDistributors.TabIndex = 27;
            this.DataGridViewDistributors.TabStop = false;
            this.DataGridViewDistributors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDistributors_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_DISTRIBUTORS";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Distribuidor
            // 
            this.Distribuidor.DataPropertyName = "NAME";
            this.Distribuidor.HeaderText = "Procedencia:";
            this.Distribuidor.Name = "Distribuidor";
            this.Distribuidor.ReadOnly = true;
            this.Distribuidor.Width = 161;
            // 
            // Tel1
            // 
            this.Tel1.DataPropertyName = "TEL1";
            this.Tel1.HeaderText = "Tel/Cel 1:";
            this.Tel1.Name = "Tel1";
            this.Tel1.ReadOnly = true;
            this.Tel1.Width = 95;
            // 
            // Tel2
            // 
            this.Tel2.DataPropertyName = "TEL2";
            this.Tel2.HeaderText = "Tel/Cel 2:";
            this.Tel2.Name = "Tel2";
            this.Tel2.ReadOnly = true;
            this.Tel2.Width = 95;
            // 
            // Tel3
            // 
            this.Tel3.DataPropertyName = "TEL3";
            this.Tel3.HeaderText = "Tel/Cel 3:";
            this.Tel3.Name = "Tel3";
            this.Tel3.ReadOnly = true;
            this.Tel3.Width = 95;
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
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSearch.Location = new System.Drawing.Point(392, 82);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(160, 62);
            this.GroupBoxSearch.TabIndex = 26;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Buscar";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(6, 22);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(148, 23);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
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
            // MaskedTextBoxTel1
            // 
            this.MaskedTextBoxTel1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxTel1.Location = new System.Drawing.Point(105, 15);
            this.MaskedTextBoxTel1.Mask = "(9999)000-000";
            this.MaskedTextBoxTel1.Name = "MaskedTextBoxTel1";
            this.MaskedTextBoxTel1.Size = new System.Drawing.Size(110, 23);
            this.MaskedTextBoxTel1.TabIndex = 3;
            this.MaskedTextBoxTel1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxTel1_MaskInputRejected);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 104);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 23);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Tel/Cel:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(108, 62);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(170, 23);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxCode.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCode.Location = new System.Drawing.Point(108, 18);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(75, 23);
            this.TextBoxCode.TabIndex = 20;
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
            this.Label0.TabIndex = 19;
            this.Label0.Text = "Código:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 23);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Nombre:";
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.GroupBoxCalculation.Location = new System.Drawing.Point(165, 47);
            this.GroupBoxCalculation.Name = "GroupBoxCalculation";
            this.GroupBoxCalculation.Size = new System.Drawing.Size(221, 97);
            this.GroupBoxCalculation.TabIndex = 29;
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
            // MaskedTextBoxTel3
            // 
            this.MaskedTextBoxTel3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxTel3.Location = new System.Drawing.Point(105, 64);
            this.MaskedTextBoxTel3.Mask = "(9999)000-000";
            this.MaskedTextBoxTel3.Name = "MaskedTextBoxTel3";
            this.MaskedTextBoxTel3.Size = new System.Drawing.Size(110, 23);
            this.MaskedTextBoxTel3.TabIndex = 5;
            this.MaskedTextBoxTel3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxTel1_MaskInputRejected);
            // 
            // MaskedTextBoxTel2
            // 
            this.MaskedTextBoxTel2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxTel2.Location = new System.Drawing.Point(105, 40);
            this.MaskedTextBoxTel2.Mask = "(9999)000-000";
            this.MaskedTextBoxTel2.Name = "MaskedTextBoxTel2";
            this.MaskedTextBoxTel2.Size = new System.Drawing.Size(110, 23);
            this.MaskedTextBoxTel2.TabIndex = 4;
            this.MaskedTextBoxTel2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxTel1_MaskInputRejected);
            // 
            // ButtonPrice
            // 
            this.ButtonPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPrice.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrice.Location = new System.Drawing.Point(108, 97);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new System.Drawing.Size(52, 35);
            this.ButtonPrice.TabIndex = 2;
            this.ButtonPrice.Text = "...";
            this.ButtonPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
            // 
            // ButtonCounter
            // 
            this.ButtonCounter.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonCounter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonCounter.Location = new System.Drawing.Point(367, 12);
            this.ButtonCounter.Name = "ButtonCounter";
            this.ButtonCounter.Size = new System.Drawing.Size(19, 23);
            this.ButtonCounter.TabIndex = 34;
            this.ButtonCounter.Text = "-";
            this.ButtonCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCounter.UseVisualStyleBackColor = true;
            this.ButtonCounter.Click += new System.EventHandler(this.ButtonCounter_Click);
            // 
            // TextBoxCounter
            // 
            this.TextBoxCounter.Font = new System.Drawing.Font("Square721 BT", 9.75F);
            this.TextBoxCounter.Location = new System.Drawing.Point(276, 12);
            this.TextBoxCounter.Name = "TextBoxCounter";
            this.TextBoxCounter.ReadOnly = true;
            this.TextBoxCounter.Size = new System.Drawing.Size(85, 23);
            this.TextBoxCounter.TabIndex = 36;
            this.TextBoxCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxCounter.Visible = false;
            // 
            // FormDistributors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.TextBoxCounter);
            this.Controls.Add(this.ButtonCounter);
            this.Controls.Add(this.GroupBoxCalculation);
            this.Controls.Add(this.ButtonPrice);
            this.Controls.Add(this.DataGridViewDistributors);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDistributors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Distribuidoras";
            this.Load += new System.EventHandler(this.FormDistributors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDistributors)).EndInit();
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            this.GroupBoxCalculation.ResumeLayout(false);
            this.GroupBoxCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewDistributors;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTel1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupBoxCalculation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTel3;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel3;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Button ButtonCounter;
        private System.Windows.Forms.TextBox TextBoxCounter;
    }
}