﻿using Education.interfaces;
using System;

namespace Education.classes.Advanced.AdditionalFeaturesInOOP
{
    class DeconstructorTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("----Деконструктор----" +
            "Синтаксический сахар, который позволяет присваивать 2 и более переменным значение из класса"
            );
            FlashLite flashLite = new FlashLite { Type = "Usual", Power = 5000 };
            uint power; string type;
            (type, power) = flashLite;
        }
    }
    class FlashLite
    {
        public string Type { get; set; }
        public uint Power { get; set; }

        public void Deconstruct(out string type, out uint power)
        {
            type = Type;
            power = Power;
        }
    }
}
