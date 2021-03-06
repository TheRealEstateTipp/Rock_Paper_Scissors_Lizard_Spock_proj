﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Simulator
    {
        public Player playerOne;
        public Player playerTwo;
        public string numberofPlayers;
        
        
        
        


        //1. What are the rules?
        //2. Single Player or Multi-Player? (Human vs. Human or Human vs. Computer)
        //3. What are players name?
        //4. Player Choose Gestures
        //5. Compare the gestures
        //6. Who wins the round? Is this the last round?
        //7. Is there a game winner? (If yes, who is the winner and would you like to play again? If no, loop back to Step 4.


        public void RunSimulator() 
        
        {
            GameRules();
            string numberofPlayers = GetNumberofPlayers();
            CreatePlayer(numberofPlayers);

            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                playerOne.Gestures();
                playerTwo.Gestures();
                CompareGestures();
            }

            
            
            DisplayWinner();
            Rematch();
            
        }


        public void GameRules()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules: Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors," +
                "Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
  
        }

        public string GetNumberofPlayers()
        {
            Console.WriteLine("How Many Players?");
            string input = Console.ReadLine();
            return input;
        }

        public void CreatePlayer(string numberofPlayers)
        {
            if (numberofPlayers == "1") 
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (numberofPlayers == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }

         }
        public void CompareGestures()
        {
            if (playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }

            else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }

            else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Lizard")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Spock")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Rock")
            {
                playerOne.score++;
                Console.WriteLine("Player One Wins!");
            }
            else if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("This Round is Tied!");
            }
            else
            {
                playerTwo.score++;
                Console.WriteLine("Player Two Wins!");
            }

        } 
        public void Rematch()
        {
            Console.WriteLine("Would You Like to Play Again?");
            string input = Console.ReadLine();

            if (input == "Yes")
            {
                RunSimulator();
            }
            else
            {
                Console.WriteLine("Thank you for playing RPSLS!");
            }
         }
        public void DisplayWinner()
        {
            if (playerOne.score == 3)
            {
                Console.WriteLine("Our winner is" + playerOne);
            }
            else
            {
                Console.WriteLine("Our winnder is" + playerTwo);
            }

        }
        
       

        



    }




}
