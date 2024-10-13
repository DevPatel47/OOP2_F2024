/*============================================================
 * Title    :   Assignment - 2 Battleship
 * Name     :   Dev Mayurkumar Patel
 * Date     :   11 October 2024
 * Purpose  :   General Tools file
 *===========================================================*/

using System;
using System.Drawing;

namespace Assignment02
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

        /// <summary>
        /// Method to validate string (player names)
        /// </summary>
        /// <param name="stringToCheck"></param>
        /// <returns></returns>
        public static bool isStringCorrect(string stringToCheck)
        {
            if (stringToCheck.Trim().Length > 1 & stringToCheck.Trim().Length < 11) return true;
            else return false;
        }
        #endregion
    }


}
