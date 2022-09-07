namespace SortingAlgorithms
{
    static class BubbleSort
    {
        static public int index { get; set; } = -1;
        static private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            index = j;
        }
        static public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    System.Threading.Thread.Sleep(5);
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
            }
            index = -1;
        }
    }
}
