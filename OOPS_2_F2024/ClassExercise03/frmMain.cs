/* **************************************
* COSC2100 Section 4 F2024
* Dev Mayurkumar Patel
* Nov 22, 2024
* Main Form Class File
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

namespace ClassExercise03
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// To initialize form
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form load event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleaguesDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet.teams);
            if (cbo_teams.SelectedItem != null)
            {
                int teamValue = (int)cbo_teams.SelectedValue;
                this.teamPlayersTableAdapter.FillPlayers(this.sportleaguesDataSet.TeamPlayers, teamValue);

            }
        }
        /// <summary>
        /// Combo box index change event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_teams.SelectedItem != null) 
            {
                int teamValue = (int)cbo_teams.SelectedValue;
                this.teamPlayersTableAdapter.FillPlayers(this.sportleaguesDataSet.TeamPlayers, teamValue);

            }
        }
    }
}
