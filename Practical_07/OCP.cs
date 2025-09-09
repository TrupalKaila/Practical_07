using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
    //Created interface of paymentprocess and declared ProcesPayment method in it
    //So, if new payment method is added in application then we dont have to change the other payment method just add new class and inherit this interface and define the working
    public interface IPaymentProcess
    {
        public void ProcessPayment(double amount);
    }
    public class CreditCardPayment : IPaymentProcess
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment for amount: {amount}");
        }
    }
    public class PayPalPayment : IPaymentProcess
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Paypal payment for amount: {amount}");
        }
    }
    public class BankTransferPayment : IPaymentProcess
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bank Transfer payment for amount: {amount}");
        }
    }

    public class PaymentMode
    {
        //Created  reference of interface
        private readonly IPaymentProcess _paymentProcess;
        //Initialize the reference of interface using parameterized constructor
        public PaymentMode(IPaymentProcess paymentProcess)
        {
            _paymentProcess = paymentProcess;
        }
        //Created the method which call processpayment method - it will call the method from class which is passed while creating the object of PaymentMode
        public void ExecutePayment(double amount)
        {
            _paymentProcess.ProcessPayment(amount);
        }
    }
}