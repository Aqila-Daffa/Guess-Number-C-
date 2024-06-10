using System;

namespace GuessingGame
{
    class Guess
    {
        public void startGame(Boolean isTrue, int random)
        {
            Random rnd = new Random();

            while (!isTrue)
            {
                Console.WriteLine("Please choose a number from 1 to 10");
                int numb = Convert.ToInt32(Console.ReadLine());

                if (numb > random)
                {
                    Console.WriteLine("The number is " + random);
                    Console.WriteLine("The number is too high, try again!");
                    random = rnd.Next(1, 10);
                }
                else if (numb < random)
                {
                    Console.WriteLine("The number is " + random);
                    Console.WriteLine("The number is too low, try again!");
                    random = rnd.Next(1, 10);
                }
                else
                {
                    Console.WriteLine("The number is " + random);
                    Console.WriteLine("You guessed correctly!");
                    isTrue = true;
                }
            }
        }
    }
}