/*============================================================
 * Title    :   Assignment 5: Data Storage - Video Game Reviews
 * Name     :   Dev Mayurkumar Patel
 * Date     :   5 December 2024
 * Purpose  :   Game Class file
 *===========================================================*/

using Assignment05.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DBAL
{
    /// <summary>
    /// Game class method
    /// </summary>
    public class Game
    {
       
        #region Default Values

        // Default Values for all properties
        private const string DEFAULT_GENRE = "Genre";
        private const string DEFAULT_TITLE = "title";
        private string DEFAULT_DATE = DateTime.Now.ToString("yyyy-MM-dd");

        #endregion


        #region Static List

        // A List to store all games
        public static List<Game> games = new List<Game>();

        #endregion


        #region Properties

        /// <summary>
        /// Represents GameID property of Game class with getter and setter
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
                Boolean isUnique = true;
                foreach (Game game in games)
                {
                    if (value == game.GameID) { isUnique = false; }
                }
                if (isUnique)
                {
                    if (value > 0)
                    {
                        _gameID = value;
                    }
                    else throw new Exception("Game ID must be a positive number");
                }
                else throw new Exception("Provided game ID is not Unique");
            }
        }
        /// <summary>
        /// Represents Title property of Game class with getter and setter
        /// </summary>
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 100)
                {
                    _title = value.Trim();
                }
                else throw new Exception("Length of provided Title is not Valid");
            }
        }
        /// <summary>
        /// Represents Genre property of Game class with getter and setter
        /// </summary>
        private string _genre;
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 50)
                {
                    _genre = value.Trim();
                }
                else throw new Exception("Length of provided Genre is not Valid");
            }
        }
        /// <summary>
        /// Represents ReleaseDate property of Game class with getter and setter
        /// </summary>
        private string _releaseDate;
        public string ReleaseDate
        {
            get
            {
                return _releaseDate;
            }
            set
            {
                _releaseDate = value;
            }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Game()
        {
            SetDefault();
        }
        /// <summary>
        /// Perameterized Constructor
        /// </summary>
        /// <param name="gameID"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="releaseDate"></param>
        public Game(int gameID, string title, string genre, string releaseDate)
        {
            GameID = gameID;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

        #endregion


        #region Non-static method to set the default values using constants

        /// <summary>
        /// Non-Static Method to Set default values
        /// </summary>
        private void SetDefault()
        {
            Title = DEFAULT_TITLE;
            Genre = DEFAULT_GENRE;
            ReleaseDate = DEFAULT_DATE;
        }

        #endregion


        #region Static method

        /// <summary>
        /// Method to fill games list from database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void FillGames() 
        {
            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);

            try
            {
                connection.Open();
                SqlCommand command;

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM games";
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                games.Clear();
                while (reader.Read())
                {
                    Game game = new Game(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3).ToString("yyyy-MM-dd"));
                    games.Add(game);
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
        /// Method to find Game Class by Game ID
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public static Game FindGameById(int gameId)
        {
            foreach (Game game in games)
            {
                if (game.GameID == gameId) return game;
            }
            return null;
        }
        /// <summary>
        /// Method to delete game in database
        /// </summary>
        /// <param name="gameID"></param>
        /// <exception cref="Exception"></exception>
        public static void DeleteGame(int gameID)
        {
            string sql = "spDeleteGame";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GameID", gameID);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillGames();
                connection.Close();
            }
        }

        #endregion


        #region Instance methods to Insert or update Game

        /// <summary>
        /// Method to insert new game in database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void InsertGame()
        {
            string sql = "spInsertNewGame";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try 
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GameID", Tools.GetMaxID("Games", "GameID") + 1);
                command.Parameters.AddWithValue("@Title", this.Title);
                command.Parameters.AddWithValue("@Genre", this.Genre);
                command.Parameters.AddWithValue("@ReleaseDate", this.ReleaseDate);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillGames();
                connection.Close();
            }

        }
        /// <summary>
        /// Method to Update game in database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void UpdateGame()
        {
            string sql = "spUpdateGame";

            SqlConnection connection = new SqlConnection(Settings.Default.dbConnect);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GameID", this.GameID);
                command.Parameters.AddWithValue("@Title", this.Title);
                command.Parameters.AddWithValue("@Genre", this.Genre);
                command.Parameters.AddWithValue("@ReleaseDate", this.ReleaseDate);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FillGames();
                connection.Close();
            }

        }

        #endregion

    }
}
