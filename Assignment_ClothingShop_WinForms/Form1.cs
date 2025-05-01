using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TitkovClothingShopApp
{
    public partial class Form1 : Form
    {
        private const string ProductDataFile = "products.txt";

        private const string SizeSurchargeFile = "size_surcharges.txt";
        private const string ColorSurchargeFile = "color_surcharges.txt";
        private const string BrandSurchargeFile = "brand_surcharges.txt";

        private void SaveSurcharges()
        {
            SaveDictionaryToFile(surchargeConfig.SizeSurcharges, SizeSurchargeFile);
            SaveDictionaryToFile(surchargeConfig.ColorSurcharges, ColorSurchargeFile);
            SaveDictionaryToFile(surchargeConfig.BrandSurcharges, BrandSurchargeFile);
        }

        private void SaveDictionaryToFile(Dictionary<string, decimal> dictionary, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kvp in dictionary)
                {
                    writer.WriteLine($"{kvp.Key}={kvp.Value}");
                }
            }
        }

        private void LoadSurcharges()
        {
            surchargeConfig.SizeSurcharges = LoadDictionaryFromFile(SizeSurchargeFile);
            surchargeConfig.ColorSurcharges = LoadDictionaryFromFile(ColorSurchargeFile);
            surchargeConfig.BrandSurcharges = LoadDictionaryFromFile(BrandSurchargeFile);
        }

        private Dictionary<string, decimal> LoadDictionaryFromFile(string filePath)
        {
            var dictionary = new Dictionary<string, decimal>();
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split('=');
                    if (parts.Length == 2 && decimal.TryParse(parts[1], out decimal value))
                    {
                        dictionary[parts[0]] = value;
                    }
                }
            }
            return dictionary;
        }


        private SurchargeConfig surchargeConfig = new SurchargeConfig
        {
            SizeSurcharges = new Dictionary<string, decimal>
            {
                { "XXL", 5 },
                { "XXXL", 10 }
            },
            ColorSurcharges = new Dictionary<string, decimal>
            {
                { "Gold", 10 },
                { "Neon", 15 },
                { "Platinum", 20 }
            },
            BrandSurcharges = new Dictionary<string, decimal>
            {
                { "Supreme", 20 },
                { "Balenciaga", 25 }
            }
        };
        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSurcharges();
            comboBox1.Items.AddRange(new string[] { "Jacket", "Pants", "Shirt", "Socks" });
            comboBoxSize.Items.AddRange(new string[] { "S", "M", "L", "XL", "XXL", "XXXL" });
            comboBoxColor.Items.AddRange(new string[] { "Black", "White", "Gold", "Neon", "Platinum" });
        }

        private void UpdateProductList()
        {
            lstProducts.Items.Clear();
            foreach (var product in products)
            {
                lstProducts.Items.Add(product.ToDisplayString(surchargeConfig));
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBasePrice.Text, out decimal basePrice))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            Product product = new Product
            {
                Type = txtType.Text,
                Cut = txtCut.Text,
                Color = txtColor.Text,
                Fabric = txtFabric.Text,
                Size = txtSize.Text,
                Brand = txtBrand.Text,
                BasePrice = basePrice
            };
            products.Add(product);
            UpdateProductList();
            Product.SaveToFile(ProductDataFile, products); // Auto-save!
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                products.RemoveAt(lstProducts.SelectedIndex);
                UpdateProductList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                Product selected = products[lstProducts.SelectedIndex];
                selected.Type = txtType.Text;
                selected.Cut = txtCut.Text;
                selected.Color = txtColor.Text;
                selected.Fabric = txtFabric.Text;
                selected.Size = txtSize.Text;
                selected.Brand = txtBrand.Text;
                selected.BasePrice = decimal.Parse(txtBasePrice.Text);
                UpdateProductList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product.SaveToFile(ProductDataFile, products);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(ProductDataFile))
            {
                products = Product.LoadFromFile(ProductDataFile);
                UpdateProductList();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            /*string filterType = comboBox1.SelectedItem?.ToString();
            lstProducts.Items.Clear();
            foreach (var p in products)
            {
                if (p.Type == filterType)
                {
                    lstProducts.Items.Add(p.ToDisplayString(surchargeConfig));
                }
            }*/
            string selectedType = comboBox1.SelectedItem?.ToString();
            string selectedSize = comboBoxSize.SelectedItem?.ToString();
            string selectedColor = comboBoxColor.SelectedItem?.ToString();

            lstProducts.Items.Clear();

            foreach (var product in products)
            {
                bool typeMatch = string.IsNullOrEmpty(selectedType) || product.Type == selectedType;
                bool sizeMatch = string.IsNullOrEmpty(selectedSize) || product.Size == selectedSize;
                bool colorMatch = string.IsNullOrEmpty(selectedColor) || product.Color == selectedColor;

                if (typeMatch && sizeMatch && colorMatch)
                {
                    lstProducts.Items.Add(product.ToDisplayString(surchargeConfig));
                }
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                Product selected = products[lstProducts.SelectedIndex];
                txtType.Text = selected.Type;
                txtCut.Text = selected.Cut;
                txtColor.Text = selected.Color;
                txtFabric.Text = selected.Fabric;
                txtSize.Text = selected.Size;
                txtBrand.Text = selected.Brand;
                txtBasePrice.Text = selected.BasePrice.ToString();
            }
        }

        private void UpdateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditSizeSurcharges_Click(object sender, EventArgs e)
        {
            SizeSurchargeEditor editor = new SizeSurchargeEditor(surchargeConfig);
            editor.ShowDialog();
            SaveSurcharges();
            UpdateProductList();
        }

        private void btnEditColorSurcharges_Click(object sender, EventArgs e)
        {
            ColorSurchargeEditor editor = new ColorSurchargeEditor(surchargeConfig);
            editor.ShowDialog();
            SaveSurcharges();
            UpdateProductList();
        }

        private void btnEditBrandSurcharges_Click(object sender, EventArgs e)
        {
            var editor = new BrandSurchargeEditor(surchargeConfig);
            editor.ShowDialog();
            SaveSurcharges();
            UpdateProductList();
        }
    }
}
