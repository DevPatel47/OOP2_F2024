/* **************************************
 * COSC2100 - Section 4 - Week 3
 * Dev Mayurkumar Patel
 * Sept 19, 2024
 * File containing general settings to run the application
 * ***********************************  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise01
{
    public static class Settings
    {
        #region Guess The Number game constants
        // Min and Max Constants
        public const int GTN_DEF_MINIMUMNUMBER = 1;
        public const int GTN_DEF_MAXIMUMNUMBER_EASY = 10;
        public const int GTN_DEF_MAXIMUMNUMBER_MEDIUM = 100;
        public const int GTN_DEF_MAXIMUMNUMBER_HARD = 1000;
        #endregion

        #region Ice Cream application constants
        // Constant Prices
        public const int IC_DEF_CHOCOFUDGEPRICE = 3;
        public const int IC_DEF_AMERICANNUTSPRICE = 2;
        public const int IC_DEF_CHOCOCRACKLEFLINGOPRICE = 4;
        public const int IC_DEF_COOKIESANDWICHPRICE = 2;
        public const int IC_DEF_CHOCOLATEOVERLOADPRICE = 5;

        // Cash in drawer
        public const int IC_DEF_INITIALCASH = 100;

        //global variable
        public static int cashInDrawer = 100;
        public static int overallSaleAmount = 0;

        #endregion




    }
}
