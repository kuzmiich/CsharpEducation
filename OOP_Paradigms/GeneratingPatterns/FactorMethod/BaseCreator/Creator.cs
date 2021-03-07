using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Paradigms.GeneratingPatterns.FactorMethod
{
    // абстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
}
