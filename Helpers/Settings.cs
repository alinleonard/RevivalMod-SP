﻿using BepInEx.Configuration; 
using UnityEngine;

namespace RevivalMod.Helpers
{
    internal class Settings
    {
        public static ConfigEntry<float> REVIVAL_DURATION;
        public static ConfigEntry<KeyCode> REVIVAL_KEY;
        public static ConfigEntry<float> REVIVAL_COOLDOWN;
        public static ConfigEntry<bool> HARDCORE_MODE; 
        public static ConfigEntry<bool> HARDCORE_HEADSHOT_DEFAULT_DEAD;
        public static ConfigEntry<float> HARDCORE_CHANCE_OF_CRITICAL_STATE;

        public static ConfigEntry<bool> TESTING;

        public static void Init(ConfigFile config)
        {
            HARDCORE_MODE = config.Bind(
                "Hardcore Mode",
                "Enable Hardcore Mode",
                false,
               "Adapt the values below the change the hardcore settings"
            );
            HARDCORE_CHANCE_OF_CRITICAL_STATE = config.Bind(
                "Hardcore Mode",
                "Chance of critical mode",
                0.75f,
               "Adapt how big the odds are to enter critical state (be revivable) in hardcore mode. 0.75 is 75%"
            );
            HARDCORE_HEADSHOT_DEFAULT_DEAD = config.Bind(
                "Hardcore Mode",
                "Headshot is alwasy dead",
                false,
               "Headshot kills always"
            );

            REVIVAL_DURATION = config.Bind(
                "General",
                "Revival Duration",
                4f,
               "Adapt the duration of the amount of time it takes to revive."
            );
            REVIVAL_KEY = config.Bind(
                "General",
                "Revival Key",
                KeyCode.F5
            );
            REVIVAL_COOLDOWN = config.Bind(
                "General",
                "Revival Cooldown",
                180f
              );

            TESTING = config.Bind(
                "Development",
                "Test Mode",
                false,
                new ConfigDescription("", null, new ConfigurationManagerAttributes { IsAdvanced = true })
            );
        }
    }
}
