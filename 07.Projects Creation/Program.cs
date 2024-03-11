
//INPUT  //OUTPUT
//4      //The architect Mihail will need 12 hours to complete 4 project/s.
//9
//Mihail
string name = Console.ReadLine();
int numberOfProjects = int.Parse(Console.ReadLine());

double neededHours = numberOfProjects * 3;

Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {numberOfProjects} project/s.");
