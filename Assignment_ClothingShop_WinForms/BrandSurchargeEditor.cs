using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TitkovClothingShopApp
{
    public partial class BrandSurchargeEditor : Form
    {
        private SurchargeConfig config;
        public BrandSurchargeEditor(SurchargeConfig config)
        {
            InitializeComponent();
            this.config = config;
            RefreshList();
        }
        private void RefreshList()
        {
            lstSurcharges.Items.Clear();
            foreach (var kvp in config.BrandSurcharges)
            {
                lstSurcharges.Items.Add($"{kvp.Key}:{kvp.Value.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            string brand = txtNewBrand.Text.Trim();
            if (!decimal.TryParse(txtNewValue.Text.Trim(), out decimal value))
            {
                MessageBox.Show("Enter a valid decimal value");
                return;
            }
            if (!string.IsNullOrEmpty(brand))
            {
                config.BrandSurcharges[brand] = value;
                RefreshList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
