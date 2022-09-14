using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Product
    {
        // Product variables
        public string Type;
        public string Brand;
        public string Model;
        public string Office;
        public DateTime PurchaseDate;
        public int USD;
        public string Currency;
        public double LocalPriceToday;

        // Product constructor
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
        
        // Print method
        public void PrintProduct()
        {
            // Print product in red if purchase date is within 3 months from being 3 years old
            if (PurchaseDate.AddMonths(-3) < DateTime.Now.AddYears(-3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Type.PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) + Office.PadRight(20) + PurchaseDate.ToString("MM/dd/yyyy").PadRight(20) + USD.ToString().PadRight(20) + Currency.PadRight(20) + LocalPriceToday); Console.ResetColor();
            }
            
            // Print product in yellow if purchase date is within 6 months from being 3 years old
            else if (PurchaseDate.AddMonths(-6) < DateTime.Now.AddYears(-3))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Type.PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) + Office.PadRight(20) + PurchaseDate.ToString("MM/dd/yyyy").PadRight(20) + USD.ToString().PadRight(20) + Currency.PadRight(20) + LocalPriceToday);
                Console.ResetColor();
            }
            
            // Print product
            else
            {
                Console.WriteLine(Type.PadRight(20) + Brand.PadRight(20) + Model.PadRight(20) + Office.PadRight(20) + PurchaseDate.ToString("MM/dd/yyyy").PadRight(20) + USD.ToString().PadRight(20) + Currency.PadRight(20) + LocalPriceToday);
            }
        }
    }
}
