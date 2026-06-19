using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fractions numbers=new Fractions();
        int result1=numbers.Divide();
        Console.WriteLine($"{result1}");

        int result2=numbers.Divide(6);
        Console.WriteLine($"{result2}");
        int result3=numbers.Divide(6,7);
        Console.WriteLine($"{result3}");

//Lets do the broing get and set stuff.
        Console.WriteLine("What is the top number? ");
        string acima=Console.ReadLine();
        
    }
}