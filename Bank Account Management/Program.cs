namespace Bank_Account_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating object of "BankAccount" class and
                // and passing the values in the parameterized constructor
                //BankAccount account = new BankAccount( null, null, -100 );
                //BankAccount account = new BankAccount( "John", null, -100 );
                //BankAccount account = new BankAccount( "John", "Doe", -100 );
                //BankAccount account = new BankAccount( "John", "Doe", -100 );
                BankAccount account = new BankAccount("John", "Doe", 100);
                // Trying to withdrawal amount higher than the available account balance.
                /*account.Withdraw( 200 );*/
                /*account.Withdraw( -20 );*/
                /*account.Withdraw(20);*/
                // Trying to deposit amount into account.
                account.Deposit( -10 );
              /*  account.Deposit(50);*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Something went wrong.");
                Console.WriteLine("Details: " + ex.Message);
            }

        }
    }
}