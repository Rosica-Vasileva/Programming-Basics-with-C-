Input     Output
550lv.     final price 3432.11 lv.
           discount 753.39lv
  
Input     Output  
150lv.     final price 936.03 lv.
           discount 205.47v


double yardArea = double.Parse(Console.ReadLine());

double price = yardArea * 7.61;

double discount = price * 0.18;
double finalPrice = price - discount;

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
