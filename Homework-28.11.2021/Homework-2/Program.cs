using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            int sum = 0;
            int result;

            while (num>0)
            {
                result = num % 10;
                sum += result;
                num /= 10;
            }
            Console.WriteLine("Ededlerin cemi: {0}",sum);
        }
    }
}
