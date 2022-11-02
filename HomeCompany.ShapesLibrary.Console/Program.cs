// See https://aka.ms/new-console-template for more information

using HomeCompany.ShapesLibrary;

var triangle1 = new Triangle(1.6, 4.3, 5.3);
Console.WriteLine($"Triangle's area: {triangle1.GetArea():f3}");
Console.WriteLine($"Is the triangle right-angled: {triangle1.IsRightAngled()}");

var triangle2 = new Triangle(5.63, 9.21, 10.79);
Console.WriteLine($"Triangle's area: {triangle2.GetArea():f3}");
Console.WriteLine($"Is the triangle right-angled: {triangle2.IsRightAngled()}");

var circle = new Circle(5.6);
Console.WriteLine($"Circle's area: {circle.GetArea():f3}");