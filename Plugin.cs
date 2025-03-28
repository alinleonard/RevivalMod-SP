﻿using BepInEx;
using BepInEx.Logging;
using RevivalMod.Features;
using BepInEx.Bootstrap;
using RevivalMod.Patches;
using RevivalMod.Helpers;

namespace RevivalMod
{
    // first string below is your plugin's GUID, it MUST be unique to any other mod. Read more about it in BepInEx docs. Be sure to update it if you copy this project.
    //[BepInDependency("com.fika.core", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInPlugin("com.kaikinoodles.revivalmod", "RevivalMod", "1.1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;

        // BaseUnityPlugin inherits MonoBehaviour, so you can use base unity functions like Awake() and Update()
        private void Awake()
        {
            // save the Logger to variable so we can use it elsewhere in the project
            LogSource = Logger;
            LogSource.LogInfo("Revival plugin loaded!");
            Settings.Init(Config);
            // Enable patches
            new DeathPatch().Enable();
            new RevivalFeatures().Enable();
            new GameStartedPatch().Enable();

            LogSource.LogInfo("Revival plugin initialized! Press F5 to use your defibrillator when in critical state.");
        }

    }
}
