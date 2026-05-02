using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.Write("Try and guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic)
            {
                Console.WriteLine("Your guess was too high");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Your guess is too low");
            }

        } while (guess != magic);

        Console.WriteLine("You got it!");
    }
}