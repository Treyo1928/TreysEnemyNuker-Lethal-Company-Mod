using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace TreysEnemyNuker
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<bool> RemoveMouthDog;
        public static ConfigEntry<bool> RemoveForestGiant;
        public static ConfigEntry<bool> RemoveEarthLeviathan;
        public static ConfigEntry<bool> RemoveBaboonHawk;
        public static ConfigEntry<bool> RemoveCentipede;
        public static ConfigEntry<bool> RemoveBunkerSpider;
        public static ConfigEntry<bool> RemoveHoardingBug;
        public static ConfigEntry<bool> RemoveFlowerMan;
        public static ConfigEntry<bool> RemoveCrawler;
        public static ConfigEntry<bool> RemoveBlob;
        public static ConfigEntry<bool> RemoveSpring;
        public static ConfigEntry<bool> RemovePuffer;
        public static ConfigEntry<bool> RemoveNutcracker;
        public static ConfigEntry<bool> RemoveManticoil;

        internal static BepInEx.Logging.ManualLogSource PluginLogger;

        private void Awake()
        {
            RemoveMouthDog = Config.Bind("Enemy Removal", "MouthDog", true, "Set to true to remove Mouth Dogs from the game.");
            RemoveForestGiant = Config.Bind("Enemy Removal", "ForestGiant", true, "Set to true to remove Forest Giants from the game.");
            RemoveEarthLeviathan = Config.Bind("Enemy Removal", "EarthLeviathan", true, "Set to true to remove Earth Leviathans from the game.");
            RemoveBaboonHawk = Config.Bind("Enemy Removal", "BaboonHawk", true, "Set to true to remove Baboon Hawks from the game.");
            RemoveCentipede = Config.Bind("Enemy Removal", "Centipede", true, "Set to true to remove Centipedes from the game.");
            RemoveBunkerSpider = Config.Bind("Enemy Removal", "BunkerSpider", true, "Set to true to remove Bunker Spiders from the game.");
            RemoveHoardingBug = Config.Bind("Enemy Removal", "HoardingBug", true, "Set to true to remove Hoarding Bugs from the game.");
            RemoveFlowerMan = Config.Bind("EnemyRemoval", "FlowerMan", true, "Set to true to remove Flower Man from the game.");
            RemoveCrawler = Config.Bind("EnemyRemoval", "Crawler", true, "Set to true to remove Crawlers from the game.");
            RemoveBlob = Config.Bind("EnemyRemoval", "Blob", true, "Set to true to remove Blobs from the game.");
            RemoveSpring = Config.Bind("EnemyRemoval", "Spring", true, "Set to true to remove Springs from the game.");
            RemovePuffer = Config.Bind("EnemyRemoval", "Puffer", true, "Set to true to remove Puffers from the game.");
            RemoveNutcracker = Config.Bind("EnemyRemoval", "Nutcracker", true, "Set to true to remove Nutcrackers from the game.");
            RemoveManticoil = Config.Bind("EnemyRemoval", "Manticoil", true, "Set to true to remove Manticoils from the game.");

            PluginLogger = Logger;
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            // Initialize Harmony
            var harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();

            // Log that patching process has been initiated
            Logger.LogInfo("Harmony patches applied.");
        }
    }
}
