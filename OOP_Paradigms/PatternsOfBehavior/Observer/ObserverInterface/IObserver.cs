﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.PatternsOfBehavior.Observer.ObserverInterface
{
    public interface IObserver<T>
    {
        string Update(T data);
    }
}
