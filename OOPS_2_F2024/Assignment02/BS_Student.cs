/*============================================================
 * Title    :   Assignment - 2 Battleship
 * Name     :   Dev Mayurkumar Patel
 * Date     :   11 October 2024
 * Purpose  :   Partial class file, extending BS class
 *===========================================================*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02
{   
    /// <summary>
    /// Partial Battle Ship "BS" class
    /// </summary>
    public static partial class BS 
    {   
        /// <summary>
        /// Method to clear Boat Position
        /// </summary>
        public static void ClearBoatPosition() 
        {
            for (int x = 0; x < MAX_BOARD_SIZE; x++)
            {
                for (int y = 0; y < MAX_BOARD_SIZE; y++)
                {
                    boatPositions[x, y] = Boats.NoBoat; // Set each position to NoBoat
                }
            }

        }

        /// <summary>
        /// Method to clear board status
        /// </summary>
        public static void ClearBoardStatus()
        {
            for (int x = 0; x < MAX_BOARD_SIZE; x++)
            {
                for (int y = 0; y < MAX_BOARD_SIZE; y++)
                {
                    board[x, y] = BoardStatus.Empty; // Set each position to NoBoat
                }
            }
        }

        /// <summary>
        /// Method to show boats on board
        /// </summary>
        public static void DisplayBoats()
        {
            for (int y = 0; y < Settings.DEF_NUMSQUARES; y++)
            {
                for (int x = 0; x < Settings.DEF_NUMSQUARES; x++)
                {
                    System.Windows.Forms.Button button = Settings.buttons[x, y];
                    if (BS.boatPositions[x, y] != Boats.NoBoat)
                    {
                        button.BackColor = Color.Orange;

                    }
                }
            }
        }

        /// <summary>
        /// Method to perform action which are required on launching missile
        /// </summary>
        /// <param name="btn"></param>
        public static void LaunchMissile(System.Windows.Forms.Button btn)
        {
            for (int y = 0; y < Settings.DEF_NUMSQUARES; y++)
            {
                for (int x = 0; x < Settings.DEF_NUMSQUARES; x++)
                {
                    if (btn == Settings.buttons[x, y])
                    {
                        if (BS.boatPositions[x, y] != Boats.NoBoat)
                        {
                            btn.BackColor = Color.Red;
                            SoundPlayer soundPlayer = new SoundPlayer("D:\\COSC_OOP_2\\OOP2_F2024\\OOPS_2_F2024\\Assignment02\\drowning-34415-[AudioTrimmer.com].wav");
                            soundPlayer.Play();
                            BS.board[x, y] = BoardStatus.Hit;
                            if (BS.boatPositions[x, y] == Boats.Carrier) { Settings.carrierValue++; }
                            if (BS.boatPositions[x, y] == Boats.Battleship) { Settings.battleshipValue++; }
                            if (BS.boatPositions[x, y] == Boats.Submarine) { Settings.submarineValue++; }
                            if (BS.boatPositions[x, y] == Boats.Cruiser) { Settings.cruiserValue++; }
                            if (BS.boatPositions[x, y] == Boats.Destroyer) { Settings.destroyerValue++; }
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                            SoundPlayer soundPlayer = new SoundPlayer("D:\\COSC_OOP_2\\OOP2_F2024\\OOPS_2_F2024\\Assignment02\\big-bubble-1-169075.wav");
                            soundPlayer.Play();
                            BS.board[x, y] = BoardStatus.Miss;
                        }
                    }
                }
            }
            btn.Enabled = false;
            Settings.turnCount++;
            
        }
    }
}
