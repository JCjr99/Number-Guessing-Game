using System;

namespace Number_Guessing_Game
{
    class Guessing_Game
    {
        private int number;
        private int noGuesses;
        public void Play()
        {
            noGuesses = 0;
            Random rdm = new Random();
            number = rdm.Next(1, 100);

            Console.WriteLine("Guess a number between 1 and 100");
            int guess =  Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (guess < number)
                {
                    noGuesses++;
                    Console.WriteLine("Guess too low! Try again");
                    Console.WriteLine("Number of guesses:" + noGuesses);
                    
                }
                else if(guess > number)
                {
                    noGuesses++;
                    Console.WriteLine("Guess too high! Try again");                 
                    Console.WriteLine("Number of guesses:" + noGuesses);
                    
                }
                else if (guess == number)
                {
                    noGuesses++;
                    Console.WriteLine("Correct! The number was " + number);
                    Console.WriteLine("Total number of guesses: " + noGuesses);
                    break;
                }
                guess = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        static void Main(string[] args)
        {
            Guessing_Game game = new Guessing_Game();
            game.Play();
        }
    }
}
