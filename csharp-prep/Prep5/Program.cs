using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        static void displayIntro()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string getUsersName()
        {
            string name="0";
            Console.WriteLine("What is your name? ");
            name=Console.ReadLine();
            return name;
        }
        static int getBirthYear()
        {
            Console.WriteLine("What year were you born in? ");
            int birhtyear=int.Parse(Console.ReadLine());
            return birhtyear;
        }
        static int GetFavoriteNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int FavNum=int.Parse(Console.ReadLine());
            return FavNum;
        }
        static int SqareFave(int bobob)
        {
            int sqared=bobob*bobob;
            return sqared;
        }
        static int DetermineAge(int Birthyear)
        {
            int age=2026-Birthyear;
            return age;
        }
        static void FinalDisplay(string name, int age, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
            Console.WriteLine($"{name}, you will turn {age} this year");
        }
        displayIntro();
        string name=getUsersName();
        int MyFavorit=GetFavoriteNumber();
        int MyFavoriteSquared=SqareFave(MyFavorit);
        int birthday=getBirthYear();
        int elder=DetermineAge(birthday);
        FinalDisplay(name,elder,MyFavoriteSquared);

    }
    
}