using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCoverageDemo
{
    public class Calculator
    {
        public static int Add(int number)
        {
            int sum;

            if(number % 2 == 0)
            {
                sum = 20;
            }
            else
            {
                sum = 30;
            }
            return sum + number;
        }
    }
}
