namespace Practical_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle
            Console.WriteLine("Single Responsibility Principle : ");
            BankAccount bankAccount = new BankAccount(123456);
            bankAccount.Deposit(5000);
            bankAccount.Withdraw(2000);
            StatementPrinter statementPrinter = new StatementPrinter();
            statementPrinter.Print(bankAccount);

            Console.WriteLine("\n--------------------------------\n");

            //Open Close Principle
            Console.WriteLine("Open Close Principle : ");
            IPaymentProcess Creditcard = new CreditCardPayment();
            PaymentMode paymentMode = new PaymentMode(Creditcard);
            Creditcard.ProcessPayment(500);

            Console.WriteLine("\n--------------------------------\n");

            //Liskov Substitution Principle
            Console.WriteLine("Liskov Substitution Principle : ");
            ElectricVehicle eVehicle = new ElectricVehicle();
            eVehicle.StartEngine();
            PetrolVehicle petrolVehicle = new PetrolVehicle();
            petrolVehicle.StartEngine();
            Console.WriteLine("\n--------------------------------\n");

            //Interface Segregation Principle
            Console.WriteLine("Interface Segregation Principle : ");
            ReadOnlyUser user = new ReadOnlyUser();
            Console.WriteLine(user.ReadDocument(1));
            AdminUser admin = new AdminUser();
            admin.CreateDocument("Random Content");
            Console.WriteLine(admin.UpdateDocument(2, "Updated content."));

            Console.WriteLine("\n--------------------------------\n");

            //Dependency Inverse Principle
            Console.WriteLine("Dependency Inverse Principle : ");
            IMusicApplication spotifyPlayer = new YTMusic();
            MusicPlayer musicPlayer = new MusicPlayer(spotifyPlayer);
            musicPlayer.Play("Danza Kuduro");
        }
    }
}
