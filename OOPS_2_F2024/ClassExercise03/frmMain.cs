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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleaguesDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet.teams);

        }

        private void cbo_teams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
