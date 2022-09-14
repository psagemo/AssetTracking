﻿/*
 * *** Level 1 ***
 * 
 * Create a console app that have classes and objects.
 * For example like below with computers and phones.
 * 
 * Laptop Computers
 *  - MacBook 
 *  - Asus
 *  - Lenovo
 *  
 * Mobile Phones
 *  - Iphone
 *  - Samsung
 *  - Nokia
 *  
 * You will need to create the appropriate properties and constructors for each object, like purchase date, price, model name etc. 
 * 
 * *** Level 2 ***
 * 
 * Create a program to create a list of assets (inputs) where the final result is to write the following to the console:
 *  • Sorted list with Class as primary (computers first, then phones)
 *  • Then sorted by purchase date
 *  • Mark any item *RED* if purchase date is less than 3 months away from 3 years.
 *  
 *  *** Level 3 ***
 *  
 *  Add offices to the model:
 *  You should be able to place items in 3 different offices around the world which will use the appropriate currency for that country.
 *  You should be able to input values in dollars and convert them to each currency (based on todays currency charts)
 *  
 *  When you write the list to the console: 
 *   • Sorted first by office, then by Purchase date
 *   • Items *RED* if date less than 3 months away from 3 years
 *   • Items *Yellow* if date less than 6 months away from 3 years
 *   • Each item should have currency according to country
 */

using AssetTracking;

List<Product> Assets = new List<Product>();

void Main(List<Product> Assets)
{
    while (true)
    {
        string type = "";
        string brand = "";
        string model = "";
        string office = "";
        DateTime? purchaseDate = null;
        int USD = 0;
        string currency = "";
        double localPriceToday = 0;

        double EUR = 0.99;
        double SEK = 10.46;
        

            string? input = Console.ReadLine();

     
        if (input?.ToLower().Trim() == "exit" || input?.ToLower().Trim() == "e")
        {
            break;
        }
        else
        {
            Console.WriteLine("Select what type of asset you would like to add:");
            Console.WriteLine("1. Phone");
            Console.WriteLine("2. Computer");
            input = Console.ReadLine();

            if (input == null)
            {
                // write error message to console
                break;
            }

            if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
            {
                break;
            }
            else if (input.ToLower().Trim() == "phone" || input.ToLower().Trim() == "p" || input.ToLower().Trim() == "1")
            {
                type = "Phone";
            }
            else if (input.ToLower().Trim() == "computer" || input.ToLower().Trim() == "c" || input.ToLower().Trim() == "2")
            {
                type = "Computer";
            }

            if (type == "Phone")
            {
                Console.WriteLine("Enter the number corresponding to the brand of the phone you would like to add.");
                Console.WriteLine("Or press enter to write the name manually");
                input = Console.ReadLine();

                switch (input?.ToLower().Trim())
                {
                    case "e":
                    case "exit":
                        break;
                    case "1":
                        brand = "iPhone";
                        break;
                    case "2":
                        brand = "Motorola";
                        break;
                    case "3":
                        brand = "Samsung";
                        break;
                    case "4":
                        brand = "Nokia";
                        break;
                    default:
                        Console.WriteLine("Please enter the name of the brand:");
                        brand = Console.ReadLine();
                        break;
                }
            }
            else if (type == "Computer")
            {
                Console.WriteLine("Enter the number corresponding to the brand of the computer you would like to add. Or press enter to write the name manually");
                input = Console.ReadLine();

                switch (input.ToLower().Trim())
                {
                    case "e":
                        break;
                    case "exit":
                        break;
                    case "1":
                        brand = "MacBook";
                        break;
                    case "2":
                        brand = "Asus";
                        break;
                    case "3":
                        brand = "Lenovo";
                        break;
                    case "4":
                        brand = "HP";
                        break;
                    default:
                        Console.WriteLine("Please enter the name of the brand:");
                        brand = Console.ReadLine();
                        break;
                }
            }
        }

        // Set local price from currency
        if (currency == "USD")
        {
            localPriceToday = USD;
        }
        else if (currency == "EUR")
        {
            localPriceToday = USD * EUR;
        }
        else if (currency == "SEK")
        {
            localPriceToday = USD * SEK;
        }

        // Create asset if all values are set
        if (type != "" && brand != "" && office != "" && purchaseDate != null && USD != 0 && currency != "")
        {
            Product product = new Product(type, brand, model, office, purchaseDate, USD, currency, localPriceToday);
        }
    }
}

