using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_arr_in_minimum_elementi
{
    class Min_Element
    {
        

        public void Element(params int[] array)
        {

            int index = -1;
            int min = int.MaxValue;
            
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value < min)
                {
                    min = value;
                    index = i;
                }
            }

            Console.WriteLine($"Minimum Eded {min} Ededin indeksi {index}");
        }
    }
}
