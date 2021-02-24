using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Utilities
{
    public class Savings
    {
        public decimal InterestCalculator(decimal p, decimal r, decimal t)
        {
            
            if (p < 0)
            {
                return 0;
            }
            if (p == 1)
            {
                return 1;
            }
           
            return (p * r * t / 100) + p;

        }
    }
}
