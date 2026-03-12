using System;
using App.Actions;
using App.Menu;

namespace App
{ 

    public class Program
    {
        static void Main()
        {
        bool bankBoolRunning = true;
                
            while(bankBoolRunning == true)
            {
                MenuDisplay.ShowBankMenu();
                string? userChoice = Console.ReadLine();
                
                // Handle null input (EOF) - exit gracefully
                if (string.IsNullOrEmpty(userChoice))
                {
                    Console.WriteLine("Goodbye homeslice!");
                    bankBoolRunning = false;
                }
                else if (userChoice == "1") 
                    {
                        UserActions.ViewAccount();
                    }  // From App.Actions
                else if (userChoice == "2") 
                    {
                    UserActions.CashDeposit(); 
                    } // From App.Actions
                else if (userChoice == "3")
                    {
                    Console.WriteLine("Goodbye homeslice!");
                        bankBoolRunning = false;
                    }
                else{
                    Console.WriteLine("Try again bruh (1, 2, or 3)");
                    }

            }
        }
    }

}