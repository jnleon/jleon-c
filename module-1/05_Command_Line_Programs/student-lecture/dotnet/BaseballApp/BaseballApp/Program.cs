using System;

namespace BaseballApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minplayerss = 1;
           const int maxplayerss = 5;
            Console.WriteLine("Hi, coach! ");
              
            int numPlayers = getIntInput("How many players are on your team?", minplayerss, maxplayerss);
            
    

            string[] playerName = new string[numPlayers];
            double[] battingAverage = new double[numPlayers];


            for (int i = 0; i < numPlayers; i++)
            {

                Console.WriteLine("What is the players name?");
                playerName[i] = Console.ReadLine();

                int atBat =  getIntInput("How many times has the player been at bat?", 1 , 24);
                /*   string strAtBat = Console.ReadLine();
                   double atBat = double.Parse(strAtBat); */


                int timesHit = getIntInput("How many times has the player hit?", 0, atBat);

                 /*   Console.WriteLine("How many times has the player hit?");
                string strTimesHit = Console.ReadLine();
                int timesHit = int.Parse(strTimesHit); */

                battingAverage[i] = timesHit / atBat;



            }
            Console.WriteLine("Player name \t Batting avarage");
            for (int i = 0; i < numPlayers; i++)
                Console.WriteLine(playerName[i] + "\t" + battingAverage[i]);


            //print the player name and batting average of the player with the highest batting avarage 

            double highestBattingAverage = battingAverage[0];
            string highestName = playerName[0];
            for (int i = 1; i < numPlayers; i++) //start at one because we're assuming first elemnt is the higest to start

                if (battingAverage[i] > highestBattingAverage)
                {
                    highestBattingAverage = battingAverage[i];
                    highestName = playerName[i];
                }
            Console.WriteLine(highestName + " had the best batting average of" + highestBattingAverage);
        }
        static int getIntInput(string msg, int low, int high)
        {

            bool p = true;
            bool q = true;



            if (!p || !q)

            {
                Console.WriteLine("Apple");
            }

            else if (p ^ q)

            {
                Console.WriteLine("Orange");
            }

            else

            {
                Console.WriteLine("Banana");
            }


            int retValue = low - 1;
            bool hasError = false;
            while (retValue < low || retValue > high)
            {
               if (hasError)
                {
                    Console.WriteLine("You have entered invalid input. Please enter an int between {0} and {1}", low, high);
                }
                Console.WriteLine(msg);
                string input = Console.ReadLine();
                retValue = int.Parse(input);
                hasError = true;
            }
            return retValue; //once they give us valid data, it kicks out of the while loop so we should return
        }
    }
   



}




