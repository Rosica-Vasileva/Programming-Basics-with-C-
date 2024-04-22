


//· Бюджет на групата – цяло число в интервала [1…8000]
//· Сезон – текст: "Spring", "Summer", "Autumn", "Winter"
//· Брой рибари – цяло число в интервала [4…18]

int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fisherMen = int.Parse(Console.ReadLine());
double moneyRequired = 0;

switch (season)
{
    case "Spring":
        moneyRequired = 3000;
        if (fisherMen <= 6)
        {
            moneyRequired *= 0.9;
        }
        else if (fisherMen <= 11)
        {
            moneyRequired *= 0.85;
        }
        else if (fisherMen >= 12)
        {
            moneyRequired *= 0.75;
        }
        break;

    case "Summer":
    case "Autumn":
        moneyRequired = 4200;
        if (fisherMen <= 6)
        {
            moneyRequired *= 0.9;
        }
        else if (fisherMen <= 11)
        {
            moneyRequired *= 0.85;
        }
        else if (fisherMen >= 12)
        {
            moneyRequired *= 0.75;
        }
        break;

    case "Winter":
        moneyRequired = 2600;
        if (fisherMen <= 6)
        {
            moneyRequired *= 0.9;
        }
        else if (fisherMen <= 11)
        {
            moneyRequired *= 0.85;
        }
        else if (fisherMen >= 12)
        {
            moneyRequired *= 0.75;
        }
        break;
}

if (fisherMen % 2 == 0 && season != "Autumn")
{
    moneyRequired *= 0.95;
}

double moneyLeftOrNeeded = Math.Abs(budget - moneyRequired);

if (budget >= moneyRequired)
{
    Console.WriteLine($"Yes! You have {moneyLeftOrNeeded:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {moneyLeftOrNeeded:F2} leva.");
}

