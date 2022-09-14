using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Product
    {
        string Type;
        string Brand;
        string Model;
        string Office;
        DateTime PurchaseDate;
        int USD;
        string Currency;
        double LocalPriceToday;

        public Product(string type, string brand, string model, string office, DateTime purchaseDate, int uSD, string currency, double localPriceToday)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Office = office;
            PurchaseDate = purchaseDate;
            USD = uSD;
            Currency = currency;
            LocalPriceToday = localPriceToday;
        }
    }
}
