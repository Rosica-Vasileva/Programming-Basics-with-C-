//12 f Miss
//17 m Mr.
//25 f Ms.
//13.5 m Master

using System;


        Console.WriteLine("Enter age:");
        double age = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter gender (m/f):");
        char gender = char.Parse(Console.ReadLine());

        if (gender == 'f')
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }
            else
            {
                Console.WriteLine("Ms");
            }
        }
        else if (gender == 'm')
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr");
            }
        }
        else
        {
            Console.WriteLine("Invalid gender input.");
        }

