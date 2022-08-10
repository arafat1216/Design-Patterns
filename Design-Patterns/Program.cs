using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{

    public class Program
    {
        static void Main(string[] args)
        {
            PaymentContext paymentContext = new PaymentContext();

            Console.WriteLine("Enter Payment Method\n 1)Debit Card\n 2)Credit Card\n 3)Cash");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                paymentContext.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (choice == 2)
            {
                paymentContext.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if(choice == 3)
            {
                paymentContext.SetPaymentStrategy(new CashPaymentStrategy());
            }

            paymentContext.Pay();
        }
    }
}