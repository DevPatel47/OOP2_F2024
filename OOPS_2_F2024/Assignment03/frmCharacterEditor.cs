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
    /// <summary>
    /// Character Editor Form Class
    /// </summary>
    public partial class frmCharacterEditor : Form
    {             
        /// <summary>
        /// Method to initialize Splash screen form
        /// </summary>
        public frmCharacterEditor()
        {
            InitializeComponent();
        }

        #region Global Variable

        Character character;
        private int attributePoints;
        private int dexterityScore;
        private int strengthScore;
        private int constitutionScore;
        private int intelligenceScore;
        private int wisdomScore;
        private int charismaScore;
        private Boolean isClaimingBonus = false;

        #endregion

        #region Custom Methods

        /// <summary>
        /// Method to claim all race and gender bonuses on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClaimBonusPoints_Click(object sender, EventArgs e)
        {
            cbo_Class.Enabled = false;
            cbo_Race.Enabled = false;
            cbo_Alignment.Enabled = false;
            cbo_Gender.Enabled = false;
            Race race = Race.FindRaceByName(cbo_Race.Text);
            try
            {
                isClaimingBonus = true;
                nud_Strength.Value += race.Strength;
                nud_Dexterity.Value += race.Dexterity;
                nud_Constitution.Value += race.Constitution;
                nud_Intelligence.Value += race.Intelligence;
                nud_Wisdom.Value += race.Wisdom;
                nud_Charisma.Value += race.Charisma;

                if (cbo_Gender.Text.Trim() == "Male") { nud_Strength.Value += 1; nud_Wisdom.Value += 1; }
                else if (cbo_Gender.Text.Trim() == "Female") { nud_Dexterity.Value += 1; nud_Intelligence.Value += 1; }
                else if (cbo_Gender.Text.Trim() == "Gender-Diverse") { nud_Constitution.Value += 1; nud_Charisma.Value += 1; }
                isClaimingBonus = false;

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
        /// <summary>
        /// Method to set Character details on form using character and character status (new/old)
        /// </summary>
        /// <param name="tempCharacter"></param>
        /// <param name="characterStatus"></param>
        public void SetCharacterDetails(Classes.Character tempCharacter, String characterStatus)
        {
            // Saving some character properties in global variables
            character = tempCharacter;
            attributePoints = character.AttributePoints;
            dexterityScore = character.Dexterity;
            strengthScore = character.Strength;
            constitutionScore = character.Constitution;
            intelligenceScore = character.Intelligence;
            wisdomScore = character.Wisdom;
            charismaScore = character.Charisma;
            // Setting some form properties for old character
            if (characterStatus == "old")
            {
                cbo_Class.Enabled = false;
                cbo_Race.Enabled = false;
                cbo_Alignment.Enabled = false;
                cbo_Gender.Enabled = false;
                cbx_isCharacterNew.Checked = false;
                btn_Save.Enabled = true;
                btn_ClaimBonusPoints.Visible = false;
                lbl_Points.Visible = false;
                nud_AttributePoints.Visible = false;
            }
            // Setting character details on form
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
        /// <summary>
        /// Method to Store updated values
        /// </summary>
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
        /// <summary>
        /// Method to be called on nud value change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NudValueChanged(NumericUpDown nud, int globalValue)
        {
            if (!isClaimingBonus)
            {
                if (IsChangeValid()) { globalValue = (int)nud.Value; attributePoints = (int)nud_AttributePoints.Value; }
                else { nud.Value = globalValue; nud_AttributePoints.Value = attributePoints; MessageBox.Show("You can't spent more than 27 Attribute Points", "Insufficient Attribute Points"); }
            }
        }
        /// <summary>
        /// Method to Check if the recent move is valid or not
        /// </summary>
        /// <returns></returns>
        private Boolean IsChangeValid()
        {
            Boolean isChangeValid = true;
            int totalAttributeSpent = CalculateAttributePointSpent(nud_Strength) + CalculateAttributePointSpent(nud_Dexterity) + CalculateAttributePointSpent(nud_Constitution) +
                CalculateAttributePointSpent(nud_Intelligence) + CalculateAttributePointSpent(nud_Wisdom) + CalculateAttributePointSpent(nud_Charisma);
            if (cbx_isCharacterNew.Checked)
            {
                if (totalAttributeSpent <= 27) { nud_AttributePoints.Value = 27 - totalAttributeSpent; isChangeValid = true; }
                else isChangeValid = false;
            }
            return isChangeValid;
        }
        /// <summary>
        /// Method to calculate attribute points
        /// </summary>
        /// <param name="nud"></param>
        /// <returns></returns>
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

        #endregion

        #region Event Methods

        /// <summary>
        /// Nud value change event method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Strength_ValueChanged(object sender, EventArgs e)
        {
            NudValueChanged(nud_Strength, strengthScore);
        }
        /// <summary>
        /// Nud value change event method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Dexterity_ValueChanged(object sender, EventArgs e)
        {
            NudValueChanged(nud_Dexterity, dexterityScore);
        }
        /// <summary>
        /// Nud value change event method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Constitution_ValueChanged(object sender, EventArgs e)
        {
            NudValueChanged(nud_Constitution, constitutionScore);
        }
        /// <summary>
        /// Nud value change event method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Intelligence_ValueChanged(object sender, EventArgs e)
        {
            NudValueChanged(nud_Intelligence, intelligenceScore);
        }
        /// <summary>
        /// Nud value change event method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Wisdom_ValueChanged(object sender, EventArgs e)
        {
            NudValueChanged(nud_Wisdom, wisdomScore);
        }
        /// <summary>
        /// Nud value change event method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_Charisma_ValueChanged(object sender, EventArgs e)
        {
            NudValueChanged(nud_Charisma, charismaScore);
        }
        /// <summary>
        /// Form Closing Event Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCharacterEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Method to return to main form on a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?", "Back Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }
        /// <summary>
        /// Method to save character on a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Method to chenge level on Xp nud click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_XP_ValueChanged(object sender, EventArgs e)
        {
            Character.SetLevelUsingXP(nud_XP, nud_Level);
        }
        /// <summary>
        /// Method to show Validation info on a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name : Minimum 2 characters and maximum 20 characters.\n\n" +
                "Class, Race, Alignment and Gender must be selected.\n\n" +
                "Strength, Dexterity, Constitution, Intelligence, Wisdom and Charisma must be between 8 and 20 after all bonuses.\n\n" +
                "Experience Points must be between 0 and 355000.\n\n" +
                "Armor, Speed and Hit Points must be between 0 and 255.\n\n" +
                "Initiative must be between 0 and 25.", "Input Requirenments");
        }
        #endregion
               
    }

}
