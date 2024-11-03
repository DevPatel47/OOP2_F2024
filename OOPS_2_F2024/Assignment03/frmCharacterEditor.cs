/*============================================================
 * Title    :   Assignment - 3 Dungeons and Dragons
 * Name     :   Dev Mayurkumar Patel
 * Date     :   22 October 2024
 * Purpose  :   Character Editor screen form file
 *===========================================================*/

using Assignment03.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class frmCharacterEditor : Form
    {
        public frmCharacterEditor()
        {
            InitializeComponent();
        }

        private void frmCharacterEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void SetCharacterDetails(Classes.Character character, String characterStatus)
        {
            if (characterStatus == "old")
            {
                cbo_Class.Enabled = false;
                cbo_Race.Enabled = false;
                cbo_Alignment.Enabled = false;
                cbo_Gender.Enabled = false;
            }
            tbx_Name.Text = character.Name;

            int classSelectedIndex = -1;
            foreach (String className in cbo_Class.Items) 
            {
                classSelectedIndex += 1;
                if (character.CharacterClass == null) cbo_Class.SelectedIndex = -1;
                else if (character.CharacterClass.Name == className) cbo_Class.SelectedIndex = classSelectedIndex;
                
            }

            int raceSelectedIndex = -1;
            foreach (String raceName in cbo_Race.Items) 
            {
                raceSelectedIndex += 1;
                if (character.CharacterRace == null) cbo_Race.SelectedIndex = -1;
                else if (character.CharacterRace.Name == raceName) cbo_Race.SelectedIndex = raceSelectedIndex;
                
            }

            int alignmentSelectIndex = -1;
            foreach (String alignment in cbo_Alignment.Items)
            {
                alignmentSelectIndex += 1;
                if (character.Alignment.ToString() == "None") cbo_Alignment.SelectedIndex = -1;
                else if (character.Alignment.ToString() == alignment) cbo_Alignment.SelectedIndex = alignmentSelectIndex;
            }

            int genderSelectIndex = -1;
            foreach (String gender in cbo_Gender.Items)
            {
                genderSelectIndex += 1;
                if (character.Gender == "None") cbo_Gender.SelectedIndex = -1;
                else if (character.Gender == gender) cbo_Gender.SelectedIndex = genderSelectIndex;
            }

            nud_AttributePoints.Value = character.AttributePoints;

            nud_Strength.Value = character.Strength;

            nud_Dexterity.Value = character.Dexterity;

            nud_Constitution.Value = character.Constitution;

            nud_Intelligence.Value = character.Intelligence;

            nud_Wisdom.Value = character.Wisdom;

            nud_Charisma.Value = character.Charisma;

            nud_XP.Value = character.ExperiencePoints;

            nud_Level.Value = character.Level;

            nud_Armor.Value = character.Armor;

            nud_Initiative.Value = character.Initiative;

            nud_Speed.Value = character.Speed;

            nud_HitPoints.Value = character.HitPoints;

        }
    }
}
