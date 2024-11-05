/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Character Class File
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Assignment03.Classes
{
    public class Character
    {

        #region Class Scope Variable

        // Stores Classes
        public static List<Character> characters = new List<Character>();

        #endregion


        #region Properties

        private string _name;
        public string Name 
        {
            get 
            { 
                return _name;
            }
            set 
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 20) 
                {   
                    Boolean isUnique = true;
                    foreach (Character character in characters) 
                    { 
                        if (value.Trim() == character.Name) isUnique = false;
                    }
                    if(isUnique) _name = value;                    
                }
                else throw new Exception("Invalid Name");
            } 
        }

        private Class _class;
        public Class CharacterClass 
        {
            get 
            {
                return _class;
            }
            set 
            {
                if (value != null) _class = value;
                else throw new Exception("Invalid Class");
            } 
        
        }

        private int _level;
        public int Level 
        {
            get 
            {
                return _level;
            }
            set 
            { 
                if (value >= 1 && value <= 20) _level = value;
                else throw new Exception("Invalid Level");
            } 
        }

        private Race _characterRace;
        public Race CharacterRace 
        {
            get
            {
                return _characterRace;
            }
            set
            {
                if (value != null) _characterRace = value;
                else throw new Exception("Invalid Race");
            }
        }
        public Constants.Alignment Alignment { get; set; }

        private string _gender;
        public string Gender 
        { 
            get
            { 
                return _gender;
            }
            set 
            {
                if (value.Trim().ToLower() == "male" || value.Trim().ToLower() == "female" || value.Trim().ToLower() == "gender-diverse") _gender = value;
                else throw new Exception("Invalid Gender");
            } 
        
        }

        private int _experiencePoints;
        public int ExperiencePoints 
        {
            get
            {
                return _experiencePoints;
            }
            set
            { 
                if(value >= 0 && value <= 355000) _experiencePoints = value;
                else throw new Exception("Invalid Experience Points");
            }
        }

        private int _strength;
        public int Strength 
        {
            get
            { 
                return _strength;
            }
            set 
            {
                if (value >= 8 && value <= 20) _strength = value;
                else throw new Exception("Invalid Strength");
            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }
            set
            {
                if (value >= 8 && value <= 20) _dexterity = value;
                else throw new Exception("Invalid Dexterity");
            }
        }

        private int _constitution;
        public int Constitution
        {
            get
            {
                return _constitution;
            }
            set
            {
                if (value >= 8 && value <= 20) _constitution = value;
                else throw new Exception("Invalid Constitution");
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }
            set
            {
                if (value >= 8 && value <= 20) _intelligence = value;
                else throw new Exception("Invalid Intelligence");
            }
        }

        private int _wisdom;
        public int Wisdom
        {
            get
            {
                return _wisdom;
            }
            set
            {
                if (value >= 8 && value <= 20) _wisdom = value;
                else throw new Exception("Invalid Wisdom");
            }
        }

        private int _charisma;
        public int Charisma
        {
            get
            {
                return _charisma;
            }
            set
            {
                if (value >= 8 && value <= 20) _charisma = value;
                else throw new Exception("Invalid Charisma");
            }
        }

        private int _armor;
        public int Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                if (value >= 0) _armor = value;
                else throw new Exception("Invalid Armor");
            }
        }

        private int _initiative;
        public int Initiative
        {
            get
            {
                return _initiative;
            }
            set
            {
                if (value >= 0 && value <= 25) _initiative = value;
                else throw new Exception("Invalid Initiative");
            }
        }

        private int _speed;
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value >= 0) _initiative = value;
                else throw new Exception("Invalid Speed");
            }
        }

        private int _hitPoints;
        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                if (value >= 0) _hitPoints = value;
                else throw new Exception("Invalid Hitpoints");
            }
        }

        private int _attributePoints;
        public int AttributePoints
        {
            get
            {
                return _attributePoints;
            }
            set
            {
                if (value >= 0 && value <= 27) _attributePoints = value;
                else throw new Exception("Invalid Attribute Points");
            }
        }


        #endregion


        #region Constructor

        public Character()
        {
            SetDefault();
        }

        public Character(string name, Class characterClass, int level, Race characterRace, Constants.Alignment alignment, string gender, int experiencePoints,
            int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int armor, int intiative, int speed, int hitPoints, int attributePoints)
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
            AttributePoints = attributePoints;
            
        }
        #endregion

        public void SetDefault() 
        {
            
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
            AttributePoints = Constants.DEFAULT_ATTRIBUTE_POINTS;
            
        }

        public static string ShowCharacterDetails(string name)
        {
            Character character = FindCharacterByName(name);

            if (character == null)
            {
                return $"Character with name '{name}' not found.";
            }

            StringBuilder retString = new StringBuilder();

            retString.AppendLine("Character Details:");
            retString.AppendLine("\n");
            retString.AppendLine($"Name: {character.Name}");
            retString.AppendLine($"Class: {character.CharacterClass.Name}");
            retString.AppendLine($"Level: {character.Level}");
            retString.AppendLine($"Race: {character.CharacterRace.Name}");
            retString.AppendLine($"Alignment: {character.Alignment}");
            retString.AppendLine($"Gender: {character.Gender}");
            retString.AppendLine($"Experience Points: {character.ExperiencePoints}");
            retString.AppendLine($"Strength: {character.Strength}");
            retString.AppendLine($"Dexterity: {character.Dexterity}");
            retString.AppendLine($"Constitution: {character.Constitution}");
            retString.AppendLine($"Intelligence: {character.Intelligence}");
            retString.AppendLine($"Wisdom: {character.Wisdom}");
            retString.AppendLine($"Charisma: {character.Charisma}");
            retString.AppendLine($"Armor: {character.Armor}");
            retString.AppendLine($"Initiative: {character.Initiative}");
            retString.AppendLine($"Speed: {character.Speed}");
            retString.AppendLine($"Hit Points: {character.HitPoints}");

            return retString.ToString();
        }

        public static Character FindCharacterByName(string name)
        {
            foreach (Character character in characters)
            {
                if (character.Name == name) return character;
            }
            return null;
        }

        public static void SetLevelUsingXP(NumericUpDown experiencePoint, NumericUpDown level) 
        {
            if (experiencePoint.Value < 300) level.Value = 1;
            else if (experiencePoint.Value >= 300 && experiencePoint.Value < 900) level.Value = 2;
            else if (experiencePoint.Value >= 900 && experiencePoint.Value < 2700) level.Value = 3;
            else if (experiencePoint.Value >= 2700 && experiencePoint.Value < 6500) level.Value = 4;
            else if (experiencePoint.Value >= 6500 && experiencePoint.Value < 14000) level.Value = 5;
            else if (experiencePoint.Value >= 14000 && experiencePoint.Value < 23000) level.Value = 6;
            else if (experiencePoint.Value >= 23000 && experiencePoint.Value < 34000) level.Value = 7;
            else if (experiencePoint.Value >= 34000 && experiencePoint.Value < 48000) level.Value = 8;
            else if (experiencePoint.Value >= 48000 && experiencePoint.Value < 64000) level.Value = 9;
            else if (experiencePoint.Value >= 64000 && experiencePoint.Value < 85000) level.Value = 10;
            else if (experiencePoint.Value >= 85000 && experiencePoint.Value < 100000) level.Value = 11;
            else if (experiencePoint.Value >= 100000 && experiencePoint.Value < 120000) level.Value = 12;
            else if (experiencePoint.Value >= 120000 && experiencePoint.Value < 140000) level.Value = 13;
            else if (experiencePoint.Value >= 140000 && experiencePoint.Value < 165000) level.Value = 14;
            else if (experiencePoint.Value >= 165000 && experiencePoint.Value < 195000) level.Value = 15;
            else if (experiencePoint.Value >= 195000 && experiencePoint.Value < 225000) level.Value = 16;
            else if (experiencePoint.Value >= 225000 && experiencePoint.Value < 265000) level.Value = 17;
            else if (experiencePoint.Value >= 265000 && experiencePoint.Value < 305000) level.Value = 18;
            else if (experiencePoint.Value >= 305000 && experiencePoint.Value < 355000) level.Value = 19;
            else if (experiencePoint.Value == 355000) level.Value = 20;
        }
    }
}
