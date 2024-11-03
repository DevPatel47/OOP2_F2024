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
    internal class Constants
    {
        
        #region Alignment Enums
        public enum Alignment
        {
            LawfulGood,
            NeutralGood,
            ChaoticGood,
            LawfulNeutral,
            Neutral,
            ChaoticNeutral,
            LawfulEvil,
            NeutralEvil,
            ChaoticEvil,
            None
        }
        #endregion

        #region Character Default Properties

        public const string DEFAULT_NAME = "Character Name";
        public const Class DEFAULT_CLASS = null;
        public const int DEFAULT_LEVEL = 0;
        public const Race DEFAULT_RACE = null;
        public const Alignment DEFAULT_ALIGNMENT = Alignment.None;
        public const string DEFAULT_GENDER = "Male";
        public const int DEFAULT_EXPERIENCE_POINTS = 0;
        public const int DEFAULT_STRENGTH = 0;
        public const int DEFAULT_DEXTERITY = 0;
        public const int DEFAULT_CONSTITUTION = 0;
        public const int DEFAULT_INTELLIGENCE = 0;
        public const int DEFAULT_WISDOM = 0;   
        public const int DEFAULT_CHARISMA = 0;
        public const int DEFAULT_ARMOR = 0;
        public const int DEFAULT_INITIATIVE = 0;
        public const int DEFAULT_SPEED = 0;
        public const int DEFAULT_HIT_POINTS = 0;

        #endregion
    }
}
