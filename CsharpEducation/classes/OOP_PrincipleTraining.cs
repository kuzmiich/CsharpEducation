﻿using System;

namespace Education
{
    class OOP_PrincipleTraining
    {
        public static void OutOOP_Pillars()
        {
            Console.WriteLine("В объектно-ориентированном программировании(ООП) есть 6 основых принципов:\n" +
                "1.Абстракция - выделение главных, наиболее значимых характеристик предмета и отбрасывание незначительных.\n" +
                "2.Инкапсуляция - контроль за изменением поведения и состояния объекта.\n" +
                "3.Наследование - механизм, который позволяет унаследовать поля и методы родительского объекта\n" +
                "(позаимствовать его функционал)\n" +
                "4.Полиморфизм - это свойство одних и тех же объектов и методов принимать разные формы.\n" +
                "a)Статический полиморфизм - Изменение реализации метода в зависимости от передаваемых параметров,\n" +
                "при одинаковой сигнатуре. Пример: перегрузка методов, или операторов\n" +
                "b)Динамический полиморфизм - это механизм, с помощью которого можно переопределять методы базового класса\n" +
                " и сигнатурами в суперклассе и подклассе.(virtual, abstract methods)\n" +
                "c)Параметрический полиморфизм - позволяющее обрабатывать значения разных типов идентичным образом,\n" +
                "т.е. исполнять физически один и тот же код для данных разных типов(использование обобщений 'T' в методах и классах)\n" +
                "5.Повторное использование кода - заключается в написание методов таким образом,\n" +
                "чтобы их можно было использовать повторно\n" +
                "6.Посылка сообщений - обращение(вызов) методов или свойств объекта\n\n"
                );
            Console.WriteLine(
                "Какие бывают виды отношения между объектами:\n" +
                "·Ассоциация - означает отношение между классами объектов, которое позволяет одному экземпляру\n" +
                "объекта вызвать другой, чтобы выполнить действие от его имени.\n" +
                "(Инициализация поля класса другим пользовательским классом)\n" +
                "-Композиция(Has A) - означает инициализация класса родителя(Car) объектами типа которые в нем содержатся(Engine)\n" +
                "-Агрегация(Has A) - методика создания нового класса из уже существующих классов путём включения экземпляров на равноправной основе.\n" +
                "Т.е передача компонентов класса из вне.Пример: класс Car принимает экземпляр Engine из конструктора\n" +
                "Делегирование - использование в программировании одного объекта другим с целью реализации тех или других функций.\n"
                );
        }
    }
}
