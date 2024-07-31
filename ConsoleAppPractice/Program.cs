// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hej världen!");

for (int i = 0; i < 100; i++)
{

    if (((i + 1) % 3 == 0) && ((i + 1) % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if ((i + 1) % 3 == 0) {

        Console.WriteLine("Fizz");
    }
    else if ((i + 1) % 5 == 0)
    {
        Console.WriteLine("Buzz");

    }
    else Console.WriteLine(i + 1);
    }

