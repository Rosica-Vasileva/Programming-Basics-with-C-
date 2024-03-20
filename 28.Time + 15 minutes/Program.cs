//1 46 2:01 //0 01 0:16 //23 59 0:14 //11 08 11:23 //12 49 13:04

int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
minutes += 15;

if (minutes >= 60)
{
    hour++;
    minutes -= 60;
}

if (hour >= 24)
{
    hour = 0;
}

Console.WriteLine($"After 15 minutes: {hour:D2}:{minutes:D2}");