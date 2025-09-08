using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
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
        private readonly IPaymentProcess _paymentProcess;
        public PaymentMode(IPaymentProcess paymentProcess)
        {
            _paymentProcess = paymentProcess;
        }
        public void ExecutePayment(double amount)
        {
            _paymentProcess.ProcessPayment(amount);
        }
    }
}
