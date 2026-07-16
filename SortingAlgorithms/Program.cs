class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int[] intArray = { 5, 8, 2, 9, 1 };

        SortingAlgorithms.Print(intArray);
        Console.WriteLine();

        SortingAlgorithms.BubSort(intArray);

        SortingAlgorithms.Print(intArray);

    }



}

public static class SortingAlgorithms
{
    public static void BubSort<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length; i++) {
            {
                for (int j = 0; j < array.Length - 1; j++)
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
