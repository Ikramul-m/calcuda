using System;

class Program
{
    public static void Main(string[] args)
    {
        string secretWord = "hatim-ben-arfa";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuess = false;

        while (guess != secretWord && !outOfGuess)
        {
            if (guessCount < guessLimit)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outOfGuess = true;
            }

        }

        if (!outOfGuess)
            Console.Write("You Win!!!");
        else
            Console.Write("You Loose!!!");

    }
}








