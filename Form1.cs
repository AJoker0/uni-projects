using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Titkov_Andrii_2419050_Assignment_3
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            cmbSortBy.Items.AddRange(new string[] { "Type", "Color", "Price" });
            cmbDirection.Items.AddRange(new string[] { "Ascending", "Descending" });
            cmbSortBy.SelectedIndex = 0;
            cmbDirection.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtType.Text) || string.IsNullOrWhiteSpace(txtColor.Text) || !double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter valid product info.");
                return;
            }

            Product p = new Product(txtType.Text, txtColor.Text, price);
            products.Add(p);
            txtType.Clear(); txtColor.Clear(); txtPrice.Clear();
            UpdateGrid();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string field = cmbSortBy.SelectedItem.ToString();
            bool ascending = cmbDirection.SelectedItem.ToString() == "Ascending";

            BubbleSort(products, field, ascending);
            UpdateGrid();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void UpdateGrid()
        {
            dgvProducts.Rows.Clear();

            foreach (Product p in products)
            {
                dgvProducts.Rows.Add(p.Type, p.Color, p.Price);
            }
        }


        private void BubbleSort(List<Product> list, string field, bool asc)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    bool swap = false;
                    switch (field)
                    {
                        case "Type":
                            swap = asc ? list[j].Type.CompareTo(list[j + 1].Type) > 0 : list[j].Type.CompareTo(list[j + 1].Type) < 0;
                            break;
                        case "Color":
                            swap = asc ? list[j].Color.CompareTo(list[j + 1].Color) > 0 : list[j].Color.CompareTo(list[j + 1].Color) < 0;
                            break;
                        case "Price":
                            swap = asc ? list[j].Price > list[j + 1].Price : list[j].Price < list[j + 1].Price;
                            break;
                    }

                    if (swap)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
