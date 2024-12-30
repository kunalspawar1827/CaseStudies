using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudies
{
    internal interface IOrder 
    {
         double CalculateDiscout(double OrdeAmount);
         
         bool CheckStock(string OrderType);
         double CalculateOrderAmount(double Amount);

    }
}
