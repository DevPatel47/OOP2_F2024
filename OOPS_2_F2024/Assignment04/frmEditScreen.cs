/*============================================================
 * Title    :   Assignment 4: File IO and Exception Handling
 * Name     :   Dev Mayurkumar Patel
 * Date     :   15 November 2024
 * Purpose  :   Editor Screen Class file
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

namespace Assignment04
{
    /// <summary>
    /// Editor Form Class
    /// </summary>
    public partial class frmEditScreen : Form
    {
        // Stores Profile
        PlayerProfile profile;
        // Stores Profile status
        Boolean isProfileNew;
        // Stores Profile Name
        String playerRecentName = "";
        /// <summary>
        /// Method to initialize Editor Form
        /// </summary>
        /// <param name="playerProfile"></param>
        /// <param name="isNewProfile"></param>
        public frmEditScreen(PlayerProfile playerProfile, Boolean isNewProfile)
        {
            InitializeComponent();
            profile = playerProfile;
            setProfileDetails();
            isProfileNew = isNewProfile;
            if (!isNewProfile ) playerRecentName = profile.ProfileName;
        }


        #region Custom Methods

        /// <summary>
        /// Method to set profile values on form
        /// </summary>
        private void setProfileDetails()
        {
            // Set Name
            tbx_profileName.Text = profile.ProfileName;
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
            // Set Is Default Profile
            cbx_setDefault.Checked = profile.IsDefaultProfile;

        }

        #endregion


        #region Event Methods

        /// <summary>
        /// Event method for save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_profileName.Text.Trim() != playerRecentName.Trim()) profile.ProfileName = tbx_profileName.Text;
                profile.InputDevice = cbo_inputDevice.SelectedItem.ToString();
                profile.AutoJump = rbn_autoJump_on.Checked;
                profile.MouseSensitivity = (int)nud_mouseSensitivity.Value;
                profile.ControllerSensitivity = (int)nud_controllerSensitivity.Value;
                profile.InvertYAxis = rbn_invertYAxis_on.Checked;
                profile.HuddTransparency = (int)nud_HUDDTransparency.Value;
                profile.ShowCoordinates = rbn_showCoordinates_on.Checked;
                profile.CameraPerspective = cbo_cameraProspective.SelectedItem?.ToString();
                profile.Brightness = (int)nud_brightness.Value;
                profile.FancyGraphics = rbn_fancyGraphics_on.Checked;
                profile.VSync = rbn_vSync_on.Checked;
                profile.Fullscreen = rbn_fullscreen_on.Checked;
                profile.RenderDistance = (int)nud_renderDistance.Value;
                profile.FieldOfView = (int)nud_fieldOfView.Value;
                profile.RayTracing = rbn_rayTracing_on.Checked;
                profile.Upscaling = rbn_upscaling_on.Checked;
                profile.Music = tbr_music.Value;
                profile.Sound = tbr_sound.Value;
                profile.IsDefaultProfile = cbx_setDefault.Checked;

                if (!isProfileNew)
                {
                    PlayerProfile.playerProfiles.Remove(PlayerProfile.FindPlayerProfileByName(playerRecentName));

                }
                PlayerProfile.playerProfiles.Add(profile);
                try
                {
                    PlayerProfile.writeInMinecraftSettingsFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Writing Error");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save profile, Please try again!!", "Problem while saving");
            }
        }
        /// <summary>
        /// Method to exit application on a click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }
        #endregion
                
    }
}
