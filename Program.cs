using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Guesso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random num = new Random(); //Program generates a random number for the user to guess
            int secretNum1 = num.Next(1,10); //number to guess is between 1 and 10
            int secretNum2 = num.Next(1,20); // number to guess is between 1 & 20
            int secretNum3 = num.Next(1,50); // number to guess is between 1 & 50
            int numGuessed = 0; //integer storing the number guessed by the user
            int guessCount = 0; // amount of time the user has guessed
            int guessLimit1 = 6; //guess limit for easy
            int trialsLeft1 = 5; // countdown for number of tries left for easy
            int guessLimit2 = 4; // guess limit for medium
            int trialsLeft2 = 3; // countdown for number of tries left for medium
            int guessLimit3 = 3; // guess limit for hard
            int trialsLeft3 = 2; // countdown for number of tries left for hard
            int DiffNum = 0; // integer storing the difficulty for the game
            


            Console.WriteLine("Welcome to Guesso. Where you display your guessing superpowers!"); //welcome message
            Console.WriteLine("Please select difficulty"); //prompt to select difficuly
            Console.Write("[1] Easy , [2] Medium , [3] Hard: "); 
            DiffNum = int.Parse(Console.ReadLine());

            List<string> Difficulty = new List<string>(); //List of difficulties jn the game
            Difficulty.Add("Easy");
            Difficulty.Add("Medium");
            Difficulty.Add("Hard");
            // Difficulty levels in the game

            if (DiffNum == 1) //if 1 was the input of the user, difficulty is easy
            {
                Console.WriteLine("Difficulty: " + Difficulty[0] + " Selected");
            }
            else if (DiffNum == 2) //if 2 was the input of the user, difficulty is medium
            {
               Console.WriteLine("Difficulty: " + Difficulty[1] + " Selected");
            }
            else if (DiffNum == 3) //if 3 was the input of the user, game is hard
            {
                Console.WriteLine("Difficulty: " + Difficulty[2] + " Selected");
            }

             while (DiffNum == 1 && guessCount < guessLimit1 && secretNum1 != numGuessed) 
             //The easy difficulty mode
            {
                Console.Write("Enter a number between 1-10: ");
                numGuessed = int.Parse(Console.ReadLine());
                guessCount++;  //number of times user has guessed

                if (secretNum1 != numGuessed && guessCount != guessLimit1) 
                // secret number has not been guessed right and the number of times user has guessed is not equal to guess limit
                {
                  Console.WriteLine("That was wrong. You have " + trialsLeft1-- + " trials left"); 
                }
                // A prompt informing the user of the number of tries they have left

                else if (guessCount == guessLimit1 && trialsLeft1 == 0) 
                //Amount of time guessed = to the limit and there is no trial left
                {
                  Console.WriteLine("Game over, You Lose!");
                }
                else if (secretNum1 == numGuessed) // if secret number was guessed right
                {
                  Console.WriteLine("Congratulations, you win!"); // success message
                }
            }

             while (DiffNum == 2 && guessCount < guessLimit2 && secretNum2 != numGuessed) 
             //The medium difficulty mode
            {
                Console.Write("Enter a number between 1-20: ");
                numGuessed = int.Parse(Console.ReadLine());
                guessCount++; //number of times the user has guessed

                if (secretNum2 != numGuessed && guessCount != guessLimit2) 
                //guess count is less than guess limit and secret number has not been gotten
                {
                  Console.WriteLine("That was wrong. You have " + trialsLeft2-- +" trials left");
                }
                else if (guessCount == guessLimit2 && trialsLeft2 == 0)
                {
                  Console.WriteLine("Game over, You Lose!"); 
                  //Number of trials is exceeded and number not guessed right
                }
                else if (secretNum2 == numGuessed)
                {
                  Console.WriteLine("Congratulations, you win!"); 
                  //Number has been guessed right within the minimum number of trials required
                }
            } 
            while (DiffNum == 3 && guessCount < guessLimit3 && secretNum3 != numGuessed) 
            //Game mode for hard
            {
                Console.Write("Enter a number between 1-50: ");
                numGuessed = int.Parse(Console.ReadLine());
                guessCount++; 

                if (secretNum3 != numGuessed && guessCount != guessLimit3)
                 //guess count is less than guess limit and secret number has not been gotten
                {
                  Console.WriteLine("That was wrong. You have " + trialsLeft3-- + " trials left");
                }
                else if (guessCount == guessLimit3 && trialsLeft3 == 0)
                {
                  Console.WriteLine("Game over, You Lose!");
                }
                else if (secretNum3 == numGuessed)
                {
                  Console.WriteLine("Congratulations, you win!");
                }
                //End of game...
            } 



           

           

                


            
            
            
                


                
            }
        
            
                

            

            
        }
    }

