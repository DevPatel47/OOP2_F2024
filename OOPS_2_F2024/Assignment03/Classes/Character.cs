/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Character Class File
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Classes
{
    internal class Character
    {

        #region Class Scope Variable

        // Stores Classes
        public static List<Character> Characters = new List<Character>();

        #endregion


        #region Properties

        public string Name { get; set; }
        public Class CharacterClass { get; set; }
        public int Level { get; set; }
        public Race CharacterRace { get; set; }
        public Constants.Alignment Alignment { get; set; }
        public string Gender { get; set; }
        public int ExperiencePoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public Constants.Armor Armor { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HitPoints { get; set; }

        #endregion


        #region Constructor

        public Character()
        {
            SetDefault();
        }

        public Character(string name, Class characterClass, int level, Race characterRace, Constants.Alignment alignment, string gender, int experiencePoints,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, Constants.Armor armor, int intiative, int speed, int hitPoints) 
        { 
            Name = name;
            CharacterClass = characterClass;
            Level = level;
            CharacterRace = characterRace;
            Alignment = alignment;
            Gender = gender;
            ExperiencePoints = experiencePoints;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
            Armor = armor;
            Initiative = intiative;
            Speed = speed;
            HitPoints = hitPoints;
        }
        #endregion

        public void SetDefault() 
        {
            Name = Constants.DEFAULT_NAME;
            CharacterClass = Constants.DEFAULT_CLASS;
            Level = Constants.DEFAULT_LEVEL;
            CharacterRace = Constants.DEFAULT_RACE;
            Alignment = Constants.DEFAULT_ALIGNMENT;
            Gender = Constants.DEFAULT_GENDER;
            ExperiencePoints = Constants.DEFAULT_EXPERIENCE_POINTS;
            Strength = Constants.DEFAULT_STRENGTH; 
            Dexterity = Constants.DEFAULT_DEXTERITY;
            Constitution = Constants.DEFAULT_CONSTITUTION;
            Intelligence = Constants.DEFAULT_INTELLIGENCE;
            Wisdom = Constants.DEFAULT_WISDOM;
            Charisma = Constants.DEFAULT_CHARISMA;
            Armor = Constants.DEFAULT_ARMOR;
            Initiative = Constants.DEFAULT_INITIATIVE;
            Speed = Constants.DEFAULT_SPEED;
            HitPoints = Constants.DEFAULT_HIT_POINTS;
        }
    }
}
