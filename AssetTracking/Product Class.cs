using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracking
{
    internal class Product
    {
        public string Type;
        public string Brand;
        public string Model;
        public string Office;
        public DateTime PurchaseDate;
        public int USD;
        public string Currency;
        public double LocalPriceToday;


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
        
        
        public void PrintProduct()
        {
            if (PurchaseDate.AddMonths(3) < DateTime.Now.AddYears(3))
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine(Type.PadRight(30), Brand.PadRight(30), Model.PadRight(30), Office.PadRight(30), PurchaseDate.ToString().PadRight(30), USD.ToString().PadRight(30), Currency.PadRight(30), LocalPriceToday);
                Console.ResetColor();
            }
            else if (PurchaseDate.AddMonths(6) < DateTime.Now.AddYears(3))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Type.PadRight(30), Brand.PadRight(30), Model.PadRight(30), Office.PadRight(30), PurchaseDate.ToString().PadRight(30), USD.ToString().PadRight(30), Currency.PadRight(30), LocalPriceToday);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(Type.PadRight(30), Brand.PadRight(30), Model.PadRight(30), Office.PadRight(30), PurchaseDate.ToString().PadRight(30), USD.ToString().PadRight(30), Currency.PadRight(30), LocalPriceToday);
            }
        }
    }
   
    //internal class Phone : Product
    //{
    //    string Type;
    //    string Brand;
    //    string Model;
    //    string Office;
    //    //public virtual new DateTime PurchaseDate;
    //    int USD;
    //    string Currency;
    //    double LocalPriceToday;

    //    public override DateTime PurchaseDate => throw new NotImplementedException();

    //    public Phone(string type, string brand, string model, string office, DateTime purchaseDate, int uSD, string currency, double localPriceToday)
    //    {
    //        Type = type;
    //        Brand = brand;
    //        Model = model;
    //        Office = office;
    //        //PurchaseDate = purchaseDate;
    //        USD = uSD;
    //        Currency = currency;
    //        LocalPriceToday = localPriceToday;
    //    }
    //}
    //internal class Computer : Product
    //{
    //    string Type;
    //    string Brand;
    //    string Model;
    //    string Office;
    //    //DateTime PurchaseDate;
    //    int USD;
    //    string Currency;
    //    double LocalPriceToday;

    //    public Computer(string type, string brand, string model, string office, DateTime purchaseDate, int uSD, string currency, double localPriceToday)
    //    {
    //        Type = type;
    //        Brand = brand;
    //        Model = model;
    //        Office = office;
    //        //PurchaseDate = purchaseDate;
    //        USD = uSD;
    //        Currency = currency;
    //        LocalPriceToday = localPriceToday;
    //    }

    //    public override DateTime PurchaseDate => throw new NotImplementedException();
    //}
}
