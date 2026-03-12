namespace App.Actions
{
    public class UserActions
    {
        public static void ViewAccount()
        {
            Console.WriteLine("Now Viewing: Your checking account");
            Console.WriteLine("Checking: 5,000,000 dollars");
        }

        public static void CashDeposit()
        {
            Console.WriteLine("Your cash has been deposited into your new Savings account");
            Console.WriteLine("Amount: 1,500");
        }
    }
}