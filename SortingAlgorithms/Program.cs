class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int[] intArray = { -11,12,-42,0,90,68,6,-9 };

        int[] selectArray = { 8, 5, 2, 9, 11, 1, 3 };

        int[] insertArray = { -10, 11, 43, 2, 69, 97, 7, -11 };

        Console.WriteLine("Before Bubble Sort:");
        SortingAlgorithms.Print(intArray);
        Console.WriteLine();

        SortingAlgorithms.BubSort(intArray);

        Console.WriteLine("After Bubble Sort:");
        SortingAlgorithms.Print(intArray); 
        Console.WriteLine();


        Console.WriteLine("Before Selection Sort:");
        SortingAlgorithms.Print(selectArray);
        Console.WriteLine() ;

        SortingAlgorithms.SelectionSort(selectArray);

        Console.WriteLine("After Selection Sort: ");
        SortingAlgorithms.Print(selectArray);
        Console.WriteLine();

        Console.WriteLine("Before Insertion Sort:");
        SortingAlgorithms.Print(insertArray);
        Console.WriteLine();

        SortingAlgorithms.InsertionSort(insertArray);

        Console.WriteLine("After Insertion Sort: ");
        SortingAlgorithms.Print(insertArray);
        Console.WriteLine();
    }



}

public static class SortingAlgorithms
{
    public static void SelectionSort<T>(T[] array) where T: IComparable
    {
        for(int i=0;i<array.Length; i++)
        {
            int minIndex = i;
            T minValue= array[i];

            for(int j=i+1;j<array.Length; j++)
            {
                if (array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];
                }
            }
            T temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }

    public static void InsertionSort<T>(T [] array)where T: IComparable
    {
        for(int i = 1; i < array.Length; i++)
        {
            int j = i;
            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                T temp= array[j-1];
                array[j - 1] = array[j];
                array[j] = temp;
                j--;
            }
        }
    }
    public static void BubSort<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length; i++) {
            {
                for (int j = 0; j < array.Length - 1-i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }

    public static void Print<T>(T[] array) {
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + ",");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

        }
    } 
}
