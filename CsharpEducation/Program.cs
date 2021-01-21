using System;
using Education.classes;
using Education.classes.Basics;
using Education.classes.Advanced;
using LibPeople = ClassLibrary.Person;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] LINE = GetLine(50, '*');
            Console.WriteLine(LINE);
            ParamsTraining.OutTask();

            TupleTraining.OutTask();

            Console.WriteLine(LINE);
            StructTraining.OutTask();

            // check class library
            Console.WriteLine("Работа с ClassLibrary(Некоторые методы используются с обобщениями)");
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

            ObjectTraining.OutTask();
            Console.WriteLine(LINE);

            GeneralizationTraining.OutTask();
            Console.WriteLine(LINE);
           
            ExceptionTraining.OutTask();
            Console.WriteLine(LINE);

            DelegateBasicTraining.OutTask();
            Console.WriteLine(LINE);

            DelegateUse.OutTask();
            Console.WriteLine(LINE);

            DelegateAnonymousTraining.OutTask();
            Console.WriteLine(LINE);

            DelegateEventTraining.OutTask();
            Console.WriteLine(LINE);
            
            DelegateCovarianceContravarianceTraining.OutTask();
            Console.WriteLine(LINE);

            DelegateActionPredicateFunc.OutTask();
            Console.WriteLine(LINE);

            InterfaceBasicTraining.OutTask();
            Console.WriteLine(LINE);

            SolidPrinciples.OutSolidPrinceples();
            Console.WriteLine(LINE);
        }
        static char[] GetLine(int length, char separator)
        {
            char[] line = new char[length];
            for (int i = 0; i < length; i++)
            {
                line[i] = separator;
            }
            return line;
        }
    }
}