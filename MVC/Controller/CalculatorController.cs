using System;
using MVC.Model;

namespace MVC.Controller
{
    public class CalculatorController
    {
        public virtual CalculatorService InitModel(decimal a, decimal b) => new(a, b);
    }
}
