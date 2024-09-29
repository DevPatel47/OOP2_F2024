using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public static class Settings
    {
        public const string DEF_PLAYER_1_NAME = "Player-1";
        public const string DEF_PLAYER_2_NAME = "Player-2";
        
        public const int DEF_SQUARESIZE = 150;
        public const int DEF_LEFTMARGIN = 470;
        public const int DEF_TOPMARGIN = 270;
        public const int DEF_NUMSQUARES = 3;

        public static Label[,] labels = new Label[3, 3];
        public static string nameOfPlayer_X;
        public static string nameOfPlayer_O;
        public static int scoreOfPlayer_X = 0;
        public static int scoreOfPlayer_O = 0;
        public static bool isPlayer_X;
    }
}
