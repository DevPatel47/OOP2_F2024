/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Class File containing Constsnts
 *===========================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment03.Classes
{
    public class Constants
    {
        
        #region Alignment Enums
        public enum Alignment
        {
            LawfulGood = 0,
            NeutralGood = 1,
            ChaoticGood = 2,
            LawfulNeutral = 3,
            Neutral = 4,
            ChaoticNeutral = 5,
            LawfulEvil = 6,
            NeutralEvil = 7,
            ChaoticEvil = 8
        }

        
        #endregion

        #region Character Default Properties

        
        public static Class DEFAULT_CLASS = Class.FindClassByName("Barbarian");
        public const int DEFAULT_LEVEL = 1;
        public static Race DEFAULT_RACE = Race.FindRaceByName("Human");
        public const Alignment DEFAULT_ALIGNMENT = Alignment.Neutral;
        public const string DEFAULT_GENDER = "Male";
        public const int DEFAULT_EXPERIENCE_POINTS = 0;
        public const int DEFAULT_STRENGTH = 8;
        public const int DEFAULT_DEXTERITY = 8;
        public const int DEFAULT_CONSTITUTION = 8;
        public const int DEFAULT_INTELLIGENCE = 8;
        public const int DEFAULT_WISDOM = 8;   
        public const int DEFAULT_CHARISMA = 8;
        public const int DEFAULT_ARMOR = 0;
        public static int DEFAULT_INITIATIVE = 0;
        public const int DEFAULT_SPEED = 0;
        public const int DEFAULT_HIT_POINTS = 0;
        public const int DEFAULT_ATTRIBUTE_POINTS = 27;
        

        #endregion
    }
}
