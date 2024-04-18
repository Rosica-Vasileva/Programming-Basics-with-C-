


int age = int.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'f')
{
    if (age < 16)
    {
        Console.WriteLine("Miss");
    }
    else // age >= 16
    {
        Console.WriteLine("Ms.");
    }
}
else // gender == 'm'
{
    if (age < 16)
    {
        Console.WriteLine("Master");
    }
    else // age >= 16
    {
        Console.WriteLine("Mr");
    }
}
