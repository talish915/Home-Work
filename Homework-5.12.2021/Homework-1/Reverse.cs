using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Reverse
    {
        public string ReverseWord(string str)
        {
            string result = "";

            string[] arr = str.Split(' ');

            foreach (string word in arr)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];

                }
                if (result.Length < str.Length)
                    result += " ";
            }
            Console.WriteLine(result);
            return result;


        }
    }
}
