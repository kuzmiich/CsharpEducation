using Education.classes;
using Education.classes.Advanced;
using Education.classes.Advanced.AdditionalFeaturesInOOP;
using Education.classes.Advanced.Linq;
using Education.classes.Advanced.Multithreading;
using Education.classes.Basics;
using Education.classes.Basics.Delegate;
using System;
using LibPeople = ClassLibrary.Base.Person;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = GetLine(50, '*');
            Console.WriteLine(line);
            ParamsTraining.OutTask();

            TupleTraining.OutTask();

            Console.WriteLine(line);
            StructTraining.OutTask();

            // check class library
            Console.WriteLine("Работа с ClassLibrary(Некоторые методы используются с обобщениями)");
            LibPeople people;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            ClassLibrary.Logic.Sorting.BubleSort(ref arr);
            // !end
            Console.WriteLine(line);

            IndexerTraining.OutTask();
            Console.WriteLine(line);

            AccessModifier.OutTask();
            Console.WriteLine(line);

            ConstAndReadonlyTraining.OutTask();
            Console.WriteLine(line);

            NullTraining.OutTask();
            Console.WriteLine(line);

            TypeConversionTraining.OutTask();
            Console.WriteLine(line);

            ObjectTraining.OutTask();
            Console.WriteLine(line);

            GeneralizationTraining.OutTask();
            Console.WriteLine(line);
           
            ExceptionTraining.OutTask();
            Console.WriteLine(line);

            DelegateBasicTraining.OutTask();
            Console.WriteLine(line);

            DelegateUse.OutTask();
            Console.WriteLine(line);

            DelegateAnonymousTraining.OutTask();
            Console.WriteLine(line);

            DelegateEventTraining.OutTask();
            Console.WriteLine(line);
            
            DelegateCovarianceContravarianceTraining.OutTask();
            Console.WriteLine(line);

            DelegateActionPredicateFunc.OutTask();
            Console.WriteLine(line);

            InterfaceBasicTraining.OutTask();
            Console.WriteLine(line);

            ICloneableTraining.OutTask();
            Console.WriteLine(line);

            IComparableTraining.OutTask();
            Console.WriteLine(line);

            InterfaceCovarianceAndContravariance.OutTask();
            Console.WriteLine(line);

            ExtensionMethodTraining.OutTask();
            Console.WriteLine(line);

            PartialClassAndMethodTraining.OutTask();
            Console.WriteLine(line);

            AnonymousTypeTraining.OutTask();
            Console.WriteLine(line);

            PatternMatchingTraining.OutTask();
            Console.WriteLine(line);

            PatternSwitchTraining.OutTask();
            Console.WriteLine(line);

            RecordsTraining.OutTask();
            Console.WriteLine(line);

            CollectionTraining.OutTask();
            Console.WriteLine(line);

            StringStringBuilderRegexTraining.OutTask();
            Console.WriteLine(line);

            AdditionalClassAndStructure.OutTask();
            Console.WriteLine(line);

            MultithreadingBasicTraining.OutTask();
            Console.WriteLine(line);

            MutexeSemaphoreTimerTraining.OutTask();
            Console.WriteLine(line);

            ClassTaskTraining.OutTask();
            Console.WriteLine(line);

            AsyncTraining.OutTask();
            Console.WriteLine(line);

            LinqTraining.OutTask();
            Console.WriteLine(line);

            ParallelLinqTraining.OutTask();
            Console.WriteLine(line);

            ReflectionTraining.OutTask();
            Console.WriteLine(line);

            DynamicTraining.OutTask();
            Console.WriteLine(line);

            GCTraining.OutTask();
            Console.WriteLine(line);

            OOP_PrincipleTraining.OutOOP_Pillars();
            Console.WriteLine(line);

            SolidPrinciple.OutSolidPrinciples();
            Console.WriteLine(line);
        }

        private static char[] GetLine(int length, char separator)
        {
            var line = new char[length];
            for (int i = 0; i < length; i++)
            {
                line[i] = separator;
            }
            return line;
        }
    }
}