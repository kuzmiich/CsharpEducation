using System;
using Education.classes;
using Education.classes.Basics;
using Education.classes.Advanced;
using Education.classes.Advanced.AdditionalFeaturesInOOP;
using LibPeople = ClassLibrary.Person;
using Education.classes.Advanced.Multithreading;

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

            AccessModifier.OutTask();
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

            ICloneableTraining.OutTask();
            Console.WriteLine(LINE);

            IComparableTraining.OutTask();
            Console.WriteLine(LINE);

            InterfaceCovarianceAndContravariance.OutTask();
            Console.WriteLine(LINE);

            ExtensionMethodTraining.OutTask();
            Console.WriteLine(LINE);

            PartialClassAndMethodTraining.OutTask();
            Console.WriteLine(LINE);

            AnonymousTypeTraining.OutTask();
            Console.WriteLine(LINE);

            PatternMatchingTraining.OutTask();
            Console.WriteLine(LINE);

            PatternSwitchTraining.OutTask();
            Console.WriteLine(LINE);

            RecordsTraining.OutTask();
            Console.WriteLine(LINE);

            CollectionTraining.OutTask();
            Console.WriteLine(LINE);

            StringTraining.OutTask();
            Console.WriteLine(LINE);

            AdditionalClassAndStructure.OutTask();
            Console.WriteLine(LINE);

            MultithreadingBasicTraining.OutTask();
            Console.WriteLine(LINE);

            MutexeSemaphoreTimerTraining.OutTask();
            Console.WriteLine(LINE);

            ClassTaskTraining.OutTask();
            Console.WriteLine(LINE);





            LinqTraining.OutTask();
            Console.WriteLine(LINE);

            OOP_PrincipleTraining.OutOOP_Principles();
            Console.WriteLine(LINE);

            SolidPrinciple.OutSolidPrinceples();
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