namespace SortingAlgorithms
{
    static class InsertionSort
    {
        static public int index { get; set; } = -1;
        static public int index2 { get; set; } = -1;
        static public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    System.Threading.Thread.Sleep(5);
                    index2 = j;
                    Swap(arr, j - 1, j);
                }
            }
            index = -1;
            index2 = -1;
        }

        static private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
