namespace TitkovClothingShopApp
{
    partial class ColorSurchargeEditor
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
            txtNewColor = new TextBox();
            txtNewValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddOrUpdate = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lstSurcharges
            // 
            lstSurcharges.FormattingEnabled = true;
            lstSurcharges.ItemHeight = 25;
            lstSurcharges.Location = new Point(12, 12);
            lstSurcharges.Name = "lstSurcharges";
            lstSurcharges.Size = new Size(305, 204);
            lstSurcharges.TabIndex = 0;
            // 
            // txtNewColor
            // 
            txtNewColor.Location = new Point(486, 44);
            txtNewColor.Name = "txtNewColor";
            txtNewColor.Size = new Size(150, 31);
            txtNewColor.TabIndex = 1;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(701, 44);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(150, 31);
            txtNewValue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 91);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 3;
            label1.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(733, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Value";
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Location = new Point(489, 161);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(147, 34);
            btnAddOrUpdate.TabIndex = 5;
            btnAddOrUpdate.Text = "Add / Update";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(701, 161);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ColorSurchargeEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 541);
            Controls.Add(btnClose);
            Controls.Add(btnAddOrUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewValue);
            Controls.Add(txtNewColor);
            Controls.Add(lstSurcharges);
            Name = "ColorSurchargeEditor";
            Text = "ColorSurchargeEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSurcharges;
        private TextBox txtNewColor;
        private TextBox txtNewValue;
        private Label label1;
        private Label label2;
        private Button btnAddOrUpdate;
        private Button btnClose;
    }
}