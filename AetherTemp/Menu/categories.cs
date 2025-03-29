﻿using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace AetherTemp.Menu
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 0;
            pageNumber = 0;
        }

        public static void MenuSettings()
        {
            buttonsType = 1;
            pageNumber = 0;
        }

        public static void advantages()
        {
            buttonsType = 2;
            pageNumber = 0;
        }

        public static void movement()
        {
            buttonsType = 3;
            pageNumber = 0;
        }

        public static void visuals()
        {
            buttonsType = 4;
            pageNumber = 0;
        }

        public static void overpowered()
        {
            buttonsType = 5;
            pageNumber = 0;
        }

        public static void safety()
        {
            pageNumber = 0;
            buttonsType = 6;
        }

        public static void fun()
        {
            buttonsType = 7;
            pageNumber = 0;
        }

        public static void guardian()
        {
            buttonsType = 8;
            pageNumber = 0;
        }

        public static void miscellaneous()
        {
            buttonsType = 9;
            pageNumber = 0;
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
    }
}
