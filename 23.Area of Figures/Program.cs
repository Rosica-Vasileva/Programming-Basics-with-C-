
        string shape = Console.ReadLine();
        double area;

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
        else if (shape == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            area = Math.PI * r * r;
        }
        else 
        {
            double a = double.Parse(Console.ReadLine());
            double hA = double.Parse(Console.ReadLine());
            area = a * hA / 2;
        }
        

        Console.WriteLine($"{area:F3}");
 
