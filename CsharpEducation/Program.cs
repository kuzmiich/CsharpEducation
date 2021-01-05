using Education.classes;
using System;
using System.Linq;
using LibPeople = ClassLibrary.People;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 50;
            char[] LINE = new char[length];
            for (int i = 0; i < length; i++)
            {
                LINE[i] = '*';
            }
            Console.WriteLine(LINE);
            ParamsTraining.OutTask();

            TupleTraining.OutTask();

            Console.WriteLine(LINE);
            StructTraining.OutTask();

            // check class library
            LibPeople people;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            ClassLibrary.Sorting.BubleSort(ref arr);
            // !end
            Console.WriteLine(LINE);

            IndexerTraining.OutTask();
            Console.WriteLine(LINE);

            AccessModifiers.OutTask();
            Console.WriteLine(LINE);

            ConstAndReadonlyTraining.OutTask();
            Console.WriteLine(LINE);

            NullTraining.OutTask();
            Console.WriteLine(LINE);

            TypeConversionTraining.OutTask();
            Console.WriteLine(LINE);
        }
    }
}