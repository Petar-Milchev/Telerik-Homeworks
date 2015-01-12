using System;

class LongSequence
{
    static void Main()
    {
        Console.Write("Print first thousand numbers: ");

        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
                Console.Write(-i + ", ");
        }
        Console.WriteLine();
    }
}