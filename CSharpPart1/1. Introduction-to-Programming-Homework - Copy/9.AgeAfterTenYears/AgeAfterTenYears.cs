using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your birth date (mm/dd/yyyy) : ");
        DateTime Birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - Birthday.Year;
        if (today.Month <= Birthday.Month)
        {
            if (today.Day < Birthday.Day)
            {
                age--;
            }
        }
        Console.WriteLine("You are {0} years old ", age);
        Console.WriteLine("After 10 years you will be {0} years old ", age + 10);

      
    }
}

