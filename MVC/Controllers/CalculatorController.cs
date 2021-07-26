using System;
using MVC.Model;

namespace MVC.Controllers
{
    public class CalculatorController
    {
        public virtual CalculatorService InitModel(decimal a, decimal b) => new(a, b);
    }
}
