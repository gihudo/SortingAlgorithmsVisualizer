namespace SortingAlgorithms
{
    static class CocktailShaker_BubbleSort
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
            int switcher = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(switcher % 2 == 0)
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    System.Threading.Thread.Sleep(5);
                    if (arr[j] > arr[j + 1])
                            Swap(arr, j, j + 1);

                    switcher++;
                }
                else
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    System.Threading.Thread.Sleep(5);
                    if(arr[j] < arr[j - 1])
                            Swap(arr, j - 1, j);

                    switcher++;
                }
            }
            index = -1;
        }
    }
}
