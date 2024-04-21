
        
        
        

string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

        double income = 0;
        int totalSeats = rows * cols;

        
        switch (projectionType)
        {
            case "Premiere":
                income = totalSeats * 12.00;
                break;
            case "Normal":
                income = totalSeats * 7.50;
                break;
            case "Discount":
                income = totalSeats * 5.00;
                break;
            default:
                Console.WriteLine("Error!");
                return;
        }

        
        Console.WriteLine("{0:f2} leva", income);
 

