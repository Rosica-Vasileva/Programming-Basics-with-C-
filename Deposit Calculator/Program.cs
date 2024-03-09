

//Lines are read from the console:
//1.Amount deposited – real number in the interval [100.00 … 10000.00]
//2.Term of the deposit (in months) – whole number in the interval [1…12]
//3.Annual interest rate - real number in the interval [0.00 …100.00]

//amount = deposited amount + term of the deposit * ((deposited amount * annual interest rate ) / 12)





double depositSum = double.Parse(Console.ReadLine());
int termOfDeposit = int.Parse(Console.ReadLine());
double annualPercentage = double.Parse(Console.ReadLine());

double sum = depositSum + termOfDeposit * ((depositSum * annualPercentage / 100) / 12);
Console.WriteLine(sum);
