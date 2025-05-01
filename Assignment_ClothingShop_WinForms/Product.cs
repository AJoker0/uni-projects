using System;
using System.Collections.Generic;
using System.IO;

namespace TitkovClothingShopApp
{
    public class Product
    {
        /*private const decimal SizeSurcharge = 5;
        private const decimal ColorSurcharge = 10;
        private const decimal BrandSurcharge = 20;*/
        private const string Delimiter = ";";

        public string Type { get; set; } = string.Empty;
        public string Cut { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Fabric { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }

        public Product() { }

        /*public decimal GetFinalPrice()
        {
            decimal finalPrice = BasePrice;
            if (Size == "XXL" || Size == "XXXL") finalPrice += SizeSurcharge;
            if (Color == "Gold" || Color == "Neon" || Color == "Platinum") finalPrice += ColorSurcharge;
            if (Brand == "Supreme" || Brand == "Balenciaga") finalPrice += BrandSurcharge;
            return finalPrice;
        }*/

        public decimal GetFinalPrice(SurchargeConfig config)
        {
            return BasePrice + config.GetSurcharge(Size, Color, Brand);
        }


        public string ToDisplayString(SurchargeConfig config)
        {
            return $"{Type} - {Color} - {Size} - {Brand} - {GetFinalPrice(config)}$";
        }


        public string ToDataString()
        {
            return string.Join(Delimiter, Type, Cut, Color, Fabric, Size, Brand, BasePrice);
        }

        public static Product FromDataString(string line)
        {
            string[] parts = line.Split(Delimiter);
            return new Product
            {
                Type = parts[0],
                Cut = parts[1],
                Color = parts[2],
                Fabric = parts[3],
                Size = parts[4],
                Brand = parts[5],
                BasePrice = decimal.Parse(parts[6])
            };
        }

        public static void SaveToFile(string filePath, List<Product> products)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            foreach (var p in products)
            {
                writer.WriteLine(p.ToDataString());
            }
        }

        public static List<Product> LoadFromFile(string filePath)
        {
            List<Product> list = new List<Product>();
            using StreamReader reader = new StreamReader(filePath);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(FromDataString(line));
            }
            return list;
        }
    }
}
