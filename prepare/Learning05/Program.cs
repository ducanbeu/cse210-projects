class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [
            new Circle(3),
            new Square(2),
            new Rectangle(4,5),
        ];

        foreach (var shape in shapes) {
            shape.SetColor("red");
            Console.WriteLine(shape.GetColor(), shape.GetArea());
        }
    }
}