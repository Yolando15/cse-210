using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square S=new Square();
        S.SetColor("red");
        string color = S.GetColor();
        double area = S.GetArea();
        Console.WriteLine($"{color}");
        Console.WriteLine($"{area}");

        //rectangle
        Rectangle R=new Rectangle();
        R.SetColor("blue");
        string colorR = R.GetColor();
        double areaR = R.GetArea();
        Console.WriteLine($"{colorR}");
        Console.WriteLine($"{areaR}");

        Circle C=new Circle();
        C.SetColor("purple");
        string colorC = C.GetColor();
        double areaC = C.GetArea();
        Console.WriteLine($"{colorC}");
        Console.WriteLine($"{areaC}");

    }
}