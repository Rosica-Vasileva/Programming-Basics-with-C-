
using System.ComponentModel.Design;

int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
bool isOpen = false;

switch (day)
{
    case "monday":
    case "tuesday":
    case "wednesday":
    case "thursday":
    case "friday":
    case "saturday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("Open");
        }
        break;


        else
        {
            Console.WriteLine("Close");
        }
        break;
