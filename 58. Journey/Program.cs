

//· Първи ред – Бюджет, реално число в интервала [10.00...5000.00].
//· Втори ред – Един от двата възможни сезона: „summer” или “winter”
//При 100лв. или по-малко – някъде в България
//o Лято – 30% от бюджета
//o Зима – 70% от бюджета
//· При 1000лв. или по малко – някъде на Балканите
//o Лято – 40% от бюджета
//o Зима – 80% от бюджета
//· При повече от 1000лв. – някъде из Европа
//o При пътуване из Европа, независимо от сезона ще похарчи 90% от бюджета.

//четем от конзолата бюджет , сезон 
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

//инициализиране на променливи за дестинация,вид на почивка,похарчени пари 
string destination = "";
string vacationType = "";
double moneySpent = 0;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        vacationType = "Camp";
        moneySpent = budget * 0.3;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        moneySpent = budget * 0.7;
    }
}

else if(budget<=1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        vacationType = "Camp";
        moneySpent = budget * 0.4;
    }
    else if (season=="winter")
    {
        vacationType = "Hotel";
        moneySpent = budget * 0.8;
    }
}
else
{
    destination = "Europe";
    vacationType = "Hotel";
    moneySpent = budget * 0.9;
}

//извеждаме изходни данни

Console.WriteLine($"Somewhere is {destination}");
Console.WriteLine($"{vacationType}-{moneySpent:F2}");