using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Logic
{
    public static class CollectionAnalysis
    {
        public static IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
            => numbers.Where(x => x % 2 == 0);

        public static IEnumerable<T> ExceptFilter<T>(IEnumerable<T> firstCollectioin, IEnumerable<T> secondCollection)
            => firstCollectioin.Except(secondCollection);

        public static IEnumerable<T> AscendingSort<T>(params T[] arr)
            => arr.OrderBy(x => x);

        public static IEnumerable<T> DescendingSort<T>(params T[] arr)
            => arr.OrderByDescending(x => x);

        public static bool Search<T>(T index, params T[] arr)
            => arr.Any(x => object.Equals(x, index));

        public static bool CheckArraySequence<T>(IEnumerable<T> arrFirst, IEnumerable<T> arrSecond)
            => arrFirst.SequenceEqual(arrSecond);
    }
}
