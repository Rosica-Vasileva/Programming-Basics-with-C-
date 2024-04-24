
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice = 0;
        double apartmentPrice = 0;

        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50;
                apartmentPrice = 65;
                if (nights > 14)
                {
                    studioPrice *= 0.7; // 30% discount
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95; // 5% discount
                }
                if (nights > 14)
                {
                    apartmentPrice *= 0.9; // 10% discount
                }
                break;
            case "June":
            case "September":
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (nights > 14)
                {
                    studioPrice *= 0.8; // 20% discount
                }
                if (nights > 14)
                {
                    apartmentPrice *= 0.9; // 10% discount
                }
                break;
            case "July":
            case "August":
                studioPrice = 76;
                apartmentPrice = 77;
                if (nights > 14)
                {
                    apartmentPrice *= 0.9; // 10% discount
                }
                break;
        }

        double studioTotalPrice = studioPrice * nights;
        double apartmentTotalPrice = apartmentPrice * nights;

        Console.WriteLine($"Apartment: {apartmentTotalPrice:f2} lv.");
        Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");


