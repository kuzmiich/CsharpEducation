using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class CalculatorService
    {

        public decimal Sum(decimal a, decimal b)
        {
            decimal result;
            checked
            {
                result = a + b;
            }
            return result;
        }
        public decimal Subtraction(decimal a, decimal b)
        {
            decimal result;
            checked
            {
                result = a > b ? a - b : b - a;
            }
            return result;
        }
        public decimal Multiplication(decimal a, decimal b)
        {
            decimal result;
            checked
            {
                result = a * b;
            }
            return result;
        }
        public decimal Division(decimal a, decimal b)
        {
            if (b == 0m)
            {
                throw new ArgumentNullException(nameof(b),"The second value cannot be zero");
            }

            return a / b;
        }
    }
}
