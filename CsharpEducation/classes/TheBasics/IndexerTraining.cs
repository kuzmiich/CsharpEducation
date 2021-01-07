using Education.interfaces;
using System;

namespace Education.classes.TheBasics
{
    class Matrix
    {
        private int[,] numbers = new int[,] { 
        { 1, 2, 4 },
        { 2, 3, 6 },
        { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            private set
            {
                numbers[i, j] = value;
            }
        }
    }
    class Player
    {
        public string Name { get; set; } // имя
        public int Number { get; set; } // номер
    }
    class Team
    {
        Player[] players = new Player[11];

        public Player this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }
    }
    class Word
    {
        public string Source { get; }
        public string Target { get; set; }
        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
    class Dictionary
    {
        private Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зеленый")
            };
        }
        public string this[string source]
        {
            get 
            {
                Word word = null;
                foreach (Word w in words)
                {
                    if (w.Source == source)
                    {
                        word = w;
                        break;
                    }
                }
                return word?.Target;
            }
            set 
            {
                foreach (Word word in words)
                {
                    if (word.Source == source)
                    {
                        word.Target = value;
                        break;
                    }
                }
            }
        }
        public Word this[int index]
        {
            get
            {
                return words[index];
            }
            set
            {
                words[index].Target = value.Target;       
            }
        }
    }
    class IndexerTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Изучение индексаторов...");
            Console.WriteLine("Тестирование индексаторов с простыми типами");
            Console.WriteLine("Тестирование индексаторов со сложными типами");
            Console.WriteLine("Создание индексаторов для перевода слов.Изменения и чтения слов.");
            Matrix matrix = new Matrix();
            Console.WriteLine(matrix[0, 0]);
            //
            Team inter = new Team();
            inter[0] = new Player { Name = "Ronaldo", Number = 9 };
            Console.WriteLine($"{inter[0].Name} - {inter[0].Number}");
            //
            Dictionary dict = new Dictionary();
            string needWord = "blue";
            Console.WriteLine(dict[needWord]);
            dict[needWord] = "голубой";
            Console.WriteLine($"{dict[needWord]}");
            //
            Console.WriteLine($"{dict[1].Source} - {dict[1].Target}");
            dict[1] = new Word("", "лиловый");
            Console.WriteLine($"{dict[1].Source} - {dict[1].Target}");
        }
    }
}
