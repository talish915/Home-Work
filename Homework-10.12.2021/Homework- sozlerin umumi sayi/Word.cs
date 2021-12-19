using System;
using System.Collections.Generic;
using System.Text;

namespace Homework__sozlerin_umumi_sayi
{
    class Word
    {
        public void CountWords(string cumle)
        {
            int wordCount = 0, index = 0;

            while (index < cumle.Length && char.IsWhiteSpace(cumle[index]))
                index++;

            while (index < cumle.Length)
            {
                while (index < cumle.Length && !char.IsWhiteSpace(cumle[index]))
                    index++;

                wordCount++;

                while (index < cumle.Length && char.IsWhiteSpace(cumle[index]))
                    index++;
            }
            Console.WriteLine("Soz sayi "+wordCount);
        }
    }
}
