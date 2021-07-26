﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user turned to the view
            Console.WriteLine("---------------Welcome to calculator-------------");
            Console.WriteLine("Input operation type (+, -, *, /):");
            var operation = Convert.ToChar(Console.ReadLine() ?? string.Empty);
            Console.Write("Input first number: ");
            var first = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input second number: ");
            var second = Convert.ToDecimal(Console.ReadLine());
            // !end

            // view send query to controller
            // controller updated model
            var model = new Controller().InitModel(first, second);
            // !end

            // without using events, the view refers to the model to receive data
            var calculateResult = operation switch
            {
                '+' => model.Sum(),
                '-' => model.Subtraction(),
                '*' => model.Multiplication(),
                '/' => model.Division(),
                _ => 0m,
            };

            Console.WriteLine($"\n\nResult - {calculateResult:f2}");
            // user get result
            // !end
        }
    }
}
