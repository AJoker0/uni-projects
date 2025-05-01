namespace TitkovClothingShopApp
{
    partial class BrandSurchargeEditor
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
            lstSurcharges = new ListBox();
            txtNewBrand = new TextBox();
            txtNewValue = new TextBox();
            btnAddOrUpdate = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstSurcharges
            // 
            lstSurcharges.FormattingEnabled = true;
            lstSurcharges.ItemHeight = 25;
            lstSurcharges.Location = new Point(12, 12);
            lstSurcharges.Name = "lstSurcharges";
            lstSurcharges.Size = new Size(301, 204);
            lstSurcharges.TabIndex = 0;
            // 
            // txtNewBrand
            // 
            txtNewBrand.Location = new Point(371, 30);
            txtNewBrand.Name = "txtNewBrand";
            txtNewBrand.Size = new Size(150, 31);
            txtNewBrand.TabIndex = 2;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(569, 30);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(150, 31);
            txtNewValue.TabIndex = 3;
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Location = new Point(369, 136);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(152, 34);
            btnAddOrUpdate.TabIndex = 6;
            btnAddOrUpdate.Text = "Add / Update";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(569, 136);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 34);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 64);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 8;
            label1.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 9;
            label2.Text = "Value";
            // 
            // BrandSurchargeEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAddOrUpdate);
            Controls.Add(txtNewValue);
            Controls.Add(txtNewBrand);
            Controls.Add(lstSurcharges);
            Name = "BrandSurchargeEditor";
            Text = "BrandSurchargeEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSurcharges;
        private TextBox txtNewBrand;
        private TextBox txtNewValue;
        private Button btnAddOrUpdate;
        private Button btnClose;
        private Label label1;
        private Label label2;
    }
}