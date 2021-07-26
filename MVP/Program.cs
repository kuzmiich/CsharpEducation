using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Presenter;
using MVP.View;

namespace MVP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user turned to the view
            Console.WriteLine("---------------Welcome to calculator-------------");
            // !end

            // view send query to presenter
            // presenter send date to model and get result
            var calculateResult = new CalculatorPresenter(new InputService()).Calculate();
            // !end

            // without using events, the view refers to the model to receive data

            Console.WriteLine($"\n\nResult - {calculateResult:f2}");
            // user get result
            // !end
        }
    }
}
