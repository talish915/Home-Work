using System;

namespace Homework_the_sozunun_setirdeki_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "the apple is on the table.";
            int say = 0;
            for (int i = 0; i < word.Split().Length; i++)
            {
                if (word.Split()[i] == "the" || word.Split()[i] == "The")
                {
                    say++;
                }
            }
            Console.WriteLine(say);
        }
    }      
}
    
