using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudies
{
    internal class RugsOrder : IOrder
    {
        static double DiscountPercentage = 0.4;
        double OrderAmount = 0;
        double disCount = 0;
        bool IsStockAvalable = false;
        public double CalculateDiscout(double OrdeAmount)
        {
            disCount = OrderAmount * DiscountPercentage;
            return disCount;
        }
        public double CalculateOrderAmount(double Amount)
        {
            OrderAmount = OrderAmount - disCount;
            return OrderAmount;
        }
        public bool CheckStock(string OrderType)
        {
            if (OrderType == "BedSheet")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

