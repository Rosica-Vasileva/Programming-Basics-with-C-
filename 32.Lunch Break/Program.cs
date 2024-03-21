//Game of Thrones 60 96 You have enough time to watch Game of Thrones and left with 0 minutes free time.
//Teen Wolf 48 60 You don't have enough time to watch Teen Wolf, you need 11 more minutes.


        
        string seriesName = Console.ReadLine();
        int episodeDuration = int.Parse(Console.ReadLine());
        int breakDuration = int.Parse(Console.ReadLine());

       
        double lunchTime = breakDuration * 1.0 / 8;
        double restTime = breakDuration * 1.0 / 4;

        
        double remainingTime = breakDuration - lunchTime - restTime;

        
        if (remainingTime >= episodeDuration)
        {
            Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(remainingTime - episodeDuration)} minutes free time.");
        }
        else
        {
            Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration - remainingTime)} more minutes.");
        }


