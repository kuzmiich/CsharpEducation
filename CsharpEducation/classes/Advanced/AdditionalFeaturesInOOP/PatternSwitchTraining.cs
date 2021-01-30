using Education.interfaces;
using System;

namespace Education.classes.Advanced.AdditionalFeaturesInOOP
{
    class PatternSwitchTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Паттерны switch ----\n" +
                "1.Паттерн switch\n" +
                "Паттерн свойств позволяет сравнивать со значениями определенных свойств объекта более компактно\n" +
                "Паттерны свойств предполагают использование фигурных скобок, внутри которых указываются свойства и\n" +
                "через двоеточие их значение {свойство: значение}. И со значением свойства в фигурных скобках\n" +
                "сравнивается свойство передаваемого объекта.\n" +
                "2.Паттерн кортежей\n" +
                "Паттерны кортежей позволяют сравнивать значения кортежей. Например, передадим конструкци switch кортеж\n" +
                "с двумя переменными и в зависимости от переданных данных возвращаем некоторое значение\n\n" +
                "Нам не обязательно сравнивать все значения кортежа, мы можем использовать только некоторые элементы кортежа.\n" +
                "В случае, если мы не хотим использовать элемент кортежа, то вместо него ставим прочерк\n" +
                "3.Позиционный паттерн\n" +
                "Позиционный паттерн применяется к типу, у которого определен метод деконструктора.\n" +
                "Через метод деконструктора мы можем получить набор выходных параметров в виде кортежа\n" +
                "и опять же по позиции сравнивать их с некоторыми значениями в конструкции switch.\n" +
                "4.Реляционный и логический паттерны\n" +
                "Реляционный паттерн позволяет сравнить передаваемое в конструкцию значение с некоторыми\n" +
                "значениями с помощью операций сравнения.\n" +
                "Логический паттерн позволяет использовать логические операторы and (логическое умножение или операция логического И)\n" +
                "и or (логическое сложение или операция логического ИЛИ) для объединения операций сравнения."
            );

        }
    }
    class Dude
    {
        public string Name { get; set; }        // имя пользователя
        public string Status { get; set; }      // статус пользователя
        public string Language { get; set; }    // язык пользователя
        /// <summary>
        /// Property Pattern
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static string GetMessage(Dude d) => d switch
        {
            { Language: "english" } => "Hello!",
            { Language: "german", Status: "admin" } => "Hallo, admin!",
            { Status: "admin" } => "Hi, admin.", 
            { Status: "user" } => "Hi, user.",
            { Language: "french" } => "Salut!",
            { } => "undefined"
        };
        /// <summary>
        /// Pattern tuple
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="daytime"></param>
        /// <returns></returns>
        static string GetMessage(string lang, string daytime) => (lang, daytime) switch
        {
            ("English", "morning") => "Good morning",
            ("English", "day") => "good day",
            _ => "Darova"
        };
        /// <summary>
        /// Positional pattern
        /// </summary>
        /// <param name="info"></param>
        /// <returns>Welcome string</returns>
        static string GetWelcome(Dude info) => info switch
        {
            ("Oleg", _, "morning") => $"Good morning, {info.Name}",
            ("Victor", _, "evening") => $"Good evening, {info.Name}",
            ("Ivan", _, "german") => $"Guten Morgen, {info.Name}",
            ("Nikita", _, "evening") => $"Guten Abend, {info.Name}",
            (_, "admin", _) => "Hello, Admin",
            (var name, var status, var lang) => $"{name} not found,{status} undefined ,{lang} unknown",
            _ => "Здрасьть"
        };
        /// <summary>
        /// Relational patterns
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        static decimal Calculate(decimal sum)
        {
            return sum switch
            {
                <= 0 => 0,
                < 50000 => sum * 0.05m,
                < 100000 => sum * 0.1m,
                _ => sum * 0.3m
            };
        }
        /// <summary>
        /// Logical patterns
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        static string CheckAge(int age)
        {
            return age switch
            {
                < 1 or > 120 => "Недействительный возраст",   // если age больше 110 и меньше 1
                >= 1 and < 18 => "Доступ запрещен",           // если age равно или больше 1 и меньше 18
                _ => "Доступ разрешен"                      // в остальных случаях
            };
        }
        public void Deconstruct(out string name,out string status,out string language)
        {
            name = Name;
            status = Status;
            language = Language;
        }
    }
}
