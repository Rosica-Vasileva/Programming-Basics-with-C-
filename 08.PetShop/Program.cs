

//Input //Output     //Input  //Output
//5     //28.5лв    // 13    //68.5лв
//4                // 9

int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double expenses = dogFood * 2.5 + catFood * 4;
Console.WriteLine($"{expenses}lv.");
