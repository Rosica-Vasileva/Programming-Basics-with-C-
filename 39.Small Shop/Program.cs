

//coffee Varna 2  0.9  
//peanuts Plovdiv 1  1.5
//beer Sofia 3  3.6
//water Plovdiv 2  1.4
//sweets Sofia 2.23  3.2335



        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0;

        if (city == "Sofia")
        {
            switch (product)
            {
                case "coffee":
                    price = 0.5;
                    break;
                case "water":
                    price = 0.8;
                    break;
                case "beer":
                    price = 1.2;
                    break;
                case "sweets":
                    price = 1.45;
                    break;
                case "peanuts":
                    price = 1.60;
                    break;
            }
        }
        else if (city == "Plovdiv")
        {
            switch (product)
            {
                case "coffee":
                    price = 0.4;
                    break;
                case "water":
                    price = 0.7;
                    break;
                case "beer":
                    price = 1.15;
                    break;
                case "sweets":
                    price = 1.30;
                    break;
                case "peanuts":
                    price = 1.50;
                    break;
            }
        }
        else if (city == "Varna")
        {
            switch (product)
            {
                case "coffee":
                    price = 0.45;
                    break;
                case "water":
                    price = 0.7;
                    break;
                case "beer":
                    price = 1.1;
                    break;
                case "sweets":
                    price = 1.35;
                    break;
                case "peanuts":
                    price = 1.55;
                    break;
            }
        }

        Console.WriteLine(price * quantity);

