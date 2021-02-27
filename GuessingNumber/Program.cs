using System;

namespace GuessingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name!");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}!\nWelcome to the Guessing Game!");
            Console.WriteLine("I am thinking of a number from 1 to 10");
            Guessing();

        }
        static void Guessing()
        {
            Random rand = new Random();
            int num = rand.Next(10);
            bool match = false;
            while (!match)
            {
                string answer = Console.ReadLine();
                int val = Int32.Parse(answer);
                if (num == val)
                {
                    Console.WriteLine("You found the answer!");
                    match = true;
                }
                else {
                    Console.WriteLine("Keep Trying!");
                }
            }
            

        }
    }
}
