using System;

namespace Homework_arr_birlestirmek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 10, 5,};
            int[] arr2 = { 22, 17, 20, };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for (int i = 0, n=0; i < arr3.Length; i++)
            {
                if (i<arr1.Length)
                {
                    arr3[i] = arr1[i];
                }
                if (i == arr1.Length || i > arr1.Length)
                {
                    arr3[i] = arr2[n];
                    n++;
                }
            }
            foreach (var item in arr3)
            {

            }
            Array.Sort(arr3);
            Array.Reverse(arr3);
            foreach (int item in arr3)
            {

            }
            Console.WriteLine(string.Join(" ", arr3));
        }
    }
}
