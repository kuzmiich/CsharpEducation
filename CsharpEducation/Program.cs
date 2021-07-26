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

            ClassLibrary.Logic.Sorting.BubleSort(ref arr);
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

            StringStringBuilderRegexTraining.OutTask();
            Console.WriteLine(LINE);

            AdditionalClassAndStructure.OutTask();
            Console.WriteLine(LINE);

            MultithreadingBasicTraining.OutTask();
            Console.WriteLine(LINE);

            MutexeSemaphoreTimerTraining.OutTask();
            Console.WriteLine(LINE);

            ClassTaskTraining.OutTask();
            Console.WriteLine(LINE);

            AsyncTraining.OutTask();
            Console.WriteLine(LINE);

            LinqTraining.OutTask();
            Console.WriteLine(LINE);

            ParallelLinqTraining.OutTask();
            Console.WriteLine(LINE);

            ReflectionTraining.OutTask();
            Console.WriteLine(LINE);

            DynamicTraining.OutTask();
            Console.WriteLine(LINE);

            GCTraining.OutTask();
            Console.WriteLine(LINE);

            OOP_PrincipleTraining.OutOOP_Pillars();
            Console.WriteLine(LINE);

            SolidPrinciple.OutSolidPrinciples();
            Console.WriteLine(LINE);

            //Your code goes here
            String s1 = "abc";
            String s2 = "cbd";
            String s3 = "abc";
            s2 = s3;
            Console.WriteLine(s1 + " " + s2 + " " + s3 + "\n");
            
            Console.Write(s2 == s3 + " ");
            Console.Write(" " + s1.Equals(s3) + " ");
            Console.Write(ReferenceEquals(s1, s3) + " ");
            Console.Write(ReferenceEquals(s2, s3));
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