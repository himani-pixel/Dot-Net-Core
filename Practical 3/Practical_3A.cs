using System;

delegate void Operation(int a, int b);
class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    public void Div(int a, int b)
    {
        Console.WriteLine("Division: " + (a / b));
    }
}
/*class Practical_3A
{
    public static void Main(string[] args)
    {
        Calculator c = new Calculator();
        Operation obj;

        obj = c.Add;
        obj(11, 11);

        obj = c.Sub;
        obj(20, 10);

        obj = c.Mul;
        obj(5, 11);

        obj = c.Div;
        obj(20, 4);

        Console.ReadLine();
    }
}*/
