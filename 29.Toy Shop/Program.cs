//40.8 20 25 30 50 10   Yes! 418.20 lv left.
//320 8 2 5 5 1 Not enough money! 238.73 lv needed.

double tourPrice = double.Parse(Console.ReadLine());
int puzzleCount = int.Parse(Console.ReadLine());
int dollCount = int.Parse(Console.ReadLine());
int bearCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

int countOfToys = puzzleCount + dollCount + bearCount + minionsCount + trucksCount;
double sumOfToys = puzzleCount * 2.60 + dollCount * 3 + bearCount * 4.10 + minionsCount * 8.2 + trucksCount * 2;

// Проверка за отстъпка за брой играчки
if (countOfToys >= 50)
{
    sumOfToys *= 0.9;
}

// Проверка за отстъпка за сума от играчки
if (sumOfToys >= 50)
{
    sumOfToys *= 0.75;
}

double gain = sumOfToys * 0.9;

Console.WriteLine(gain);

if (gain >= tourPrice)
{
    Console.WriteLine($"Yes! {gain - tourPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tourPrice - gain:f2} lv needed.");
}
