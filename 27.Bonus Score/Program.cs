

//20        6 26
//175       37 212
//2703      270.3 2973.3
//15875     1589.5 17464.5

int number = int.Parse(Console.ReadLine());
double bonus = 0;

if (number<=100)
{
    bonus = 5;
}

else if (number >100 && number <=1000)
{
    bonus = 0.2 * number;
}

else
{
    bonus = 0.1 * number;
}

if (number%2==0)
{
    bonus = bonus + 1;
}

else if (number%10==5)
{
    bonus = bonus + 2;
}

Console.WriteLine(bonus);
Console.WriteLine(number+bonus);
