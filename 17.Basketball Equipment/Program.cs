
      


int yearlyFee = int.Parse(Console.ReadLine());

        double basketballShoesPrice = yearlyFee - (yearlyFee * 0.40);
        double basketballKitPrice = basketballShoesPrice - (basketballShoesPrice * 0.20);
        double basketballBallPrice = basketballKitPrice / 4;
        double basketballAccessoriesPrice = basketballBallPrice / 5;

        double totalCost = yearlyFee + basketballShoesPrice + basketballKitPrice + basketballBallPrice + basketballAccessoriesPrice;

        Console.WriteLine($"{totalCost:F2}");


