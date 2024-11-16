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
        // Stores Profiles
        public static List<PlayerProfile> playerProfiles = new List<PlayerProfile>();

        #endregion


        #region Properties

        private string _profileName;
        public string ProfileName 
        {
            get
            {
                return _profileName;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 30)
                {
                    _profileName = value;
                }
            }
        }

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
            }
        }

        public Boolean AutoJump;

        private int _mouseSensitivity;
        public int MouseSensitivity 
        {
            get
            {
                return _mouseSensitivity;
            }
            set
            {
                if (value >= 30 && value <=70)
                {
                    _mouseSensitivity = value;
                }
            }
        }

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
            }
        }

        public Boolean InvertYAxis;

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
            }
        }

        public Boolean FancyGraphics;
        public Boolean VSync;
        public Boolean Fullscreen;
                
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
            }
        }
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
            }
        }

        public Boolean RayTracing;
        public Boolean Upscaling;

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
            }
        }
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
            }
        }
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
            }
        }

        public Boolean ShowCoordinates;

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
            }
        }

        #endregion


        #region Constructor

        public PlayerProfile() 
        {
            SetDefault();
        }

        public PlayerProfile(string playerName, string inputDevice, Boolean autoJump, int mouseSensitivity,
            int controllerSensitivity, Boolean invertYAxis, int brightness, Boolean fancyGraphics, Boolean vSync,
            Boolean fullscreen, int renderDistance, int fieldOfView, Boolean rayTracing, Boolean upscaling, int music,
            int sound, int huddTransparency, Boolean showCoordinates, string cameraPerspective) 
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
        }

        #endregion


        #region Non-static method to set the default values using constants

        /// <summary>
        /// Non-Static Method to Set default values
        /// </summary>
        private void SetDefault()
        {            
            ProfileName = DEFAULT_PROFILE_NAME;
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
        }

        #endregion


        public static void readMinecraftSettingsFile()
        {

            try
            {

                string filePath = "C:\\COSC_OOP_2\\OOP2_F2024\\OOPS_2_F2024\\Assignment04\\minecraftSettings.csv";
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {

                    string[] properties = line.Split(',');

                    PlayerProfile.playerProfiles.Add(new PlayerProfile(properties[0], properties[1], Boolean.Parse(properties[2]), int.Parse(properties[3]), int.Parse(properties[4]),
                        Boolean.Parse(properties[5]), int.Parse(properties[6]), Boolean.Parse(properties[7]), Boolean.Parse(properties[8]), Boolean.Parse(properties[9]), int.Parse(properties[10]),
                        int.Parse(properties[11]), Boolean.Parse(properties[12]), Boolean.Parse(properties[13]), int.Parse(properties[14]), int.Parse(properties[15]), int.Parse(properties[16]),
                        Boolean.Parse(properties[17]), properties[18]));
                    
                }

            }
            catch
            {
                throw new FileLoadException();
            }

        }

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
                            $"{profile.ShowCoordinates},{profile.CameraPerspective}");
                    }
                }

            }
            catch
            {
                throw new FileLoadException();
            }
        }
    }
}
