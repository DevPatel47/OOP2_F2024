/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Race Class File
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Classes
{
    /// <summary>
    /// Race Class
    /// </summary>
    public class Race
    {

        #region Class Scope Variable

        // Stores Races
        public static List<Race> races = new List<Race>();

        #endregion

        #region Properties

        /// <summary>
        /// Name property of Race class including its getter and setter
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description property of Race class including its getter and setter
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Strength property of Race class including its getter and setter
        /// </summary>
        public int Strength { get; set; }
        /// <summary>
        /// Dexterity property of Race class including its getter and setter
        /// </summary>
        public int Dexterity { get; set; }
        /// <summary>
        /// Constitution property of Race class including its getter and setter
        /// </summary>
        public int Constitution { get; set; }
        /// <summary>
        /// Intelligence property of Race class including its getter and setter
        /// </summary>
        public int Intelligence { get; set; }
        /// <summary>
        /// Wisdom property of Race class including its getter and setter
        /// </summary>
        public int Wisdom { get; set; }
        /// <summary>
        /// Charisma property of Race class including its getter and setter
        /// </summary>
        public int Charisma { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="strength"></param>
        /// <param name="dexternity"></param>
        /// <param name="constitution"></param>
        /// <param name="intelligence"></param>
        /// <param name="wisdom"></param>
        /// <param name="charisma"></param>
        public Race(string name, string description, int strength, int dexternity, int constitution, int intelligence, int wisdom, int charisma) 
        { 
            Name = name;
            Description = description;
            Strength = strength;
            Dexterity = dexternity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Method to populate provided races
        /// </summary>
        public static void PopulateRaces()
        {
            races.Add(new Race("Dwarf", "Dwarves were raised from the earth in the elder days by a deity of the forge.", 2, 0, 2, 0, 0, 0));
            races.Add(new Race("Elf (High)", "The elves’ curiosity led many of them to explore other planes of existence.", 0, 2, 0, 1, 0, 0));
            races.Add(new Race("Elf (Wood)", "The elves’ curiosity led many of them to explore other planes of existence.", 0, 2, 0, 0, 1, 0));
            races.Add(new Race("Halfling", "Halflings possess a brave and adventurous spirit that leads them on journeys of discovery.", 0, 2, 0, 0, 0, 1));
            races.Add(new Race("Human", "Found throughout the multiverse, humans are as varied as they are numerous.", 1, 1, 1, 1, 1, 1));
            races.Add(new Race("Dragonborn", "The ancestors of dragonborn hatched from the eggs of chromatic and metallic dragons.", 2, 0, 0, 0, 0, 1));
            races.Add(new Race("Gnome", "Gnomes are magical folk created by gods of invention, illusions, and life underground.", 0, 1, 0, 2, 0, 0));
            races.Add(new Race("Half-Elf", "Half-elves combine what some say are the best qualities of their elf and human parents.", 0, 1, 0, 1, 0, 2));
            races.Add(new Race("Half-Orc", "Some half-orcs rise to become proud leaders of orc communities. Some venture into the world to prove their worth. Many of these become adventurers, achieving greatness for their mighty deeds.", 2, 0, 1, 0, 0, 0));
            races.Add(new Race("Tiefling", "Tieflings are either born in the Lower Planes or have fiendish ancestors who originated there.", 0, 0, 0, 1, 0, 2));
            races.Add(new Race("Githyanki", "Githyanki complement their physical prowess with psionic might, instilled in them by mind flayers and cultivated over eons in the Astral Plane.", 1, 2, 0, 0, 0, 0));
        }
        /// <summary>
        /// Method to find race by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Race FindRaceByName(string name)
        {
            foreach (Race race in races)
            {
                if (race.Name == name) return race;
            }
            return null;
        }

        #endregion

    }
}
