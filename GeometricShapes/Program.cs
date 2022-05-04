using GeometricShapes;

var quad1 = new Quad() {Name = "Bob", Side1 = 3, Side2 = 4, Side3 = 5, Side4 = 6};
Console.WriteLine($"Perimeter {quad1.Name} is {quad1.Perimeter()} units.");

var rect1 = new Rect() {Name = "Steve", SideL = 5, SideS = 3 };
Console.WriteLine($"\nPerimeter {rect1.Name} is {rect1.Perimeter()} units.");
Console.WriteLine($"Area {rect1.Name} is {rect1.Area()} units square.");

var square1 = new Square() { Name = "Michelle", Side = 5};
Console.WriteLine($"\nPerimeter {square1.Name} is {square1.Perimeter()} units.");
Console.WriteLine($"Area {square1.Name} is {square1.Area()} units square.");