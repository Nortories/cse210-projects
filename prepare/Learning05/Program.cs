using System;

class Program
{
    static void Main(string[] args)
    {

        Square shape1 = new Square("blue", 5);
        Rectangle shape2 = new Rectangle("black", 4, 6);
        Circle shape3 = new Circle("green", 4);

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(shape1);
        shapeList.Add(shape2);
        shapeList.Add(shape3);

        foreach (Shape shape in shapeList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            System.Console.WriteLine($"Color:{color} Area:{area}");
        }
        
    }
}