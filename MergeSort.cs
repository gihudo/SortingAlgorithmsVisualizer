namespace SortingAlgorithms
{
    static class MergeSort
    {
        static public int index { get; set; } = -1;
        static public void Sort(int[] arr, int begin, int end)
        {
            if (begin >= end)
                return;

            int mid = begin + (end - begin) / 2;
            Sort(arr, begin, mid);
            Sort(arr, mid + 1, end);
            Merge(arr, begin, mid, end);

            index = -1;
            System.Threading.Thread.Sleep(5);
        }

        static private void Merge(int[] arr, int left, int mid, int right)
        {
            int[] leftArr = new int[mid - left + 1];
            int[] rightArr = new int[right - mid];

            for (int i = 0; i < leftArr.Length; i++)
                leftArr[i] = arr[left + i];
            for (int i = 0; i < rightArr.Length; i++)
                rightArr[i] = arr[mid + i + 1];

            int indexOfLeftArray = 0;
            int indexOfRightArray = 0;
            int indexOfMergedArray = left;

            while(indexOfLeftArray < leftArr.Length && indexOfRightArray < rightArr.Length)
            {
                //delay
                System.Threading.Thread.Sleep(1);
                if(leftArr[indexOfLeftArray] <= rightArr[indexOfRightArray])
                {
                    arr[indexOfMergedArray] = leftArr[indexOfLeftArray];
                    indexOfLeftArray++;
                }
                else
                {
                    arr[indexOfMergedArray] = rightArr[indexOfRightArray];
                    indexOfRightArray++;
                }
                indexOfMergedArray++;
            }

            while(indexOfLeftArray < leftArr.Length)
            {
                index = indexOfMergedArray;
                //delay
                System.Threading.Thread.Sleep(1);

                arr[indexOfMergedArray] = leftArr[indexOfLeftArray];
                indexOfLeftArray++;
                indexOfMergedArray++;
            }

            while (indexOfRightArray < rightArr.Length)
            {
                index = indexOfMergedArray;
                //delay
                System.Threading.Thread.Sleep(1);

                arr[indexOfMergedArray] = rightArr[indexOfRightArray];
                indexOfRightArray++;
                indexOfMergedArray++;
            }
        }
    }
}

