using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGussingGame
{
    public static class GameManager
    {
       public enum GameState
        {
            Menu,
            Initialize,
            CollectData,
            Input,
            GameOver

        };

        public enum Rounds
        {
            Round1,
            Round2
        };
        public enum WinConditions
        {
            None,
            Player1Won,
            Player2Won,
            Tie
        };
        /* States */
        public static GameState gameState;
        public static Rounds turnBase;
        public static WinConditions winState;
        /* Checks */
        public static bool HasCollectedNames = false;
        public static bool IsValtInput = false;
        public static bool IsPlayerCorrect = false;
        public static bool HasEveryonePlayed = false;
        public static bool IsPlayerOne = true;
        public static int attempts = 5;
        /* Loops Check */
        public static bool HasQuit = false;
        public static bool HasRetry = false;
        /* Stored cashe */
        public static int numberCashe;

        // Meathods just storing values. No calcuations.
        /// <summary>
        /// Sets the Player name from the Gamemanager class.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="name"></param>
        public static void InputName(Player player, string name)
        {
            player.SetName(name);
        }
        /// <summary>
        /// Set the Player pick number and checks to see if the number valued.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="number"></param>
        public static void InputSelectedNumber(Player player, string number)
        {
            IsValtInput = player.SelectNumber(number);
            numberCashe = player.GetNumberSelected();
        }
        /// <summary>
        /// Sets the Player number that they gusse. It check to see if It is a valit input. which is a number.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="numGusse"></param>
        public static void InputGusse(Player player, string numGusse)
        {
           IsValtInput = player.Guessing(numGusse);
        }
        /// <summary>
        ///  Get the player Input and Do things depending on the game state.
        /// </summary>
        /// <param name="playerInputString"></param>
        /// <param name="state"></param>
        /// <param name="player"></param>
        public static void GetPlayerInput(ref string playerInputString, GameState state,Player player)
        {
            switch (state)
            {
                case GameState.Initialize:
                    playerInputString = Console.ReadLine();
                    CommandInputs(playerInputString);
                    break;
                case GameState.CollectData:
                    if (!HasCollectedNames)
                    {
                        if (IsPlayerOne)
                        {
                            ConsoleExtracts.ColorTextLine(StrOutputs.GetAskNameStr(IsPlayerOne), ConsoleColor.Yellow);
                            IsPlayerOne = false;
                        }
                        else
                            ConsoleExtracts.ColorTextLine(StrOutputs.GetAskNameStr(IsPlayerOne), ConsoleColor.Yellow);
                        playerInputString = Console.ReadLine();
                        CommandInputs(playerInputString);
                    }
                    else
                    {
                        ConsoleExtracts.ColorTextLine($"{player.GetName()} {StrOutputs.GetAskNumberStr()}", ConsoleColor.Yellow);
                        playerInputString = Console.ReadLine();
                        CommandInputs(playerInputString);
                    }
                    
                    break;
                case GameState.Input:
                    ConsoleExtracts.ColorTextLine($"{player.GetName()}. {StrOutputs.GetOutputScoresStr(attempts)}", ConsoleColor.DarkYellow);
                    playerInputString = Console.ReadLine();
                      break;
                  case GameState.GameOver:
                      playerInputString = Console.ReadLine();
                    CommandInputs(playerInputString);
                    break;

            }
        }
        /// <summary>
        /// Rests Values to make Retry works.
        /// </summary>
        private static void Retry()
        {
            IsPlayerOne = true;
            HasRetry = true;
            turnBase = GameManager.Rounds.Round1;
            gameState = GameManager.GameState.Menu;
        }
        private static void CommandInputs(string input)
        {
            if (input.ToLower() == StrOutputs.Commands[0] || input.ToLower() == StrOutputs.Commands[1])
            {
                HasQuit = true;
            }
            else if (input.ToLower() == StrOutputs.Commands[2])
            {
                Retry();
            }
        }

    }
}
