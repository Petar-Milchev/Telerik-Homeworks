using System;

    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a= {0} b= {1}", a, b);
            a = a + b;
            b = a - b;
            a = b + b;
            Console.WriteLine("a= {0} b= {1}", a, b);

        }
    }

