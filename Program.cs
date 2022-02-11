using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandom;
            int enemyRandom;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++) //the int i = 0 = initialiser section; the i < 10 = the conditional section, the i++ =iterator section
            {
                Console.WriteLine("Press any key to roll the dice. ");

                Console.ReadKey();

                playerRandom = random.Next(1, 7); //the next helps to create a lower-bound of 1
                Console.WriteLine("You rolled a " + playerRandom); //and a higher bound of 7. the range falls between 1 to 6

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // waiting for 1000 min secs equivalent to 1 secs before ds


                enemyRandom = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandom);

                if (playerRandom > enemyRandom)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");

                }
                else if (playerRandom < enemyRandom)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The score is now - Player: " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You Win!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("It is a draw");
            }
            Console.ReadKey();
        }   
    }
}