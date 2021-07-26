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

        public CalculatorPresenter(OutputService outputService)
        {
            _viewService = outputService ?? throw new ArgumentNullException(nameof(outputService));
        }

        public decimal Calculate()
        {
            var operationType = _viewService.GetChar(Console.ReadLine());
            var first = _viewService.GetDecimal(Console.ReadLine());
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
