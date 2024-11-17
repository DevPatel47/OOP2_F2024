/*============================================================
 * Title    :   Assignment 4: File IO and Exception Handling
 * Name     :   Dev Mayurkumar Patel
 * Date     :   15 November 2024
 * Purpose  :   PlayerProfile Class file
 *===========================================================*/


using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    /// <summary>
    /// PlayerProfile Class
    /// </summary>
    public class PlayerProfile
    {

        #region Class Scope Variable

        // Defaults
        private static string DEFAULT_PROFILE_NAME = "Player";
        private const string DEFAULT_INPUT_DEVICE= "Keyboard";
        private const Boolean DEFAULT_AUTO_JUMP = true;
        private const int DEFAULT_MOUSE_SENSITIVITY = 50;
        private const int DEFAULT_CONTROLLER_SENSITIVITY = 50;
        private const Boolean DEFAULT_INVERT_Y_AXIS = false;
        private const int DEFAULT_BRIGHTNESS = 50;
        private const Boolean DEFAULT_FANCY_GRAPHICS = true;
        private const Boolean DEFAULT_V_SYNC = true;
        private const Boolean DEFAULT_FULLSCREEN = false;
        private const int DEFAULT_RENDER_DISTANCE = 16;
        private const int DEFAULT_FOV = 64;
        private const Boolean DEFAULT_RAY_TRACING = false;
        private const Boolean DEFAULT_UPSCALING = false;
        private const int DEFAULT_MUSIC = 100;
        private const int DEFAULT_SOUND = 100;
        private const int DEFAULT_HUDD_TRANSPARANCY = 100;
        private const Boolean DEFAULT_SHOW_COORDINATES = false;
        private string DEFAULT_CAMERA_PERSPECTIVE = "First-person";
        private const Boolean DEFAULT_IS_DEFAULT_PROFILE = false;
        // Stores Profiles
        public static List<PlayerProfile> playerProfiles = new List<PlayerProfile>();

        #endregion


        #region Properties

        /// <summary>
        /// Represents ProfileName property of PlayerProfile with getter and setter
        /// </summary>
        private string _profileName;
        public string ProfileName 
        {
            get
            {
                return _profileName;
            }
            set
            {

                if (value.Trim().Length >= 2 && value.Trim().Length <= 30)
                {
                    Boolean isUnique = true;
                    foreach (PlayerProfile profile in playerProfiles)
                    {
                        if (value.Trim() == profile.ProfileName.Trim()) isUnique = false;
                    }
                    if (isUnique) _profileName = value.Trim();
                    else throw new Exception("Profile Name is not unique");

                }
                else throw new Exception("Profile Name is not valid");
            }
        }
        /// <summary>
        /// Represents InputDevice property of PlayerProfile with getter and setter
        /// </summary>
        private string _inputDevice;
        public string InputDevice 
        {
            get
            {
                return _inputDevice;
            }
            set
            {
                if (value.ToLower() == "keyboard" || value.ToLower() == "controller" || value.ToLower() == "touch")
                {
                    _inputDevice = value;
                }
                else throw new Exception("Invalid Input Device");
            }
        }
        /// <summary>
        /// Represents AutoJump property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean AutoJump;
        /// <summary>
        /// Represents MouseSensitivity property of PlayerProfile with getter and setter
        /// </summary>
        private int _mouseSensitivity;
        public int MouseSensitivity 
        {
            get
            {
                return _mouseSensitivity;
            }
            set
            {
                if (value >= 30 && value <= 70)
                {
                    _mouseSensitivity = value;
                }
                else throw new Exception("Invalid Mouse Sensitivity");
            }
        }
        /// <summary>
        /// Represents ControllerSensitivity property of PlayerProfile with getter and setter
        /// </summary>
        private int _controllerSensitivity;
        public int ControllerSensitivity 
        {
            get
            {
                return _controllerSensitivity;
            }
            set
            {
                if (value >= 30 && value <= 70)
                {
                    _controllerSensitivity = value;
                }
                else throw new Exception("Invalid Controller Sensitivity");
            }
        }
        /// <summary>
        /// Represents InvertYAxis property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean InvertYAxis;
        /// <summary>
        /// Represents Brightness property of PlayerProfile with getter and setter
        /// </summary>
        private int _brightness;
        public int Brightness 
        {
            get
            {
                return _brightness;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _brightness = value;
                }
                else throw new Exception("Invalid Brightness");
            }
        }
        /// <summary>
        /// Represents FancyGraphics property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean FancyGraphics;
        /// <summary>
        /// Represents VSync property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean VSync;
        /// <summary>
        /// Represents Fullscreen property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean Fullscreen;
        /// <summary>
        /// Represents RenderDistance property of PlayerProfile with getter and setter
        /// </summary>                
        private int _renderDistance;
        public int RenderDistance 
        {
            get
            {
                return _renderDistance;
            }
            set
            {
                if (value >= 4 && value <= 128)
                {
                    _renderDistance = value;
                }
                else throw new Exception("Invalid Render Distance");
            }
        }
        /// <summary>
        /// Represents FieldOfView property of PlayerProfile with getter and setter
        /// </summary>
        private int _fieldOfView;
        public int FieldOfView 
        {
            get
            {
                return _fieldOfView;
            }
            set
            {
                if (value >= 60 && value <= 90)
                {
                    _fieldOfView = value;
                }
                else throw new Exception("Invalid FOV");
            }
        }
        /// <summary>
        /// Represents RayTracing property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean RayTracing;
        /// <summary>
        /// Represents Upscaling property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean Upscaling;
        /// <summary>
        /// Represents Music property of PlayerProfile with getter and setter
        /// </summary>
        private int _music;
        public int Music 
        {
            get
            {
                return _music;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _music = value;
                }
                else throw new Exception("Invalid Music Value");
            }
        }
        /// <summary>
        /// Represents Sound property of PlayerProfile with getter and setter
        /// </summary>
        private int _sound;
        public int Sound 
        {
            get
            {
                return _sound;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _sound = value;
                }
                else throw new Exception("Invalid Sound Value");
            }
        }
        /// <summary>
        /// Represents HuddTransparency property of PlayerProfile with getter and setter
        /// </summary>
        private int _huddTransparency;
        public int HuddTransparency 
        {
            get
            {
                return _huddTransparency;
            }
            set
            {
                if (value >= 25 && value <= 100)
                {
                    _huddTransparency = value;
                }
                else throw new Exception("Invalid HUDD Transparency");
            }
        }
        /// <summary>
        /// Represents ShowCoordinates property of PlayerProfile with getter and setter
        /// </summary>
        public Boolean ShowCoordinates;
        /// <summary>
        /// Represents CameraPerspective property of PlayerProfile with getter and setter
        /// </summary>
        private string _cameraPerspective;
        public string CameraPerspective 
        {
            get
            {
                return _cameraPerspective;
            }
            set
            {
                if (value.ToLower() == "first-person" || value.ToLower() == "third-person front" || value.ToLower() == "third-person back")
                {
                    _cameraPerspective = value;
                }
                else throw new Exception("Invalid Camera Perspective");
            }
        }
        /// <summary>
        /// Represents IsDefaultProfile property of PlayerProfile with getter and setter
        /// </summary>
        private Boolean _isDefaultProfile;
        public Boolean IsDefaultProfile 
        {
            get
            {
                return _isDefaultProfile;
            }
            set
            {
                if (value == true)
                {
                    foreach (PlayerProfile profile in playerProfiles)
                    {
                        profile.IsDefaultProfile = false;
                    }
                }
                _isDefaultProfile = value;
            }
        }

        #endregion


        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlayerProfile() 
        {
            SetDefault();
        }
        /// <summary>
        /// Perameterized Constructor
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="inputDevice"></param>
        /// <param name="autoJump"></param>
        /// <param name="mouseSensitivity"></param>
        /// <param name="controllerSensitivity"></param>
        /// <param name="invertYAxis"></param>
        /// <param name="brightness"></param>
        /// <param name="fancyGraphics"></param>
        /// <param name="vSync"></param>
        /// <param name="fullscreen"></param>
        /// <param name="renderDistance"></param>
        /// <param name="fieldOfView"></param>
        /// <param name="rayTracing"></param>
        /// <param name="upscaling"></param>
        /// <param name="music"></param>
        /// <param name="sound"></param>
        /// <param name="huddTransparency"></param>
        /// <param name="showCoordinates"></param>
        /// <param name="cameraPerspective"></param>
        /// <param name="isDefaultProfile"></param>
        public PlayerProfile(string playerName, string inputDevice, Boolean autoJump, int mouseSensitivity,
            int controllerSensitivity, Boolean invertYAxis, int brightness, Boolean fancyGraphics, Boolean vSync,
            Boolean fullscreen, int renderDistance, int fieldOfView, Boolean rayTracing, Boolean upscaling, int music,
            int sound, int huddTransparency, Boolean showCoordinates, string cameraPerspective, Boolean isDefaultProfile) 
        {
            ProfileName = playerName;
            InputDevice = inputDevice;
            AutoJump = autoJump;
            MouseSensitivity = mouseSensitivity;
            ControllerSensitivity = controllerSensitivity;
            InvertYAxis = invertYAxis;
            Brightness = brightness;
            FancyGraphics = fancyGraphics;
            VSync = vSync;
            Fullscreen = fullscreen;
            RenderDistance = renderDistance;
            FieldOfView = fieldOfView;
            RayTracing = rayTracing;
            Upscaling = upscaling;
            Music = music;
            Sound = sound;
            HuddTransparency = huddTransparency;
            ShowCoordinates = showCoordinates;
            CameraPerspective = cameraPerspective;
            IsDefaultProfile = isDefaultProfile;
        }

        #endregion


        #region Non-static method to set the default values using constants

        /// <summary>
        /// Non-Static Method to Set default values
        /// </summary>
        private void SetDefault()
        {

            InputDevice = DEFAULT_INPUT_DEVICE;
            AutoJump = DEFAULT_AUTO_JUMP;
            MouseSensitivity = DEFAULT_MOUSE_SENSITIVITY;
            ControllerSensitivity = DEFAULT_CONTROLLER_SENSITIVITY;
            InvertYAxis = DEFAULT_INVERT_Y_AXIS;
            Brightness = DEFAULT_BRIGHTNESS;
            FancyGraphics = DEFAULT_FANCY_GRAPHICS;
            VSync = DEFAULT_V_SYNC;
            Fullscreen = DEFAULT_FULLSCREEN;
            RenderDistance = DEFAULT_RENDER_DISTANCE;
            FieldOfView = DEFAULT_FOV;
            RayTracing = DEFAULT_RAY_TRACING;
            Upscaling = DEFAULT_UPSCALING;
            Music = DEFAULT_MUSIC;
            Sound = DEFAULT_SOUND;
            HuddTransparency = DEFAULT_HUDD_TRANSPARANCY;
            ShowCoordinates = DEFAULT_SHOW_COORDINATES;
            CameraPerspective = DEFAULT_CAMERA_PERSPECTIVE;
            IsDefaultProfile = DEFAULT_IS_DEFAULT_PROFILE;

        }

        #endregion


        #region Static Methods

        /// <summary>
        /// Method to read a Settings file 
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void readMinecraftSettingsFile()
        {

            try
            {

                string filePath = "C:\\COSC_OOP_2\\OOP2_F2024\\OOPS_2_F2024\\Assignment04\\minecraftSettings.csv";
                string[] lines = File.ReadAllLines(filePath);
                playerProfiles.Clear();
                foreach (string line in lines)
                {

                    string[] properties = line.Split(',');

                    PlayerProfile.playerProfiles.Add(new PlayerProfile(properties[0], properties[1], Boolean.Parse(properties[2]), int.Parse(properties[3]), int.Parse(properties[4]),
                        Boolean.Parse(properties[5]), int.Parse(properties[6]), Boolean.Parse(properties[7]), Boolean.Parse(properties[8]), Boolean.Parse(properties[9]), int.Parse(properties[10]),
                        int.Parse(properties[11]), Boolean.Parse(properties[12]), Boolean.Parse(properties[13]), int.Parse(properties[14]), int.Parse(properties[15]), int.Parse(properties[16]),
                        Boolean.Parse(properties[17]), properties[18], Boolean.Parse(properties[19])));

                }

            }
            catch
            {
                throw new Exception("Error while reading Settings File");
            }

        }
        /// <summary>
        /// Method to write a Settings file
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void writeInMinecraftSettingsFile()
        {
            try
            {
                string filePath = "C:\\COSC_OOP_2\\OOP2_F2024\\OOPS_2_F2024\\Assignment04\\minecraftSettings.csv";
                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    foreach (PlayerProfile profile in playerProfiles)
                    {
                        writer.WriteLine($"{profile.ProfileName},{profile.InputDevice},{profile.AutoJump},{profile.MouseSensitivity},{profile.ControllerSensitivity}," +
                            $"{profile.InvertYAxis},{profile.Brightness},{profile.FancyGraphics},{profile.VSync},{profile.Fullscreen},{profile.RenderDistance}," +
                            $"{profile.FieldOfView},{profile.RayTracing},{profile.Upscaling},{profile.Music},{profile.Sound},{profile.HuddTransparency}," +
                            $"{profile.ShowCoordinates},{profile.CameraPerspective},{profile.IsDefaultProfile}");
                    }
                }

            }
            catch
            {
                throw new Exception("Error while writing the Settings");
            }
        }
        /// <summary>
        /// Method to find Profile by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static PlayerProfile FindPlayerProfileByName(string name)
        {
            foreach (PlayerProfile profile in playerProfiles)
            {
                if (profile.ProfileName == name) return profile;
            }
            return null;
        }

        #endregion

    }
}
