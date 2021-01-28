using Education.interfaces;
using System;

namespace Education.classes.Basics
{
    class ExceptionTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("--------Повторение Exceptions, реализация, как создавать классы Exception-------\n" +
            "InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения\n" +
            "Message: хранит сообщение об исключении, текст ошибки\n" +
            "Source: хранит имя объекта или сборки, которое вызвало исключение\n" +
            "StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения\n" +
            "TargetSite: возвращает метод, в котором и было вызвано исключение\n" +
            "Exception наследуется от интерфейса System.Runtime.Serialization ISerializable\n");
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
