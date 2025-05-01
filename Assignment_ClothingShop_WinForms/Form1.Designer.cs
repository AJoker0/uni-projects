namespace TitkovClothingShopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtType = new TextBox();
            txtCut = new TextBox();
            txtColor = new TextBox();
            txtFabric = new TextBox();
            txtSize = new TextBox();
            txtBrand = new TextBox();
            txtBasePrice = new TextBox();
            lblType = new Label();
            label2 = new Label();
            lblColor = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnFilter = new Button();
            btnDelete = new Button();
            lstProducts = new ListBox();
            comboBox1 = new ComboBox();
            comboBoxSize = new ComboBox();
            comboBoxColor = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnEditSizeSurcharges = new Button();
            btnEditColorSurcharges = new Button();
            btnEditBrandSurcharges = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtType
            // 
            txtType.Location = new Point(19, 44);
            txtType.Name = "txtType";
            txtType.Size = new Size(150, 31);
            txtType.TabIndex = 0;
            // 
            // txtCut
            // 
            txtCut.Location = new Point(212, 44);
            txtCut.Name = "txtCut";
            txtCut.Size = new Size(150, 31);
            txtCut.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(399, 44);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(150, 31);
            txtColor.TabIndex = 2;
            // 
            // txtFabric
            // 
            txtFabric.Location = new Point(598, 44);
            txtFabric.Name = "txtFabric";
            txtFabric.Size = new Size(150, 31);
            txtFabric.TabIndex = 3;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(791, 44);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(150, 31);
            txtSize.TabIndex = 4;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(988, 44);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(150, 31);
            txtBrand.TabIndex = 5;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(1170, 44);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(150, 31);
            txtBasePrice.TabIndex = 6;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(55, 78);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 25);
            lblType.TabIndex = 7;
            lblType.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 8;
            label2.Text = "Cut";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(435, 78);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(55, 25);
            lblColor.TabIndex = 9;
            lblColor.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 78);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 10;
            label4.Text = "Fabric";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(827, 78);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 11;
            label5.Text = "Size";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1024, 78);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 12;
            label6.Text = "Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1206, 78);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 13;
            label7.Text = "BasePrice";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(328, 648);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 54);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(586, 588);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(135, 54);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(423, 588);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 54);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(506, 648);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(135, 54);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(1295, 176);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(135, 54);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(692, 648);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 54);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 25;
            lstProducts.Location = new Point(12, 27);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(1049, 429);
            lstProducts.TabIndex = 20;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 22;
            comboBox1.Text = "Type";
            // 
            // comboBoxSize
            // 
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Location = new Point(212, 30);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(182, 33);
            comboBoxSize.TabIndex = 23;
            comboBoxSize.Text = "Size";
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(424, 30);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(182, 33);
            comboBoxColor.TabIndex = 24;
            comboBoxColor.Text = "Color";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBasePrice);
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(txtCut);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtFabric);
            groupBox1.Controls.Add(txtSize);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(lblType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblColor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 462);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1335, 120);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxColor);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(comboBoxSize);
            groupBox2.Location = new Point(1067, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(606, 82);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // btnEditSizeSurcharges
            // 
            btnEditSizeSurcharges.Location = new Point(1067, 312);
            btnEditSizeSurcharges.Name = "btnEditSizeSurcharges";
            btnEditSizeSurcharges.Size = new Size(180, 34);
            btnEditSizeSurcharges.TabIndex = 27;
            btnEditSizeSurcharges.Text = "Edit Size Surcharges";
            btnEditSizeSurcharges.UseVisualStyleBackColor = true;
            btnEditSizeSurcharges.Click += btnEditSizeSurcharges_Click;
            // 
            // btnEditColorSurcharges
            // 
            btnEditColorSurcharges.Location = new Point(1277, 312);
            btnEditColorSurcharges.Name = "btnEditColorSurcharges";
            btnEditColorSurcharges.Size = new Size(192, 34);
            btnEditColorSurcharges.TabIndex = 28;
            btnEditColorSurcharges.Text = "Edit Color Surcharges";
            btnEditColorSurcharges.UseVisualStyleBackColor = true;
            btnEditColorSurcharges.Click += btnEditColorSurcharges_Click;
            // 
            // btnEditBrandSurcharges
            // 
            btnEditBrandSurcharges.Location = new Point(1509, 312);
            btnEditBrandSurcharges.Name = "btnEditBrandSurcharges";
            btnEditBrandSurcharges.Size = new Size(204, 34);
            btnEditBrandSurcharges.TabIndex = 29;
            btnEditBrandSurcharges.Text = "Edit Brand Surcharges";
            btnEditBrandSurcharges.UseVisualStyleBackColor = true;
            btnEditBrandSurcharges.Click += btnEditBrandSurcharges_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 816);
            Controls.Add(btnEditBrandSurcharges);
            Controls.Add(btnEditColorSurcharges);
            Controls.Add(btnEditSizeSurcharges);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnFilter);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtType;
        private TextBox txtCut;
        private TextBox txtColor;
        private TextBox txtFabric;
        private TextBox txtSize;
        private TextBox txtBrand;
        private TextBox txtBasePrice;
        private Label lblType;
        private Label label2;
        private Label lblColor;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSave;
        private Button btnLoad;
        private Button btnFilter;
        private Button btnDelete;
        private ListBox lstProducts;
        private ComboBox comboBox1;
        private ComboBox comboBoxSize;
        private ComboBox comboBoxColor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnEditSizeSurcharges;
        private Button btnEditColorSurcharges;
        private Button btnEditBrandSurcharges;
    }
}
