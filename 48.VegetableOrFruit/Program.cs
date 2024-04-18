

string food = Console.ReadLine();

switch (food)
{
    case "bannana":
    case "apple":
    case "kiwi":
    case "grapes":
    case "cherry":
    case "lemon":
        Console.WriteLine("Fruit");
        break;
    case "tomato":
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("Vegetable");
        break;
   default:
        Console.WriteLine("Unknow");
        break;
}
