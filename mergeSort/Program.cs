namespace mergeSort
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

            // Mergesort ausführen
            Mergesort(array, 0, array.Length - 1);

            // Ausgabedaten ausgeben
            Console.WriteLine("Sortierte Ausgabedaten:");
            PrintArray(array);
        }

        static void Mergesort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Mergesort(array, left, middle);
                Mergesort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(array, left, leftArray, 0, leftSize);
            Array.Copy(array, middle + 1, rightArray, 0, rightSize);

            int i = 0, j = 0, k = left;

            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }

}
