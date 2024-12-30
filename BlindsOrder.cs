using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudies
{
    internal class BlindsOrder : IOrder
    {
        static double DiscountPercentage = 0.05; 
        double OrderAmount = 0;
        double disCount = 0;
        bool IsStockAvalable = false;
        public double CalculateDiscout(double OrdeAmount)
        {
            disCount = OrdeAmount * DiscountPercentage ;
            return disCount;
        }
        public double CalculateOrderAmount(double Amount)
        {
            OrderAmount = Amount - disCount;
            return OrderAmount;
        }
        public bool CheckStock(string OrderType)
        {
            if(OrderType == "Blinds")
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
