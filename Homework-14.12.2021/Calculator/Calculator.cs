using System;

namespace Calculator
{
    public class Calculator1
    {
        public void Calculator(int a, char op, int b)
        {
            int res = 0;
            if (op == '+')
            {
                res = a + b;
            }
            else if (op == '-')
            {
                res = a - b;
            }
            else if (op == '*')
            {
                res = a * b;
            }
            else if (op == '/')
            {
                res = a / b;
            }
            Console.WriteLine(res);
        }
    }
}
