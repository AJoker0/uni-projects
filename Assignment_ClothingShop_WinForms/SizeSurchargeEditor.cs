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
    public partial class SizeSurchargeEditor : Form
    {
        private SurchargeConfig config;
        public SizeSurchargeEditor(SurchargeConfig surchargeConfig)
        {
            InitializeComponent();
            this.config = surchargeConfig;
            RefreshList();
        }

        private void RefreshList()
        {
            lstSurcharges.Items.Clear();
            foreach (var entry in config.SizeSurcharges)
            {
                //lstSurcharges.Items.Add($"{entry.Key}: {entry.Value:C}");
                lstSurcharges.Items.Add($"{entry.Key}: {entry.Value.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))}");
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            string size = txtNewSize.Text.Trim();
            if (!decimal.TryParse(txtNewValue.Text.Trim(), out decimal value))
            {
                MessageBox.Show("Enter a valid decimal value");
                return;
            }
            if (string.IsNullOrEmpty(size))
            {
                MessageBox.Show("Size cannot be empty");
                return;
            }
            config.SizeSurcharges[size] = value;
            RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
