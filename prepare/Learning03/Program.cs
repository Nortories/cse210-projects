using System;

class Program
{
    static void Main(string[] args)
    {
        CreateFractions();
    }

    public static void CreateFractions()
    {

        Fraction f1 = new Fraction();
        Fraction f2= new Fraction(5);
        Fraction f3= new Fraction(3,4);
        Fraction f4= new Fraction(1,3);

        System.Console.WriteLine(f1.GetFractionString());
        System.Console.WriteLine(f1.GetDecimalValue());

        System.Console.WriteLine(f2.GetFractionString());
        System.Console.WriteLine(f2.GetDecimalValue());

        System.Console.WriteLine(f3.GetFractionString());
        System.Console.WriteLine(f3.GetDecimalValue());
        
        System.Console.WriteLine(f4.GetFractionString());
        System.Console.WriteLine(f4.GetDecimalValue());


    }

}