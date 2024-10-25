using Metal.lol.Mods;
using Metal.lol.Mods.RPC;
using Photon.Pun;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    /*
    ALL COMMENTS ARE SILENT'S (ME) OR ASTEROIDS (@asteroidrealaccount) TO CHECK WHERE STUFF IS AND MORE
    */
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.movement(), toolTip = "Opens the movement mods for the menu", isTogglable = false},
                new ButtonInfo { buttonText = "Visual", method =() => SettingsMods.Visual(), toolTip = "Opens the Visual mods for the menu", isTogglable = false},
                new ButtonInfo { buttonText = "Sound", method =() => SettingsMods.Sound(), toolTip = "Opens the Visual mods for the menu", isTogglable = false},
                new ButtonInfo { buttonText = "Important", method =() => SettingsMods.Important(), toolTip = "Opens the Important mods for the menu", isTogglable = false},
                new ButtonInfo { buttonText = "Animals", method =() => SettingsMods.Spam(), toolTip = "Opens the Animals mods for the menu", isTogglable = false},
               // new ButtonInfo { buttonText = "Rig", method =() => SettingsMods.Rig(), toolTip = "Opens the Rig mods for the menu", isTogglable = false},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                new ButtonInfo { buttonText = "Change Button Layout", enableMethod =() => SettingsMods.TriggerPagesOn(), disableMethod =() => SettingsMods.TriggerPagesOff(), enabled = TopButtons, toolTip = "Changes the button type."},
            },

            new ButtonInfo[] { // movement Mods 24 mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), toolTip = "plats", isTogglable = true},
                new ButtonInfo { buttonText = "Sticky Platforms", method =() => Movement.StickyPlatforms(), toolTip = "Sticky plats", isTogglable = true},
                new ButtonInfo { buttonText = "Invis Platforms", method =() => Movement.InvisPlatforms(), toolTip = "Invis plats", isTogglable = true},
                new ButtonInfo { buttonText = "Fly [<color=green>A</color>]", method =() => Movement.Fly(), toolTip = "Fly", isTogglable = true},
                new ButtonInfo { buttonText = "Fly [<color=green>B</color>]", method =() => Movement.BFly(), toolTip = "B Fly", isTogglable = true},
                new ButtonInfo { buttonText = "Fly [<color=green>X</color>]", method =() => Movement.BFly(), toolTip = "Y Fly", isTogglable = true},
                new ButtonInfo { buttonText = "Fly [<color=green>NoClip</color>]", method =() => Movement.NCFly(), toolTip = "NoClip Fly", isTogglable = true},
                new ButtonInfo { buttonText = "Hand Fly", method =() => Movement.HFly(), toolTip = "Hand Fly", isTogglable = true},
                new ButtonInfo { buttonText = "Excel Fly", method =() => Movement.ExcelFly(), toolTip = "Excel Fly", isTogglable = true},
                new ButtonInfo { buttonText = "Iron Man", method =() => Movement.IronMan(), toolTip = "Iron Man", isTogglable = true},
                new ButtonInfo { buttonText = "No Tag Freeze", method =() => Movement.NoTagFreeze(), toolTip = "NoTagFreeze", isTogglable = true},
                new ButtonInfo { buttonText = "Force Tag Freeze", method =() => Movement.ForceTagFreeze(), toolTip = "Force Tag Freeze", isTogglable = true},
                new ButtonInfo { buttonText = "Long Arms", method =() => Movement.LongArms(), toolTip = "Long arms", isTogglable = false},
                new ButtonInfo { buttonText = "Extreme Long Arms", method =() => Movement.ExtremeLongArms(), toolTip = "Extreme Long arms", isTogglable = false},
                new ButtonInfo { buttonText = "Small Arms", method =() => Movement.SmallArms(), toolTip = "Small Long arms", isTogglable = false},
                new ButtonInfo { buttonText = "Reset Arms", method =() => Movement.NoLongArms(), toolTip = "reset arms", isTogglable = false},
                new ButtonInfo { buttonText = "No Clip", method =() => Movement.NoClip(), toolTip = "no clip", isTogglable = true},
                new ButtonInfo { buttonText = "TP Gun", method =() => Movement.TPGun(), toolTip = "TPGun", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Monke", method =() => Movement.GhostMonke(), toolTip = "GhostMonke", isTogglable = true},
                new ButtonInfo { buttonText = "Invis Monke", method =() => Movement.Invis(), toolTip = "invis monke", isTogglable = true},
                new ButtonInfo { buttonText = "Grab Rig", method =() => Movement.GrabRig(), toolTip = "GrabRig", isTogglable = true},
                new ButtonInfo { buttonText = "Rig Gun", method =() => Movement.RigGun(), toolTip = "RigGun", isTogglable = true},
                new ButtonInfo { buttonText = "Speed Boost", method =() => Movement.SpeedBoost(), toolTip = "SpeedBoost", isTogglable = true},
                new ButtonInfo { buttonText = "Small Speed Boost", method =() => Movement.SSpeedBoost(), toolTip = "SpeedBoost small", isTogglable = true},
            },

            new ButtonInfo[] { // visual Mods 6 mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Bug ESP", method =() => Visual.bugesp(), toolTip = "bug esp", isTogglable = true},
                new ButtonInfo { buttonText = "Bat ESP", method =() => Visual.batesp(), toolTip = "bat esp", isTogglable = true},
                new ButtonInfo { buttonText = "Box ESP", method =() => Visual.ESP(), toolTip = "box esp", isTogglable = true},
                new ButtonInfo { buttonText = "Tracers", method =() => Visual.Tracers(), toolTip = "Tracers", isTogglable = true},
                new ButtonInfo { buttonText = "Snake Chams", method =() => Visual.SnakeChams(), toolTip = "Snake Chams", isTogglable = true},
                //new ButtonInfo { buttonText = "Play Moon Eye Event [CS]", method =() => Sound.PlayEyeMonsterMoonEvent(), toolTip = "event", isTogglable = true},
            },

            new ButtonInfo[] { // sound Mods 5 mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Keyboard Spam [<color=green>UND?</color>]", method =() => Sound.KeyboardSpam(), toolTip = "Keyboard Spam", isTogglable = true},
                new ButtonInfo { buttonText = "Bark Spam [<color=green>UND?</color>]", method =() => Sound.BarkSpam(), toolTip = "Bark Spam", isTogglable = true},
                new ButtonInfo { buttonText = "Button Spam [<color=green>UND?</color>]", method =() => Sound.btnSpam(), toolTip = "button Spam", isTogglable = true},
                new ButtonInfo { buttonText = "Crystal Spam [<color=green>UND?</color>]", method =() => Sound.metalSpam(), toolTip = "metal Spam", isTogglable = true},
                new ButtonInfo { buttonText = "Glass Spam [<color=green>UND?</color>]", method =() => Sound.glassSpam(), toolTip = "glass Spam", isTogglable = true},
            },

            new ButtonInfo[] { // Important Mods 5 mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Disconnect", method =() => Important.Disconnect(), toolTip = "Makes you leave lobby", isTogglable = false},
                new ButtonInfo { buttonText = "Quit Game", method =() => Important.Fastquit(), toolTip = "", isTogglable = false},
                new ButtonInfo { buttonText = "Master Check", method =() => Important.MCheck(), toolTip = "Checks if u master", isTogglable = false},
                new ButtonInfo { buttonText = "Flush RPC's [<color=green>USE</color>]", method =() => rpc.RPCPROTECTION(), toolTip = "Flushes your rpc calls", isTogglable = false},
                new ButtonInfo { buttonText = "Clear Notis", method =() => Important.ClearNotis(), toolTip = "Clears notis", isTogglable = false},
// works but no turn off  new ButtonInfo { buttonText = "FPC", enableMethod =() => Important.FirstPersonCamOff(), disableMethod =() => Important.FirstPersonCam(), toolTip = "fpc", isTogglable = true},
                //new ButtonInfo { buttonText = "Join Pub Forest", method =() => Important.JoinPublic(), toolTip = "frst", isTogglable = false},
            },

            new ButtonInfo[] { // Animals Mods 5 mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Grab Bug", method =() => Animals.Grabbug(), toolTip = "Grab Bug", isTogglable = true},
                new ButtonInfo { buttonText = "Bug Gun", method =() => Animals.BugGun(), toolTip = "BugGun ", isTogglable = true},
                new ButtonInfo { buttonText = "Grab Bat", method =() => Animals.Grabbat(), toolTip = "Grab Bat", isTogglable = true},
                new ButtonInfo { buttonText = "Bat Gun", method =() => Animals.batGun(), toolTip = "Bat Gun", isTogglable = true},
                new ButtonInfo { buttonText = "Grab BeachBall", method =() => Animals.Grabball(), toolTip = "Grab Ball", isTogglable = true},
            },

            new ButtonInfo[] { // holder Catergory
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                
            },


            // for custom boards
            new ButtonInfo[]
            {
                new ButtonInfo { buttonText = "boards", method =() => CustomBoards.CustomBoards1(), toolTip = "boards", enabled = true},
            }
        };
    }
}
