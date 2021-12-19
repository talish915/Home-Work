using System;

namespace Homework__arr_da_sondan_evvele_ardicilliqi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 50, 10, 64, 22, 76 };
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
