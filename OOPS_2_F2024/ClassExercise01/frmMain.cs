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

        #endregion



        #region Guess The Number Game



        #region Defaults
        /// <summary>
        /// Method containing default settings for Guess the number game
        /// </summary>
        private void SetGTN_Defaults()
        {
            cbo_GTN_Difficulty.SelectedIndex = 0;
            nudGuessedNumber.Minimum = Settings.GTN_DEF_MINIMUMNUMBER;
            SetGTNMaximum();
        }
        #endregion

        #region Custom Methods
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

        #region General Events
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
            if (panGuessTheNumber.Visible)
            {
                panGuessTheNumber.Visible = false;
            }
            else
            {
                panIceCream.Visible = false;
                panGuessTheNumber.Visible = true;
                SetGTN_Defaults();
            }

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

        #endregion



        #region Ice Cream Application


        #region Defaults
        /// <summary>
        /// Method containing default settings for Ice cream application
        /// </summary>
        private void SetIC_Defaults()
        {
            Reset_IC_ItemDetails();
            Reset_IC_Cart();

        }

        /// <summary>
        /// Method containing default settings for Payment summary panel
        /// </summary>
        private void SetPS_Defaults()
        {
            lbl_PS_TotalAmount.Text = "- -";
            nud_PS_CashReceived.Value = 0;
            lbl_PS_ChangePrice.Text = "- -";
            gbx_PS_SalesDetails.Visible = false;
        }
        #endregion

        #region Custom Methods
        private void Reset_IC_ItemDetails()
        {
            lbl_IC_ItemPrice.Text = "- -";
            lbl_IC_ItemTotalPrice.Text = "- -";
            lbl_IC_ItemName.Text = "Item";
            nud_IC_Quantity.Value = 0;
            nud_IC_Quantity.Enabled = false;
        }

        private void Reset_IC_Cart()
        {
            lbl_IC_CartItem1.Text = "";
            lbl_IC_CartItem2.Text = "";
            lbl_IC_CartItem3.Text = "";
            lbl_IC_CartItem4.Text = "";
            lbl_IC_CartItem5.Text = "";

            nud_IC_CartItem1_Quantity.Value = 0;
            nud_IC_CartItem1_Quantity.Visible = false;

            nud_IC_CartItem2_Quantity.Value = 0;
            nud_IC_CartItem2_Quantity.Visible = false;

            nud_IC_CartItem3_Quantity.Value = 0;
            nud_IC_CartItem3_Quantity.Visible = false;

            nud_IC_CartItem4_Quantity.Value = 0;
            nud_IC_CartItem4_Quantity.Visible = false;

            nud_IC_CartItem5_Quantity.Value = 0;
            nud_IC_CartItem5_Quantity.Visible = false;

            lbl_IC_CartTotalPrice.Text = "- -";
        }

        private void set_IC_ItemDetails(String itemName, int price)
        {
            Reset_IC_ItemDetails();
            lbl_IC_ItemName.Text = itemName;
            nud_IC_Quantity.Enabled = true;
            lbl_IC_ItemPrice.Text = "" + price + " $";

        }

        #endregion

        #region General Events

        #endregion


        #endregion




        #region Startup









        #endregion

        #region Custom Methods for Guess The Number Game



        #endregion

        #region General Events for Guess The Number Game






        #endregion

        #region Custom Methods for Ice Cream Application






        #endregion

        #region General Events for Ice Cream Application

        private void btn_IC_ClearItem_Click(object sender, EventArgs e)
        {
            Reset_IC_ItemDetails();
        }

        private void btn_IC_EditCart_Click(object sender, EventArgs e)
        {
            if (nud_IC_CartItem1_Quantity.Visible) nud_IC_CartItem1_Quantity.Enabled = true;
            if (nud_IC_CartItem2_Quantity.Visible) nud_IC_CartItem2_Quantity.Enabled = true;
            if (nud_IC_CartItem3_Quantity.Visible) nud_IC_CartItem3_Quantity.Enabled = true;
            if (nud_IC_CartItem4_Quantity.Visible) nud_IC_CartItem4_Quantity.Enabled = true;
            if (nud_IC_CartItem5_Quantity.Visible) nud_IC_CartItem5_Quantity.Enabled = true;

        }

        private void btn_IC_Exit_Click(object sender, EventArgs e)
        {
            panIceCream.Visible = false;
        }

        private void btnIceCream_Click(object sender, EventArgs e)
        {
            if (panIceCream.Visible)
            {
                panIceCream.Visible = false;
            }
            else
            {
                panGuessTheNumber.Visible = false;
                panIceCream.Visible = true;
                SetIC_Defaults();
            }
        }

        private void btn_IC_ChocoFudge_Click(object sender, EventArgs e)
        {
            set_IC_ItemDetails("Choco Fudge", Settings.IC_DEF_CHOCOFUDGEPRICE);

        }

        private void btn_IC_AmericanNuts_Click(object sender, EventArgs e)
        {
            set_IC_ItemDetails("American Nuts", Settings.IC_DEF_AMERICANNUTSPRICE);
        }

        private void btn_IC_ChocoCrackleFlingo_Click(object sender, EventArgs e)
        {
            set_IC_ItemDetails("Choco Crackle Flingo", Settings.IC_DEF_CHOCOCRACKLEFLINGOPRICE);
        }

        private void btn_IC_CookieSandwich_Click(object sender, EventArgs e)
        {
            set_IC_ItemDetails("CookieSandwich", Settings.IC_DEF_COOKIESANDWICHPRICE);
        }

        private void btn_IC_ChocolateOverload_Click(object sender, EventArgs e)
        {
            set_IC_ItemDetails("Chocolate Overload", Settings.IC_DEF_CHOCOLATEOVERLOADPRICE);
        }





        #endregion

        private void nud_IC_Quantity_ValueChanged(object sender, EventArgs e)
        {
            

            if (lbl_IC_ItemName.Text == "Choco Fudge") 
            {
                lbl_IC_ItemTotalPrice.Text = "" + (Settings.IC_DEF_CHOCOFUDGEPRICE * (int)nud_IC_Quantity.Value) + " $";
            }
            else if (lbl_IC_ItemName.Text == "American Nuts")
            {
                lbl_IC_ItemTotalPrice.Text = "" + (Settings.IC_DEF_AMERICANNUTSPRICE * (int)nud_IC_Quantity.Value) + " $";
            }
            else if (lbl_IC_ItemName.Text == "Choco Crackle Flingo")
            {
                lbl_IC_ItemTotalPrice.Text = "" + (Settings.IC_DEF_CHOCOCRACKLEFLINGOPRICE * (int)nud_IC_Quantity.Value) + " $";
            }
            else if (lbl_IC_ItemName.Text == "CookieSandwich")
            {
                lbl_IC_ItemTotalPrice.Text = "" + (Settings.IC_DEF_COOKIESANDWICHPRICE * (int)nud_IC_Quantity.Value) + " $";
            }
            else if (lbl_IC_ItemName.Text == "Chocolate Overload")
            {
                lbl_IC_ItemTotalPrice.Text = "" + (Settings.IC_DEF_CHOCOLATEOVERLOADPRICE * (int)nud_IC_Quantity.Value) + " $";
            }
        }

        private void btn_IC_AddToCart_Click(object sender, EventArgs e)
        {
            if (lbl_IC_ItemName.Text == "Choco Fudge")
            {
                lbl_IC_CartItem1.Visible = true;
                nud_IC_CartItem1_Quantity.Visible = true;
                lbl_IC_CartItem1.Text = lbl_IC_ItemName.Text;
                nud_IC_CartItem1_Quantity.Value += nud_IC_Quantity.Value;
                
            }
            else if (lbl_IC_ItemName.Text == "American Nuts")
            {
                lbl_IC_CartItem2.Visible = true;
                nud_IC_CartItem2_Quantity.Visible = true;
                lbl_IC_CartItem2.Text = lbl_IC_ItemName.Text;
                nud_IC_CartItem2_Quantity.Value += nud_IC_Quantity.Value;
            }
            else if (lbl_IC_ItemName.Text == "Choco Crackle Flingo")
            {
                lbl_IC_CartItem3.Visible = true;
                nud_IC_CartItem3_Quantity.Visible = true;
                lbl_IC_CartItem3.Text = lbl_IC_ItemName.Text;
                nud_IC_CartItem3_Quantity.Value += nud_IC_Quantity.Value;
            }
            else if (lbl_IC_ItemName.Text == "CookieSandwich")
            {
                lbl_IC_CartItem4.Visible = true;
                nud_IC_CartItem4_Quantity.Visible = true;
                lbl_IC_CartItem4.Text = lbl_IC_ItemName.Text;
                nud_IC_CartItem4_Quantity.Value += nud_IC_Quantity.Value;
            }
            else if (lbl_IC_ItemName.Text == "Chocolate Overload")
            {
                lbl_IC_CartItem5.Visible = true;
                nud_IC_CartItem5_Quantity.Visible = true;
                lbl_IC_CartItem5.Text = lbl_IC_ItemName.Text;
                nud_IC_CartItem5_Quantity.Value += nud_IC_Quantity.Value;
            }
            Reset_IC_ItemDetails();
            btn_IC_Total.Enabled = true;
            btn_IC_EditCart.Enabled = true;
        }

        private void btn_IC_Total_Click(object sender, EventArgs e)
        {
            lbl_IC_CartTotalPrice.Visible = true;
            lbl_IC_CartTotal.Visible = true;

             Decimal cartTotal = Settings.IC_DEF_CHOCOFUDGEPRICE*nud_IC_CartItem1_Quantity.Value + Settings.IC_DEF_AMERICANNUTSPRICE*nud_IC_CartItem2_Quantity.Value +
                Settings.IC_DEF_CHOCOCRACKLEFLINGOPRICE*nud_IC_CartItem3_Quantity.Value + Settings.IC_DEF_COOKIESANDWICHPRICE*nud_IC_CartItem4_Quantity.Value + 
                Settings.IC_DEF_CHOCOLATEOVERLOADPRICE*nud_IC_CartItem5_Quantity.Value;

            lbl_IC_CartTotalPrice.Text = "" + cartTotal + " $";

            btn_IC_Buy.Enabled = true;

        }

        private void lbl_PS_TotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void btn_IC_Buy_Click(object sender, EventArgs e)
        {
            pan_IC_PaymentSummary.Visible = true;
            pan_IC_PaymentSummary.BringToFront();
            lbl_PS_TotalAmount.Text = lbl_IC_CartTotalPrice.Text;
        }

        private void btn_PS_ContinueShopping_Click(object sender, EventArgs e)
        {
            pan_IC_PaymentSummary.Visible=false;
            SetIC_Defaults();
            SetPS_Defaults();
        }

        private void btn_PS_Back_Click(object sender, EventArgs e)
        {
            pan_IC_PaymentSummary.Visible = false;
        }

    

        private void btn_PS_Card_Click(object sender, EventArgs e)
        {
            Decimal cartTotal = Settings.IC_DEF_CHOCOFUDGEPRICE * nud_IC_CartItem1_Quantity.Value + Settings.IC_DEF_AMERICANNUTSPRICE * nud_IC_CartItem2_Quantity.Value +
                Settings.IC_DEF_CHOCOCRACKLEFLINGOPRICE * nud_IC_CartItem3_Quantity.Value + Settings.IC_DEF_COOKIESANDWICHPRICE * nud_IC_CartItem4_Quantity.Value +
                Settings.IC_DEF_CHOCOLATEOVERLOADPRICE * nud_IC_CartItem5_Quantity.Value;

            Settings.overallSaleAmount += (int)cartTotal;

            pan_IC_PaymentSummary.Visible = false;
            SetIC_Defaults();
            SetPS_Defaults();
        }

        private void btn_PS_Cash_Click(object sender, EventArgs e)
        {
            gbx_PS_CashPayment.Enabled = true;
        }

        private void btn_PS_CashExact_Click(object sender, EventArgs e)
        {
            Decimal cartTotal = Settings.IC_DEF_CHOCOFUDGEPRICE * nud_IC_CartItem1_Quantity.Value + Settings.IC_DEF_AMERICANNUTSPRICE * nud_IC_CartItem2_Quantity.Value +
                Settings.IC_DEF_CHOCOCRACKLEFLINGOPRICE * nud_IC_CartItem3_Quantity.Value + Settings.IC_DEF_COOKIESANDWICHPRICE * nud_IC_CartItem4_Quantity.Value +
                Settings.IC_DEF_CHOCOLATEOVERLOADPRICE * nud_IC_CartItem5_Quantity.Value;

            Settings.cashInDrawer += (int)cartTotal;
            Settings.overallSaleAmount += (int)cartTotal;

            pan_IC_PaymentSummary.Visible = false;
            SetIC_Defaults();
            SetPS_Defaults();
        }

        private void btn_PS_Cash_1_Click(object sender, EventArgs e)
        {
            nud_PS_CashReceived.Value += 1;
        }

        private void btn_PS_Cash_2_Click(object sender, EventArgs e)
        {
            nud_PS_CashReceived.Value += 2;
        }

        private void btn_PS_Cash_5_Click(object sender, EventArgs e)
        {
            nud_PS_CashReceived.Value += 5;
        }

        private void btn_PS_Cash_10_Click(object sender, EventArgs e)
        {
            nud_PS_CashReceived.Value += 10;
        }

        private void btn_PS_Cash_20_Click(object sender, EventArgs e)
        {
            nud_PS_CashReceived.Value += 20;
        }

        private void btn_PS_CalculateChange_Click(object sender, EventArgs e)
        {
            Decimal cartTotal = Settings.IC_DEF_CHOCOFUDGEPRICE * nud_IC_CartItem1_Quantity.Value + Settings.IC_DEF_AMERICANNUTSPRICE * nud_IC_CartItem2_Quantity.Value +
                Settings.IC_DEF_CHOCOCRACKLEFLINGOPRICE * nud_IC_CartItem3_Quantity.Value + Settings.IC_DEF_COOKIESANDWICHPRICE * nud_IC_CartItem4_Quantity.Value +
                Settings.IC_DEF_CHOCOLATEOVERLOADPRICE * nud_IC_CartItem5_Quantity.Value;

            lbl_PS_ChangePrice.Text = "" + Tools.CalculateChange((int)nud_PS_CashReceived.Value, (int)cartTotal) + " $";

            Settings.cashInDrawer += (int)cartTotal;
            Settings.overallSaleAmount += (int)cartTotal;
        }

        private void btn_ShowSalesDetails_Click(object sender, EventArgs e)
        {
            gbx_PS_SalesDetails.Visible = true;
            lbl_PS_CashInDrawerAmount.Text = "" + Settings.cashInDrawer + " $";
            lbl_PS_OverallSaleAmount.Text = "" + Settings.overallSaleAmount + " $";
        }
    }
}
