using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGussingGame
{
    /// <summary>
    /// This is the class of all strings
    /// </summary>
    public static class StrOutputs
    {
        /* Console outputs strings*/
        private static string title;
        private static string round1;
        private static string round2;
        private static string setting;
        private static string about;
        private static string rulesTitle;
        private static string welcomeStatement;
        private static string rules;
        private static string continueMessage;
        private static string askingForNames;
        private static string askingForNumber;
        private static string outputScores;
        private static string WinCondition;
        private static string TieCondition;
        private static string correctGusse;
        private static string tooHighOrLowGusse;
        private static string consoleCommands;
        private static string notValueInput;
        private static string SettingMessage;

        public static string[] menuOptions = new string[5];
        public static string[] settingsOptions = new string[5];
        public static string[] Commands = new string[3];
        private static string aboutStr;

        public enum Language
        {
            English,
            Spanish
        };
        public static Language language = Language.English;

        public static void GetMeunOptionsStr()
        {
            if (language == Language.English)
            {
                menuOptions[0] = "Play ";
                menuOptions[1] = "Rules ";
                menuOptions[2] = "Settings ";
                menuOptions[3] = "Exit ";
                menuOptions[4] = "About ";
            }
            else if (language == Language.Spanish)
            {
                menuOptions[0] = "Tocar ";
                menuOptions[1] = "Normas ";
                menuOptions[2] = "Ajustes ";
                menuOptions[3] = "Salida ";
                menuOptions[4] = "Acerca de ";
            }
        }
        public static void GetSettingOptionsStr()
        {
            if (language == Language.English)
            {
                settingsOptions[0] = "Music ";
                settingsOptions[1] = "SFX ";
                settingsOptions[2] = "-Language ";
                settingsOptions[3] = "English ";
                settingsOptions[4] = "Español ";
            }
            else if (language == Language.Spanish)
            {
                settingsOptions[0] = "Música ";
                settingsOptions[1] = "SFX ";
                settingsOptions[2] = "-Idioma ";
                settingsOptions[3] = "English ";
                settingsOptions[4] = "Español ";
            }
        }
        public static void GetCommandsStr()
        {
            if (language == Language.English)
            {
                Commands[0] = "exit";
                Commands[1] = "quit";
                Commands[2] = "retry";
            }
            else if (language == Language.Spanish)
            {
                Commands[0] = "salida";
                Commands[1] = "renunciar";
                Commands[2] = "rever";
            }
        }
        public static string GetTitleStr()
        {
            if (language == Language.English)
            {
                title = @"
   _____                     _                _____                      
  / ____|                   (_)              / ____|                     
 | |  __ _   _  ___  ___ ___ _ _ __   __ _  | |  __  __ _ _ __ ___   ___ 
 | | |_ | | | |/ _ \/ __/ __| | '_ \ / _` | | | |_ |/ _` | '_ ` _ \ / _ \
 | |__| | |_| |  __/\__ \__ \ | | | | (_| | | |__| | (_| | | | | | |  __/
  \_____|\__,_|\___||___/___/_|_| |_|\__, |  \_____|\__,_|_| |_| |_|\___|
                                      __/ |                              
                                     |___/                               
";
                return title;
            }
            else if(language == Language.Spanish)
            {
                title = @"
       _                              _                  _ _       _                                
      | |                            | |                | (_)     (_)                               
      | |_   _  ___  __ _  ___     __| | ___    __ _  __| |___   ___ _ __   __ _ _ __  ______ _ ___ 
  _   | | | | |/ _ \/ _` |/ _ \   / _` |/ _ \  / _` |/ _` | \ \ / / | '_ \ / _` | '_ \|_  / _` / __|
 | |__| | |_| |  __/ (_| | (_) | | (_| |  __/ | (_| | (_| | |\ V /| | | | | (_| | | | |/ / (_| \__ \
  \____/ \__,_|\___|\__, |\___/   \__,_|\___|  \__,_|\__,_|_| \_/ |_|_| |_|\__,_|_| |_/___\__,_|___/
                     __/ |                                                                          
                    |___/                                                                           
";
                return title;
            }
            return null;
        }
        public static string GetRound1Str()
        {
            if (language == Language.English)
            {
                round1 = @"
  _____                       _   __ 
 |  __ \                     | | /_ |
 | |__) |___  _   _ _ __   __| |  | |
 |  _  // _ \| | | | '_ \ / _` |  | |
 | | \ \ (_) | |_| | | | | (_| |  | |
 |_|  \_\___/ \__,_|_| |_|\__,_|  |_|
                                     
                                     
";
                return round1;
            }
            else if (language == Language.Spanish)
            {
                round1 = @"
  _                                 _         __ 
 | |                               | |       /_ |
 | |     __ _   _ __ ___  _ __   __| | __ _   | |
 | |    / _` | | '__/ _ \| '_ \ / _` |/ _` |  | |
 | |___| (_| | | | | (_) | | | | (_| | (_| |  | |
 |______\__,_| |_|  \___/|_| |_|\__,_|\__,_|  |_|
                                                 
                                                 
";
                return round1;
            }
            return null;
        }
        public static string GetRound2Str()
        {
            if (language == Language.English)
            {
                round2 = @"
  _____                       _   ___  
 |  __ \                     | | |__ \ 
 | |__) |___  _   _ _ __   __| |    ) |
 |  _  // _ \| | | | '_ \ / _` |   / / 
 | | \ \ (_) | |_| | | | | (_| |  / /_ 
 |_|  \_\___/ \__,_|_| |_|\__,_| |____|
                                       
                                       
";
                return round2;
            }
            else if (language == Language.Spanish)
            {
                round2 = @"
  _                                 _         ___  
 | |                               | |       |__ \ 
 | |     __ _   _ __ ___  _ __   __| | __ _     ) |
 | |    / _` | | '__/ _ \| '_ \ / _` |/ _` |   / / 
 | |___| (_| | | | | (_) | | | | (_| | (_| |  / /_ 
 |______\__,_| |_|  \___/|_| |_|\__,_|\__,_| |____|
                                                   
                                                   
";
                return round2;
            }
            return null;
        }
        public static string GetSettingStr()
        {
            if (language == Language.English)
            {
                setting = @"
   _____      _   _   _                 
  / ____|    | | | | (_)                
 | (___   ___| |_| |_ _ _ __   __ _ ___ 
  \___ \ / _ \ __| __| | '_ \ / _` / __|
  ____) |  __/ |_| |_| | | | | (_| \__ \
 |_____/ \___|\__|\__|_|_| |_|\__, |___/
                               __/ |    
                              |___/     
";
                return setting;
            }
            else if (language == Language.Spanish)
            {
                setting = @"
        _           _            
       (_)         | |           
   __ _ _ _   _ ___| |_ ___  ___ 
  / _` | | | | / __| __/ _ \/ __|
 | (_| | | |_| \__ \ ||  __/\__ \
  \__,_| |\__,_|___/\__\___||___/
      _/ |                       
     |__/                        
";
                return setting;
            }
            return null;
        }
        public static string GetAboutMeStr()
        {
            if (language == Language.English)
            {
                about = @"
           _                 _     __  __      
     /\   | |               | |   |  \/  |     
    /  \  | |__   ___  _   _| |_  | \  / | ___ 
   / /\ \ | '_ \ / _ \| | | | __| | |\/| |/ _ \
  / ____ \| |_) | (_) | |_| | |_  | |  | |  __/
 /_/    \_\_.__/ \___/ \__,_|\__| |_|  |_|\___|
                                               
                                               
";
                return about;
            }
            else if (language == Language.Spanish)
            {
                about = @"
   _____       _                          __
  / ____|     | |                        /_/
 | (___   ___ | |__  _ __ ___   _ __ ___  _ 
  \___ \ / _ \| '_ \| '__/ _ \ | '_ ` _ \| |
  ____) | (_) | |_) | | |  __/ | | | | | | |
 |_____/ \___/|_.__/|_|  \___| |_| |_| |_|_|
                                            
                                            
";
                return about;
            }
            return null;
        }
        public static string GetRulesTitleStr()
        {
            if (language == Language.English)
            {
                rulesTitle = @"
  _____       _           
 |  __ \     | |          
 | |__) |   _| | ___  ___ 
 |  _  / | | | |/ _ \/ __|
 | | \ \ |_| | |  __/\__ \
 |_|  \_\__,_|_|\___||___/
                          
                          
";
                return rulesTitle;
            }
            else if (language == Language.Spanish)
            {
                rulesTitle = @"
  _   _                                
 | \ | |                               
 |  \| | ___  _ __ _ __ ___   __ _ ___ 
 | . ` |/ _ \| '__| '_ ` _ \ / _` / __|
 | |\  | (_) | |  | | | | | | (_| \__ \
 |_| \_|\___/|_|  |_| |_| |_|\__,_|___/
                                       
                                       
";
                return rulesTitle;
            }
            return null;
        }
        public static string GetWelcomeStr()
        {
            if (language == Language.English)
            {
                welcomeStatement = "Welcome to Gusseting game. This is a fun action adventure, Console command prompt, RPG." +
                    "\nYes! Thing will become very colorful, because white on black text is boring." +
                    "\n\nUse the Up and Down arrow keys for navigation. To select Press Enter. " +
                    "\n---------------------------------------------------------------------------------------";
                return welcomeStatement;
            }
            else if(language == Language.Spanish)
            {
                welcomeStatement = "Bienvenido al juego de adivinanzas. Esta es una divertida aventura de acción, símbolo del sistema de consola, RPG." +
                    "\n¡Sí! La cosa se volverá muy colorida, porque el texto blanco sobre negro es aburrido." +
                    "\n\nUtilice las teclas de flecha hacia arriba y hacia abajo para navegar. Para seleccionar Presione Entrar." +
                    "\n---------------------------------------------------------------------------------------";
                return welcomeStatement;
            }
            return null;
        }
        public static string GetRulesStr()
        {
            if (language == Language.English)
            {
                rules =
                    "\nSummary: Player 1 will pick a number between 0 - 100. Player 2 has 5 attempts to guess the number that Player 1 picked, correctly." +
                    "\nOnce Player 2 has guess the correct number or exhausted all attempts. Player 2 will pick a number between 0 - 100," +
                    "\nand Player 1 will have 5 attempts to guess correctly. After Player 1 gusse correctly or exhausted all attempts the game ends and score is calculated." +
                    "\n------Rules------" +
                    "\n1. Players can't pick a number above 100 or below 0. If you try to pick below the computer will just pick zero." +
                    "\nIf you try to pick above 100 the computer will just pick 100. Please Don't try." +
                    "\n2. Players must pick a number / integer value. If you pick anything but that the computer will just give you a hard time." +
                    "\n3. When Computer ask for a name just input an alias (name) or a readable assortment of characters";
                return rules;
            }
            else if(language == Language.Spanish)
            {
                rules =
                    "\nResumen: El jugador 1 elegirá un número entre 0 - 100. El jugador 2 tiene 5 intentos para transmitir correctamente el número que eligió el jugador 1." +
                    "\nUna vez que el jugador 2 haya adivinado el número correcto o haya agotado todos los intentos. El jugador 2 elegirá un número entre 0 y 100," +
                    "\ny el jugador 1 tendrá 5 intentos para lanzarse correctamente." +
                    "\nDespués de que el jugador 1 se lanza correctamente o agota todos los intentos, el juego termina y se calcula la puntuación." +
                    "\n------Normas------" +
                    "\n1. Los jugadores no pueden elegir un número por encima de 100 o por debajo de 0." +
                    "\nSi intentas elegir por debajo, la computadora simplemente elegirá cero." +
                    "\n2. Los jugadores deben elegir un número / valor entero. Si eliges cualquier cosa que no sea eso, la computadora te hará pasar un mal rato." +
                    "\n3. Cuando la computadora solicite un nombre, ingrese un alias (nombre) o una variedad de caracteres legible.";
                return rules;
            }
            return null;
        }
        public static string GetAboutStr()
        {
            if (language == Language.English)
            {
                aboutStr = "Hello. I am the creator of this guessing game. well...I am the one who coded it." +
                    "\nThe one thing I can say it this is one Overengineered console guessing game!" +
                    "\nMade by: Malachias Harris" +
                    "\nAudio from: Ryan McCoy";
                return aboutStr;
            }
            else if(language == Language.Spanish)
            {
                aboutStr = "Hola. Soy el creador de este juego de adivinanzas. bueno ... yo soy quien lo codificó." +
                    "\n¡Lo único que puedo decir es que es un juego de adivinanzas de consola Over Engineered!" +
                    "\nHecho por: Malachias Harris" +
                    "\nAudio de: Ryan McCoy";
                return aboutStr;
            }
            return null;
        }
        public static string GetSettingMessageStr()
        {
            if (language == Language.English)
            {
                SettingMessage = "Use the arrow keys Up and Down to navigate and Enter to select." +
                    "\nGreen = On." +
                    "\nRed = Off";
                return SettingMessage;
            }
            else if (language == Language.Spanish)
            {
                SettingMessage = "Use las teclas de flecha hacia arriba y hacia abajo para navegar y Enter para seleccionar." +
                    "\nVerde = Encendido." +
                    "\nRojo = apagado";
                return SettingMessage;
            }
            return null;
        }
        public static string GetContinueMessage()
        {
            if (language == Language.English)
            {
                continueMessage = "Press Spacebar to Continue...";
                return continueMessage;
            }
            else if(language == Language.Spanish)
            {
                continueMessage = "Presiona la barra espaciadora para continuar...";
                return continueMessage;
            }
            return null;
        }
        public static string GetAskNameStr(bool IsPlayer1)
        {
            if (language == Language.English)
            {
                if (IsPlayer1)
                {
                    askingForNames = "Player One! Input your name.";
                }
                else
                {
                    askingForNames = "Player Two! Input your name.";
                }
                return askingForNames;
            }
            else if(language == Language.Spanish)
            {
                if (IsPlayer1)
                {
                    askingForNames = "¡Jugador uno! Ingrese su nombre.";
                }
                else
                {
                    askingForNames = "¡Jugador dos! Ingrese su nombre.";
                }
                return askingForNames;
            }
            return null;
        }
        public static string GetAskNumberStr()
        {
            if (language == Language.English)
            {
                askingForNumber = "Pick a number between 0 - 100";
                return askingForNumber;
            }
            else if (language == Language.Spanish)
            {
                askingForNumber = "Elija un número entre 0 - 100";
                return askingForNumber;
            }
            return null;
        }
        public static string GetCorrectGussesStr()
        {
            if (language == Language.English)
            {
                correctGusse = "You guess right!";
                return correctGusse;
            }
            else if (language == Language.Spanish)
            {
                correctGusse = "¡Acertaste!";
                return correctGusse;
            }
            return null;
        }
        public static string GetTooHighOrTooLowGussesStr(bool isTooHigh)
        {
            if (language == Language.English)
            {
                if (isTooHigh)
                {
                    tooHighOrLowGusse = "Your too high! Guess lower.";
                    return tooHighOrLowGusse;
                }
                else
                {
                    tooHighOrLowGusse = "Your too low! Guess higher";
                    return tooHighOrLowGusse;
                }
            }
            else if(language == Language.Spanish)
            {
                if (isTooHigh)
                {
                    tooHighOrLowGusse = "¡Estás demasiado alto! Adivina más bajo.";
                    return tooHighOrLowGusse;
                }
                else
                {
                    tooHighOrLowGusse = "¡Estás demasiado bajo! Adivina más alto.";
                    return tooHighOrLowGusse;
                }
            }
            return null;
        }
        public static string GetNotValuedInputStr(string name)
        {
            if (language == Language.English)
            {
                notValueInput = $"{name}, Please input only integers (numbers).";
                return notValueInput;
            }
            else if (language == Language.Spanish)
            {
                notValueInput = $"{name}, Ingrese solo enteros (números).";
                return notValueInput;
            }
            return null;
        }
        public static string GetConsoleCommandsStr()
        {
            if (language == Language.English)
            {
                consoleCommands = "\nTo Exit --> Type in the command prompt \"Exit\"" +
                    "\nTo Retry --> Type in the command prompt \"Retry\"";
                return consoleCommands;
            }
            else if (language == Language.Spanish)
            {
                consoleCommands = "\nabandonar --> Escriba en el símbolo del sistema \"Salida\"" +
                    "\nPara reintentar --> Escriba en el símbolo del sistema \"Rever\"";
                return consoleCommands;
            }
            return null;
        }
        public static string GetOutputScoresStr(int attempts)
        {
            if (language == Language.English)
            {
                outputScores = $"You got {attempts} attempts to guess the correct number.";
                return outputScores;
            }
            else if (language == Language.Spanish)
            {
                outputScores = $"Tu tienes {attempts} intenta adivinar el número correcto.";
                return outputScores;
            }
            return null;
        }
        public static string GetWinconditionStr(string playerName, int playerNumberOfGuesses)
        {
            if (language == Language.English)
            {
                WinCondition = $"{playerName} won!!\n" +
                               $"Your Score {playerNumberOfGuesses} Guesses Out of 5.";
                return WinCondition;
            }
            else if (language == Language.Spanish)
            {
                WinCondition = $"{playerName} Ganó\n" +
                    $"Tu puntuación {playerNumberOfGuesses} Adivina de 5.";
                return WinCondition;
            }
            return null;
        }

        public static string GetTieConditionStr(string playerOneName, string playerTwoName, int playerNumberOfGuesses)
        {
            if (language == Language.English)
            {
                TieCondition = $"{playerOneName} and {playerTwoName}. Has tied\n" +
                                         $"Score {playerNumberOfGuesses} Out of 5.";
                return TieCondition;
            }
            else if(language == Language.Spanish)
            {
                TieCondition = $"{playerOneName} y {playerTwoName}. Ha atado\n" +
                    $"Puntaje {playerNumberOfGuesses} Adivina de 5.";
                return TieCondition;
            }
            return null;
        }
    }
}
