using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace StupidTemplate.Mods
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 1;
        }

        public static void MenuSettings()
        {
            buttonsType = 2;
        }

        public static void movement()
        {
            buttonsType = 3;
        }

        public static void Visual()
        {
            buttonsType = 4;
        }

        public static void Sound()
        {
            buttonsType = 5;
        }

        public static void Important()
        {
            buttonsType = 6;
        }

        public static void Spam()
        {
            buttonsType = 7;
        }

        public static void Animals()
        {
            buttonsType = 8;
        }

        public static void Rig()
        {
            buttonsType = 9;
        }
        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }

        public static void TriggerPagesOn()
        {
            TopButtons = true;
        }
        public static void TriggerPagesOff()
        {
            TopButtons = false;
        }
    }
}
