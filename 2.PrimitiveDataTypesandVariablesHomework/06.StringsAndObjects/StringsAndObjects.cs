using System;

    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string greeting = (string)helloWorld;
            Console.WriteLine("{0}\n{1} ", helloWorld, greeting);
        }
    }

