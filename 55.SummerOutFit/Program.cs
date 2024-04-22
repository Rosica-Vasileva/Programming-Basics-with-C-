
//Partofday /temperature Мorning Afternoon Evening

//10 <= temperature <= 18 Outfit = Sweatshirt Shoes = Sneakers Outfit = Shirt Shoes = Moccasins Outfit = Shirt Shoes = Moccasins

//18 < temperature <= 24 Outfit = Shirt Shoes = Moccasins Outfit = T-Shirt Shoes = Sandals Outfit = Shirt Shoes = Moccasins

//temperature >= 25 Outfit = T-Shirt Shoes = Sandals Outfit = Swim Suit Shoes = Barefoot Outfit = Shirt Shoes = Moccasins

        

        int temperature = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        string outfit = "";
        string shoes = "";

        
        if (temperature >= 10 && temperature <= 18)
        {
            switch (partOfDay)
            {
                case "Morning":
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    break;
                case "Afternoon":
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
            }
        }
        else if (temperature > 18 && temperature <= 24)
        {
            switch (partOfDay)
            {
                case "Morning":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                case "Afternoon":
                case "Evening":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
            }
        }
        else if (temperature >= 25)
        {
            switch (partOfDay)
            {
                case "Morning":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
                case "Afternoon":
                case "Evening":
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    break;
            }
        }

        Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
   

