using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess My Number Game!!! ");

            Console.WriteLine("I'm going to genearte a randomly number between 1 and 100, and you are going to guess which number it is.");


            bool keepGoing = true;
            Random random = new Random();




            while (keepGoing){
                
                
                int secretNumber = random.Next(1, 101);
                int guess = 0;
                int attempts = 0;

                
                
                while (secretNumber != guess ) { 
                Console.WriteLine("Which number between 1 and 100 is your guess?");

                string guessedNumberText = Console.ReadLine();

                bool isValidNumber = int.TryParse(guessedNumberText, out int guessedNumber);


                    if (isValidNumber == false)
                {
                    Console.WriteLine("That is not a valid number");
                    continue;
                }

                    attempts++;


                    if (guessedNumber == secretNumber)
                {
                    Console.WriteLine($"Congratulations, You guessed the correct Number : {guessedNumber} and the number of attempts was {attempts}");
                        Console.WriteLine("Do you want to play again: (yes/no)");
                        string playAgain = Console.ReadLine();

                        if(playAgain.ToLower() == "yes")
                        {
                            keepGoing = true;
                        }
                        else
                        {
                            keepGoing = false;
                        }
                        
                        guess = guessedNumber;
                    break;
                }
                else if (guessedNumber > secretNumber)
                {


                    Console.WriteLine("The secret number is smaller than your guess");
                    continue;
                }
                else {
                    Console.WriteLine("The secret number is bigger than your guess");
                    continue;

                }








                }
            }








            Console.ReadLine();
        }
    }
}
