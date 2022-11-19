namespace SortingAlgorithms
{
    static class SelectionSort
    {
        static public int index { get; set; } = -1;
        static public int index2 { get; set; } = -1;
        static public void Sort(int[] arr)
        {
            int indexOfMin;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                indexOfMin = i;
                index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //delay
                    System.Threading.Thread.Sleep(1);
                    index2 = j;
                    if (arr[j] < arr[indexOfMin])
                        indexOfMin = j;
                }
                Swap(arr, i, indexOfMin);
            }
            index = -1;
            System.Threading.Thread.Sleep(5);
        }

        static private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
