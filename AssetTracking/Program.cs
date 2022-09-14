/*
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


Main();

void Main()
{
    // Initiate list of assets
    List<Product> Assets = new List<Product>();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("--------------------------------------------------- Welcome to AssetTracker! ---------------------------------------------------");
    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
    Console.ResetColor();

    while (true)
    {
        // Initiating variables
        string type = "";
        string brand = "";
        string model = "";
        string office = "";
        DateTime purchaseDate = new();
        int USD = 0;
        string currency = "";
        double localPriceToday = 0;
        double EUR = 0.99;
        double SEK = 10.46;

        
        // Check if type is set
        if (type.Trim() == "")
        {
            Console.WriteLine("Select what type of asset you would like to add:");
            Console.WriteLine("1. Phone");
            Console.WriteLine("2. Computer");
            Console.WriteLine();
            Exit(); // Method to print exit instructions

            string input = Console.ReadLine();

            // Exit functionallity
            if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
            {
                break;
            }
                
            // Set type from user input
            else if (input.ToLower().Trim() == "phone" || input.ToLower().Trim() == "p" || input.ToLower().Trim() == "1")
            {
                type = "Phone";
            }
            else if (input.ToLower().Trim() == "computer" || input.ToLower().Trim() == "c" || input.ToLower().Trim() == "2")
            {
                type = "Computer";
            }                
        }
            
        // Check if brand is set
        if (brand.Trim() == "")
        {
            // Add new phone
            if (type == "Phone")
            {
                Console.WriteLine("Enter the number corresponding to the brand of the phone you would like to add. Or press enter to write the name manually");
                Console.WriteLine("1. iPhone");
                Console.WriteLine("2. Motorola");
                Console.WriteLine("3. Samsung");
                Console.WriteLine("4. Nokia");
                Exit(); // Method to print exit instructions

                string input = Console.ReadLine();

                switch (input.ToLower().Trim())
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
                        input = Console.ReadLine();
                        if (input.Trim() == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You need to enter a brand.");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            brand = input;
                            break;
                        }
                }
            }

            // Add new computer
            else if (type == "Computer")
            {
                Console.WriteLine("Enter the number corresponding to the brand of the computer you would like to add. Or press enter to write the name manually");
                Console.WriteLine("1. MacBook");
                Console.WriteLine("2. Asus");
                Console.WriteLine("3. Lenovo");
                Console.WriteLine("4. HP");
                Exit(); // Method to print exit instructions
                string input = Console.ReadLine();

                // Set brand from options or manually
                switch (input.ToLower().Trim())
                {
                    // Exit functionallity
                    case "e":
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

                    // Prompt user for manual input
                    default:
                        Console.WriteLine("Please enter the name of the brand:");
                        input = Console.ReadLine();
                            
                        // Error handling
                        if (input.Trim() == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You need to enter a brand.");
                            Console.ResetColor();
                            break;
                        }

                        // Set brand from input
                        else
                        {
                            brand = input;
                            break;
                        }
                }
            }
        }

        // Check if model is set
        if (model.Trim() == "")
        {
            Console.WriteLine("Enter the " + brand + "'s model:");
            Exit(); // Method to print exit instructions

            string input = Console.ReadLine();

            // Exit functionallity
            if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
            {
                break;
            }

            // Error handling
            else if (input.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You need to enter a model.");
                Console.ResetColor();
            }

            // Set model from input
            else
            {
                model = input;
            }
        }

        // Check if office is set
        if (office == "")
        {
            Console.WriteLine("Enter the number corresponding to the office the asset belongs to:");
            Console.WriteLine("1. USA");
            Console.WriteLine("2. Spain");
            Console.WriteLine("3. Swedem");
            Exit(); // Method to print exit instructions
            string input = Console.ReadLine();

            // Set office and currency from user input
            switch (input.ToLower().Trim())
            {
                // Exit functionallity
                case "e":
                case "exit":
                    break;
                case "1":
                    office = "USA";
                    currency = "USD";
                    break;
                case "2":
                    office = "Spain";
                    currency = "EUR";
                    break;
                case "3":
                    office = "Sweden";
                    currency = "SEK";
                    break;

                // Error handling
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, you must enter a number between 1-3 corresponding to the correct office.");
                    Console.ResetColor();
                    break;
            }
        }

        // Check if purchase date is set
        if (purchaseDate == DateTime.MinValue)
        {            
            int year = 0;
            int month = 0;
            int day = 0;

            // Set year from user input + error handling
            while (year == 0)
            {
                Console.WriteLine("Enter the year the asset was purchased:"); ;
                Exit(); // Method to print exit instructions
                string input = Console.ReadLine();

                // Exit functionallity
                if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
                {
                    break;
                }
                else if (input.Trim().Length == 4)
                {
                    if (int.TryParse(input, out year)) { }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input, year must be written with numbers");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, year must be written with 4 single-digit numbers");
                    Console.ResetColor();
                }
            }

            // Set month from user input + error handling
            while (month == 0)
            {
                Console.WriteLine("Enter the month the asset was purchased:");
                Exit(); // Method to print exit instructions

                string input = Console.ReadLine();

                // Exit functionallity
                if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
                {
                    break;
                }
                else if (input.Trim().Length == 2)
                {
                    if (int.TryParse(input.Trim(), out month)) { }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input, month must be written with numbers");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, month must be written with two single-digit numbers");
                    Console.ResetColor();
                }
            }

            // Set day from user input + error handling
            while (day == 0)
            {
                Console.WriteLine("Enter the day the asset was purchased:");
                Exit(); // Method to print exit instructions
                string input = Console.ReadLine();

                // Exit functionallity
                if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
                {
                    break;
                }
                else if (input.Trim().Length == 2)
                {
                    if (int.TryParse(input.Trim(), out day)) { }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input, day must be written with numbers");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, day must be written with two single-digit numbers");
                    Console.ResetColor();
                }
            }

            // Create datetime from user day, month & year + error handling
            try
            {
                string purchaseD = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
                purchaseDate = Convert.ToDateTime(purchaseD);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input, the purchase date is not valid.");
                Console.ResetColor();
            }

        }

        // Check if price in USD is set
        if (USD == 0)
        {
            Console.WriteLine("Enter the assets purchase price in USD:");
            Exit(); // Method to print exit instructions

            string input = Console.ReadLine();

            // Exit functionallity
            if (input.ToLower().Trim() == "exit" || input.ToLower().Trim() == "e")
            {
                break;
            }
            // Set price or print error
            else if (int.TryParse(input.Trim(), out USD)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input, price must be written with numbers");
                Console.ResetColor();
            }
        }

        // Check if local price today is set
        if (localPriceToday == 0)
        {
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
        }

        // Create asset if all values are set
        if (type != "" && brand != "" && office != "" && purchaseDate != DateTime.MinValue && USD != 0 && currency != "")
        {
            Product product = new Product(type, brand, model, office, purchaseDate, USD, currency, localPriceToday);
            Assets.Add(product);
        }                
    }

    // Sort list by primarily by office and secondarily by purchase date
    List<Product> SortedAssets = Assets.OrderBy(Product => Product.Office).ThenBy(Product => Product.PurchaseDate).ToList();

    // Print list
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Type".PadRight(30), "Brand".PadRight(30), "Model".PadRight(30), "Office".PadRight(30), "Purchase Date".PadRight(30), "Price in USD".PadRight(30), "Currency".PadRight(30), "Local price today");
    Console.ResetColor();
    foreach (Product asset in SortedAssets)
    {
        asset.PrintProduct();
    }
}

// Print exit instructions to user
void Exit()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Enter 'E' or 'EXIT' in order to close the program.");
    Console.ResetColor();
}


