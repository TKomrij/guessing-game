using System;

int secretNumber = new Random().Next(1, 100);

Console.Write("Easy, Medium, Hard, or Cheater??? ");
string inputDifficulty = Console.ReadLine();

if (inputDifficulty.ToLower() == "easy")
{
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("What is the magic number?");

        int guesses = 8 - i;
        Console.WriteLine($"Guesses Left: {guesses}");

        string input = Console.ReadLine();
        int parsedInput = Int32.Parse(input);


        if (parsedInput == secretNumber)
        {
            Console.WriteLine("You guessed the secret number!");
            i = 8;
        }
        else
        {
            Console.WriteLine("Darn it! Wrong answer.");
        }


        if (parsedInput > secretNumber)
        {
            Console.WriteLine("Oops, a little too high!");
        }
        else if (parsedInput < secretNumber)
        {
            Console.WriteLine("Oops, a little too low!");
        }
    }
}
else if (inputDifficulty.ToLower() == "medium")
{
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("What is the magic number?");

        int guesses = 6 - i;
        Console.WriteLine($"Guesses Left: {guesses}");

        string input = Console.ReadLine();
        int parsedInput = Int32.Parse(input);


        if (parsedInput == secretNumber)
        {
            Console.WriteLine("You guessed the secret number!");
            i = 6;
        }
        else
        {
            Console.WriteLine("Darn it! Wrong answer.");
        }


        if (parsedInput > secretNumber)
        {
            Console.WriteLine("Oops, a little too high!");
        }
        else if (parsedInput < secretNumber)
        {
            Console.WriteLine("Oops, a little too low!");
        }
    }
}
else if (inputDifficulty.ToLower() == "hard")
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("What is the magic number?");

        int guesses = 4 - i;
        Console.WriteLine($"Guesses Left: {guesses}");

        string input = Console.ReadLine();
        int parsedInput = Int32.Parse(input);


        if (parsedInput == secretNumber)
        {
            Console.WriteLine("You guessed the secret number!");
            i = 4;
        }
        else
        {
            Console.WriteLine("Darn it! Wrong answer.");
        }


        if (parsedInput > secretNumber)
        {
            Console.WriteLine("Oops, a little too high!");
        }
        else if (parsedInput < secretNumber)
        {
            Console.WriteLine("Oops, a little too low!");
        }
    }
}
else if (inputDifficulty.ToLower() == "cheater")
{
    for (int i = 0; i > -1; i++)
    {
        Console.WriteLine("What is the magic number?");

        string input = Console.ReadLine();
        int parsedInput = Int32.Parse(input);


        if (parsedInput == secretNumber)
        {
            Console.WriteLine("You guessed the secret number!");
            break;
        }
        else
        {
            Console.WriteLine("Darn it! Wrong answer.");
        }


        if (parsedInput > secretNumber)
        {
            Console.WriteLine("Oops, a little too high!");
        }
        else if (parsedInput < secretNumber)
        {
            Console.WriteLine("Oops, a little too low!");
        }
    }
}



