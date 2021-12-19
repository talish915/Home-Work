using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    public static class Extension
    {
        public static void Word(this string word, string a)
        {
            bool res = false;
            int count = 0;
            for (int i = 0, k = 0; i < word.Length;i++)
            {
                if (word[i]==a[k])
                {
                    k++;
                    count++;
                }
                else
                {
                    k = 0;
                    count = 0;

                }
                if (count >= a.Length)
                {
                    res = true;
                    
                }
            }
            
            
            Console.WriteLine(res);
        }
    }
}
