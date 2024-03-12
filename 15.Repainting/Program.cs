using System;

class MainClass
{
    public static void Main(string[] args)
    {
        double nylonKvm = double.Parse(Console.ReadLine());
        double paintLitres = double.Parse(Console.ReadLine());
        double thinnerLitres = double.Parse(Console.ReadLine());
        double hourse = double.Parse(Console.ReadLine());

        double nylonPrice = (nylonKvm + 2) * 1.50;
        double paintPrice = (paintLitres + (paintLitres * 0.10)) * 14.50;
        double thinnerPrice = thinnerLitres * 5.00;
        double bag = 0.40;

        double totalPrice = nylonPrice + paintPrice + thinnerPrice + bag;
        double masterPrice = (totalPrice * 0.30) * hourse;
        double finalPrice = totalPrice + masterPrice;

        Console.WriteLine(finalPrice);
    }
}
