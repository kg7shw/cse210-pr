using System;

class Program
{

    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        List<Shapes> shapes = new List<Shapes>();

        // Square test1 = new Square("Blue", 2.3);
        // test1.GetColor();
        // test1.GetArea();

        Square shape1 = new Square("Blue", 2.3);
        shapes.Add(shape1);
        Rectangle shape2 = new Rectangle("Red", 2.3, 4.5);
        shapes.Add(shape2);
        Circle shape3 = new Circle("Green", 5.3);
        shapes.Add(shape3);


        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"{color}, {area}");
        }
        
    }
}