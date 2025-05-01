using System.Collections.Generic;

namespace TitkovClothingShopApp
{
    public class SurchargeConfig
    {
        public Dictionary<string, decimal> SizeSurcharges { get; set; } = new();
        public Dictionary<string, decimal> ColorSurcharges { get; set; } = new();
        public Dictionary<string, decimal> BrandSurcharges { get; set; } = new();

        public decimal GetSurcharge(string size, string color, string brand)
        {
            decimal total = 0;
            if (SizeSurcharges.ContainsKey(size)) total += SizeSurcharges[size];
            if (ColorSurcharges.ContainsKey(color)) total += ColorSurcharges[color];
            if (BrandSurcharges.ContainsKey(brand)) total += BrandSurcharges[brand];
            return total;
        }
    }
}
