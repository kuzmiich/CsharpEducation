using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.classes
{
    public sealed class SolidPrinciples
    {
        public static void OutSolidPrinceples()
        {
            Dictionary<string, string> solidPrinceplesDict = new() {
                {
                    "Принцип единственной ответственности (Single Responsibility Principle):\n",
                    "Существует лишь одна причина, приводящая к изменению класса.\n" +
                    "У каждого метода должна быть только 1 задача\n"
                },
                {
                    "Принцип открытости/закрытости (Open-closed Principle):\n",
                    "Программные сущности должны быть открыты для расширения, но закрыты для модификации.\n"
                },
                {
                    "Принцип подстановки Барбары Лисков (Liskov Substitution Principle):\n",
                    "Предварительные условия не могут быть усилены в подтипе.\n" +
                    "Постусловия не могут быть ослаблены в подтипе.\n" +
                    "Инварианты супертипа могут быть сохранены в подтипе.\n" +
                    ""
                },
                {
                    "Принцип инверсии зависимостей (Dependency Inversion Principle):\n",
                    "Высокоуровневые модули не должны зависеть от низкоуровневых. Оба вида модулей должны зависеть от абстракций.\n" +
                    "Абстракции не должны зависеть от подробностей.Подробности должны зависеть от абстракций.\n"
                },
                {
                    "Принцип разделения интерфейса (Interface Segregation Principle):\n",
                    "Нельзя заставлять клиента реализовать интерфейс, которым он не пользуется.\n"
                }
            };
            foreach(var principle in solidPrinceplesDict)
            {
                Console.WriteLine($"{principle.Key}{principle.Value}");
            }
        }
    }
}
