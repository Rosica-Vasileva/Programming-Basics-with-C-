//20000 120 55.5 Action! Wingard starts filming with 11340.00 leva left.
//15437.62 186 57.99 Action! Wingard starts filming with 4186.33 leva left.


        double budgetMovies = double.Parse(Console.ReadLine());
        int extrasCount = int.Parse(Console.ReadLine());
        double sumClothingOneExtras = double.Parse(Console.ReadLine());

        double sumOfDecor = 0.1 * budgetMovies;
        double sumClothingAllExtras = extrasCount * sumClothingOneExtras;

       
        if (extrasCount > 150)
        {
            double discount = 0.1 * sumClothingAllExtras;
            sumClothingAllExtras -= discount;
        }

        double allSumMovies = sumOfDecor + sumClothingAllExtras;
        double sumRemainder = budgetMovies - allSumMovies;

        if (sumRemainder >= 0)
        {
            Console.WriteLine($"Action! Wingard starts filming with {sumRemainder:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! Wingard needs {Math.Abs(sumRemainder):F2} leva more.");
        }

