using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGussingGame
{
    /// <summary>
    /// The is the class that handles all of the score calculation to all the game to function.
    /// </summary>
   public static class ScoreManager
    {
        /// <summary>
        /// Player 1 is index 0, and Player 2 is index 1.
        /// </summary>
        private static int[] PlayersScore = new int[2];

        /// <summary>
        /// Handle the player attempts (gusse deuctions). The meathod check to see if the number gusse is the same as the number the other player selected.
        /// If the player gusse correctly Dose nothing ----> set a value to true.
        /// If the player gusse incorrectly Removes guess ----> set a value to false.
        /// </summary>
        /// <param name="player"></param>
        public static void HandleAttemps(Player player)
        {
            string output;
            if (GameManager.IsValtInput)
            {
                if (player.GetNumberCashe() == GameManager.numberCashe)
                {
                    ConsoleExtracts.ColorTextLine(StrOutputs.GetCorrectGussesStr(),ConsoleColor.Green);
                    GameManager.IsPlayerCorrect = true;
                }
                else
                {
                    output = player.GetNumberCashe() > GameManager.numberCashe ? StrOutputs.GetTooHighOrTooLowGussesStr(true) 
                        : StrOutputs.GetTooHighOrTooLowGussesStr(false);
                    ConsoleExtracts.ColorTextLine(output, ConsoleColor.Red);
                    player.deductNumberOfGusses(1);
                    GameManager.IsPlayerCorrect = false;
                }

                // This Keeps track of the amount of attempts made from the player.
                if(GameManager.turnBase == GameManager.Rounds.Round1)
                {
                    PlayersScore[1] = player.GetNumberOfGusses();
                }
                else if(GameManager.turnBase == GameManager.Rounds.Round2)
                {
                    PlayersScore[0] = player.GetNumberOfGusses();
                }
            }
        }

        /// <summary>
        /// Set the win condition of the player.
        /// </summary>
        public static void HandleWinCondition()
        {
            if(PlayersScore[0] > PlayersScore[1])
            {
                GameManager.winState = GameManager.WinConditions.Player1Won;
            }
            else if(PlayersScore[0] < PlayersScore[1])
            {
                GameManager.winState = GameManager.WinConditions.Player2Won;
            }
            else if(PlayersScore[0] == PlayersScore[1])
            {
                GameManager.winState = GameManager.WinConditions.Tie;
            }
        }

    }
}
