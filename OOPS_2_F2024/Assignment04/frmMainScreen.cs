using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace Assignment04
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplashScreen frm = new frmSplashScreen(this);
            frm.ShowDialog();
            PlayerProfile.readMinecraftSettingsFile();
            foreach (PlayerProfile profile in PlayerProfile.playerProfiles)
            {
                cbo_profileName.Items.Add(profile.ProfileName);
            }
        }

        private void setProfileDetails() 
        {
            
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_createNewProfile_Click(object sender, EventArgs e)
        {
            PlayerProfile newPlayerProfile = new PlayerProfile();
            frmEditScreen frm = new frmEditScreen(newPlayerProfile);
            frm.ShowDialog();
        }

        
    }
}
