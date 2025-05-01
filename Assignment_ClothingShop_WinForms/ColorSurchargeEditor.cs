using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitkovClothingShopApp
{
    public partial class ColorSurchargeEditor : Form
    {
        private SurchargeConfig config;
        public ColorSurchargeEditor(SurchargeConfig surchargeConfig)
        {
            InitializeComponent();
            this.config = surchargeConfig;
            RefreshList();
        }
        private void RefreshList()
        {
            lstSurcharges.Items.Clear();
            foreach (var kvp in config.ColorSurcharges)
            {
                lstSurcharges.Items.Add($"{kvp.Key}: {kvp.Value.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            string color = txtNewColor.Text.Trim();
            if (!decimal.TryParse(txtNewValue.Text.Trim(), out decimal value))
            {
                MessageBox.Show("Enter a valid decimal value");
                return;
            }
            if (string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Color cannot be empty");
                return;
            }
            config.ColorSurcharges[color] = value;
            RefreshList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
