using TestTask4.Model;

IFigure figure;

figure = new Square(5,5);
Console.WriteLine($"Square - Width: {figure.Width}, Hight: {figure.Hight}");
Console.WriteLine($"Perimeter: {figure.GetPerimeter()}");
Console.WriteLine($"Square: {figure.GetSquare()}");
Console.WriteLine($"Can Be: {figure.CanBe()}");
Console.WriteLine("========================================");

figure = new Rectangle(3, 5);
Console.WriteLine($"Square - Width: {figure.Width}, Hight: {figure.Hight}");
Console.WriteLine($"Perimeter: {figure.GetPerimeter()}");
Console.WriteLine($"Square: {figure.GetSquare()}");
Console.WriteLine($"Can Be: {figure.CanBe()}");
Console.WriteLine("========================================");

figure = new Rhomb(4, 9);
Console.WriteLine($"Rhomb - Width: {figure.Width}, Hight: {figure.Hight}");
Console.WriteLine($"Perimeter: {figure.GetPerimeter()}");
Console.WriteLine($"Square: {figure.GetSquare()}");
Console.WriteLine($"Can Be: {figure.CanBe()}");
Console.WriteLine("========================================");


figure = new Circle(4);
Console.WriteLine($"Circle - Radius: {figure.Width / 2}");
Console.WriteLine($"Perimeter: {figure.GetPerimeter()}");
Console.WriteLine($"Square: {figure.GetSquare()}");
Console.WriteLine($"Can Be: {figure.CanBe()}");
Console.WriteLine("========================================");