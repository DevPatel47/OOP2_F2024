/* **************************************
 * COSC2100 Section 4 F2024
 * Dev Mayurkumar Patel
 * Sept 19, 2024
 * General Tools File
 * ***********************************  */

using System;
using System.Drawing;

namespace Assignment01
{
    /// <summary>
    /// Class containing all Tools
    /// </summary>
    public static class Tools
    {


        static Random random = new Random();

        /// <summary>
        /// Generates random number
        /// </summary>
        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }

        /// <summary>
        /// Generates random color
        /// </summary>
        public static Color RandomColor()
        {
            return Color.FromArgb(255, RandomInt(0, 255), RandomInt(0, 255), RandomInt(0, 255));
        }


        /// <summary>
        /// Method to calculate changes 
        /// </summary>
        /// <param name="amountReceived"></param>
        /// <param name="totalAmountDue"></param>
        /// <returns></returns>
        public static int CalculateChange(int amountReceived, int totalAmountDue)
        {
            return amountReceived - totalAmountDue;
        }

        #region Tic-Tac-Toe

        public static string RandomPlayer(string player1, string player2)
        {
            int randomInt = RandomInt(0, 1);

            if (randomInt == 0) return player1;
            else return player2;
            
        }

        public static bool isStringCorrect(string stringToCheck)
        {
            if (stringToCheck.Trim().Length > 1 & stringToCheck.Trim().Length < 11) return true;
            else return false;
        }
        #endregion
    }


}
