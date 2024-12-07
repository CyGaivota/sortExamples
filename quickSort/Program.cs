namespace quickSort
{
    using System;

    class Program
    {
        static void Main()
        {
            // Beispiel-Datenmenge
            int[] array = { 34, 7, 23, 32, 5, 62 };

            // Eingabedaten ausgeben
            Console.WriteLine("Eingabedaten:");
            PrintArray(array);

            // Quicksort ausführen
            Quicksort(array, 0, array.Length - 1);

            // Ausgabedaten ausgeben
            Console.WriteLine("Sortierte Ausgabedaten:");
            PrintArray(array);
        }

        static void Quicksort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                Quicksort(array, left, pivotIndex - 1);
                Quicksort(array, pivotIndex + 1, right);
            }
        }

        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }

}
