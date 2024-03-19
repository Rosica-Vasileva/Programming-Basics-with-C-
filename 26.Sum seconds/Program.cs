
//35 45 44    2:04
//22 7 34     1:03
//50 50 49    2:29
//14 12 10    0:36

int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int sumTime = firstTime + secondTime + thirdTime;
int minutes = sumTime / 60;
int seconds = sumTime % 60;


if (seconds<10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}

Console.WriteLine($"{minutes}:{seconds}");

