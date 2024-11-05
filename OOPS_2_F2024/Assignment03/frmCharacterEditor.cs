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
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class frmCharacterEditor : Form
    {
        Character character;
        public frmCharacterEditor()
        {
            InitializeComponent();
        }

        private void frmCharacterEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void SetCharacterDetails(Classes.Character tempCharacter, String characterStatus)
        {
            character = tempCharacter;
            if (characterStatus == "old")
            {
                cbo_Class.Enabled = false;
                cbo_Race.Enabled = false;
                cbo_Alignment.Enabled = false;
                cbo_Gender.Enabled = false;
                cbx_isCharacterNew.Checked = false;
                btn_Save.Enabled = true;
                btn_ClaimBonusPoints.Enabled = false;
            }
            tbx_Name.Text = tempCharacter.Name;

            int classSelectedIndex = -1;
            foreach (String className in cbo_Class.Items) 
            {
                classSelectedIndex += 1;
                if (tempCharacter.CharacterClass == null) cbo_Class.SelectedIndex = -1;
                else if (tempCharacter.CharacterClass.Name == className) cbo_Class.SelectedIndex = classSelectedIndex;
                
            }

            int raceSelectedIndex = -1;
            foreach (String raceName in cbo_Race.Items) 
            {
                raceSelectedIndex += 1;
                if (tempCharacter.CharacterRace == null) cbo_Race.SelectedIndex = -1;
                else if (tempCharacter.CharacterRace.Name == raceName) cbo_Race.SelectedIndex = raceSelectedIndex;
                
            }

            int alignmentSelectIndex = -1;
            foreach (String alignment in cbo_Alignment.Items)
            {
                alignmentSelectIndex += 1;
                if (tempCharacter.Alignment.ToString() == "None") cbo_Alignment.SelectedIndex = -1;
                else if (tempCharacter.Alignment.ToString() == alignment) cbo_Alignment.SelectedIndex = alignmentSelectIndex;
            }

            int genderSelectIndex = -1;
            foreach (String gender in cbo_Gender.Items)
            {
                genderSelectIndex += 1;
                if (tempCharacter.Gender == "None") cbo_Gender.SelectedIndex = -1;
                else if (tempCharacter.Gender == gender) cbo_Gender.SelectedIndex = genderSelectIndex;
            }

            nud_AttributePoints.Value = tempCharacter.AttributePoints;
            nud_Strength.Value = tempCharacter.Strength;
            nud_Dexterity.Value = tempCharacter.Dexterity;
            nud_Constitution.Value = tempCharacter.Constitution;
            nud_Intelligence.Value = tempCharacter.Intelligence;
            nud_Wisdom.Value = tempCharacter.Wisdom;
            nud_Charisma.Value = tempCharacter.Charisma;
            nud_XP.Value = tempCharacter.ExperiencePoints;
            nud_Level.Value = tempCharacter.Level;
            nud_Armor.Value = tempCharacter.Armor;
            nud_Initiative.Value = tempCharacter.Initiative;
            nud_Speed.Value = tempCharacter.Speed;
            nud_HitPoints.Value = tempCharacter.HitPoints;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?", "Back Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            { 
            this.Hide();
            frmMain frm = new frmMain();
                frm.Show();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try 
            {
                if (cbx_isCharacterNew.Checked)
                {
                    Character.characters.Add(new Character(tbx_Name.Text.Trim(), Class.FindClassByName(cbo_Class.Text), (int)nud_Level.Value, Race.FindRaceByName(cbo_Race.Text), (Constants.Alignment)cbo_Alignment.SelectedIndex,
                    cbo_Gender.Text, (int)nud_XP.Value, (int)nud_Strength.Value, (int)nud_Dexterity.Value, (int)nud_Constitution.Value, (int)nud_Intelligence.Value, (int)nud_Wisdom.Value, (int)nud_Charisma.Value,
                    (int)nud_Armor.Value, (int)nud_Initiative.Value, (int)nud_Speed.Value, (int)nud_HitPoints.Value, (int)nud_AttributePoints.Value));                    
                }
                else
                {
                    UpdateCharacter();
                }
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            catch
            {
                Exception exception = new Exception("Invalid Values entered, Please try again!!");
                MessageBox.Show(exception.Message, "Error while saving");
            }            
        }

        private void UpdateCharacter() 
        {            
            character.Name = tbx_Name.Text.Trim();
            character.AttributePoints = (int)nud_AttributePoints.Value;
            character.Strength = (int)nud_Strength.Value;
            character.Dexterity = (int)nud_Dexterity.Value;
            character.Constitution = (int)nud_Constitution.Value;
            character.Intelligence = (int)nud_Intelligence.Value;
            character.Wisdom = (int)nud_Wisdom.Value;
            character.Charisma = (int)nud_Charisma.Value;
            character.ExperiencePoints = (int)nud_XP.Value;
            character.Level = (int)nud_Level.Value;
            character.Armor = (int)nud_Armor.Value;
            character.Initiative = (int)nud_Initiative.Value;
            character.Speed = (int)nud_Speed.Value;
            character.HitPoints = (int)nud_HitPoints.Value;            
        }

        private void nud_Strength_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_Dexterity_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_Constitution_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_Intelligence_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_Wisdom_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_Charisma_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_XP_ValueChanged(object sender, EventArgs e)
        {
            Character.SetLevelUsingXP(nud_XP, nud_Level );
        }

        private void btn_ClaimBonusPoints_Click(object sender, EventArgs e)
        {
            cbo_Class.Enabled = false;
            cbo_Race.Enabled = false;
            cbo_Alignment.Enabled = false;
            cbo_Gender.Enabled = false;
            Race race = Race.FindRaceByName(cbo_Race.Text);
            try
            {                
                nud_Strength.Value += race.Strength;
                nud_Dexterity.Value += race.Dexterity;
                nud_Constitution.Value += race.Constitution;
                nud_Intelligence.Value += race.Intelligence;
                nud_Wisdom.Value += race.Wisdom;
                nud_Charisma.Value += race.Charisma;

                if (cbo_Gender.Text.Trim() == "Male") { nud_Strength.Value += 1; nud_Wisdom.Value += 1; }
                else if (cbo_Gender.Text.Trim() == "Female") { nud_Dexterity.Value += 1; nud_Intelligence.Value += 1; }
                else if (cbo_Gender.Text.Trim() == "Gender-Diverse") { nud_Constitution.Value += 1; nud_Charisma.Value += 1; }

                btn_Save.Enabled = true;
                nud_Strength.Enabled = false;
                nud_Dexterity.Enabled = false;
                nud_Constitution.Enabled = false;
                nud_Intelligence.Enabled = false;
                nud_Wisdom.Enabled = false;
                nud_Charisma.Enabled = false;
                btn_ClaimBonusPoints.Enabled = false;
            }
            catch 
            {
                Exception exception = new Exception("Invalid Attribute values, Please try again!!");
                MessageBox.Show(exception.Message);
                nud_AttributePoints.Value = character.AttributePoints;
                nud_Strength.Value = character.Strength;
                nud_Dexterity.Value = character.Dexterity;
                nud_Constitution.Value = character.Constitution;
                nud_Intelligence.Value = character.Intelligence;
                nud_Wisdom.Value = character.Wisdom;
                nud_Charisma.Value = character.Charisma;                
            }            
        }        
    }
}
