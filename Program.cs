namespace ATM
{
    class Program
    {
        public static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose Your Selection..");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
                
            }

            void deposit(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to deposit?");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);
                Console.WriteLine("Your new Balance is: " + currentUser.getBalance());
            }

            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to withdraw: ");
                double withdrawal = Double.Parse(Console.ReadLine());

                // Check if user has enough balance in account
                if(currentUser.getBalance() < withdrawal)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    double newBalance = currentUser.getBalance() - withdrawal;
                    currentUser.setBalance(newBalance);
                    Console.WriteLine("Thank you for your service");
                }
            }

            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance());
            }

            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("4869568945789513", 1234, "John", "Smith", 1503.32));
            cardHolders.Add(new cardHolder("4569568945789513", 5689, "Bruce", "Wayne", 5550.56));
            cardHolders.Add(new cardHolder("4369568945789513", 2456, "Barry", "Ellen", 2503.32));
            cardHolders.Add(new cardHolder("4269568945789513", 6958, "Loice", "Layne", 3503.32));
            cardHolders.Add(new cardHolder("4169568945789513", 4523, "Lex", "Luttor", 8503.32));

            //User Task
            Console.WriteLine("Welcome to Apex ATM");
            Console.WriteLine("please insert you card: ");
            string debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();

                    currentUser = cardHolders.FirstOrDefault(a => a.getNum() == debitCardNum);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("card not recognized. Please try again");
                    }
                }
                catch
                {

                    Console.WriteLine("card not recognized. Please try again");
                }
            }

            Console.WriteLine("please enter your pin:");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());

                    if (currentUser.getPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin. Please try again");
                    }
                }
                catch
                {

                    Console.WriteLine("Incorrect pin. Please try again");
                }
            }

            Console.WriteLine("Welcome: " + currentUser.getFirstName());
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    throw;
                }
                if(option == 1) { deposit(currentUser); }
                else if(option == 2) { withdraw(currentUser); }
                else if(option == 3) { balance(currentUser); }
                else if(option == 4) { break; }
                else { option = 0; }
            } while (option != 4);
            Console.WriteLine("Thank You! Have a nice day..");

        }
    }
}
