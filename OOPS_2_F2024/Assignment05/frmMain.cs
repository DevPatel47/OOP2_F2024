/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Main form class file
 *===========================================================*/

using Assignment05.Properties;
using DBAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05
{
    /// <summary>
    /// Main form class method
    /// </summary>
    public partial class frmMain : Form
    {
        // Stores User
        public User user;
        private int tempGameId;
        /// <summary>
        /// Method to initialize form
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            DBAL.Game.FillGames();
            DBAL.User.FillUsers();
            DBAL.Review.FillReviews();
        }

        #region Event Methods

        /// <summary>
        /// Form Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();

            // TODO: This line of code loads data into the 'vgr_dts_reviews.Reviews' table. You can move, or remove it, as needed.
            this.reviewsTableAdapter.Fill(this.vgr_dts_reviews.Reviews);
            // TODO: This line of code loads data into the 'vgr_dts_Games.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.vgr_dts_games.Games);

            frmLogin frm = new frmLogin(this);
            frm.ShowDialog();
            if (user != null) tss_lbl_UserDetails.Text = user.ToString();

        }
        /// <summary>
        /// Method to load all reviews of a game on click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_games_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = dgv_games.SelectedCells[0].RowIndex;
                int selectedGameId = int.Parse(dgv_games.Rows[rowindex].Cells[0].Value.ToString());
                this.gameReviewsTableAdapter.Fill(this.vgr_dts_reviews.GameReviews, selectedGameId);
                tempGameId = selectedGameId;
            }
            catch { MessageBox.Show("Game ID must be an Integer", "Invalid selected value"); }

        }
        /// <summary>
        /// Method to exit on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        /// <summary>
        /// method to add review on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addReview_Click(object sender, EventArgs e)
        {
            DBAL.Review review = new DBAL.Review();
            try
            {
                review.GameID = tempGameId;
                review.ReviewerID = user.UserID;
                review.Rating = tbr_Rating.Value;
                review.ReviewText = tbx_Review.Text;
                review.ReviewDate = DateTime.Now.ToString("yyyy-MM-dd");
                review.InsertReview();
                this.gameReviewsTableAdapter.Fill(this.vgr_dts_reviews.GameReviews, tempGameId);
                MessageBox.Show("Review Successfully Added", "Review Added");
            }
            catch
            {
                MessageBox.Show("Provided Review is not valid, Please try again!!", "Invalid Review");
            }
            finally
            {
                Review.FillReviews();
            }
        }
        /// <summary>
        /// Method to delete review on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteReview_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgv_reviews.SelectedCells[0].RowIndex;
                int selectedReviewId = int.Parse(dgv_reviews.Rows[rowindex].Cells[0].Value.ToString());
                Review.DeleteReview(selectedReviewId);
                this.gameReviewsTableAdapter.Fill(this.vgr_dts_reviews.GameReviews, tempGameId);

            }
            catch { MessageBox.Show("Review ID must be an Integer", "Invalid selected value"); }

        }
        /// <summary>
        /// Method to logout user on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ts_User_logOut_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }
        /// <summary>
        /// Method to delete user on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void ts_user_deleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User?", "Delete User Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string sql = "spDeleteUser";

                SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userID", user.UserID);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    User.FillUsers();
                    connection.Close();
                }
                frmMain_Load(sender, e);
            }
        }
        /// <summary>
        /// Method to show developer details on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ts_about_aboutDeveloper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nName : Dev Mayurkumar Patel" +
                "\nStudent ID : 100921283" +
                "\nCourse : COSC-2100-04-OOP2", "About Developer");
            
        }

        #endregion

    }
}
