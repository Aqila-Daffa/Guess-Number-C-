using System;

namespace GuessingGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Guess guess = new Guess();
            int randNum = rnd.Next(1, 10);

            Boolean isCorrect = false;

            Console.WriteLine("Welcome to guessing game!");
            //Console.WriteLine(!isCorrect);

            guess.startGame(isCorrect, randNum);
            
            //Console.WriteLine(isCorrect);
            Console.WriteLine("Congrats, you won the game!");


        }
    }
}