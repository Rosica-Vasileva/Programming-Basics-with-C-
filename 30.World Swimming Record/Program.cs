//10464 1500 20 //No, he failed! He was 20786.00 seconds slower.
//55555.67 3017 5.03 //Yes, he succeeded! The new world record is 17688.01 seconds.

double recordInSecond = double.Parse(Console.ReadLine());
double distanceInMetres = double.Parse(Console.ReadLine());
double timeInSecondsForOnMeters = double.Parse(Console.ReadLine());

double timeIvanInSeconds = distanceInMetres * timeInSecondsForOnMeters;
double delay = Math.Floor(distanceInMetres / 15);
double allTime = delay * 12.5 + timeIvanInSeconds;

if(allTime<recordInSecond)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:f2} seconds.");
}

else
{
    Console.WriteLine($"No, he failed! He was {allTime - recordInSecond:f2} seconds slower.");
}