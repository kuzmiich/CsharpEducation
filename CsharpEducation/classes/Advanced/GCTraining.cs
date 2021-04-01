using System;

namespace Education.classes.Advanced
{
    class GCTraining
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение сборщика мусора(GC) ----\n" +
                "GC представляет из себя инструмент встроенный в CLR для очистки памяти\n" +
                "Мусор делится на 3 типа поколений объектов: 0, 1, 2 поколения\n" +
                "Вначеле каждый объект принадлежит 0 поколению, если его не удалила первая проходка GC, то он переходит в 1 поколение" +
                "Те объекты, на которые уже нет ссылок, уничтожаются, а те, которые по-прежнему актуальны, повышаются до поколения 2.\n" +
                "Так же надо отметить, что для крупных объектов(>=85.000 байт) существует своя куча - Large Object Heap.\n" +
                "Класс System.GC используется, когда нужно очистить неуправляемую память\n" +
                "I.Основные методы:\n" +
                "1.AddMemoryPressure информирует среду CLR о выделении большого объема неуправляемой памяти,\n" +
                "которую надо учесть при планировании сборки мусора.\n" +
                "2.В связке с этим методом используется метод RemoveMemoryPressure, который указывает CLR,\n" +
                "что ранее выделенная память освобождена, и ее не надо учитывать при сборке мусора.\n" +
                "3.Метод Collect приводит в действие механизм сборки мусора. Перегруженные версии метода позволяют указать поколение объектов,\n" +
                "вплоть до которого надо произвести сборку мусора\n" +
                "4.GetGeneration(Object) позволяет определить номер поколения, к которому относится переданый в качестве параметра объект\n" +
                "5.GetTotalMemory возвращает объем памяти в байтах, которое занято в управляемой куче\n" +
                "Метод WaitForPendingFinalizers приостанавливает работу текущего потока до освобождения всех объектов, для которых производится сборка мусора\n" +
                "II.Деструктор, Finalyze, реализация интерфейса IDisposable\n" +
                "Microsoft рекомендует использовать комбинированный подход: реализация интерефейса IDisposable и объявление конструктора\n" +
                "III.конструкция using испоьзуется для очистки памяти в некотором блоке кода.\n" +
                "В C# 8.0 добавили возможность создавать using для всей области кода(синтаксический сахар)\n" +
                "");

            // 1
            object variable = 5;
            Console.WriteLine($"Максимальное количество генераций, которое может поддерживает система: {GC.MaxGeneration}");
            Console.WriteLine($"Номер поколения - {GC.GetGeneration(variable)}");
            Console.WriteLine($"Объем занятой памяти: {GC.GetTotalMemory(false)}");

            // 2
            PersonFinalize person = new PersonFinalize();
            person.Dispose();
            // 3
            using (User user = new User { Name = "Tom" })
            {
                Console.WriteLine(user.Name);
            }
            // using User user = new User { Name = "Tom" };

        }
    }
    public class PersonFinalize : object, IDisposable
    {
        public string Name { get; set; }
        private bool _disposed = false;

        public PersonFinalize(string name)
        {
            Name = name;
        }

        public PersonFinalize()
        {
        }

        ~PersonFinalize()
        {
            Dispose(false);
            Console.WriteLine("Dispose object");
        }

        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed) return;

            if(!disposing)
            {
                Name = null;
            }
            else
            {
                // освобождаем неуправляемые объекты
                _disposed = true;
            }
            // Обращение к методу Dispose базового класса если он есть
        }
    }
}
