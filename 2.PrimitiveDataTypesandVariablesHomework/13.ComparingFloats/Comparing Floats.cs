using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number A:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (a - b == eps)
        {
            Console.WriteLine(a = b);
        }
        else
        {
            Console.WriteLine(a != b);
        }
    }
}

