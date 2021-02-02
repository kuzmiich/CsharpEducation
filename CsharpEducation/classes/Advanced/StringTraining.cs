using Education.interfaces;
using System;
using System.Text.RegularExpressions;

namespace Education.classes.Advanced
{
    class StringTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Работа со строками ----\n" +
                "1.Виды форматов:\n" +
                "C / c - Задает формат денежной единицы, указывает количество десятичных разрядов после запятой\n" +
                "D / d - Целочисленный формат, указывает минимальное количество цифр\n" +
                "E / e - Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой\n" +
                "F / f - Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой\n" +
                "G / g - Задает более короткий из двух форматов: F или E\n" +
                "N / n - Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой\n" +
                "P / p - Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой\n" +
                "X / x - Шестнадцатеричный формат числа\n" +
                "" +
                "2.Изучение регулярных выражений:\n" +
                "Compiled: при установке этого значения регулярное выражение компилируется в сборку,\n" +
                "что обеспечивает более быстрое выполнение" +
                "CultureInvariant: при установке этого значения будут игнорироваться региональные различия\n" +
                "IgnoreCase: при установке этого значения будет игнорироваться регистр\n" +
                "IgnorePatternWhitespace: удаляет из строки пробелы и разрешает комментарии, начинающиеся со знака #" +
                "Multiline: указывает, что текст надо рассматривать в многострочном режиме.При таком режиме символы \"^\" и \"$\"\n" +
                "совпадают, соответственно, с началом и концом любой строки, а не с началом и концом всего текста\n" +
                "RightToLeft: приписывает читать строку справа налево\n" +
                "Singleline: устанавливает однострочный режим, а весь текст рассматривается как одна строка\n" +
                "Некоторые элементы синтаксиса регулярных выражений:\n" +
                "^: соответствие должно начинаться в начале строки(например, выражение @\"^пр\\w*\"\n" +
                "соответствует слову \"привет\" в строке \"привет мир\")" +
                "$: конец строки(например, выражение @\"\\w*ир$\" соответствует слову \"мир\" в строке \"привет мир\",\n" +
                "так как часть \"ир\" находится в самом конце)" +
                ".: знак точки определяет любой одиночный символ(например, выражение \"м.р\" соответствует слову\n" +
                "\"мир\" или \"мор\")" +
                "*: предыдущий символ повторяется 0 и более раз\n" +
                "+: предыдущий символ повторяется 1 и более раз\n" +
                "?: предыдущий символ повторяется 0 или 1 раз\n" +
                "\\s: соответствует любому пробельному символу\n" +
                "\\S: соответствует любому символу, не являющемуся пробелом\n" +
                "\\w: соответствует любому алфавитно-цифровому символу\n" +
                "\\W: соответствует любому не алфавитно-цифровому символу\n" +
                "\\d: соответствует любой десятичной цифре\n" +
                "\\D: соответствует любому символу, не являющемуся десятичной цифрой\n"
            ); 
            double number = 23.75;
            string result = String.Format("{0:C}", number);
            Console.WriteLine(result); // $ 23.7
            string result2 = String.Format("{0:C2}", number);
            Console.WriteLine(result2); // $ 23.70
            
            int number2 = 23;
            string result3 = String.Format("{0:d}", number2);
            Console.WriteLine(result3); // 23
            string result4 = String.Format("{0:d4}", number2);
            Console.WriteLine(result4); // 0023
            
            string result5 = String.Format("{0:f}", number2);
            Console.WriteLine(result); // 23,00

            double number3 = 45.08;
            string result6 = String.Format("{0:f4}", number3);
            Console.WriteLine(result2); // 45,0800
            double number4 = 25.07;
            string result7 = String.Format("{0:f1}", number4);
            Console.WriteLine(result2); // 25,1

            decimal number5 = 0.15345m;
            Console.WriteLine("{0:P1}", number5);// 15.3%

            // Настраиваемые форматы
            float number6 = 15.43434f;
            string result8 = String.Format("{0:##.###}", number6);
            Console.WriteLine(result8); // +1 (987) 654-32-10

            // ToString
            long number7 = 19876543210;
            Console.WriteLine(number7.ToString("+# (###) ###-##-##"));// +1 (987) 654-32-10

            double number8 = 24.8;
            Console.WriteLine(number8.ToString("C2")); // $ 24,80

            long number9 = 375987654321;
            Console.WriteLine($"DaDaDaDa {number9:+(###)-##-###-##-##}");
            Console.WriteLine($"DaDaDaDa {number9:+(###)-##-###-##-##, 5}");

            double variable = 555.632554;
            Console.WriteLine("{0:N4} da\n", variable);


            // Библиотека System.Text.RegularExpressions
            // Поиск в строке по некоторому регулярному выражению
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            // Проверка почты на валидацию используя регулярные выражения
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            
            Console.WriteLine("\nВведите адрес электронной почты:");
            string email = "mail@gmail.ru";
            if (Regex.IsMatch(email, pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Email подтвержден");
            }
            else
            {
                Console.WriteLine("Некорректный email");
            }

            // Замена и метод Replace
            string s2 = "  Мама  мыла  раму.  ";
            string pattern2 = @"\W";
            string target = " ";
            Regex regex2 = new Regex(pattern2);
            string resString = regex2.Replace(s2, target);
            Console.WriteLine(resString);
        }
    }
}
