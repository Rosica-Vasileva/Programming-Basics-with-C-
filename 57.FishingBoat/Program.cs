


//· Бюджет на групата – цяло число в интервала [1…8000]
//· Сезон – текст: "Spring", "Summer", "Autumn", "Winter"
//· Брой рибари – цяло число в интервала [4…18]

int budget = int.Parse(Console.ReadLine()); //четем бюджета от конзолата
string season = Console.ReadLine();         //четем за кой сезон 
int fisherMen = int.Parse(Console.ReadLine());  //четем броя рибари от конзолата
double moneyRequired = 0;      //инициализираме променлива за цена за конкретен сезон 

switch (season)                //ако сезона е 
{
    case "Spring":             //Пролет
        moneyRequired = 3000;  //наем на кораб през пролетта е 3000
        if (fisherMen <= 6)    //ако рибарите са по малко от 6 човека ще вземат 10% намаелние 
        {
            moneyRequired *= 0.9;   //цената на наема изважда 10% отстъпка
        }
        else if (fisherMen <= 11)  //ако рибарите са по малко от 11 човека ще вземат 15% намаление
        {
            moneyRequired *= 0.85;  //от цената за наем на конкретния сезон вадим 15 % намаление
        }
        else if (fisherMen >= 12)   //ако рибарите са повече от 12 човека ще вземат 25 % намаление 
        {
            moneyRequired *= 0.75;  //от цената за наема вадим 25 % намаление 
        }
        break;

    case "Summer": //наема 4200 се отнася и за двата сезона Лято и Есен 
    case "Autumn": //
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

if (fisherMen % 2 == 0 && season != "Autumn") //ако рибарите са четен брой , за всички сезони с изключение на есента ще вземат още 5 % отстъпка
{
    moneyRequired *= 0.95;
}

double moneyLeftOrNeeded = Math.Abs(budget - moneyRequired);  

if (budget >= moneyRequired) //ако бюджета им е повече от нужната сума за наем или ако не е достатъчен 
{
    Console.WriteLine($"Yes! You have {moneyLeftOrNeeded:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {moneyLeftOrNeeded:F2} leva.");
}

