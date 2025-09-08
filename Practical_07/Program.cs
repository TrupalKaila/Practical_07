namespace Practical_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle
            BankAccount bankAccount = new BankAccount(123456);
            Console.Write("Enter amount want to deposit : ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            bankAccount.Deposit(depositAmount);
            Console.Write("Enter amount want to Withdraw : ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            bankAccount.Withdraw(withdrawAmount);
            StatementPrinter statementPrinter = new StatementPrinter();
            statementPrinter.Print(bankAccount);

            //Open Close Principle
            IPaymentProcess Creditcard = new CreditCardPayment();
            PaymentMode paymentMode = new PaymentMode(Creditcard);
            Creditcard.ProcessPayment(500);

            //Liskov Substitution Principle


            //Interface Segregation Principle
            ReadOnlyUser user = new ReadOnlyUser();
            Console.WriteLine(user.ReadDocument(1));
            AdminUser admin = new AdminUser();
            admin.CreateDocument("Random Content");
            Console.WriteLine(admin.UpdateDocument(2, "Updated content."));

            //Dependency Inverse Principle
            IMusicApplication spotifyPlayer = new YTMusic();
            MusicPlayer musicPlayer = new MusicPlayer(spotifyPlayer);
            musicPlayer.Play("Danza Kuduro");
        }
    }
}
