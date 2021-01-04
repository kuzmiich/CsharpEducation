namespace ClassLibrary
{
    public static class Sorting
    {
        private static void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
        public static void BubleSort<T>(ref T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
        }
    }
}
