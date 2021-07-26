using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class CalculatorService
    {
        public decimal A { get; set; }
        public decimal B { get; set; }

        public CalculatorService(decimal a, decimal b)
        {
            A = a;
            B = b;
        }

        public decimal Sum()
        {
            decimal result;
            checked
            {
                result = A + B;
            }
            return result;
        }
        public decimal Subtraction()
        {
            decimal result;
            checked
            {
                result = A > B ? A - B : B - A;
            }
            return result;
        }
        public decimal Multiplication()
        {
            decimal result;
            checked
            {
                result = A * B;
            }
            return result;
        }
        public decimal Division()
        {
            if (B == 0m)
            {
                throw new ArgumentNullException(nameof(B),"The second value cannot be zero");
            }

            return A / B;
        }
    }
}
