using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullableOne = null;
            double? nullableTwo = null;
            Console.WriteLine(nullableOne + " " + nullableTwo);
            nullableOne += 3;
            nullableTwo *= 12;
            Console.WriteLine(nullableOne + " " + nullableTwo);
        }
    }

