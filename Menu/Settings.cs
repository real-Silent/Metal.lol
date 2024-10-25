using StupidTemplate.Classes;
using StupidTemplate.Menu;
using System;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient { colors = GetSolidGradient(new Color32(72, 72, 72, 255)) };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Color.black) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(Color.red)} // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        //public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);
        public static Font currentFont = Font.CreateDynamicFontFromOSFont("SimSun", 14);


        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;
        public static bool TopButtons = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 0.7f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 6;

        
    }
}
