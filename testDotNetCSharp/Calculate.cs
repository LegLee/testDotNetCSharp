using System;

namespace testDotNetCSharp
{
    public class Calculate
    {
        public Calculate()
        {
        }

        public int summ(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
        public int sub(int a, int b)
        {
            int c;
            c = a - b;
            return c;
        }
        public int mul(int a, int b)
        {
            int c;
            c = a * b;
            return c;
        }
        public float div(int a, int b)
        {
            float c=0;
            if (b != 0)
            {
                c = (float)a / b;
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!\n");
            }
            return c;
        }
    }
}
