/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Classes Class File
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Classes
{
    internal class Class
    {

        #region Class Scope Variable

        // Stores Classes
        public static List<Class> Classes = new List<Class>();

        #endregion


        #region Properties

        public string Name { get; set; }
        public string Description { get; set; }
        public int HpDice { get; set; }
        public string PrimaryAbility { get; set; }
        public string PrimarySave { get; set; }
        public string SecondarySave { get; set; }

        #endregion


        #region Constructor
              
        public Class(string name, string description, int hpDice, string primaryAbility, string primarySave, string secondarySave)
        { 
            Name = name;
            Description = description;
            HpDice = hpDice;
            PrimaryAbility = primaryAbility;
            PrimarySave = primarySave;
            SecondarySave = secondarySave;
        }

        #endregion


        public static void PopulateClasses()
        {
            Classes.Add(new Class("Barbarian",  "A fierce warrior of Primal Rage.",                 12,     "Strength",     "Strength",     "Constitution"));
            Classes.Add(new Class("Bard",       "An inspiring Perfomer of Music, Dance and Magic.", 8,      "Dexterity",    "Dexterity",    "Charisma"));
            Classes.Add(new Class("Cleric",     "A Miraculous Priest of Divine Power.",             8,      "Wisdom",       "Wisdom",       "Charisma"));
            Classes.Add(new Class("Druid",      "A Nature Priest of Primal Power.",                 8,      "Intelligence", "Intelligence", "Wisdom"));
            Classes.Add(new Class("Fighter",    "A Master of All Arms and Armor.",                  10,     "Strength",     "Strength",     "Constitution"));
            Classes.Add(new Class("Monk",       "A Martial Artist of Supernatural Focus.",          8,      "Dexterity",    "Dexterity",    "Strength"));
            Classes.Add(new Class("Paladin",    "A Devout Warrior of Sacred Oaths.",                10,     "Strength",     "Wisdom",       "Charisma"));
            Classes.Add(new Class("Ranger",     "A Wandering Warrior Imbued with Primal Magic.",    10,     "Dexterity",    "Strength",     "Dexterity"));
            Classes.Add(new Class("Rogue",      "A Dexterous Expert in Stealth and Subterfuge.",    8,      "Dexterity",    "Intelligence", "Dexterity"));
            Classes.Add(new Class("Sorcerer",   "A Dazzling Mage Filled with Innate Magic.",        6,      "Charisma",     "Constitution", "Charisma"));
            Classes.Add(new Class("Warlock",    "An Occultist Empowered by Otherworldly Pacts.",    8,      "Charisma",     "Wisdom",       "Charisma"));
            Classes.Add(new Class("Wizard",     "A Scholarly Magic-User of Arcane Power.",          6,      "Intelligence", "Intelligence", "Wisdom"));
        }
    }
}
