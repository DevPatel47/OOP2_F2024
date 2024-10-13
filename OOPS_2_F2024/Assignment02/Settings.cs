/*============================================================
 * Title    :   Assignment - 2 Battleship
 * Name     :   Dev Mayurkumar Patel
 * Date     :   11 October 2024
 * Purpose  :   Contain settings for Battle Ship Game
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02
{   
    /// <summary>
    /// Class containing default settings
    /// </summary>
    public static class Settings
    {
               
        // Default Layout for game board
        public const int DEF_SQUARESIZE = 30;
        public const int DEF_SPACE = 10;
        public const int DEF_LEFTMARGIN = 84;
        public const int DEF_TOPMARGIN = 132;
        public const int DEF_NUMSQUARES = 10;

        // Array containing properties of each box of game board 
        public static Button[,] buttons = new Button[10, 10];

        // Global variables to track player's progress
        public static int turnCount = 0;
        public static int carrierValue= 0;
        public static int battleshipValue = 0;
        public static int submarineValue= 0;
        public static int cruiserValue = 0;
        public static int destroyerValue = 0;
    }
}
