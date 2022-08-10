using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("Enter Amount");
            double amount = int.Parse(Console.ReadLine());

            Console.WriteLine("PROCESSING PAYMENT....");
            Console.WriteLine("PAYMENT SUCCESSFUL");
            Console.WriteLine($"Paid ${amount} Cash");
        }
    }
}
