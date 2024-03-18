string shape = Console.ReadLine();
double area = 0;

if (shape == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (shape == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    area = sideA * sideB;
}


Console.WriteLine(area);

