/*============================================================
 * Title    :   Assignment - 1 Tic-Tac-Toe
 * Name     :   Dev Mayurkumar Patel
 * Date     :   27 September 2024
 * Purpose  :   Contain settings for Tic-Tac-Toe Game
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{   
    /// <summary>
    /// Method containing default settings
    /// </summary>
    public static class Settings
    {
        // Default Player Names
        public const string DEF_PLAYER_1_NAME = "Player-1";
        public const string DEF_PLAYER_2_NAME = "Player-2";
        
        // Default Layout for game board
        public const int DEF_SQUARESIZE = 150;
        public const int DEF_LEFTMARGIN = 470;
        public const int DEF_TOPMARGIN = 270;
        public const int DEF_NUMSQUARES = 3;

        // Array containing properties of each box of game board 
        public static Button[,] buttons = new Button[3, 3];

        // Global Variables
        public static string nameOfPlayer_X;
        public static string nameOfPlayer_O;
        public static int scoreOfPlayer_X = 0;
        public static int scoreOfPlayer_O = 0;
        public static bool isPlayer_X;
    }
}
