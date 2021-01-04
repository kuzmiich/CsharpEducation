using ConsoleApp1.classes;
using LibPeople = ClassLibrary.People;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsTraining.OutTask();
            TupleTraining.OutTask();
            StructTraining.OutTask();
            // check class library
            LibPeople people;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            ClassLibrary.Sorting.BubleSort(ref arr);
            // !end

        }
    }
}