using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGussingGame
{
    public class Player
    {
        private string m_name;
        private int numberOfGuesses = 5;
        private int numberSelected;
        private int numberCashe; // Number Cashe Is the player Guesses. ---> This change every time a player Guesse the number.

        /* Rest the nuber of Guesses */
        public void Reset()
        {
            numberOfGuesses = 5;
            numberSelected = 0;
            m_name = string.Empty;
        }

        /* Helper function {set} */
        public void SetName(string name)
        {
            m_name = name;
        }   
        public bool SelectNumber(string number)
        {
            try
            {
                numberSelected = Convert.ToInt32(number);
                numberSelected = numberSelected > 100 ? 100 : numberSelected;
                numberSelected = numberSelected < 0 ? 0 : numberSelected;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Guessing(string number)
        {
            try
            {
                numberCashe = Convert.ToInt32(number);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int deductNumberOfGusses(int amountToDeduct)
        {
            numberOfGuesses -= amountToDeduct;
            return numberOfGuesses;
        }

        /* Helper Fuctions {Get} */
        public int GetNumberSelected()
        {
            return numberSelected;
        }
        public string GetName()
        {
            return m_name;
        }
        public int GetNumberCashe()
        {
            return numberCashe;
        }
        public int GetNumberOfGusses()
        {
            return numberOfGuesses;
        }
    }
}
