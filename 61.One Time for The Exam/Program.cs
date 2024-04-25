
//9
//30
//9
//50
//Late 20 minutes after the start 9 00 10 30 Late 1:30 hours after the start 10 00 10 00 On time

//9
//00
//8
//30
//On time 30 minutes before the start 14 00 13 55 On time 5 minutes before the start 11 30 10 55 Early 35 minutes before the start

//16
//00
//15
//00 
//Early 1:00 hours before the start 11 30 8 12 Early 3:18 hours before the start 11 30 12 29 Late 59 minutes after the start


int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examTime = examHour * 60 + examMinute;
int arrivalTime = arrivalHour * 60 + arrivalMinute;
int difference = arrivalTime - examTime;

if (difference>0)
{
    Console.WriteLine("On time.");
}
else if (difference<=30)
{
    Console.WriteLine("Early");
    Console.WriteLine($"{difference}minutes befor the start.");
}
else
{
    Console.WriteLine("Late");
}

int hoursLate = difference / 60;
int minutesLate = difference % 60;

if(hoursLate==0)
{
    Console.WriteLine($"{minutesLate}minutes after the start.");
}
else
{
    Console.WriteLine($"{hoursLate}:{minutesLate:D2}hours after the start");
}