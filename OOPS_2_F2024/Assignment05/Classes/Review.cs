/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Review Class file
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment05.Properties;

namespace DBAL
{
    /// <summary>
    /// Review class method
    /// </summary>
    public class Review
    {

        #region Default Values

        // Default Values for all properties
        private const int DEFAULT_RATING = 1;
        private const string DEFAULT_REVIEW_TEXT = "No review provided.";
        private string DEFAULT_REVIEW_DATE = DateTime.Now.ToString("yyyy-MM-dd");

        #endregion


        #region Static List

        // A List to store all reviews
        public static List<Review> reviews = new List<Review>();

        #endregion


        #region Properties

        /// <summary>
        /// Represents ReviewID property of Review class with getter and setter
        /// </summary>
        private int _reviewID;
        public int ReviewID
        {
            get 
            { 
                return _reviewID; 
            }
            set
            {
                Boolean isUnique = true;
                foreach (Review review in reviews)
                {
                    if (value == review.ReviewID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _reviewID = value;
                    }
                    else throw new Exception("Review ID must be a positive number");
                }
                else throw new Exception("Provided Review ID is not Unique");
            }
        }
        /// <summary>
        /// Represents GameID property of Review class with getter and setter
        /// </summary>
        private int _gameID;
        public int GameID
        {
            get 
            {
                return _gameID; 
            }
            set
            {
                if (value > 0)
                {
                    Boolean isGameExists = false;
                    foreach (Game game in Game.games)
                    {
                        if (value == game.GameID) { isGameExists = true; }
                    }
                    if (isGameExists)
                    {
                        _gameID = value;
                    }
                    else throw new Exception("Provided game ID does not exist");
                }
                else
                {
                    throw new Exception("Game ID must be a positive number.");
                }
            }
        }
        /// <summary>
        /// Represents ReviewerID property of Review class with getter and setter
        /// </summary>
        private int _reviewerID;
        public int ReviewerID
        {
            get 
            { 
                return _reviewerID; 
            }
            set
            {
                if (value > 0)
                {
                    Boolean isReviewerExists = false;
                    foreach (User user in User.users)
                    {
                        if (value == user.UserID) { isReviewerExists = true; }
                    }
                    if (isReviewerExists)
                    {
                        _reviewerID = value;
                    }
                    else throw new Exception("Provided Reviewer ID does not exist");
                }
                else
                {
                    throw new Exception("Reviewer ID must be a positive number.");
                }
            }
        }
        /// <summary>
        /// Represents Rating property of Review class with getter and setter
        /// </summary>
        private int _rating;
        public int Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("Rating must be between 1 and 10.");
                }
            }
        }
        /// <summary>
        /// Represents ReviewText property of Review class with getter and setter
        /// </summary>
        private string _reviewText;
        public string ReviewText
        {
            get 
            { 
                return _reviewText; 
            }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 500)
                {
                    _reviewText = value.Trim();
                }
                else
                {
                    throw new Exception("Review text must be non-empty and up to 500 characters.");
                }
            }
        }
        /// <summary>
        /// Represents ReviewDate property of Review class with getter and setter
        /// </summary>
        private string _reviewDate;
        public string ReviewDate
        {
            get 
            { 
                return _reviewDate; 
            }
            set
            {
                _reviewDate = value;
                
            }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Review()
        {
            SetDefault();
        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="reviewID"></param>
        /// <param name="gameID"></param>
        /// <param name="reviewerID"></param>
        /// <param name="rating"></param>
        /// <param name="reviewText"></param>
        /// <param name="reviewDate"></param>
        public Review(int reviewID, int gameID, int reviewerID, int rating, string reviewText, string reviewDate)
        {
            ReviewID = reviewID;
            GameID = gameID;
            ReviewerID = reviewerID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }

        #endregion


        #region Non-static method to set the default values using constants

        /// <summary>
        /// Method to set the default values using constants
        /// </summary>
        private void SetDefault()
        {
            Rating = DEFAULT_RATING;
            ReviewText = DEFAULT_REVIEW_TEXT;
            ReviewDate = DEFAULT_REVIEW_DATE;
        }

        #endregion


        #region Static Methods

        /// <summary>
        /// <summary>
        /// Method to fill Reviews list from database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void FillReviews()
        {
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Reviews", connection);
                SqlDataReader reader = command.ExecuteReader();

                reviews.Clear();
                while (reader.Read())
                {
                    Review review = new Review(
                        reader.GetInt32(0),  // ReviewID
                        reader.GetInt32(1),  // GameID
                        reader.GetInt32(2),  // ReviewerID
                        reader.GetInt32(3),  // Rating
                        reader.GetString(4), // ReviewText
                        reader.GetDateTime(5).ToString("yyyy-MM-dd") // ReviewDate
                    );
                    reviews.Add(review);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Method to find review by id
        /// </summary>
        /// <param name="reviewID"></param>
        /// <returns></returns>
        public static Review FindReviewById(int reviewID)
        {
            foreach (Review review in reviews)
            {
                if (review.ReviewID == reviewID) return review;
            }
            return null;
        }
        /// <summary>
        /// Method to delete review
        /// </summary>
        /// <param name="reviewID"></param>
        /// <exception cref="Exception"></exception>
        public static void DeleteReview(int reviewID)
        {
            string sql = "spDeleteReview";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReviewID", reviewID);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillReviews();
                connection.Close();
            }
        }

        #endregion


        #region Instance methods to Insert or update Game

        /// <summary>
        /// Method to insert new review
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void InsertReview()
        {
            string sql = "spInsertNewReview";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReviewID", Tools.GetMaxID("Reviews", "ReviewID") + 1);
                command.Parameters.AddWithValue("@GameID", this.GameID);
                command.Parameters.AddWithValue("@UserID", this.ReviewerID);
                command.Parameters.AddWithValue("@Rating", this.Rating);
                command.Parameters.AddWithValue("@ReviewText", this.ReviewText);
                command.Parameters.AddWithValue("@ReviewDate", this.ReviewDate);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillReviews();
                connection.Close();
            }

        }
        /// <summary>
        /// Method to update review
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void UpdateReview()
        {
            string sql = "spUpdateReview";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReviewID", this.ReviewID);
                command.Parameters.AddWithValue("@GameID", this.GameID);
                command.Parameters.AddWithValue("@ReviewerID", this.ReviewerID);
                command.Parameters.AddWithValue("@Rating", this.Rating);
                command.Parameters.AddWithValue("@ReviewText", this.ReviewText);
                command.Parameters.AddWithValue("@ReviewDate", this.ReviewDate);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillReviews();
                connection.Close();
            }

        }

        #endregion

    }
}

