using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * 1. App asks the user's name and greets the users by it's name;
             * 2. App asks the user's age and calculates what year the user was born;
             * 3. App displays the results to the user
             
             */
            Console.WriteLine("What's your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello there, " + Name);
            Console.WriteLine("How old are you?");
            string Userinput;
            Userinput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(Userinput);
            int Born = 2020 - YearOfBirth;
            Console.WriteLine("You were born in the year " + Born + ".");


        }
    }
}
