/*
 * Class name: Banking App
 * Version 1
 * Author: Maxim Dobrynin
 */

void BuildBankingApp()
{
    // Initialise variable
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;

    // Display the main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read users choice menu choice
    // Convert string to integer using explicit typecasting

    choice = Convert.ToInt32(Console.ReadLine());

    // Menu choice of 1 OR 2 is represented by ||
    if (choice == 1 || choice == 2)
    {
        // Valid menu choice
        if (choice == 1)
        {
            // Deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much would you like to deposit");
            Console.WriteLine("Enter amount including pence using a decimal point");

            // Typically a currency value is input as a decimal value
            // so the "double" type is required to store deposit amount

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            // This line of code is interpreted as 
            // account balance = account balance + deposit amount
            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if(choice == 2)
        {
            // View current account information
            Console.WriteLine("You have chosen to view current amount information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else 
        {
            // View current account information
            Console.WriteLine("You have chosen to view current account information");
        }
    }
    else
    {
        // Invalide menu choice
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

BuildBankingApp();