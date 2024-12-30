using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlindsOrder Order1 = new BlindsOrder();
            double Order1_Discount = Order1.CalculateDiscout(2500D);
            double Order1_AmountToPay = Order1.CalculateOrderAmount(2500D);
            bool IsstockAvailable = Order1.CheckStock("Blinds");

            // Now You Can Validate All Parameters And Process Your Logic To Place Order 
            if (IsstockAvailable) 
            {
                Console.WriteLine($"Your Order Has Been Placed Thank You " );
            }
            else
            {
                Console.WriteLine("Something Went Wrong Your Order Has Not Been Placed");
            }

        }
    }
}
