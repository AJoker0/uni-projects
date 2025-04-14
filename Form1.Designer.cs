namespace Titkov_Andrii_2419050_Assignment_3
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
            dgvProducts = new DataGridView();
            colType = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            btnSort = new Button();
            cmbDirection = new ComboBox();
            cmbSortBy = new ComboBox();
            btnAdd = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtColor = new TextBox();
            lblColor = new Label();
            txtType = new TextBox();
            lblType = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colType, colColor, colPrice });
            dgvProducts.Location = new Point(12, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(700, 418);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 8;
            colType.Name = "colType";
            colType.Width = 150;
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 8;
            colColor.Name = "colColor";
            colColor.Width = 150;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 8;
            colPrice.Name = "colPrice";
            colPrice.Width = 150;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(1536, 41);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cmbDirection
            // 
            cmbDirection.FormattingEnabled = true;
            cmbDirection.Location = new Point(864, 43);
            cmbDirection.Name = "cmbDirection";
            cmbDirection.Size = new Size(277, 33);
            cmbDirection.TabIndex = 2;
            cmbDirection.Text = " Items: ascending, descending";
            // 
            // cmbSortBy
            // 
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Location = new Point(1190, 43);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(182, 33);
            cmbSortBy.TabIndex = 3;
            cmbSortBy.Text = "Type, Color, Price";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1536, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(819, 190);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(819, 242);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(1066, 192);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(150, 31);
            txtColor.TabIndex = 7;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(1066, 244);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(55, 25);
            lblColor.TabIndex = 8;
            lblColor.Text = "Color";
            // 
            // txtType
            // 
            txtType.Location = new Point(1301, 190);
            txtType.Name = "txtType";
            txtType.Size = new Size(150, 31);
            txtType.TabIndex = 9;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(1301, 242);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 25);
            lblType.TabIndex = 10;
            lblType.Text = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 815);
            Controls.Add(lblType);
            Controls.Add(txtType);
            Controls.Add(lblColor);
            Controls.Add(txtColor);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
            Controls.Add(cmbSortBy);
            Controls.Add(cmbDirection);
            Controls.Add(btnSort);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnSort;
        private ComboBox cmbDirection;
        private ComboBox cmbSortBy;
        private Button btnAdd;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtColor;
        private Label lblColor;
        private TextBox txtType;
        private Label lblType;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colPrice;
    }
}
