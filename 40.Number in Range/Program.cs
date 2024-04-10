

//-25 Yes
//0 No
//25 Yes


int number = int.Parse(Console.ReadLine());

if (number != 0 && number >= -100 && number <= 100)
{
    Console.WriteLine("Yes");
}

else if (number!=0)
{
    Console.WriteLine("No");    
}