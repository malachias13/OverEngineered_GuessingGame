using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGussingGame
{
    public class Menu
    {
        /* Menu */
        enum MenuState
        {
            Play,
            Rules,
            Setting,
            Exit,
            About
        };
        enum SettingsState
        {
            Music,
            SFX,
            language,
            English,
            Español
        };
        MenuState menu = MenuState.Play;
        SettingsState settings = SettingsState.Music;

        int menuValue = 0;
        int settingsValue = 0;
        ConsoleKeyInfo KeyPressed;

        /* Checks */
        private static bool HasSlected = false;
        private static bool isSettingsPage = false;
        private static bool isMusicToggleOn = true;
        private static bool isSFXToggleOn = true;

        /* ----- Menu Colors ---- */

        /* Setting ------> *** Color ***  */
        ConsoleColor settingTitleColorBackground = ConsoleColor.Blue;
        ConsoleColor settingTitleColor = ConsoleColor.White;

        /* Title ----> *** Color *** */
        ConsoleColor titleColorText = ConsoleColor.DarkRed;

        /* Welcome Text color ----> *** Color *** */
        ConsoleColor WelcomeTextColor = ConsoleColor.Cyan;

        /* About Me ----> *** Color *** */
        ConsoleColor aboutMeColorBackground = ConsoleColor.Blue;
        ConsoleColor aboutMeColorText = ConsoleColor.White;

        /* Rules Title ----> *** Color *** */
        ConsoleColor rulesTitleColorBackground = ConsoleColor.Blue;
        ConsoleColor rulesColorText = ConsoleColor.White;

        public void DrawMenuSelector()
        {
            // Geting the values of the menuOptions array.
            StrOutputs.GetMeunOptionsStr();
            StrOutputs.GetCommandsStr();
            switch (menu)
            {
                case MenuState.Play:
                    Console.Clear();
                    ConsoleExtracts.ColorTextLine(StrOutputs.GetTitleStr(), titleColorText);
                    ConsoleExtracts.ColorTextLine(StrOutputs.GetWelcomeStr(), WelcomeTextColor);
                    ConsoleExtracts.HighlightTextLine($">> {StrOutputs.menuOptions[0]}<<",ConsoleColor.Gray,ConsoleColor.Black);
                    Console.WriteLine($"{StrOutputs.menuOptions[1]}");
                    Console.WriteLine($"{StrOutputs.menuOptions[2]}");
                    Console.WriteLine($"{StrOutputs.menuOptions[3]}");
                    Console.WriteLine($"{StrOutputs.menuOptions[4]}");
                    break;
                case MenuState.Rules:
                    Console.Clear();
                    if (!HasSlected)
                    {
                        ConsoleExtracts.ColorTextLine(StrOutputs.GetTitleStr(), titleColorText);
                        ConsoleExtracts.ColorTextLine(StrOutputs.GetWelcomeStr(), WelcomeTextColor);
                        Console.WriteLine($"{StrOutputs.menuOptions[0]}");
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.menuOptions[1]}<<", ConsoleColor.Gray, ConsoleColor.Black);
                        Console.WriteLine($"{StrOutputs.menuOptions[2]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[3]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[4]}");
                    }
                    else
                    {
                        DrawRulesPage();
                    }
                    break;
                case MenuState.Setting:
                    if (!isSettingsPage)
                    {
                        ConsoleExtracts.ColorTextLine(StrOutputs.GetTitleStr(), titleColorText);
                        ConsoleExtracts.ColorTextLine(StrOutputs.GetWelcomeStr(), WelcomeTextColor);
                        Console.WriteLine($"{StrOutputs.menuOptions[0]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[1]}");
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.menuOptions[2]}<<", ConsoleColor.Gray, ConsoleColor.Black);
                        Console.WriteLine($"{StrOutputs.menuOptions[3]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[4]}");
                    }
                    else
                    {
                        DarwSettingsMenu();
                    }
                    break;
                case MenuState.Exit:
                    Console.Clear();
                    ConsoleExtracts.ColorTextLine(StrOutputs.GetTitleStr(), titleColorText);
                    ConsoleExtracts.ColorTextLine(StrOutputs.GetWelcomeStr(), WelcomeTextColor);
                    Console.WriteLine($"{StrOutputs.menuOptions[0]}");
                    Console.WriteLine($"{StrOutputs.menuOptions[1]}");
                    Console.WriteLine($"{StrOutputs.menuOptions[2]}");
                    ConsoleExtracts.HighlightTextLine($">> {StrOutputs.menuOptions[3]}<<", ConsoleColor.Gray, ConsoleColor.Black);
                    Console.WriteLine($"{StrOutputs.menuOptions[4]}");
                    break;
                case MenuState.About:
                    if(!HasSlected)
                    {
                        ConsoleExtracts.ColorTextLine(StrOutputs.GetTitleStr(), titleColorText);
                        ConsoleExtracts.ColorTextLine(StrOutputs.GetWelcomeStr(), WelcomeTextColor);
                        Console.WriteLine($"{StrOutputs.menuOptions[0]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[1]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[2]}");
                        Console.WriteLine($"{StrOutputs.menuOptions[3]}");
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.menuOptions[4]}<<", ConsoleColor.Gray, ConsoleColor.Black);
                    }
                    else
                    {
                        DrawAboutPage();        
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
        private void DarwSettingsMenu()
        {
            StrOutputs.GetSettingOptionsStr();
            switch (settings)
            {
                case SettingsState.Music:
                    Console.Clear();
                    ConsoleExtracts.HighlightTextLine(StrOutputs.GetSettingStr(), settingTitleColorBackground, settingTitleColor);
                    if (isMusicToggleOn)
                    {
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.settingsOptions[0]}<<", ConsoleColor.Green, ConsoleColor.Black);
                    }
                    else
                    {
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.settingsOptions[0]}<<", ConsoleColor.Red, ConsoleColor.Black);
                    }
                    if(isSFXToggleOn)
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Green, ConsoleColor.Black);
                    }
                    else
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Red, ConsoleColor.Black);
                    }

                    ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[2]}", ConsoleColor.Green, ConsoleColor.Black);

                    ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
                    break;
                case SettingsState.SFX:
                    Console.Clear();
                    ConsoleExtracts.HighlightTextLine(StrOutputs.GetSettingStr(), settingTitleColorBackground, settingTitleColor);
                    if (isMusicToggleOn)
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Green, ConsoleColor.Black);
                    }
                    else
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Red, ConsoleColor.Black);
                    }
                    if(isSFXToggleOn)
                    {
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.settingsOptions[1]}<<", ConsoleColor.Green, ConsoleColor.Black);
                    }
                    else
                    {
                        ConsoleExtracts.HighlightTextLine($">> {StrOutputs.settingsOptions[1]}<<", ConsoleColor.Red, ConsoleColor.Black);
                    }
                    
                    ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[2]}", ConsoleColor.Green, ConsoleColor.Black);

                    ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
                    break;
                case SettingsState.language:
                    Console.Clear();
                    ConsoleExtracts.HighlightTextLine(StrOutputs.GetSettingStr(), settingTitleColorBackground, settingTitleColor);
                    if (isMusicToggleOn)
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Green, ConsoleColor.Black);
                    }
                    else
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Red, ConsoleColor.Black);
                    }
                    if (isSFXToggleOn)
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Green, ConsoleColor.Black);
                    }
                    else
                    {
                        ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Red, ConsoleColor.Black);
                    }

                    if(!HasSlected)
                    ConsoleExtracts.HighlightTextLine($">> {StrOutputs.settingsOptions[2]}<<", ConsoleColor.Green, ConsoleColor.Black);
                    else
                        ConsoleExtracts.HighlightTextLine($"    >> {StrOutputs.settingsOptions[2]}<<", ConsoleColor.Green, ConsoleColor.Black);

                    ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
                    break;
                case SettingsState.English:
                    Console.Clear();
                    ConsoleExtracts.HighlightTextLine(StrOutputs.GetSettingStr(), settingTitleColorBackground, settingTitleColor);
                    if (HasSlected)
                    {
                        if(isMusicToggleOn)
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Green, ConsoleColor.Black);
                        }
                        else
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Red, ConsoleColor.Black);
                        }
                        if(isSFXToggleOn)
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Green, ConsoleColor.Black);
                        }
                        else
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Red, ConsoleColor.Black);
                        }
                       
                       
                        ConsoleExtracts.HighlightTextLine($"    {StrOutputs.settingsOptions[2]}", ConsoleColor.Green, ConsoleColor.Black);
                        if (StrOutputs.language == StrOutputs.Language.English)
                        {
                            ConsoleExtracts.HighlightTextLine($"        >> {StrOutputs.settingsOptions[3]}<<", ConsoleColor.Green, ConsoleColor.Black);
                            ConsoleExtracts.HighlightTextLine($"      {StrOutputs.settingsOptions[4]}", ConsoleColor.Red, ConsoleColor.Black);
                        }
                        else
                        {
                            ConsoleExtracts.HighlightTextLine($"        >> {StrOutputs.settingsOptions[3]}<<", ConsoleColor.Red, ConsoleColor.Black);
                            ConsoleExtracts.HighlightTextLine($"      {StrOutputs.settingsOptions[4]}", ConsoleColor.Green, ConsoleColor.Black);
                        }
                    }
                    ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
                    break;
                case SettingsState.Español:
                    Console.Clear();
                    ConsoleExtracts.HighlightTextLine(StrOutputs.GetSettingStr(), settingTitleColorBackground, settingTitleColor);
                    if (HasSlected)
                    {
                        if(isMusicToggleOn)
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Green, ConsoleColor.Black);
                        }
                        else
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[0]}", ConsoleColor.Red, ConsoleColor.Black);
                        }
                        if(isSFXToggleOn)
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Green, ConsoleColor.Black);
                        }
                        else
                        {
                            ConsoleExtracts.HighlightTextLine($"{StrOutputs.settingsOptions[1]}", ConsoleColor.Red, ConsoleColor.Black);
                        }
                        
                       
                        ConsoleExtracts.HighlightTextLine($"    {StrOutputs.settingsOptions[2]}", ConsoleColor.Green, ConsoleColor.Black);
                        if (StrOutputs.language == StrOutputs.Language.Spanish)
                        {
                            ConsoleExtracts.HighlightTextLine($"      {StrOutputs.settingsOptions[3]}", ConsoleColor.Red, ConsoleColor.Black);
                            ConsoleExtracts.HighlightTextLine($"        >> {StrOutputs.settingsOptions[4]}<<", ConsoleColor.Green, ConsoleColor.Black);
                        }
                        else
                        {
                            ConsoleExtracts.HighlightTextLine($"      {StrOutputs.settingsOptions[3]}", ConsoleColor.Green, ConsoleColor.Black);
                            ConsoleExtracts.HighlightTextLine($"        >> {StrOutputs.settingsOptions[4]}<<", ConsoleColor.Red, ConsoleColor.Black);
                        }
                    }
                    ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
                    break;
            }

        }
        private void DrawAboutPage()
        {
            Console.Clear();
            ConsoleExtracts.HighlightTextLine(StrOutputs.GetAboutMeStr(), aboutMeColorBackground, aboutMeColorText);
            ConsoleExtracts.ColorTextLine(StrOutputs.GetAboutStr(), ConsoleColor.DarkYellow);
            ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
            
        }
        private void DrawRulesPage()
        {
            ConsoleExtracts.HighlightTextLine(StrOutputs.GetRulesTitleStr(), rulesTitleColorBackground, rulesColorText);
            ConsoleExtracts.ColorTextLine(StrOutputs.GetRulesStr(), ConsoleColor.Cyan);
            ConsoleExtracts.ColorTextLine(StrOutputs.GetConsoleCommandsStr(), ConsoleColor.DarkCyan);
            ConsoleExtracts.ColorTextLine($"\n{StrOutputs.GetContinueMessage()}", ConsoleColor.Gray);
        }

        public void HandleMenuSelection()
        {
            if (isSettingsPage) { return; }
             KeyPressed = Console.ReadKey();
            if (!HasSlected)
            {
                if (KeyPressed.Key == ConsoleKey.DownArrow)
                {
                    if(isSFXToggleOn)
                        SFX.PlaySound(SFX.SoundEffects[1]);
                    menuValue = (menuValue + 1) % StrOutputs.menuOptions.Length;
                    menu = (MenuState)menuValue;
                    
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (isSFXToggleOn)
                        SFX.PlaySound(SFX.SoundEffects[1]);
                    menuValue = menuValue <= 0 ? menuValue = StrOutputs.menuOptions.Length - 1 : Math.Abs((menuValue - 1) % StrOutputs.menuOptions.Length);

                    menu = (MenuState)menuValue;
                    
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menu)
                    {
                        case MenuState.Play:
                            GameManager.gameState = GameManager.GameState.Initialize;
                            break;
                        case MenuState.Rules:
                            HasSlected = true;
                            break;
                        case MenuState.Setting:
                            settingsValue = 0;
                            settings = (SettingsState)settingsValue;
                            HasSlected = true;
                            isSettingsPage = true;
                            break;
                        case MenuState.Exit:
                            Environment.Exit(0);
                            break;
                        case MenuState.About:
                            HasSlected = true;
                            break;
                    }
                }
            }
            else if(HasSlected)
            {
                if(KeyPressed.Key == ConsoleKey.Spacebar)
                {
                    HasSlected = false;
                    isSettingsPage = false;
                }
            }
        }
        public void HandleSettingSlection()
        {
             if(!isSettingsPage) { return; }

            if (settings != SettingsState.English && settings != SettingsState.Español)
                HasSlected = false;
            else
                HasSlected = true;

            KeyPressed = Console.ReadKey();
            { 
                if (KeyPressed.Key == ConsoleKey.DownArrow)
                {
                    if(isSFXToggleOn)
                        SFX.PlaySound(SFX.SoundEffects[1]);
                    settingsValue = !HasSlected ? (settingsValue + 1) % (StrOutputs.settingsOptions.Length - 2) : ((settingsValue + 1) % (StrOutputs.settingsOptions.Length));
                    settings = (SettingsState)settingsValue;

                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (isSFXToggleOn)
                        SFX.PlaySound(SFX.SoundEffects[1]);
                    if (!HasSlected)
                    settingsValue = settingsValue <= 0 ? settingsValue = (StrOutputs.settingsOptions.Length - 1) - 2 : Math.Abs((settingsValue - 1) % StrOutputs.settingsOptions.Length);
                    else
                        settingsValue = settingsValue <= 3 ? settingsValue = StrOutputs.settingsOptions.Length - 1 : Math.Abs((settingsValue - 1) % StrOutputs.settingsOptions.Length);
                    settings = (SettingsState)settingsValue;

                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    switch (settings)
                    {
                        case SettingsState.Music:
                            isMusicToggleOn = isMusicToggleOn == true ? isMusicToggleOn = false : isMusicToggleOn = true;
                            break;
                        case SettingsState.SFX:
                            isSFXToggleOn = isSFXToggleOn == true ? isSFXToggleOn = false : isSFXToggleOn = true;
                            break;
                        case SettingsState.language:
                            HasSlected = true;
                            
                            settings = (SettingsState)(settingsValue = 3);

                            break;
                        case SettingsState.English:
                            StrOutputs.language = StrOutputs.Language.English;
                            break;
                        case SettingsState.Español:
                            StrOutputs.language = StrOutputs.Language.Spanish;
                            break;
                    }
                }
            }
            if (KeyPressed.Key == ConsoleKey.Spacebar)
            {
                HasSlected = false;
                isSettingsPage = false;
                Console.Clear();
                DrawMenuSelector();
            }

        }
        /* Getters Functions*/
        public  static bool GetIsSFXToggleOn()
        {
             return isSFXToggleOn; 
        }
        public static bool GetIsMusicToggleOn()
        {
            return isMusicToggleOn;
        }
    }
}
