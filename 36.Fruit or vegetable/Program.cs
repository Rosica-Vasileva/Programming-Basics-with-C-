//banana fruit
//apple fruit
//tomato vegetable
//water unknown

string input = Console.ReadLine();
switch (input)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
    case "grapes":
        Console.WriteLine("fruit");
        break;
    case "tomato":
    case "cucumber":
    case "pepper":
    case "carot":
        Console.WriteLine("vegetable");
        break;
    default:
        Console.WriteLine("unknow");
        break;        
}