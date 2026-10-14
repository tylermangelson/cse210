using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        int x = 10;

        Console.WriteLine("Hello Circle");

        Circle myCircle = new Circle(x);


        double area = myCircle.GetArea();

        Console.WriteLine(area);
        

        double radius = myCircle.GetRadius();
        Console.WriteLine(radius);


    }

}