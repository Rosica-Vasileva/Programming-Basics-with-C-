

//To write the program that reads the whole number entered by the user and checks if it is less than 100, between 100 and 200 or more than 200. If the number is:
//· under 100 print: "Less than 100"
//· between 100 and 200 print: "Between 100 and 200"
//· over 200 print: "More than 200"

int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Less than 100");
}

else if (number <=200)
{
    Console.WriteLine("Between 100-200");

}

else
{
    Console.WriteLine("Greater than 200");
}
