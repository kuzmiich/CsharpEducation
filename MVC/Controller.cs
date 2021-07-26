using System;

namespace MVC
{
    public class Controller
    {
        public virtual Model InitModel(decimal a, decimal b) => new(a, b);
    }
}
