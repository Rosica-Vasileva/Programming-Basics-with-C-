

//900 2 1 3  You have 198.75 leva left!
//920.45 3 1  1 Not enough money! You need 3.92 leva more!

double budget = double.Parse(Console.ReadLine());
int videocardsCount = int.Parse(Console.ReadLine());
int proccesorCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());

double sum = videocardsCount * 250 + (0.35 * videocardsCount * 250) * proccesorCount + (0.1 * videocardsCount * 250) * ramCount;

if(videocardsCount>proccesorCount)
{
    double discount = 0.15 * sum;
    sum = sum - discount;
}

if (budget>=sum)
{
    Console.WriteLine($"You have {budget-sum:f2} leva left!");
}

else
{
    Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
}
