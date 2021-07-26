using System;
using MVP;
using MVP.View;
using Console = System.Console;

namespace MVP.Presenter
{
    public class CalculatorPresenter
    {
        private readonly IView _viewService;
        private static readonly CalculatorService Model = new ();

        public CalculatorPresenter(InputService inputService)
        {
            _viewService = inputService ?? throw new ArgumentNullException(nameof(inputService));
        }

        public decimal Calculate()
        {
            Console.Write("Input operation type: ");
            var operationType = _viewService.GetChar(Console.ReadLine());
            Console.Write("Input first number: ");
            var first = _viewService.GetDecimal(Console.ReadLine());
            Console.Write("Input second number: ");
            var second = _viewService.GetDecimal(Console.ReadLine());

            return operationType switch
            {
                '+' => Model.Sum(first, second),
                '-' => Model.Subtraction(first, second),
                '*' => Model.Multiplication(first, second),
                '/' => Model.Division(first, second),
                _ => 0m,
            };
        }
    }
}
