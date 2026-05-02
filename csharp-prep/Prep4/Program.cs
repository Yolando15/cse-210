using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers=new();
        Console.Write("Enter a list of numbers, enter 0 when finished");
        int entry;
        do
        {
            Console.WriteLine("Enter a number: ");
            entry=int.Parse(Console.ReadLine());
            numbers.Add(entry);
        }while(entry!=0);
        //Lets do some math
        int size=numbers.Count-1;
        int sum=0;
        int largest=numbers[0];
        for (int i=0; i<size; i++)
        {
            sum=sum+numbers[i];
            if (largest<numbers[i])
            {
                largest=numbers[i];
            }
        }
        double average=sum/size;
        //Lets write the  results
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}