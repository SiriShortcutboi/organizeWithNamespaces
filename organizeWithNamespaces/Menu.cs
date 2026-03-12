namespace App.Menu
    {
        public class MenuDisplay
        {
            public static void ShowBankMenu() //using static on methods not on variables
            {
                Console.WriteLine("Chase Bank Main Menu");
                Console.WriteLine("1. View Account");
                Console.WriteLine("2. Update Account");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");
            }
        }
    }    