using Education.interfaces;
using System;
using System.Globalization;

namespace Education.classes.Advanced
{
    class AdditionalClassAndStructure : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine(
                "---- Дополнительные классы и структуры ----\n" +
                "1.Структура DateTime представляет из себя объект, который содержится в пространстве имен System\n" +
                "Данный объект, используется для работы со временем\n" +
                "2.Lazy initialization\n" +
                "3.Структурна Span и ее особенности\n" +
                "Основные методы Span:" +
                "void Fill(T value): заполняет все элементы Span значением value" +
                "T[] ToArray(): преобразует Span в массив" +
                "Span<T> Slice(int start, int length): выделяет из Span length элементов начиная с индекса start в виде другого Span" +
                "void Clear(): очищает Span" +
                "void CopyTo(Span<T> destination): копирует элементы текущего Span в другой Span" +
                "bool TryCopyTo(Span<T> destination): копирует элементы текущего Span в другой Span,\n" +
                "но при этом также возвращает значение bool, которое указывает, удачно ли прошла операция копирования\n" +
                "Как структура, определенная с модификатором ref\n" +
                "Span не может быть присвоена переменной типа Object, dynamic или переменной типа интерфейса.\n" +
                "Она не может быть использована как поле в объектах ссылочного типа\n" +
                "Она не может быть использована в пределах\n" +
                "4.----- Индексы и Диапазоны -----\n" +
                "Изучение System.Range и System.Index. Оба типа являются структурами.\n" +
                "Тип Range представляет некоторый диапазон значений в некоторой последовательность," +
                "а тип Index - индекс в последовательности.\n"
            );
            
            // 1.DataTime
            DateTime date = DateTime.Now;
            Console.WriteLine($"Month - {date.Month}"); 

            // 2.Lazy initialization
            Person person = new Person();
            person.PlayGuitar();
            person.DoesntPlayGuitar();
            person.DoesntPlayGuitar();
            person.DoesntPlayGuitar();
            person.DoesntPlayGuitar();
            person.PlayGuitar();

            // Преобразование типов, использование System.Globalization для изменения форматирования
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double b = double.Parse("23.56", formatter);

            // 3. Структурный тип span
            string[] people = new string[] { "Tom", "Alice", "Bob" };
            Span<string> peopleSpan = people;
            peopleSpan[1] = "Ann";
            Console.WriteLine(peopleSpan[2]);   // получение элемента
            Console.WriteLine(peopleSpan.Length);   // получение длины Span
            peopleSpan.ToArray();
            
            peopleSpan.Fill(string.Join(' ', people));
            peopleSpan.ToArray();
            peopleSpan.Slice(0, 1);
            peopleSpan.Clear();
            Span<string> value = new string[] { "1", "23", "3", "434"};
            peopleSpan.CopyTo(value);
            peopleSpan.TryCopyTo(value);
            Console.WriteLine(string.Join(' ', peopleSpan.ToArray()));
            // Структурный тип ReadOnlySpan для неизменяемых объектов
            string text = "hello, world";
            string worldString = text.Substring(startIndex: 7, length: 5);           // есть выделение памяти под символы
            ReadOnlySpan<char> worldSpan = text.AsSpan().Slice(start: 7, length: 5); // нет выделения памяти под символы
                                                                                     //worldSpan[0] = 'a'; // Нельзя изменить
            Console.WriteLine(worldSpan[0]); // выводим первый символ

            // перебор символов
            foreach (var c in worldSpan)
            {
                Console.Write(c);
            }
            // Индексы
            Index myIndex1 = 2;
            Index myIndex2 = ^2;
            string[] peoples = { "Tom", "Bob", "Sam", "Kate", "Alice" };
            string selected1 = peoples[myIndex1];    // Sam
            string selected2 = peoples[myIndex2];    // Kate
            Console.WriteLine(selected1);
            Console.WriteLine(selected2);

            // Диапазон
            Index start = 1;
            Index end = 4;
            Range myRange1 = start..end;
            Range myRange2 = 1..4; 
            string[] peopleRange1 = people[^2..];       // два последних - Kate, Alice
            string[] peopleRange2 = people[..^1];       // начиная с предпоследнего - Tom, Bob, Sam, Kate
            string[] peopleRange3 = people[^3..^1];     // два начиная с предпоследнего - Sam, Kate
            Console.WriteLine(string.Join(" ", peoples[myRange1]));
            
        }
    }

    class Guitar
    {
        private static string _notes;
        public string PlayMusic { 
            get
            {
                return "Song ♫♫♫";
            }
            set
            {
                _notes = value;
            }
        }
    }
    class Person
    {
        Lazy<Guitar> guitar = new Lazy<Guitar>();

        public void PlayGuitar()
        { 
            Console.WriteLine($"{guitar.Value.PlayMusic}.Играет на гитаре!");
        }
        public void DoesntPlayGuitar()
        {
            Console.WriteLine("Не играет на гитаре");
        }
    }
}
