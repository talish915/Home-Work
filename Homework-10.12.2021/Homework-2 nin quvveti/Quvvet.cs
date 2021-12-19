using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_2_nin_quvveti
{
    class Quvvet
    {
        public void Power(int num)
        {
            bool result = true;
            for (int i = 1; i < num; i*=2)
            {
                if (num==i*2)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
