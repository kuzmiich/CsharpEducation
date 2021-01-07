using Education.interfaces;
using System;

namespace Education.classes.TheBasics
{
    class ExceptionTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("--------Повторение Exceptions, реализация, как создавать классы Exception-------");
            Console.WriteLine("InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения");
            Console.WriteLine("Message: хранит сообщение об исключении, текст ошибки");
            Console.WriteLine("Source: хранит имя объекта или сборки, которое вызвало исключение");
            Console.WriteLine("StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения");
            Console.WriteLine("TargetSite: возвращает метод, в котором и было вызвано исключение");
            Console.WriteLine("Exception наследуется от интерфейса System.Runtime.Serialization ISerializable");
            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                Console.WriteLine("finally выполняется не зависомо отловился Exception или нет.");
            }
        }
        class Person
        {
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 18)
                    {
                        throw new PersonException("Лицам до 18 регистрация запрещена");
                    }    
                    else
                    {
                        age = value;
                    }
                }
            }
        }
        class PersonException : Exception
        {
            public PersonException(string message)
                : base(message)
            { }
        }
    }
}
