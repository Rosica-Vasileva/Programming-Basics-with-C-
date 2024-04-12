

//75 invalid
//150 nowayout
//220 invalid
//199 nowayout
//-1 invalid
//100 nowayout
//200 nowayout
//0 nowayout

int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <= 200 || number == 0)
{
    Console.WriteLine("valid");
}
else
{
    Console.WriteLine("invalid");
}

