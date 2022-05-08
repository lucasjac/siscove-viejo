namespace SISCOVE___Todo_Envase
{
    partial class FormComparison
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComparison));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ComboBoxDistributor1 = new System.Windows.Forms.ComboBox();
            this.NumericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.GroupBoxQuantity = new System.Windows.Forms.GroupBox();
            this.MaskedTextBoxPrice1 = new System.Windows.Forms.MaskedTextBox();
            this.ComboBoxProduct1 = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor2 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct2 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice2 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor3 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct3 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice3 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor4 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct4 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice4 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor5 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct5 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice5 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor6 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct6 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice6 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor7 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct7 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice7 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.ComboBoxDistributor8 = new System.Windows.Forms.ComboBox();
            this.ComboBoxProduct8 = new System.Windows.Forms.ComboBox();
            this.MaskedTextBoxPrice8 = new System.Windows.Forms.MaskedTextBox();
            this.ButtonComparison = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).BeginInit();
            this.GroupBoxQuantity.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(53, 19);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(43, 36);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "OK";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ComboBoxDistributor1
            // 
            this.ComboBoxDistributor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor1.FormattingEnabled = true;
            this.ComboBoxDistributor1.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor1.Name = "ComboBoxDistributor1";
            this.ComboBoxDistributor1.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor1.TabIndex = 3;
            // 
            // NumericUpDownQuantity
            // 
            this.NumericUpDownQuantity.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownQuantity.Location = new System.Drawing.Point(6, 27);
            this.NumericUpDownQuantity.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            this.NumericUpDownQuantity.Size = new System.Drawing.Size(41, 23);
            this.NumericUpDownQuantity.TabIndex = 1;
            this.NumericUpDownQuantity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.NumericUpDownQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericUpDownQuantity_KeyPress);
            // 
            // GroupBoxQuantity
            // 
            this.GroupBoxQuantity.Controls.Add(this.ButtonSearch);
            this.GroupBoxQuantity.Controls.Add(this.NumericUpDownQuantity);
            this.GroupBoxQuantity.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxQuantity.Name = "GroupBoxQuantity";
            this.GroupBoxQuantity.Size = new System.Drawing.Size(104, 70);
            this.GroupBoxQuantity.TabIndex = 1;
            this.GroupBoxQuantity.TabStop = false;
            // 
            // MaskedTextBoxPrice1
            // 
            this.MaskedTextBoxPrice1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice1.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice1.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice1.Name = "MaskedTextBoxPrice1";
            this.MaskedTextBoxPrice1.ReadOnly = true;
            this.MaskedTextBoxPrice1.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice1.TabIndex = 5;
            this.MaskedTextBoxPrice1.TabStop = false;
            // 
            // ComboBoxProduct1
            // 
            this.ComboBoxProduct1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct1.FormattingEnabled = true;
            this.ComboBoxProduct1.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct1.Name = "ComboBoxProduct1";
            this.ComboBoxProduct1.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct1.TabIndex = 4;
            this.ComboBoxProduct1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProduct1_SelectedIndexChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ComboBoxDistributor1);
            this.GroupBox1.Controls.Add(this.ComboBoxProduct1);
            this.GroupBox1.Controls.Add(this.MaskedTextBoxPrice1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 120);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(268, 90);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ComboBoxDistributor2);
            this.GroupBox2.Controls.Add(this.ComboBoxProduct2);
            this.GroupBox2.Controls.Add(this.MaskedTextBoxPrice2);
            this.GroupBox2.Location = new System.Drawing.Point(284, 120);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(268, 90);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            // 
            // ComboBoxDistributor2
            // 
            this.ComboBoxDistributor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor2.FormattingEnabled = true;
            this.ComboBoxDistributor2.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor2.Name = "ComboBoxDistributor2";
            this.ComboBoxDistributor2.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor2.TabIndex = 5;
            // 
            // ComboBoxProduct2
            // 
            this.ComboBoxProduct2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct2.FormattingEnabled = true;
            this.ComboBoxProduct2.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct2.Name = "ComboBoxProduct2";
            this.ComboBoxProduct2.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct2.TabIndex = 6;
            // 
            // MaskedTextBoxPrice2
            // 
            this.MaskedTextBoxPrice2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice2.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice2.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice2.Name = "MaskedTextBoxPrice2";
            this.MaskedTextBoxPrice2.ReadOnly = true;
            this.MaskedTextBoxPrice2.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice2.TabIndex = 5;
            this.MaskedTextBoxPrice2.TabStop = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ComboBoxDistributor3);
            this.GroupBox3.Controls.Add(this.ComboBoxProduct3);
            this.GroupBox3.Controls.Add(this.MaskedTextBoxPrice3);
            this.GroupBox3.Enabled = false;
            this.GroupBox3.Location = new System.Drawing.Point(12, 216);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(268, 90);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // ComboBoxDistributor3
            // 
            this.ComboBoxDistributor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor3.FormattingEnabled = true;
            this.ComboBoxDistributor3.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor3.Name = "ComboBoxDistributor3";
            this.ComboBoxDistributor3.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor3.TabIndex = 7;
            // 
            // ComboBoxProduct3
            // 
            this.ComboBoxProduct3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct3.FormattingEnabled = true;
            this.ComboBoxProduct3.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct3.Name = "ComboBoxProduct3";
            this.ComboBoxProduct3.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct3.TabIndex = 8;
            // 
            // MaskedTextBoxPrice3
            // 
            this.MaskedTextBoxPrice3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice3.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice3.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice3.Name = "MaskedTextBoxPrice3";
            this.MaskedTextBoxPrice3.ReadOnly = true;
            this.MaskedTextBoxPrice3.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice3.TabIndex = 5;
            this.MaskedTextBoxPrice3.TabStop = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.ComboBoxDistributor4);
            this.GroupBox4.Controls.Add(this.ComboBoxProduct4);
            this.GroupBox4.Controls.Add(this.MaskedTextBoxPrice4);
            this.GroupBox4.Enabled = false;
            this.GroupBox4.Location = new System.Drawing.Point(284, 216);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(268, 90);
            this.GroupBox4.TabIndex = 5;
            this.GroupBox4.TabStop = false;
            // 
            // ComboBoxDistributor4
            // 
            this.ComboBoxDistributor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor4.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor4.FormattingEnabled = true;
            this.ComboBoxDistributor4.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor4.Name = "ComboBoxDistributor4";
            this.ComboBoxDistributor4.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor4.TabIndex = 9;
            // 
            // ComboBoxProduct4
            // 
            this.ComboBoxProduct4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct4.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct4.FormattingEnabled = true;
            this.ComboBoxProduct4.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct4.Name = "ComboBoxProduct4";
            this.ComboBoxProduct4.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct4.TabIndex = 10;
            // 
            // MaskedTextBoxPrice4
            // 
            this.MaskedTextBoxPrice4.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice4.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice4.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice4.Name = "MaskedTextBoxPrice4";
            this.MaskedTextBoxPrice4.ReadOnly = true;
            this.MaskedTextBoxPrice4.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice4.TabIndex = 5;
            this.MaskedTextBoxPrice4.TabStop = false;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.ComboBoxDistributor5);
            this.GroupBox5.Controls.Add(this.ComboBoxProduct5);
            this.GroupBox5.Controls.Add(this.MaskedTextBoxPrice5);
            this.GroupBox5.Enabled = false;
            this.GroupBox5.Location = new System.Drawing.Point(12, 312);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(268, 90);
            this.GroupBox5.TabIndex = 6;
            this.GroupBox5.TabStop = false;
            // 
            // ComboBoxDistributor5
            // 
            this.ComboBoxDistributor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor5.FormattingEnabled = true;
            this.ComboBoxDistributor5.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor5.Name = "ComboBoxDistributor5";
            this.ComboBoxDistributor5.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor5.TabIndex = 11;
            // 
            // ComboBoxProduct5
            // 
            this.ComboBoxProduct5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct5.FormattingEnabled = true;
            this.ComboBoxProduct5.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct5.Name = "ComboBoxProduct5";
            this.ComboBoxProduct5.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct5.TabIndex = 12;
            // 
            // MaskedTextBoxPrice5
            // 
            this.MaskedTextBoxPrice5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice5.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice5.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice5.Name = "MaskedTextBoxPrice5";
            this.MaskedTextBoxPrice5.ReadOnly = true;
            this.MaskedTextBoxPrice5.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice5.TabIndex = 5;
            this.MaskedTextBoxPrice5.TabStop = false;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.ComboBoxDistributor6);
            this.GroupBox6.Controls.Add(this.ComboBoxProduct6);
            this.GroupBox6.Controls.Add(this.MaskedTextBoxPrice6);
            this.GroupBox6.Enabled = false;
            this.GroupBox6.Location = new System.Drawing.Point(284, 312);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(268, 90);
            this.GroupBox6.TabIndex = 7;
            this.GroupBox6.TabStop = false;
            // 
            // ComboBoxDistributor6
            // 
            this.ComboBoxDistributor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor6.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor6.FormattingEnabled = true;
            this.ComboBoxDistributor6.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor6.Name = "ComboBoxDistributor6";
            this.ComboBoxDistributor6.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor6.TabIndex = 13;
            // 
            // ComboBoxProduct6
            // 
            this.ComboBoxProduct6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct6.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct6.FormattingEnabled = true;
            this.ComboBoxProduct6.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct6.Name = "ComboBoxProduct6";
            this.ComboBoxProduct6.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct6.TabIndex = 14;
            // 
            // MaskedTextBoxPrice6
            // 
            this.MaskedTextBoxPrice6.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice6.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice6.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice6.Name = "MaskedTextBoxPrice6";
            this.MaskedTextBoxPrice6.ReadOnly = true;
            this.MaskedTextBoxPrice6.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice6.TabIndex = 5;
            this.MaskedTextBoxPrice6.TabStop = false;
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.ComboBoxDistributor7);
            this.GroupBox7.Controls.Add(this.ComboBoxProduct7);
            this.GroupBox7.Controls.Add(this.MaskedTextBoxPrice7);
            this.GroupBox7.Enabled = false;
            this.GroupBox7.Location = new System.Drawing.Point(12, 408);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(268, 90);
            this.GroupBox7.TabIndex = 8;
            this.GroupBox7.TabStop = false;
            // 
            // ComboBoxDistributor7
            // 
            this.ComboBoxDistributor7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor7.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor7.FormattingEnabled = true;
            this.ComboBoxDistributor7.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor7.Name = "ComboBoxDistributor7";
            this.ComboBoxDistributor7.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor7.TabIndex = 15;
            // 
            // ComboBoxProduct7
            // 
            this.ComboBoxProduct7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct7.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct7.FormattingEnabled = true;
            this.ComboBoxProduct7.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct7.Name = "ComboBoxProduct7";
            this.ComboBoxProduct7.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct7.TabIndex = 16;
            // 
            // MaskedTextBoxPrice7
            // 
            this.MaskedTextBoxPrice7.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice7.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice7.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice7.Name = "MaskedTextBoxPrice7";
            this.MaskedTextBoxPrice7.ReadOnly = true;
            this.MaskedTextBoxPrice7.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice7.TabIndex = 5;
            this.MaskedTextBoxPrice7.TabStop = false;
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.ComboBoxDistributor8);
            this.GroupBox8.Controls.Add(this.ComboBoxProduct8);
            this.GroupBox8.Controls.Add(this.MaskedTextBoxPrice8);
            this.GroupBox8.Enabled = false;
            this.GroupBox8.Location = new System.Drawing.Point(284, 408);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(268, 90);
            this.GroupBox8.TabIndex = 9;
            this.GroupBox8.TabStop = false;
            // 
            // ComboBoxDistributor8
            // 
            this.ComboBoxDistributor8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDistributor8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistributor8.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDistributor8.FormattingEnabled = true;
            this.ComboBoxDistributor8.Location = new System.Drawing.Point(6, 19);
            this.ComboBoxDistributor8.Name = "ComboBoxDistributor8";
            this.ComboBoxDistributor8.Size = new System.Drawing.Size(256, 24);
            this.ComboBoxDistributor8.TabIndex = 17;
            // 
            // ComboBoxProduct8
            // 
            this.ComboBoxProduct8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProduct8.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProduct8.FormattingEnabled = true;
            this.ComboBoxProduct8.Location = new System.Drawing.Point(6, 49);
            this.ComboBoxProduct8.Name = "ComboBoxProduct8";
            this.ComboBoxProduct8.Size = new System.Drawing.Size(160, 24);
            this.ComboBoxProduct8.TabIndex = 18;
            // 
            // MaskedTextBoxPrice8
            // 
            this.MaskedTextBoxPrice8.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBoxPrice8.Location = new System.Drawing.Point(172, 49);
            this.MaskedTextBoxPrice8.Mask = "9999999 gs,";
            this.MaskedTextBoxPrice8.Name = "MaskedTextBoxPrice8";
            this.MaskedTextBoxPrice8.ReadOnly = true;
            this.MaskedTextBoxPrice8.Size = new System.Drawing.Size(90, 23);
            this.MaskedTextBoxPrice8.TabIndex = 5;
            this.MaskedTextBoxPrice8.TabStop = false;
            // 
            // ButtonComparison
            // 
            this.ButtonComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonComparison.Location = new System.Drawing.Point(202, 71);
            this.ButtonComparison.Name = "ButtonComparison";
            this.ButtonComparison.Size = new System.Drawing.Size(161, 43);
            this.ButtonComparison.TabIndex = 19;
            this.ButtonComparison.Text = "Comparar precios";
            this.ButtonComparison.UseVisualStyleBackColor = true;
            this.ButtonComparison.Click += new System.EventHandler(this.ButtonComparison_Click);
            // 
            // FormComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this.ButtonComparison);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox8);
            this.Controls.Add(this.GroupBox7);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBoxQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComparison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOVE - Comparación de precios";
            this.Load += new System.EventHandler(this.FormComparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).EndInit();
            this.GroupBoxQuantity.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ComboBox ComboBoxDistributor1;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuantity;
        private System.Windows.Forms.GroupBox GroupBoxQuantity;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice1;
        private System.Windows.Forms.ComboBox ComboBoxProduct1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.ComboBox ComboBoxDistributor2;
        private System.Windows.Forms.ComboBox ComboBoxProduct2;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice2;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.ComboBox ComboBoxDistributor3;
        private System.Windows.Forms.ComboBox ComboBoxProduct3;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice3;
        private System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.ComboBox ComboBoxDistributor4;
        private System.Windows.Forms.ComboBox ComboBoxProduct4;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice4;
        private System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.ComboBox ComboBoxDistributor5;
        private System.Windows.Forms.ComboBox ComboBoxProduct5;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice5;
        private System.Windows.Forms.GroupBox GroupBox6;
        private System.Windows.Forms.ComboBox ComboBoxDistributor6;
        private System.Windows.Forms.ComboBox ComboBoxProduct6;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice6;
        private System.Windows.Forms.GroupBox GroupBox7;
        private System.Windows.Forms.ComboBox ComboBoxDistributor7;
        private System.Windows.Forms.ComboBox ComboBoxProduct7;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice7;
        private System.Windows.Forms.GroupBox GroupBox8;
        private System.Windows.Forms.ComboBox ComboBoxDistributor8;
        private System.Windows.Forms.ComboBox ComboBoxProduct8;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPrice8;
        private System.Windows.Forms.Button ButtonComparison;
    }
}