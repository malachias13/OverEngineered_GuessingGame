using System;
using System.Threading;
using System.Media;

/*  Project Name: Interactive Gussing Game
    Contribution:
    Feature:
    Start & End dates
    References:
    Links:

 */

/*  First Name: Malachias  
 *  Last Name: Harris
 */
namespace InteractiveGussingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The Player oject (class). */
            Player player1 = new Player();
            Player player2 = new Player();
            Player tempPlayer = player1; 
            Player tempPlayer2 = player2;
            /* Menu Selector class */
            Menu menu = new Menu();
            /*Variables*/
            string  Input = string.Empty;
            int iterator = 0;
            GameManager.gameState = GameManager.GameState.Menu;
            GameManager.turnBase = GameManager.Rounds.Round1;
            GameManager.winState = GameManager.WinConditions.None;

            SFX.InstantiateSound();

           
            // Game Loop.
            do
            {
                Console.Clear();

                switch (GameManager.gameState)
                {
                    case GameManager.GameState.Menu:
                        menu.DrawMenuSelector();
                        menu.HandleSettingSlection();
                        menu.HandleMenuSelection();
                        if (GameManager.HasRetry)
                        {
                            // Reset all information
                            player1.Reset();
                            player2.Reset();

                            tempPlayer = player1;
                            tempPlayer2 = player2;
                            Input = string.Empty;
                            iterator = 0;
                            GameManager.HasCollectedNames = false;
                            GameManager.IsPlayerCorrect = false;
                            GameManager.HasEveryonePlayed = false;
                            GameManager.attempts = tempPlayer2.GetNumberOfGusses();
                            GameManager.HasRetry = false;
                        }
                        break;
                    case GameManager.GameState.Initialize:

                        // Make something that reads out the rules.

                        if (GameManager.turnBase == GameManager.Rounds.Round1)
                        {
                            // Reset all information
                            tempPlayer = player1;
                            tempPlayer2 = player2;
                            Input = string.Empty;
                            iterator = 0;
                            GameManager.IsPlayerCorrect = false;
                            GameManager.attempts = tempPlayer2.GetNumberOfGusses();

                            // Can add A big large text o saying Round 1! ---> Add Thread Here to Make sure the player can read this
                            ConsoleExtracts.ColorTextLine(StrOutputs.GetRound1Str(), ConsoleColor.DarkMagenta);
                            Thread.Sleep(1300);
                            GameManager.gameState = GameManager.GameState.CollectData;
                        }
                        else if (GameManager.turnBase == GameManager.Rounds.Round2)
                        {
                            tempPlayer = player2;
                            tempPlayer2 = player1;
                            Input = string.Empty;
                            iterator = 0;
                            GameManager.IsPlayerCorrect = false;
                            GameManager.attempts = tempPlayer2.GetNumberOfGusses();

                            // Can add A big large text o saying Round 2! ---> Add Thread Here to Make sure the player can read this
                            ConsoleExtracts.ColorTextLine(StrOutputs.GetRound2Str(), ConsoleColor.DarkMagenta);
                            Thread.Sleep(1300);
                            GameManager.gameState = GameManager.GameState.CollectData;
                        }

                        break;

                    case GameManager.GameState.CollectData:

                        if (Input == string.Empty)
                        {
                            GameManager.GetPlayerInput(ref Input, GameManager.GameState.CollectData,tempPlayer) ;
                        }
                        if (GameManager.HasCollectedNames)
                        {
                            // Make an if state me to seperater the players
                            GameManager.InputSelectedNumber(tempPlayer, Input);
                            Input = string.Empty;
                            if (GameManager.IsValtInput)
                                GameManager.gameState = GameManager.GameState.Input;
                            else if(!GameManager.IsValtInput && !GameManager.HasRetry && !GameManager.HasQuit)
                            {
                                if(Menu.GetIsSFXToggleOn())
                                    SFX.PlaySound(SFX.SoundEffects[2]);
                                ConsoleExtracts.ColorTextLine(StrOutputs.GetNotValuedInputStr(tempPlayer.GetName()),
                                    ConsoleColor.Red);
                                Thread.Sleep(700);
                            }
                        }

                        if(!GameManager.HasCollectedNames)
                        {
                            if (iterator == 0)
                            {
                                GameManager.InputName(tempPlayer, Input);
                                iterator++;
                                Input = string.Empty;
                            }
                            else if (iterator == 1) 
                            {
                                GameManager.InputName(tempPlayer2, Input);
                                Input = string.Empty;

                                GameManager.HasCollectedNames = true;
                            }
                            
                        }
                        break;

                    case GameManager.GameState.Input:
                        if (!GameManager.IsPlayerCorrect)
                        {
                            if (Input == string.Empty)
                            {
                                GameManager.GetPlayerInput(ref Input, GameManager.GameState.Input, tempPlayer2);
                            }

                            if (tempPlayer2.GetNumberOfGusses() > 0)
                            {
                                GameManager.InputGusse(tempPlayer2, Input);
                                ScoreManager.HandleAttemps(tempPlayer2);
                                GameManager.attempts = tempPlayer2.GetNumberOfGusses();
                                if (!GameManager.IsValtInput && !GameManager.HasRetry && !GameManager.HasQuit)
                                {
                                    if (Menu.GetIsSFXToggleOn())
                                        SFX.PlaySound(SFX.SoundEffects[2]);
                                    ConsoleExtracts.ColorTextLine(StrOutputs.GetNotValuedInputStr(tempPlayer2.GetName()),
                                        ConsoleColor.Red);
                                    Thread.Sleep(700); // ---> Give time for the Player to see the text. That's all.
                                }
                            }
                            else if(tempPlayer2.GetNumberOfGusses() == 0)
                            {
                                if(GameManager.turnBase == GameManager.Rounds.Round2)
                                {
                                    GameManager.HasEveryonePlayed = true;
                                }
                                GameManager.gameState = GameManager.GameState.Initialize;
                                GameManager.turnBase = GameManager.Rounds.Round2;
                                
                            }
                        }
                        else if(GameManager.IsPlayerCorrect)
                        {
                            // Can add some try calculating text Here!!!!! or If not remove thread
                            Thread.Sleep(1000);
                            if (GameManager.turnBase == GameManager.Rounds.Round2)
                            {
                                GameManager.HasEveryonePlayed = true;
                            }
                            GameManager.gameState = GameManager.GameState.Initialize;
                            GameManager.turnBase = GameManager.Rounds.Round2;
                        }

                        if(GameManager.HasEveryonePlayed)
                        {
                            GameManager.gameState = GameManager.GameState.GameOver;
                        }

                        Input = string.Empty;
                        break;
                    case GameManager.GameState.GameOver:
                        ScoreManager.HandleWinCondition();
                        switch (GameManager.winState)
                        {  
                            case GameManager.WinConditions.None:
                                //Console.Error.Write("Something went wrong!");
                                break;
                            case GameManager.WinConditions.Player1Won:
                                if (Menu.GetIsSFXToggleOn())
                                    SFX.PlaySound(SFX.SoundEffects[3]);
                                ConsoleExtracts.ColorTextLine(StrOutputs.GetWinconditionStr(player1.GetName(), player1.GetNumberOfGusses())
                                    , ConsoleColor.Green);

                                break;
                            case GameManager.WinConditions.Player2Won:
                                if (Menu.GetIsSFXToggleOn())
                                    SFX.PlaySound(SFX.SoundEffects[3]);
                                ConsoleExtracts.ColorTextLine(StrOutputs.GetWinconditionStr(player2.GetName(), player2.GetNumberOfGusses())
                                    , ConsoleColor.Green);


                                break;
                            case GameManager.WinConditions.Tie:
                                if (Menu.GetIsSFXToggleOn())
                                    SFX.PlaySound(SFX.SoundEffects[3]);
                                ConsoleExtracts.ColorTextLine(StrOutputs.GetTieConditionStr(player1.GetName(),player2.GetName(),player1.GetNumberOfGusses())
                                    , ConsoleColor.Gray);
                                break;
                        }

                        ConsoleExtracts.ColorTextLine(StrOutputs.GetConsoleCommandsStr(), ConsoleColor.DarkCyan);
                        Input = string.Empty;
                        if (Input == string.Empty)
                        {
                            GameManager.GetPlayerInput(ref Input, GameManager.GameState.GameOver, tempPlayer);
                        }
                        break;
                }

            } 
            while (GameManager.HasQuit == false);

           // Console.ReadKey();
        }
    }
}
