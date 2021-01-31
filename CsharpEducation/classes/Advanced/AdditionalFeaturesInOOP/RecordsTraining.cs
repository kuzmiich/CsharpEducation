using Education.interfaces;
using System;

namespace Education.classes.Advanced.AdditionalFeaturesInOOP
{
    class RecordsTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение Records ----\n" +
                "Records представляют новый ссылочный тип, который появился в C#9.\n" +
                "Все records являются ссылочными типами. На уровне промежуточного языка IL,\n" +
                "в который компилируется код C#, для record фактически создается класс.\n" +
                "Records являются неизменяемыми (immutable) только при определенных условиях.\n" +
                "Отличия Record от обычных class:\n" +
                "1.При определении record компилятор генерирует метод Equals() для сравнения с другим объектом.\n" +
                "При этом сравнение двух records производится на основе их ЗНАЧЕНИЙ.\n" +
                "2.Для record уже по умолчанию реализованы операторы == и !=, которые также сравнивают две record по значению\n" +
                "3.В отличие от классов records поддерживают инициализацию с помощью оператора with.\n" +
                "Он позволяет создать одну record на основе другой record\n" +
                "Пример: var person2 = person1 with {Name=\"value\"}\n" +
                "4.Есть так называемые позиционные records\n" +
                "Их описание выглядит следующим образом: \"public record имя класса(тип имя_init_свойства, и т.д);\"\n"
            );
        }
        record Dog
        {
            public string Name { get; init; }
            public uint Age { get; init; }

            public void Deconstruct(string name, uint age)
            {
                name = Name;
                age = Age;
            }
        }
        record Dog2(string Name,uint Age);
    }
}
