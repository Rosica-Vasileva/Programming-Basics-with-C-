

//INPUT   //OUTPUT    //INPUT  //OUTPUT
//212    //7         //432     //7
//20                //15
//2                //4


int pageNum = int.Parse(Console.ReadLine());
int pageOneHours = int.Parse(Console.ReadLine());
int dayNum = int.Parse(Console.ReadLine());

int totalHours = pageNum / pageOneHours;
int hourseDay = totalHours / dayNum;
Console.WriteLine($"{hourseDay}");