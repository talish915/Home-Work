using System;

namespace Homework_arr_da_elementeri_siralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20,200};
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>100&&arr[i]<999)
                {
                    sum1 = sum1 + arr[i];
                }
                else
                {
                    sum2 = sum2 + arr[i];
                }
            }
            Console.WriteLine(sum1-sum2);
        }
    }
}
