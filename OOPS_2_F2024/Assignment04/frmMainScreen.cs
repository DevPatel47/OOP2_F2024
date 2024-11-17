/*============================================================
 * Title    :   Assignment 4: File IO and Exception Handling
 * Name     :   Dev Mayurkumar Patel
 * Date     :   15 November 2024
 * Purpose  :   Main Screen Class file
 *===========================================================*/


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
using System.Linq.Expressions;
using System.Diagnostics;

namespace Assignment04
{
    /// <summary>
    /// Main Form Class
    /// </summary>
    public partial class frmMainScreen : Form
    {
        // Stores PlayerProfile
        private PlayerProfile profile;
        /// <summary>
        /// Method to initialize form main
        /// </summary>
        public frmMainScreen()
        {
            InitializeComponent();
        }

        #region Custom Methods

        /// <summary>
        /// Method to Load and set Default Profile
        /// </summary>
        private void LoadDefaultProfile()
        {
            foreach (PlayerProfile profile in PlayerProfile.playerProfiles)
            {
                if (profile.IsDefaultProfile)
                {
                    int nameIndex = -1;
                    foreach (string profileName in cbo_profileName.Items)
                    {
                        nameIndex = nameIndex + 1;
                        if (profileName == null) cbo_profileName.SelectedIndex = -1;
                        else if (profileName == profile.ProfileName) cbo_profileName.SelectedIndex = nameIndex;

                    }
                }
            }
        }
        /// <summary>
        /// Method to Set Profile details on form
        /// </summary>
        private void SetProfileDetails()
        {
            // Set Input Device
            int inputSelectedIndex = -1;
            foreach (String inputDevice in cbo_inputDevice.Items)
            {
                inputSelectedIndex += 1;
                if (profile.InputDevice == null) cbo_inputDevice.SelectedIndex = -1;
                else if (profile.InputDevice == inputDevice) cbo_inputDevice.SelectedIndex = inputSelectedIndex;
            }
            // Set AutoJump
            rbn_autoJump_on.Checked = profile.AutoJump;
            rbn_autoJump_off.Checked = !profile.AutoJump;
            // Set Mouse Sensitivity
            nud_mouseSensitivity.Value = profile.MouseSensitivity;
            // Set Controller Sensitivity
            nud_controllerSensitivity.Value = profile.ControllerSensitivity;
            // Set Invert Y-Axis
            rbn_invertYAxis_on.Checked = profile.InvertYAxis;
            rbn_invertYAxis_off.Checked = !profile.InvertYAxis;
            // Set HUDD Transparency
            nud_HUDDTransparency.Value = profile.HuddTransparency;
            // Set Show coordinates
            rbn_showCoordinates_on.Checked = profile.ShowCoordinates;
            rbn_showCoordinates_off.Checked = !profile.ShowCoordinates;
            // Set Camera Prospective
            int cameraProsSelectedIndex = -1;
            foreach (String prospective in cbo_cameraProspective.Items)
            {
                cameraProsSelectedIndex += 1;
                if (profile.CameraPerspective == null) cbo_cameraProspective.SelectedIndex = -1;
                else if (profile.CameraPerspective == prospective) cbo_cameraProspective.SelectedIndex = cameraProsSelectedIndex;
            }
            // Set Brightness
            nud_brightness.Value = profile.Brightness;
            // Set Fancy Graphics
            rbn_fancyGraphics_on.Checked = profile.FancyGraphics;
            rbn_fancyGraphics_off.Checked = !profile.FancyGraphics;
            // Set V-Sync
            rbn_vSync_on.Checked = profile.VSync;
            rbn_vSync_off.Checked = !profile.VSync;
            // Set Fullscreen
            rbn_fullscreen_on.Checked = profile.Fullscreen;
            rbn_fullscreen_off.Checked = !profile.Fullscreen;
            // Set Render Distance
            nud_renderDistance.Value = profile.RenderDistance;
            // Set Field Of View
            nud_fieldOfView.Value = profile.FieldOfView;
            // Set Ray Tracing
            rbn_rayTracing_on.Checked = profile.RayTracing;
            rbn_rayTracing_off.Checked = !profile.RayTracing;
            // Set Upscaling
            rbn_upscaling_on.Checked = profile.Upscaling;
            rbn_upscaling_off.Checked = !profile.Upscaling;
            // Set Music
            tbr_music.Value = profile.Music;
            // Set Sound
            tbr_sound.Value = profile.Sound;

        }
        /// <summary>
        /// Method to set default settings
        /// </summary>
        private void SetDefaults()
        {

            cbo_profileName.SelectedIndex = -1;
            rbn_autoJump_on.Checked = false;
            rbn_autoJump_off.Checked = false;
            nud_mouseSensitivity.Value = 50;
            nud_controllerSensitivity.Value = 50;
            rbn_invertYAxis_on.Checked = false;
            rbn_invertYAxis_off.Checked = false;
            nud_HUDDTransparency.Value = 100;
            rbn_showCoordinates_on.Checked = false;
            rbn_showCoordinates_off.Checked = false;
            cbo_cameraProspective.SelectedIndex = -1;
            nud_brightness.Value = 50;
            rbn_fancyGraphics_on.Checked = false;
            rbn_fancyGraphics_off.Checked = false;
            rbn_vSync_on.Checked = false;
            rbn_vSync_off.Checked = false;
            rbn_fullscreen_on.Checked = false;
            rbn_fullscreen_off.Checked = false;
            nud_renderDistance.Value = 16;
            nud_fieldOfView.Value = 64;
            rbn_rayTracing_on.Checked = false;
            rbn_rayTracing_off.Checked = false;
            rbn_upscaling_on.Checked = false;
            rbn_upscaling_off.Checked = false;
            tbr_music.Value = 0;
            tbr_sound.Value = 0;

        }
        /// <summary>
        /// Method to populate profile names in combo box
        /// </summary>
        public void PopulateProfiles()
        {
            cbo_profileName.Items.Clear();
            foreach (PlayerProfile profile in PlayerProfile.playerProfiles)
            {
                cbo_profileName.Items.Add(profile.ProfileName);
            }
        }

        #endregion


        #region Event Methods

        /// <summary>
        /// Event Method for Create profile button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createNewProfile_Click(object sender, EventArgs e)
        {
            PlayerProfile newPlayerProfile = new PlayerProfile();
            frmEditScreen frm = new frmEditScreen(newPlayerProfile, true);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                SetDefaults();
                try
                {
                    PlayerProfile.readMinecraftSettingsFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Reading error");
                }
                PopulateProfiles();
                LoadDefaultProfile();
            }
        }
        /// <summary>
        /// Load Event for Main Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            // Show Splash Screen
            this.Hide();
            frmSplashScreen frm = new frmSplashScreen(this);
            frm.ShowDialog();
            // Set Defaults
            SetDefaults();
            try
            {
                PlayerProfile.readMinecraftSettingsFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reading error");
            }
            PopulateProfiles();
            LoadDefaultProfile();

        }
        /// <summary>
        /// Event method for edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (cbo_profileName.SelectedIndex == -1) MessageBox.Show("Please select the Player profile that you want to edit.", "Select Profile Notice");
            else if (cbo_profileName.SelectedIndex != -1)
            {
                frmEditScreen frm = new frmEditScreen(profile, false);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    SetDefaults();
                    try
                    {
                        PlayerProfile.readMinecraftSettingsFile();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Reading error");
                    }
                    PopulateProfiles();
                    LoadDefaultProfile();
                }
            }

        }
        /// <summary>
        /// Event method for Profile name combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_profileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_profileName.SelectedIndex == -1)
            {
                SetDefaults();
            }
            else
            {
                profile = PlayerProfile.FindPlayerProfileByName(cbo_profileName.Text);
                SetProfileDetails();
            }

        }
        /// <summary>
        /// Event method for Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        /// <summary>
        /// Event Method for Delete Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete the Profile?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PlayerProfile.playerProfiles.Remove(profile);
                cbo_profileName.SelectedIndex = -1;
                try
                {
                    PlayerProfile.writeInMinecraftSettingsFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Writing Error");
                }
                PopulateProfiles();
                LoadDefaultProfile();

            }

        }

        #endregion
      
    }
}
