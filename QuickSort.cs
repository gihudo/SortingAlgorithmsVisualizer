namespace SortingAlgorithms
{
    static class QuickSort
    {
        static public int index { get; set; } = -1;
        static public int index2 { get; set; } = -1;
        static public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pi = Partition(arr, left, right);
                Sort(arr, left, pi - 1);
                Sort(arr, pi + 1, right);
            }

            index = -1;
            index2 = -1;
            System.Threading.Thread.Sleep(5);
        }
        static private int Partition(int[] arr, int left, int right)
        {
            int indx = left;
            int pivot = arr[left];
            for (int i = left + 1; i <= right; i++)
            {
                //delay
                System.Threading.Thread.Sleep(1);
                if (arr[i] < pivot)
                {
                    indx++;
                    Swap(arr, indx, i);
                }
            }

            Swap(arr, indx, left);
            return indx;
        }

        static private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i]= arr[j];
            arr[j]= temp;
            index = i;
            index2 = j;
        }
    }
}
