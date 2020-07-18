using System;
using System.Collections.Generic;
using System.Text;


namespace testDotNetCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;
            int number;
            int result;
            float resultD;
            Calculate prog = new Calculate();
            while(true)
            {
                Console.WriteLine("Введите первое число ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите операцию: \n0)Выход \n1) Сумма \n2) Вчитание \n3) Умножение \n4) Деление");
                number = Convert.ToInt32(Console.ReadLine());
                if(number==1)
                {
                    result=prog.summ(a, b);
                    Console.WriteLine($"Result: {result}");
                }
                else if (number == 2)
                {
                    result = prog.sub(a, b);
                    Console.WriteLine($"Result: {result}");
                }
                else if (number == 3)
                {
                    result = prog.mul(a, b);
                    Console.WriteLine($"Result: {result}");
                }
                else if(number == 4)
                {
                    resultD = prog.div(a, b);
                    Console.WriteLine($"Result: {resultD}");
                }
                else if(number == 0)
                {
                    break;
                }
            }
        }
    }
}
