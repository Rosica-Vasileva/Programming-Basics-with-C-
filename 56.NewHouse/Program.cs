
//Input
//Roses 55 250
//Tulips 88 260
//· Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
//· Ако Нели купи повече от 90 Далии - 15% отстъпка от крайната цена
//· Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
//· Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
//· Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%

string flowerType = Console.ReadLine();
int countFlower = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double price = 0;

switch (flowerType)
{
    case "Roses":
        price = countFlower * 5;//броя цветя * цената за брой=цялата сума
        if(countFlower>80)      //ако броя е по голям от 80 цената се променя
        {
            price *= 0.8;      //цената - 10%
        }
        break;
    case  "Dahlias":
            price = countFlower * 3.80;//броя цветя * цената за брой=цялата сума
        if (countFlower>90)            //ако броя е по голям от 90 цената се промнея
        {
            price *= 0.85;       //цената - 15%
        }
        break;
    case "Tulips":
            price = countFlower * 2.8;//броя цветя * цената за брой=цялата сума
        if (countFlower>80)           //ако броя е по голям от 80 цената се променя
        {
            price *= 0.85;            //цената - 15%
        }
        break;
    case "Narcissus":
            price = countFlower * 3.0;//броя цветя * цената за брой=цялата сума
        if (countFlower<120)          //ако броя е по малък от 120 цената се променя
        {
            price *= 1.15;            //цената + 15% оскъпяване
        }
        break;
            case "Gladiolus":
            price = countFlower * 2.5;//броя цветя * цената за брой=цялата сума
        if (countFlower<80)           //ако броя е по малък от 80 цената се променя
        {
            price *=1.20;             //цената + 20% оскъпяване 
        }
        break;
}

double absoluteValue = Math.Abs(budget - price);
if (budget >= price)
{
    Console.WriteLine($"Hey, you have a great garden with {countFlower} {flowerType} and {absoluteValue:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {absoluteValue:F2} leva more.");
}