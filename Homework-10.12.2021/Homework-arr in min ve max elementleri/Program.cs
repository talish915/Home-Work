using System;

namespace Homework_arr_in_min_ve_max_elementleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,4,3,6,5,7,8,10};
            int min = int.MaxValue;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max=arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum Eded" + min);
            Console.WriteLine("Maximum eded" + max);
        }
    }
}
