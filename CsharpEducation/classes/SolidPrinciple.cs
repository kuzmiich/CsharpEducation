using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes
{
    public sealed class SolidPrinciple
    {
        public static void OutSolidPrinciples()
        {
            Dictionary<string, string> solidPrinceplesDict = new() {
                {
                    "1.Принцип единственной ответственности (Single Responsibility Principle):\n",

                    "--Существует лишь одна причина, приводящая к изменению класса.--\n" +
                    "SRP говорит о том, что у каждый объект должен быть ответственнен только за один процесс.\n"
                },
                {
                    "2.Принцип открытости/закрытости (Open-closed Principle):\n",

                    "Программные сущности должны быть открыты для расширения, но закрыты для модификации.\n"
                },
                {
                    "3.Принцип подстановки Барбары Лисков (Liskov Substitution Principle):\n",

                    "Класс потомок должен при необходимости заменять класс родитель.\n"
                },
                {
                    "4.Принцип инверсии зависимостей (Dependency Inversion Principle):\n",

                    "Модули высокого уровня не должны зависеть от модулей низкого уровня. Оба должны зависеть от абстракций (например, интерфейсов).\n" +
                    "Абстракции не должны зависеть от деталей. Детали (конкретные реализации) должны зависеть от абстракций.\n"
                },
                {
                    "5.Принцип разделения интерфейса (Interface Segregation Principle):\n",

                    "Не реализовывать интерфейс, который ты не используешь.\n"
                }
            };
            foreach(var principle in solidPrinceplesDict)
            {
                Console.WriteLine($"{principle.Key}{principle.Value}");
            }
        }
    }
}
