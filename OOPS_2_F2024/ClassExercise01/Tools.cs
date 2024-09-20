/* **************************************
 * COSC2100 Section 4 F2024
 * Dev Mayurkumar Patel
 * Sept 19, 2024
 * General Tools File
 * ***********************************  */

using System;
using System.Drawing;

namespace ClassExercise01
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
    }


}
