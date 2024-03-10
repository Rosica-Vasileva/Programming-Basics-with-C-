  //INPUT       //INPUT 
 //2          // 7                  
//3         //3
//2        //6



int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double chickenPrice = chickenMenu * 10.35;
double fishPrice = fishMenu * 12.40;
double vegePrice = vegetarianMenu * 8.15;

double totalMenuPrice = chickenMenu + fishMenu + vegetarianMenu;
double dessertPrice = 0.2 * totalMenuPrice;
double deliveryPrice = 2.5;
double totalPrice = totalMenuPrice + dessertPrice + deliveryPrice;
Console.WriteLine($"{totalPrice:F2}");