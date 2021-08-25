using MVP.Model;
using MVP.View;
using System;

namespace MVP.Presenter
{
    public class CalculatorPresenter
    {
        private readonly IInputService _inputServiceService;
        private static readonly CalculatorService Model = new ();

        public CalculatorPresenter(InputService inputService)
        {
            _inputServiceService = inputService ?? throw new ArgumentNullException(nameof(inputService));
        }

        public decimal Calculate()
        {
            Console.Write("Input operation type: ");
            var operationType = Console.ReadLine();
            Console.Write("Input first number: ");
            var first = _inputServiceService.GetDecimal(Console.ReadLine());
            Console.Write("Input second number: ");
            var second = _inputServiceService.GetDecimal(Console.ReadLine());

            return operationType switch
            {
                "+" => Model.Sum(first, second),
                "-" => Model.Subtraction(first, second),
                "*" => Model.Multiplication(first, second),
                "/" => Model.Division(first, second),
                _ => 0m,
            };
        }
    }
}
