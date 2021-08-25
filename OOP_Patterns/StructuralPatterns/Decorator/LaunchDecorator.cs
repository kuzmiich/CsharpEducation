using System;
using DesignPatterns.StructuralPatterns.Decorator.BaseComponent;
using DesignPatterns.StructuralPatterns.Decorator.ConcreteComponent;
using DesignPatterns.StructuralPatterns.Decorator.ConcreteDecorator;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class LaunchDecorator : ILaunchPattern
    {
        public void OutPatternInfo()
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
            Console.WriteLine($"Название: {pizza1.Name}");
            Console.WriteLine($"Цена: {pizza1.GetCost()}");
     
            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
            Console.WriteLine($"Название: {pizza2.Name}");
            Console.WriteLine($"Цена: {pizza2.GetCost()}");
     
            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            Console.WriteLine($"Название: {pizza3.Name}");
            Console.WriteLine($"Цена: {pizza3.GetCost()}");
             
        }
    }
}