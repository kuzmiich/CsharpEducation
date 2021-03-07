﻿using OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseCreator;
using OOP_Paradigms.GeneratingPatterns.FactorMethod.BaseProduct;
using OOP_Paradigms.GeneratingPatterns.FactorMethod.CreateArea;
using System;

namespace OOP_Paradigms.GeneratingPatterns.FactorMethod
{
    class LaunchFactoryMethod : LaunchPattern
    {
        public override void OutPatternInfo()
        {
            Console.WriteLine(
                "Когда нужно использовать паттерн фабричный метод:\n" +
                "-Когда заранее неизвестно, объекты каких типов необходимо создавать\n" +
                "-Когда система должна быть независимой от процесса создания новых объектов и расширяемой:\n" +
                "в нее можно легко вводить новые классы, объекты которых система должна создавать.\n" +
                "-Когда создание новых объектов необходимо делегировать из базового класса классам наследникам");

            Creator dev = new StoneHouseCreator("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodHouseCreator("Частный застройщик");
            House house = dev.Create();
        }
    }
}
