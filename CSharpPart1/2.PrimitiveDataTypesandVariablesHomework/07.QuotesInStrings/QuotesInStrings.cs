using System;

    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string first = "The \"use\" of quotations causes difficulties.";
            string second = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("{0}\n{1}" , first, second);
        }
    }

