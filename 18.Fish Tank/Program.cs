




int length = int.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

int volume = (int)(length * width * height);
double volumeLitres = volume / 1000.0;
double occupiedSpace = percentage / 100.0;
double litresNeeded = volumeLitres * (1 - occupiedSpace);
Console.WriteLine($"{litresNeeded:F3}");
