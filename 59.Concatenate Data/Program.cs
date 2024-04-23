

        // Четене на входните данни от конзолата
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());

        // Променлива за съхранение на резултата от операцията
        double result = 0;

        // Извършване на математическата операция
        switch (operation)
        {
            case '+':
                result = N1 + N2;
                Console.WriteLine($"{N1} + {N2} = {result} - {IsEven(result)}");
                break;
            case '-':
                result = N1 - N2;
                Console.WriteLine($"{N1} - {N2} = {result} - {IsEven(result)}");
                break;
            case '*':
                result = N1 * N2;
                Console.WriteLine($"{N1} * {N2} = {result} - {IsEven(result)}");
                break;
            case '/':
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result = (double)N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
                break;
            case '%':
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
                break;
        }
   

    // Метод за определяне дали число е четно или нечетно
    static string IsEven(double number)
    {
        return number % 2 == 0 ? "even" : "odd";
    }






