

//A fruit shop operates at the following prices during working days:
//fruit banana apple orange grapefruit kiwi pineapple grapes
//price 2.50 1.20 0.85 1.45 2.70 5.50 3.85
//Saturdays and Sundays the store operates at higher prices:
//fruit banana apple orange grapefruit kiwi pineapple grapes
//price 2.70 1.25 0.90 1.60 3.00 5.60 4.20

string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;
bool isValid = true;

switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                price = 2.5;
                break;
            case "apple":
                price = 1.2;
                break;
            case "orange":
                price = 0.85;
                break;
            case "grapefruit":
                price = 1.45;
                break;
            case "kiwi":
                price = 2.7;
                break;
            case "pineapple":
                price = 5.5;
                break;
            case "grapes":
                price = 3.85;
                break;
            default:
                isValid = false;
                break;
        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                price = 2.7;
                break;
            case "apple":
                price = 1.25;
                break;
            case "orange":
                price = 0.9;
                break;
            case "grapefruit":
                price = 1.6;
                break;
            case "kiwi":
                price = 3;
                break;
            case "pineapple":
                price = 5.6;
                break;
            case "grapes":
                price = 4.2;
                break;
            default:
                isValid = false;
                break;
        }
        break;
    default:
        isValid = false;
        break;
}
if (isValid)
{
    Console.WriteLine($"{price * quantity:f2}");
}
else
{
    Console.WriteLine("error");
}
