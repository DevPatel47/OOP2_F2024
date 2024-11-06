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
        private int attributePoints;
        private int dexterityScore;
        private int strengthScore;
        private int constitutionScore;
        private int intelligenceScore;
        private int wisdomScore;
        private int charismaScore;

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
            attributePoints = character.AttributePoints;
            dexterityScore = character.Dexterity;
            strengthScore = character.Strength;
            constitutionScore = character.Constitution;
            intelligenceScore = character.Intelligence;
            wisdomScore = character.Wisdom;
            charismaScore = character.Charisma;

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
                Exception exception = new Exception("Please check little info button on top-right corner and try again!!");
                MessageBox.Show(exception.Message, "Invalid Values");
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
            if (IsChangeValid()) { strengthScore = (int)nud_Strength.Value; attributePoints = (int)nud_AttributePoints.Value; }
            else { nud_Strength.Value = strengthScore; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
        }

        private void nud_Dexterity_ValueChanged(object sender, EventArgs e)
        {
            if (IsChangeValid()) { dexterityScore = (int)nud_Dexterity.Value; attributePoints = (int)nud_AttributePoints.Value; }
            else { nud_Dexterity.Value = dexterityScore; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
        }

        private void nud_Constitution_ValueChanged(object sender, EventArgs e)
        {
            if (IsChangeValid()) { constitutionScore = (int)nud_Constitution.Value; attributePoints = (int)nud_AttributePoints.Value; }
            else { nud_Constitution.Value = constitutionScore; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
        }

        private void nud_Intelligence_ValueChanged(object sender, EventArgs e)
        {
            if (IsChangeValid()) { intelligenceScore = (int)nud_Intelligence.Value; attributePoints = (int)nud_AttributePoints.Value; }
            else { nud_Intelligence.Value = intelligenceScore; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
        }

        private void nud_Wisdom_ValueChanged(object sender, EventArgs e)
        {
            if (IsChangeValid()) { wisdomScore = (int)nud_Wisdom.Value; attributePoints = (int)nud_AttributePoints.Value; }
            else { nud_Wisdom.Value = wisdomScore; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
        }

        private void nud_Charisma_ValueChanged(object sender, EventArgs e)
        {
            if (IsChangeValid()) { charismaScore = (int)nud_Charisma.Value; attributePoints = (int)nud_AttributePoints.Value; }
            else { nud_Charisma.Value = charismaScore; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
        }

        private Boolean IsChangeValid() 
        {
            Boolean isChangeValid = true;
            int totalAttributeSpent = CalculateAttributePointSpent(nud_Strength) + CalculateAttributePointSpent(nud_Dexterity) + CalculateAttributePointSpent(nud_Constitution) +
                CalculateAttributePointSpent(nud_Intelligence) + CalculateAttributePointSpent(nud_Wisdom) + CalculateAttributePointSpent(nud_Charisma);
            if (totalAttributeSpent <= 27) { nud_AttributePoints.Value = 27 - totalAttributeSpent; isChangeValid = true; }
            else isChangeValid = false;

            return isChangeValid;
        }

        private int CalculateAttributePointSpent(NumericUpDown nud) 
        {
            int attributePointSpent = 0;
            for (int i = 9; i <= nud.Value; i++)
            {
                if (i >= 8 && i <= 13) attributePointSpent += 1;
                if (i >= 14 && i <= 18) attributePointSpent += 2;
                if (i == 19 || i == 20) attributePointSpent += 3;
            }
            return attributePointSpent;
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

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : Minimum 2 characters and maximum 20 characters.\n\n" +
                "Class, Race, Alignment and Gender must be selected.\n\n" +
                "Strength, Dexterity, Constitution, Intelligence, Wisdom and Charisma must be between 8 and 20 after all bonuses.\n\n" +
                "Experience Points must be between 0 and 355000.\n\n" +
                "Armor, Speed and Hit Points must be between 0 and 255.\n\n" +
                "Initiative must be between 0 and 25.", "Input Requirenments");
        }
    }
}
