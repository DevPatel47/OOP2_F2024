/* **************************************
 * COSC2100 - Section 4 - Week 3
 * Dev Mayurkumar Patel
 * Sept 19, 2024
 * Week 3 - Demo A and Class Exercise 1
 * ***********************************  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExercise01
{
    public partial class frmMain : Form
    {

        #region Startup

        /// <summary>
        /// Method to initialize main form.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to Load main from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();

        }

        /// <summary>
        /// Method to set default settings
        /// </summary>
        private void SetDefaults()
        {
            SetGTN_Defaults();
            SetIC_Defaults();
        }

        /// <summary>
        /// Method containing default settings for Guess the number game
        /// </summary>
        private void SetGTN_Defaults()
        {
            cbo_GTN_Difficulty.SelectedIndex = 0;
            nudGuessedNumber.Minimum = 1;
            SetGTNMaximum();
        }

        /// <summary>
        /// Method containing default settings for Ice cream application
        /// </summary>
        private void SetIC_Defaults()
        {

        }

        #endregion

        #region Custom Methods for Guess The Number Game

        /// <summary>
        /// Method to set the guessing range according to difficulty
        /// </summary>
        private void SetGTNMaximum()
        {
            int maximumNumber;

            switch (cbo_GTN_Difficulty.SelectedIndex)
            {
                case 1:
                    nudGuessedNumber.Maximum = Settings.GTN_DEF_MAXIMUMNUMBER_MEDIUM;
                    maximumNumber = Settings.GTN_DEF_MAXIMUMNUMBER_MEDIUM;
                    break;
                case 2:
                    nudGuessedNumber.Maximum = Settings.GTN_DEF_MAXIMUMNUMBER_HARD;
                    maximumNumber = Settings.GTN_DEF_MAXIMUMNUMBER_HARD;
                    break;
                default:
                    nudGuessedNumber.Maximum = Settings.GTN_DEF_MAXIMUMNUMBER_EASY;
                    maximumNumber = Settings.GTN_DEF_MAXIMUMNUMBER_EASY;
                    break;
            }

            lbl_GTN_DifficultyInstructions.Text = "For this Difficulty level you will have to guess a number between 1 and " + maximumNumber + " ."
;

            nudGTNRandomNumber.Value = Tools.RandomInt(1, (int)nudGuessedNumber.Maximum);

            nudGTNNumGuesses.Value = 0;

        }

        #endregion

        #region General Events for Guess The Number Game
        
        /// <summary>
        /// Method to reset settings on changing difficulty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_GTN_Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_GTN_Output.Text = "";
            nudGuessedNumber.Value = 1;
            SetGTNMaximum();
        }

        /// <summary>
        /// Method to make panel visible on clicking Guess The Number button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuessTheNumber_Click(object sender, EventArgs e)
        {
            panGuessTheNumber.Visible = !panGuessTheNumber.Visible;
            SetGTN_Defaults();
        }

        /// <summary>
        /// Method to output result on guessing a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GTN_Guess_Click(object sender, EventArgs e)
        {
            nudGTNNumGuesses.Value += 1;

            // compare guess to value
            if (nudGuessedNumber.Value > nudGTNRandomNumber.Value)
            {
                lbl_GTN_Output.Text += "Guess " + nudGTNNumGuesses.Value + " is TOO HIGH!\n";
            }
            else if (nudGuessedNumber.Value < nudGTNRandomNumber.Value)
            {
                lbl_GTN_Output.Text += "Guess " + nudGTNNumGuesses.Value + " is TOO LOW!\n";
            }
            else
            {
                lbl_GTN_Output.Text += "YEAH! You got it!  It took you " + nudGTNNumGuesses.Value + " guesses\n";
            }
        }

        private void lbl_GTN_Title_Click(object sender, EventArgs e)
        {

        }

        private void panGuessTheNumber_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGTNMinimumLabel_Click(object sender, EventArgs e)
        {

        }

        private void gbx_GTN_Settings_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to exit Guess The Number game panel on clicking exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GTN_exit_Click(object sender, EventArgs e)
        {
            panGuessTheNumber.Visible = false;
        }

        #endregion

        #region Custom Methods for Ice Cream Application



        #endregion

        #region General Events for Ice Cream Application



        #endregion

        

        
    }
}
